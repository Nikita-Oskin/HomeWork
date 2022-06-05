using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace pcshop_console
{
    public class Videocards
    {
        CRUD newt_n = new CRUD();
        public void SelectVideocards(SqlConnection conn, string query = "SELECT * FROM Videocards")
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine($"{reader.GetValue(0)}:> {reader.GetValue(1)} | {reader.GetValue(2)} | {reader.GetValue(3)} GB | {reader.GetValue(4)}  | Цена: {reader.GetValue(7)} $ | Статус: {reader.GetValue(8)}");
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

        public void InsertVideocards(SqlConnection conn)
        {
            Console.WriteLine("Вы можете изменить только цену и статус товара. Поэтому будьте внимательные когда добавляете запись в бд");

            Console.Write("Brand: ");
            string c1 = Console.ReadLine();
            Console.Write("Model: ");
            string c2 = Console.ReadLine();
            Console.Write("Memory size: ");
            int c3 = int.Parse(Console.ReadLine());
            Console.Write("Type memory: ");
            string c4 = Console.ReadLine();
            Console.Write("Speed: ");
            int c5 = int.Parse(Console.ReadLine());
            Console.Write("Connectors: ");
            string c6 = Console.ReadLine();

            Console.Write("Price: ");
            double c7 = double.Parse(Console.ReadLine());
            Console.Write("Status: ");
            string c8 = Console.ReadLine();

            string query = "INSERT INTO videocards(v_brand, v_model, v_memory_size, v_type_memory, v_speed, v_connectors, v_price, v_status) " +
                           $"VALUES('{c1}', '{c2}', {c3}, '{c4}', {c5}, '{c6}', {c7}, '{c8}')";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            Console.WriteLine(newt_n.custominsertupdatedelete(cmd));

            Console.WriteLine("Вернуться назад? y/n");
            string y_n = Console.ReadLine();
            Console.Clear();
            if (y_n == "y") newt_n.Videocards();

        }

        public void UpdateVideocards(SqlConnection conn)
        {
            Console.WriteLine("Вы можете изменить только цену и статус процессора");
            Console.WriteLine("Выберите ID процессора");
            int c0 = int.Parse(Console.ReadLine());

            SelectVideocards(conn, $"SELECT * FROM Videocards WHERE v_id = {c0}");

            Console.Write("Price: ");
            double c12 = double.Parse(Console.ReadLine());
            Console.Write("Status: ");
            string c13 = Console.ReadLine();

            string query = $"UPDATE Videocards SET v_price  = {c12}, v_status = '{c13}' WHERE v_id = {c0}";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            Console.WriteLine(newt_n.custominsertupdatedelete(cmd));
            SelectVideocards(conn, $"SELECT * FROM Videocards WHERE v_id = {c0}");

            Console.WriteLine("Вернуться назад? y/n");
            string y_n = Console.ReadLine();
            Console.Clear();
            if (y_n == "y") newt_n.Videocards();

        }

        public void DeleteVideocards(SqlConnection conn)
        {
            Console.WriteLine("Введите ID для удаление");
            int c0 = int.Parse(Console.ReadLine());

            SelectVideocards(conn, $"SELECT * FROM Videocards WHERE v_id = {c0}");
            string query = $"DELETE FROM Videocards WHERE v_id = {c0}";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            Console.WriteLine(newt_n.custominsertupdatedelete(cmd));

            Console.WriteLine("Вернуться назад? y/n");
            string y_n = Console.ReadLine();
            Console.Clear();
            if (y_n == "y") newt_n.Videocards();
        }

    }
}
