using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace pcshop_console
{
    public class Processors
    {
        CRUD newt_n = new CRUD();
        public void SelectProcessors(SqlConnection conn, string query = "SELECT * FROM processors")
        {     
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine($"{reader.GetValue(0)}:> {reader.GetValue(1)} | {reader.GetValue(2)} | {reader.GetValue(3)} ядер / {reader.GetValue(4)} потоков | {reader.GetValue(5)}MHz / {reader.GetValue(6)}MHz | " +
                                        $"Видеоядро: {reader.GetValue(7)} | Цена: {reader.GetValue(12)} $ | Статус: {reader.GetValue(13)}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public void InsertProcessors(SqlConnection conn)
        {
            Console.WriteLine("Вы можете изменить только цену и статус товара. Поэтому будьте внимательные когда добавляете запись в бд");

            Console.Write("Brand: ");
            string c1 = Console.ReadLine();
            Console.Write("Model: ");
            string c2 = Console.ReadLine();
            Console.Write("Socket: ");
            string c3 = Console.ReadLine();
            Console.Write("Cores: ");
            int c4 = int.Parse(Console.ReadLine());
            Console.Write("Threads: ");
            int c5 = int.Parse(Console.ReadLine());
            Console.Write("Base Speed: ");
            double c6 = double.Parse(Console.ReadLine());
            Console.Write("Turbo Speed: ");
            double c7 = double.Parse(Console.ReadLine());
            Console.Write("Videocard: ");
            string c8 = Console.ReadLine();
            Console.Write("Cache: ");
            int c9 = int.Parse(Console.ReadLine());
            Console.Write("TDP: ");
            int c10 = int.Parse(Console.ReadLine());
            Console.Write("Equipment: ");
            string c11 = Console.ReadLine();
            Console.Write("Price: ");
            double c12 = double.Parse(Console.ReadLine());
            Console.Write("Status: ");
            string c13 = Console.ReadLine();

            string query = "INSERT INTO processors(cpu_brand, cpu_model, cpu_socket, cpu_cores, cpu_threads, cpu_base_speed, cpu_max_speed, cpu_graphics, cpu_cache, cpu_tdp, cpu_equipment, cpu_price, cpu_status) " +
                           $"VALUES('{c1}', '{c2}', '{c3}', {c4}, {c5}, {c6}, {c7}, '{c8}', {c9}, {c10}, '{c11}', {c12}, '{c13}')";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            Console.WriteLine(newt_n.custominsertupdatedelete(cmd));

            Console.WriteLine("Вернуться назад? y/n");
            string y_n = Console.ReadLine();
            Console.Clear();
            if (y_n == "y") newt_n.Processors();

        }
    
        public void UpdateProcessors(SqlConnection conn)
        {
            Console.WriteLine("Вы можете изменить только цену и статус процессора");
            Console.WriteLine("Выберите ID процессора");
            int c0 = int.Parse(Console.ReadLine());

            SelectProcessors(conn, $"SELECT * FROM processors WHERE cpu_id = {c0}");

            Console.Write("Price: ");
            double c12 = double.Parse(Console.ReadLine());
            Console.Write("Status: ");
            string c13 = Console.ReadLine();

            string query = $"UPDATE processors SET cpu_price  = {c12}, cpu_status = '{c13}' WHERE cpu_id = {c0}";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            Console.WriteLine(newt_n.custominsertupdatedelete(cmd));

            SelectProcessors(conn, $"SELECT * FROM processors WHERE cpu_id = {c0}");

            Console.WriteLine("Вернуться назад? y/n");
            string y_n = Console.ReadLine();
            Console.Clear();
            if (y_n == "y") newt_n.Processors();

        }
    
        public void DeleteProcessors(SqlConnection conn)
        {
            Console.WriteLine("Введите ID для удаление");
            int c0 = int.Parse(Console.ReadLine());

            SelectProcessors(conn, $"SELECT * FROM processors WHERE cpu_id = {c0}");
            string query = $"DELETE FROM processors WHERE cpu_id = {c0}";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            Console.WriteLine(newt_n.custominsertupdatedelete(cmd));

            Console.WriteLine("Вернуться назад? y/n");
            string y_n = Console.ReadLine();
            Console.Clear();
            if (y_n == "y") newt_n.Processors();
        }
    
    }
}
