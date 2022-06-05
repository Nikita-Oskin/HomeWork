using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace pcshop_console
{
    public class CRUD
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public static string sql = string.Empty;

        SqlDataAdapter adprt;
        DataSet dset;
        public DataTable dt;
        static string getmessage { get; set; }

        const string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\BLOCK3\Block3_WF\pcshop_wpf\Database1.mdf;Integrated Security=True";

        public void Select()
        {
            string query = $"SELECT * FROM accessories";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine($"{reader.GetInt32(0)}:> {reader.GetString(1)}");

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

        public void Processors()
        {
            SqlConnection conn = new SqlConnection(cs);
            Processors cpu = new Processors();

            cpu.SelectProcessors(conn);

            Console.WriteLine("Какую действию хотите выполнить?");
            Console.WriteLine("Добавить(I) | Изменить(U) | Удалить(D) | Назад(B)");
            string query = Console.ReadLine();
            Console.Clear();

            switch (query)
            {
                case "I":
                case "Добавить":
                case "добавить":
                    cpu.InsertProcessors(conn);
                    break;
                case "U":
                case "Изменить":
                case "изменить":
                    cpu.UpdateProcessors(conn);
                    break;
                case "D":
                case "Удалить":
                case "удалить":
                    cpu.DeleteProcessors(conn);
                    break;
                case "B":
                case "Назад":
                case "назад":
                    Select();
                    break;
            }
            



        }

        public void Motherboards()
        {
            SqlConnection conn = new SqlConnection(cs);
            Motherboards mb = new Motherboards();

            mb.SelectMotherboards(conn);

            Console.WriteLine("Какую действию хотите выполнить?");
            Console.WriteLine("Добавить(I) | Изменить(U) | Удалить(D) | Назад(B)");
            string query = Console.ReadLine();
            Console.Clear();

            switch (query)
            {
                case "I":
                case "Добавить":
                case "добавить":
                    mb.InsertMotherboards(conn);
                    break;
                case "U":
                case "Изменить":
                case "изменить":
                    mb.UpdateMotherboards(conn);
                    break;
                case "D":
                case "Удалить":
                case "удалить":
                    mb.DeleteMotherboards(conn);
                    break;
                case "B":
                case "Назад":
                case "назад":
                    Select();
                    break;
                default:
                    Console.WriteLine("Нет такой таблицы");
                    Motherboards();
                    break;
            }
        }

        public void RAM()
        {
            SqlConnection conn = new SqlConnection(cs);
            RAM ram = new RAM();

            ram.SelectRam(conn);

            Console.WriteLine("Какую действию хотите выполнить?");
            Console.WriteLine("Добавить(I) | Изменить(U) | Удалить(D) | Назад(B)");
            string query = Console.ReadLine();
            Console.Clear();

            switch (query)
            {
                case "I":
                case "Добавить":
                case "добавить":
                    ram.InsertRam(conn);
                    break;
                case "U":
                case "Изменить":
                case "изменить":
                    ram.UpdateRam(conn);
                    break;
                case "D":
                case "Удалить":
                case "удалить":
                    ram.DeleteRam(conn);
                    break;
                case "B":
                case "Назад":
                case "назад":
                    Select();
                    break;
                default:
                    Console.WriteLine("Нет такой таблицы");
                    RAM();
                    break;
            }
        }

        public void Videocards()
        {
            SqlConnection conn = new SqlConnection(cs);
            Videocards vc = new Videocards();

            vc.SelectVideocards(conn);

            Console.WriteLine("Какую действию хотите выполнить?");
            Console.WriteLine("Добавить(I) | Изменить(U) | Удалить(D) | Назад(B)");
            string query = Console.ReadLine();
            Console.Clear();

            switch (query)
            {
                case "I":
                case "Добавить":
                case "добавить":
                    vc.InsertVideocards(conn);
                    break;
                case "U":
                case "Изменить":
                case "изменить":
                    vc.UpdateVideocards(conn);
                    break;
                case "D":
                case "Удалить":
                case "удалить":
                    vc.DeleteVideocards(conn);
                    break;
                case "B":
                case "Назад":
                case "назад":
                    Select();
                    break;
                default:
                    Console.WriteLine("Нет такой таблицы");
                    RAM();
                    break;
            }
        }

        public void SSD_Drivers()
        {
            SqlConnection conn = new SqlConnection(cs);
            SSD_Drivers vc = new SSD_Drivers();

            vc.SelectSSD_Drivers(conn);

            Console.WriteLine("Какую действию хотите выполнить?");
            Console.WriteLine("Добавить(I) | Изменить(U) | Удалить(D) | Назад(B)");
            string query = Console.ReadLine();
            Console.Clear();

            switch (query)
            {
                case "I":
                case "Добавить":
                case "добавить":
                    vc.InsertSSD_Drivers(conn);
                    break;
                case "U":
                case "Изменить":
                case "изменить":
                    vc.UpdateSSD_Drivers(conn);
                    break;
                case "D":
                case "Удалить":
                case "удалить":
                    vc.DeleteSSD_Drivers(conn);
                    break;
                case "B":
                case "Назад":
                case "назад":
                    Select();
                    break;
                default:
                    Console.WriteLine("Нет такой таблицы");
                    RAM();
                    break;
            }
        }

        public CRUD()
        {
            conn = new SqlConnection(cs);
            cmd = new SqlCommand();
            adprt = new SqlDataAdapter();
            dset = new DataSet();
            dt = new DataTable();
        }

        public bool Connect()
        {
            try
            {
                conn.Open();
                getmessage = "Connected";
                return true;
            }
            catch (Exception ex)
            {
                getmessage = "бд не подключился";
                return false;
            }
        }

        public bool Disconnect()
        {
            try
            {
                conn.Close();
                getmessage = "Close";
                return true;
            }
            catch (Exception ex)
            {
                getmessage = "бд не отключился";
                return false;
            }
        }

        public string custominsertupdatedelete(SqlCommand cmd2parameterizednoconnectionNeeded)
        {
            string ret = "";
            string allqueries = cmd2parameterizednoconnectionNeeded.CommandText;
            try
            {
                cmd2parameterizednoconnectionNeeded.Connection = conn;
                Connect();

                cmd2parameterizednoconnectionNeeded.ExecuteNonQuery();
                if (allqueries.Contains("INSERT INTO "))
                {
                    ret = getmessage = "Добавлено";
                }
                else if (allqueries.Contains("DELETE FROM "))
                {
                    ret = getmessage = "Удалено";
                }
                else if (allqueries.Contains("UPDATE "))
                {
                    ret = getmessage = "Изменено";
                }
            }
            catch (Exception ex)
            {
                ret = getmessage = "Failed to execute " + cmd2parameterizednoconnectionNeeded.CommandText + "\n Reason: " + ex.Message;
            }
            finally { Disconnect(); }
            return ret;
        }

    }
}
