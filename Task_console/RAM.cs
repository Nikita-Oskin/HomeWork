using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace pcshop_console
{
    public class RAM
    {
        CRUD newt_n = new CRUD();
        public void SelectRam(SqlConnection conn, string query = "SELECT * FROM ram")
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine($"{reader.GetValue(0)}:> {reader.GetValue(1)} | {reader.GetValue(2)} | {reader.GetValue(3)} | {reader.GetValue(4)} GB | Кол-во {reader.GetValue(5)} | {reader.GetValue(6)} MHz | " +
                                        $"RGB: {reader.GetValue(7)} | Цена: {reader.GetValue(8)} $ | Статус: {reader.GetValue(9)}");
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

        public void InsertRam(SqlConnection conn)
        {
            Console.WriteLine("Вы можете изменить только цену и статус товара. Поэтому будьте внимательные когда добавляете запись в бд");

            Console.Write("Brand: ");
            string c1 = Console.ReadLine();
            Console.Write("Model: ");
            string c2 = Console.ReadLine();
            Console.Write("Type memory: ");
            string c3 = Console.ReadLine();
            Console.Write("Memory size: ");
            int c4 = int.Parse(Console.ReadLine());
            Console.Write("Count: ");
            int c5 = int.Parse(Console.ReadLine());
            Console.Write("Speed: ");
            int c6 = int.Parse(Console.ReadLine());
            Console.Write("RGB (yes/no): ");
            string c7 = Console.ReadLine();

            Console.Write("Price: ");
            double c8 = double.Parse(Console.ReadLine());
            Console.Write("Status: ");
            string c9 = Console.ReadLine();

            string query = "INSERT INTO ram(ram_brand, ram_model, ram_type_memory, ram_memory_size, ram_count, ram_speed, ram_rgb, ram_price, ram_status) " +
                           $"VALUES('{c1}', '{c2}', '{c3}', {c4}, {c5}, {c6}, '{c7}', {c8}, '{c9}')";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            Console.WriteLine(newt_n.custominsertupdatedelete(cmd));

            Console.WriteLine("Вернуться назад? y/n");
            string y_n = Console.ReadLine();
            Console.Clear();
            if (y_n == "y") newt_n.RAM();

        }

        public void UpdateRam(SqlConnection conn)
        {
            Console.WriteLine("Вы можете изменить только цену и статус процессора");
            Console.WriteLine("Выберите ID процессора");
            int c0 = int.Parse(Console.ReadLine());

            SelectRam(conn, $"SELECT * FROM Ram WHERE ram_id = {c0}");

            Console.Write("Price: ");
            double c12 = double.Parse(Console.ReadLine());
            Console.Write("Status: ");
            string c13 = Console.ReadLine();

            string query = $"UPDATE Ram SET ram_price  = {c12}, ram_status = '{c13}' WHERE ram_id = {c0}";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            Console.WriteLine(newt_n.custominsertupdatedelete(cmd));

            SelectRam(conn, $"SELECT * FROM Ram WHERE ram_id = {c0}");

            Console.WriteLine("Вернуться назад? y/n");
            string y_n = Console.ReadLine();
            Console.Clear();
            if (y_n == "y") newt_n.RAM();

        }

        public void DeleteRam(SqlConnection conn)
        {
            Console.WriteLine("Введите ID для удаление");
            int c0 = int.Parse(Console.ReadLine());

            SelectRam(conn, $"SELECT * FROM Ram WHERE ram_id = {c0}");
            string query = $"DELETE FROM Ram WHERE ram_id = {c0}";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            Console.WriteLine(newt_n.custominsertupdatedelete(cmd));

            Console.WriteLine("Вернуться назад? y/n");
            string y_n = Console.ReadLine();
            Console.Clear();
            if (y_n == "y") newt_n.RAM();
        }
    }
}
