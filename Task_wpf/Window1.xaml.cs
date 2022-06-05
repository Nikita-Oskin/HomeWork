using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace pcshop_wpf
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void CPU_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CPU_CRUD cpu_crud = new CPU_CRUD();
            cpu_crud.Show();
        }

        private void Motherboards_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Motherboards motherboards = new Motherboards();
            motherboards.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Videocards videocards = new Videocards();
            videocards.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RAM ram = new RAM();
            ram.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SSDDrivers ssd = new SSDDrivers();
            ssd.Show();
        }
    }
}
