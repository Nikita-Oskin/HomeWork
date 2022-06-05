using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace pcshop_console
{
    public class Motherboards
    {
        CRUD newt_n = new CRUD();
        public void SelectMotherboards(SqlConnection conn, string query = "SELECT * FROM motherboards")
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine($"{reader.GetValue(0)}:> {reader.GetValue(1)} | {reader.GetValue(2)} | {reader.GetValue(3)} | {reader.GetValue(4)} | {reader.GetValue(5)} | Кол-во слотов ОЗУ:  {reader.GetValue(6)} | Макс ОЗУ: {reader.GetValue(7)} GB | " +
                                        $"Цена: {reader.GetValue(11)} $ | Статус: {reader.GetValue(12)}");
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

        public void InsertMotherboards(SqlConnection conn)
        {
            Console.WriteLine("Вы можете изменить только цену и статус товара. Поэтому будьте внимательные когда добавляете запись в бд");

            Console.Write("Brand: ");
            string c1 = Console.ReadLine();
            Console.Write("Model: ");
            string c2 = Console.ReadLine();
            Console.Write("CPY type: ");
            string c3 = Console.ReadLine();
            Console.Write("RAM memory: ");
            string c4 = Console.ReadLine();
            Console.Write("Form Factor: ");
            string c5 = Console.ReadLine();
            Console.Write("Memory slots: ");
            int c6 = int.Parse(Console.ReadLine());
            Console.Write("Max memory: ");
            int c7 = int.Parse(Console.ReadLine());
            Console.Write("Socket: ");
            string c8 = Console.ReadLine();
            Console.Write("SATA slots: ");
            int c9 = int.Parse(Console.ReadLine());
            Console.Write("USB count: ");
            int c10 = int.Parse(Console.ReadLine());
            
            Console.Write("Price: ");
            double c11 = double.Parse(Console.ReadLine());
            Console.Write("Status: ");
            string c12 = Console.ReadLine();

            string query = "INSERT INTO motherboards(m_brand, m_model, m_cpu_type, m_ram_memory, m_form_factor, m_memory_slots, m_max_memory, m_socket, m_sata_slots, m_usb_count, m_price, m_status)" +
                           $"VALUES('{c1}', '{c2}', '{c3}', '{c4}', '{c5}', {c6}, {c7}, '{c8}', {c9}, {c10}, {c11}, '{c12}')";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            Console.WriteLine(newt_n.custominsertupdatedelete(cmd));

            Console.WriteLine("Вернуться назад? y/n");
            string y_n = Console.ReadLine();
            Console.Clear();
            if (y_n == "y") newt_n.Motherboards();

        }

        public void UpdateMotherboards(SqlConnection conn)
        {
            Console.WriteLine("Вы можете изменить только цену и статус процессора");
            Console.WriteLine("Выберите ID процессора");
            int c0 = int.Parse(Console.ReadLine());

            SelectMotherboards(conn, $"SELECT * FROM motherboards WHERE m_id = {c0}");

            Console.Write("Price: ");
            double c12 = double.Parse(Console.ReadLine());
            Console.Write("Status: ");
            string c13 = Console.ReadLine();

            string query = $"UPDATE motherboards SET m_price  = {c12}, m_status = '{c13}' WHERE m_id = {c0}";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            Console.WriteLine(newt_n.custominsertupdatedelete(cmd));

            SelectMotherboards(conn, $"SELECT * FROM motherboards WHERE m_id = {c0}");

            Console.WriteLine("Вернуться назад? y/n");
            string y_n = Console.ReadLine();
            Console.Clear();
            if (y_n == "y") newt_n.Motherboards();

        }

        public void DeleteMotherboards(SqlConnection conn)
        {
            Console.WriteLine("Введите ID для удаление");
            int c0 = int.Parse(Console.ReadLine());

            SelectMotherboards(conn, $"SELECT * FROM motherboards WHERE m_id = {c0}");
            string query = $"DELETE FROM motherboards WHERE m_id = {c0}";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            Console.WriteLine(newt_n.custominsertupdatedelete(cmd));

            Console.WriteLine("Вернуться назад? y/n");
            string y_n = Console.ReadLine();
            Console.Clear();
            if (y_n == "y") newt_n.Motherboards();
        }

    }
}
