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
using System.Data;
using System.Data.SqlClient;

namespace pcshop_wpf
{
    /// <summary>
    /// Interaction logic for RAM.xaml
    /// </summary>
    public partial class RAM : Window
    {
        CRUD dl;
        public RAM()
        {
            dl = new CRUD();
            InitializeComponent();
            READ();
        }

        public void READ()
        {
            datagrid.ItemsSource = null;
            dl.Read_data("SELECT " +
                "ram_id as id," +
                "ram_brand as brand," +
                "ram_model as model," +
                "ram_type_memory as type_memory," +
                "ram_memory_size as size," +
                "ram_count as count," +
                "ram_speed as speed," +
                "ram_rgb as rgb," +
                "ram_price as price," +
                "ram_status as status," +
                "ram_access_id as a_id FROM ram");
            datagrid.ItemsSource = dl.dt.DefaultView;
        }

        public void Clear_box()
        {
            lbl_ram_id.Content = txt_ram_model.Text = txt_ram_price.Text = txt_ram_count.Text = txt_ram_memory_size.Text = txt_ram_model.Text = txt_ram_rgb.Text = txt_ram_speed.Text = string.Empty;
            cbox_ram_brand.SelectedIndex = cbox_ram_type_memory.SelectedIndex = cbox_ram_status.SelectedIndex = -1;
        }

        private void Insert_btn_Click_2(object sender, RoutedEventArgs e)
        {
            string insert = "INSERT INTO ram(ram_brand, ram_model, ram_type_memory, ram_memory_size, ram_count, ram_speed, ram_rgb, ram_price, ram_status) " +
                           $"VALUES('{cbox_ram_brand.Text}', '{txt_ram_model.Text}', '{cbox_ram_type_memory.Text}', {txt_ram_memory_size.Text}, {txt_ram_count.Text}, {txt_ram_speed.Text}, '{txt_ram_rgb.Text}', {txt_ram_price.Text}, '{cbox_ram_status.Text}')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = insert;
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            READ();
        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            string update = $"UPDATE ram SET ram_brand ='{cbox_ram_brand.Text}', ram_model ='{txt_ram_model.Text}', ram_type_memory ='{cbox_ram_type_memory.Text}', ram_memory_size ={txt_ram_memory_size.Text}, " +
                            $"ram_count={txt_ram_count.Text}, ram_speed={txt_ram_speed.Text}, ram_rgb = '{txt_ram_rgb.Text}', ram_price={txt_ram_price.Text}, ram_status='{cbox_ram_status.Text}' WHERE ram_id={lbl_ram_id.Content}";

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = update;

            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");

            READ();
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            string delete = $"DELETE FROM ram WHERE ram_id={lbl_ram_id.Content}";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = delete;
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            READ();
        }

        private void Clear_btn_Click_1(object sender, RoutedEventArgs e)
        {
            Clear_box();
        }

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid senderGrid = (DataGrid)sender;
            try
            {
                if (datagrid.Items.Count > 0)
                {
                    lbl_ram_id.Content = ((DataRowView)datagrid.SelectedItem).Row[0].ToString();
                    cbox_ram_brand.Text = ((DataRowView)datagrid.SelectedItem).Row[1].ToString();
                    txt_ram_model.Text = ((DataRowView)datagrid.SelectedItem).Row[2].ToString();
                    cbox_ram_type_memory.Text = ((DataRowView)datagrid.SelectedItem).Row[3].ToString();
                    txt_ram_memory_size.Text = ((DataRowView)datagrid.SelectedItem).Row[4].ToString();
                    txt_ram_count.Text = ((DataRowView)datagrid.SelectedItem).Row[5].ToString();
                    txt_ram_speed.Text = ((DataRowView)datagrid.SelectedItem).Row[6].ToString();
                    txt_ram_rgb.Text = ((DataRowView)datagrid.SelectedItem).Row[7].ToString();
                    txt_ram_price.Text = ((DataRowView)datagrid.SelectedItem).Row[8].ToString();
                    cbox_ram_status.Text = ((DataRowView)datagrid.SelectedItem).Row[9].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}
