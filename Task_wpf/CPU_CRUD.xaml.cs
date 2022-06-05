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
    /// Interaction logic for CPU_CRUD.xaml
    /// </summary>
    public partial class CPU_CRUD : Window
    {
        CRUD dl;
        public CPU_CRUD()
        {
            dl = new CRUD();
            InitializeComponent();
            LoadGrid();
        }
        

        public void LoadGrid()
        {
            datagrid.ItemsSource = null;
            dl.Read_data("SELECT " +
                "cpu_id as id," +
                "cpu_brand as brand," +
                "cpu_model as model," +
                "cpu_socket as socket," +
                "cpu_cores as cores," +
                "cpu_threads as threads," +
                "cpu_base_speed as b_speed," +
                "cpu_max_speed as t_speed," +
                "cpu_cache as cache," +
                "cpu_tdp as tdp," +
                "cpu_graphics as graphics," +
                "cpu_equipment as eqpmnt," +
                "cpu_price as price," +
                "cpu_status as status," +
                "cpu_access_id as a_id FROM processors");
            datagrid.ItemsSource = dl.dt.DefaultView; ;
        }

        public void Clear_box()
        {
            lbl_cpu_id.Content = txt_cpu_base_speed.Text = txt_cpu_cache.Text = txt_cpu_cores.Text = txt_cpu_graphics.Text = txt_cpu_max_turbo.Text = txt_cpu_model.Text = txt_cpu_price.Text = txt_cpu_socket.Text = txt_cpu_tdp.Text = txt_cpu_threads.Text = string.Empty;
            cbox_cpu_brand.SelectedIndex = cbox_cpu_equipment.SelectedIndex = cbox_cpu_status.SelectedIndex = -1;
        }



        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid senderGrid = (DataGrid)sender;
            try
            {
                if (datagrid.Items.Count > 0)
                {
                    lbl_cpu_id.Content = ((DataRowView)datagrid.SelectedItem).Row[0].ToString();
                    cbox_cpu_brand.Text = ((DataRowView)datagrid.SelectedItem).Row[1].ToString();
                    txt_cpu_model.Text = ((DataRowView)datagrid.SelectedItem).Row[2].ToString();
                    txt_cpu_socket.Text = ((DataRowView)datagrid.SelectedItem).Row[3].ToString();
                    txt_cpu_cores.Text = ((DataRowView)datagrid.SelectedItem).Row[4].ToString();
                    txt_cpu_threads.Text = ((DataRowView)datagrid.SelectedItem).Row[5].ToString();
                    txt_cpu_base_speed.Text = ((DataRowView)datagrid.SelectedItem).Row[6].ToString();
                    txt_cpu_max_turbo.Text = ((DataRowView)datagrid.SelectedItem).Row[7].ToString();
                    txt_cpu_cache.Text = ((DataRowView)datagrid.SelectedItem).Row[8].ToString();
                    txt_cpu_tdp.Text = ((DataRowView)datagrid.SelectedItem).Row[9].ToString();
                    txt_cpu_graphics.Text = ((DataRowView)datagrid.SelectedItem).Row[10].ToString();
                    cbox_cpu_equipment.Text = ((DataRowView)datagrid.SelectedItem).Row[11].ToString();
                    txt_cpu_price.Text = ((DataRowView)datagrid.SelectedItem).Row[12].ToString();
                    cbox_cpu_status.Text = ((DataRowView)datagrid.SelectedItem).Row[13].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void cbox_cpu_brand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Insert_btn_Click_2(object sender, RoutedEventArgs e)
        {
            string insert = "INSERT INTO processors(cpu_brand, cpu_model, cpu_socket, cpu_cores, cpu_threads, cpu_base_speed, cpu_max_speed, cpu_graphics, cpu_cache, cpu_tdp, cpu_equipment, cpu_price, cpu_status) " +
                           $"VALUES('{cbox_cpu_brand.Text}', '{txt_cpu_model.Text}', '{txt_cpu_socket.Text}', {txt_cpu_cores.Text}, {txt_cpu_threads.Text}, {txt_cpu_base_speed.Text}, {txt_cpu_max_turbo.Text}, '{txt_cpu_graphics.Text}', {txt_cpu_cache.Text}, {txt_cpu_tdp.Text}, '{cbox_cpu_equipment.Text}', {txt_cpu_price.Text}, '{cbox_cpu_status.Text}')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = insert;

            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");

            LoadGrid();
        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            string update = $"UPDATE processors SET cpu_brand='{cbox_cpu_brand.Text}', cpu_model='{txt_cpu_model.Text}', cpu_socket='{txt_cpu_socket.Text}', cpu_cores={txt_cpu_cores.Text}, cpu_threads={txt_cpu_threads.Text}, cpu_base_speed={txt_cpu_base_speed.Text}, cpu_max_speed={txt_cpu_max_turbo.Text}, cpu_cache={txt_cpu_cache.Text}, cpu_tdp={txt_cpu_tdp.Text}, cpu_graphics='{txt_cpu_graphics.Text}', cpu_equipment='{cbox_cpu_equipment.Text}', cpu_price={txt_cpu_price.Text}, cpu_status='{cbox_cpu_status.Text}' WHERE cpu_id={lbl_cpu_id.Content}";

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = update;

            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");

            LoadGrid();
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            string delete = $"DELETE FROM processors WHERE cpu_id={lbl_cpu_id.Content}";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = delete;
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            LoadGrid();
        }

        private void Clear_btn_Click_1(object sender, RoutedEventArgs e)
        {
            Clear_box();
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 window1 = new Window1();
            window1.Show();
        }

        
    }
}
