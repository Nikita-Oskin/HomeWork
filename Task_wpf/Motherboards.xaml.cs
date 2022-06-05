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
    /// Логика взаимодействия для Motherboards.xaml
    /// </summary>
    public partial class Motherboards : Window
    {
        CRUD dl;
        public Motherboards()
        {
            dl = new CRUD();
            InitializeComponent();
            READ();
        }

        public void READ()
        {
            datagrid.ItemsSource = null;
            dl.Read_data("SELECT " +
                "m_id as id," +
                "m_brand as brand," +
                "m_model as model," +
                "m_cpu_type as CPU," +
                "m_ram_memory as RAM," +
                "m_form_factor as FORM_FACTOR," +
                "m_memory_slots as RAM_slots," +
                "m_max_memory as max_RAM," +
                "m_socket as socket," +
                "m_sata_slots as SATA," +
                "m_usb_count as USB," +
                "m_price as price," +
                "m_status as status," +
                "m_access_id as a_id FROM motherboards");
            datagrid.ItemsSource = dl.dt.DefaultView;
        }

        private void Insert_btn_Click_2(object sender, RoutedEventArgs e)
        {
            string insert = "INSERT INTO motherboards(m_brand, m_model, m_cpu_type, m_ram_memory, m_form_factor, m_memory_slots, m_max_memory, m_socket, m_sata_slots, m_usb_count, m_price, m_status)" +
                            $"VALUES('{cbox_m_brand.Text}', '{txt_m_model.Text}', '{cbox_m_cpu_type.Text}', '{cbox_m_ram_memory.Text}', '{txt_m_form_factor.Text}', {txt_m_memory_slots.Text}, {txt_m_max_memory.Text}, '{txt_m_socket.Text}', {txt_m_sata_slots.Text}, {txt_m_usb_slots.Text}, {txt_m_price.Text}, '{cbox_m_status.Text}')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = insert;

            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");

            READ();
        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            string update = $"UPDATE motherboards SET m_brand = '{cbox_m_brand.Text}', m_model = '{txt_m_model.Text}', m_cpu_type = '{cbox_m_cpu_type.Text}', m_ram_memory = '{cbox_m_ram_memory.Text}', m_form_factor = '{txt_m_form_factor.Text}', m_memory_slots = '{txt_m_memory_slots.Text}', m_max_memory = {txt_m_max_memory.Text}, m_socket = '{txt_m_socket.Text}', m_sata_slots = {txt_m_sata_slots.Text}, m_usb_count = {txt_m_usb_slots.Text}, m_price ={txt_m_price.Text} , m_status = '{cbox_m_status.Text}' WHERE m_id = {lbl_m_id.Content}";

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = update;

            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");

            READ();
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            string delete = $"DELETE FROM motherboards WHERE m_id={lbl_m_id.Content}";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = delete;
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            READ();
        }
        public void Clear_box()
        {
            lbl_m_id.Content = txt_m_form_factor.Text = txt_m_max_memory.Text = txt_m_memory_slots.Text = txt_m_model.Text = txt_m_price.Text = txt_m_sata_slots.Text = txt_m_socket.Text = txt_m_usb_slots.Text = string.Empty;
            cbox_m_brand.SelectedIndex = cbox_m_cpu_type.SelectedIndex = cbox_m_ram_memory.SelectedIndex = cbox_m_status.SelectedIndex = -1;
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

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid senderGrid = (DataGrid)sender;
            try
            {
                if (datagrid.Items.Count > 0)
                {
                    lbl_m_id.Content = ((DataRowView)datagrid.SelectedItem).Row[0].ToString();
                    cbox_m_brand.Text = ((DataRowView)datagrid.SelectedItem).Row[1].ToString();
                    txt_m_model.Text = ((DataRowView)datagrid.SelectedItem).Row[2].ToString();
                    cbox_m_cpu_type.Text = ((DataRowView)datagrid.SelectedItem).Row[3].ToString();
                    cbox_m_ram_memory.Text = ((DataRowView)datagrid.SelectedItem).Row[4].ToString();
                    txt_m_form_factor.Text = ((DataRowView)datagrid.SelectedItem).Row[5].ToString();
                    txt_m_memory_slots.Text = ((DataRowView)datagrid.SelectedItem).Row[6].ToString();
                    txt_m_max_memory.Text = ((DataRowView)datagrid.SelectedItem).Row[7].ToString();
                    txt_m_socket.Text = ((DataRowView)datagrid.SelectedItem).Row[8].ToString();
                    txt_m_sata_slots.Text = ((DataRowView)datagrid.SelectedItem).Row[9].ToString();
                    txt_m_usb_slots.Text = ((DataRowView)datagrid.SelectedItem).Row[10].ToString();
                    txt_m_price.Text = ((DataRowView)datagrid.SelectedItem).Row[11].ToString();
                    cbox_m_status.Text = ((DataRowView)datagrid.SelectedItem).Row[12].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
