using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace pcshop_console
{
    public class SSD_Drivers
    {
        CRUD newt_n = new CRUD();
        public void SelectSSD_Drivers(SqlConnection conn, string query = "SELECT * FROM ssd_drives")
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine($"{reader.GetValue(0)}:> {reader.GetValue(1)} | {reader.GetValue(2)} | {reader.GetValue(3)} | {reader.GetValue(4)} GB | NVMe {reader.GetValue(5)} | {reader.GetValue(6)}MHz |" +
                                        $"{reader.GetValue(7)} MHZ | Цена: {reader.GetValue(8)} $ | Статус: {reader.GetValue(9)}");
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

        public void InsertSSD_Drivers(SqlConnection conn)
        {
            Console.WriteLine("Вы можете изменить только цену и статус товара. Поэтому будьте внимательные когда добавляете запись в бд");

            Console.Write("Brand: ");
            string c1 = Console.ReadLine();
            Console.Write("Model: ");
            string c2 = Console.ReadLine();
            Console.Write("Connectibity: ");
            string c3 = Console.ReadLine();
            Console.Write("Storage: ");
            int c4 = int.Parse(Console.ReadLine());
            Console.Write("NVMe (yes/no): ");
            string c5 = Console.ReadLine();
            Console.Write("Recording Speed: ");
            int c6 = int.Parse(Console.ReadLine());
            Console.Write("Reading Speed: ");
            int c7 = int.Parse(Console.ReadLine());
           
            Console.Write("Price: ");
            double c8 = double.Parse(Console.ReadLine());
            Console.Write("Status: ");
            string c9 = Console.ReadLine();

            string query = "INSERT INTO ssd_drives(ssd_brand, ssd_model, ssd_connectivity, ssd_storage, ssd_nvme, ssd_recording_speed, ssd_reading_speed, ssd_price, ssd_status) " +
                           $"VALUES('{c1}', '{c2}', '{c3}', {c4}, '{c5}', {c6}, {c7}, {c8}, '{c9}')";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            Console.WriteLine(newt_n.custominsertupdatedelete(cmd));

            Console.WriteLine("Вернуться назад? y/n");
            string y_n = Console.ReadLine();
            Console.Clear();
            if (y_n == "y") newt_n.SSD_Drivers();

        }

        public void UpdateSSD_Drivers(SqlConnection conn)
        {
            Console.WriteLine("Вы можете изменить только цену и статус процессора");
            Console.WriteLine("Выберите ID процессора");
            int c0 = int.Parse(Console.ReadLine());

            SelectSSD_Drivers(conn, $"SELECT * FROM ssd_drives WHERE ssd_id = {c0}");

            Console.Write("Price: ");
            double c12 = double.Parse(Console.ReadLine());
            Console.Write("Status: ");
            string c13 = Console.ReadLine();

            string query = $"UPDATE ssd_drives SET ssd_price  = {c12}, ssd_status = '{c13}' WHERE ssd_id = {c0}";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            Console.WriteLine(newt_n.custominsertupdatedelete(cmd));
            SelectSSD_Drivers(conn, $"SELECT * FROM ssd_drives WHERE ssd_id = {c0}");

            Console.WriteLine("Вернуться назад? y/n");
            string y_n = Console.ReadLine();
            Console.Clear();
            if (y_n == "y") newt_n.SSD_Drivers();

        }

        public void DeleteSSD_Drivers(SqlConnection conn)
        {
            Console.WriteLine("Введите ID для удаление");
            int c0 = int.Parse(Console.ReadLine());

            SelectSSD_Drivers(conn, $"SELECT * FROM ssd_drives WHERE ssd_id = {c0}");
            string query = $"DELETE FROM ssd_drives WHERE cpu_id = {c0}";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            Console.WriteLine(newt_n.custominsertupdatedelete(cmd));

            Console.WriteLine("Вернуться назад? y/n");
            string y_n = Console.ReadLine();
            Console.Clear();
            if (y_n == "y") newt_n.SSD_Drivers();
        }

    }
}
