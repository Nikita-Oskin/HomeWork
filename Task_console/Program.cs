using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pcshop_console
{
    class Program
    {
        static void Main(string[] args)
        {

            CRUD newt_n = new CRUD();
            Console.WriteLine("Выберите таблицу");

            newt_n.Select();
            Console.WriteLine();
            string table = Console.ReadLine();
            Console.Clear();

            switch (table)
            {
                case "p":
                case "processors":
                case "Processors":
                case "1":
                    newt_n.Processors();
                    break;
                case "m":
                case "motherboards":
                case "Motherboards":
                case "2":
                    newt_n.Motherboards();
                    break;
                case "v":
                case "videocards":
                case "Videocards":
                case "3":
                    newt_n.Videocards();
                    break;
                case "r":
                case "ram":
                case "RAM":
                case "4":
                    newt_n.RAM();
                    break;
                case "ssd":
                case "ssd_drivers":
                case "SSD_Drivers":
                case "5":
                    newt_n.SSD_Drivers();
                    break;
                default:
                    Console.WriteLine("Нет такой таблицы");
                    Main(args);
                    break;
            }

            Console.ReadKey();
        }
    }
}
