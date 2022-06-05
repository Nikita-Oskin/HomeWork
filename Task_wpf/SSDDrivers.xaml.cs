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
    /// Логика взаимодействия для SSDDrivers.xaml
    /// </summary>
    public partial class SSDDrivers : Window
    {
        CRUD dl;
        public SSDDrivers()
        {
            dl = new CRUD();
            InitializeComponent();
            READ();
        }

        public void READ()
        {
            datagrid.ItemsSource = null;
            dl.Read_data("SELECT " +
                "ssd_id as id," +
                "ssd_brand as brand," +
                "ssd_model as model," +
                "ssd_connectivity as connectibity," +
                "ssd_storage as storage," +
                "ssd_nvme as nvme," +
                "ssd_recording_speed as recording_speed," +
                "ssd_reading_speed as reading_speed," +
                "ssd_price as price," +
                "ssd_status as status," +
                "ssd_access_id as a_id FROM ssd_drives");
            datagrid.ItemsSource = dl.dt.DefaultView;
        }

        public void Clear_box()
        {
            lbl_ssd_id.Content = txt_ssd_model.Text = txt_ssd_price.Text = txt_ssd_reading_speed.Text = txt_ssd_recording_speed.Text = txt_ssd_storage.Text = string.Empty;
            cbox_ssd_brand.SelectedIndex = cbox_ssd_connectivity.SelectedIndex = cbox_ssd_nvme.SelectedIndex = cbox_ssd_status.SelectedIndex = -1;
        }

        private void Insert_btn_Click_2(object sender, RoutedEventArgs e)
        {
            string insert = "INSERT INTO ssd_drives(ssd_brand, ssd_model, ssd_connectivity, ssd_storage, ssd_nvme, ssd_recording_speed, ssd_reading_speed, ssd_price, ssd_status) " +
                           $"VALUES('{cbox_ssd_brand.Text}', '{txt_ssd_model.Text}', '{cbox_ssd_connectivity.Text}', {txt_ssd_storage.Text}, '{cbox_ssd_nvme.Text}', {txt_ssd_recording_speed.Text}, {txt_ssd_reading_speed.Text}, {txt_ssd_price.Text}, '{cbox_ssd_status.Text}')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = insert;
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            READ();
        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            string update = $"UPDATE ssd_drives SET ssd_brand ='{cbox_ssd_brand.Text}', ssd_model ='{txt_ssd_model.Text}', ssd_connectivity ='{cbox_ssd_connectivity.Text}', ssd_storage ={txt_ssd_storage.Text}, " +
                            $"ssd_nvme='{cbox_ssd_nvme.Text}', ssd_recording_speed={txt_ssd_recording_speed.Text}, ssd_reading_speed = {txt_ssd_reading_speed.Text}, ssd_price={txt_ssd_price.Text}, ssd_status='{cbox_ssd_status.Text}' WHERE ssd_id={lbl_ssd_id.Content}";

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = update;

            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");

            READ();
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            string delete = $"DELETE FROM ssd_drives WHERE ssd_id={lbl_ssd_id.Content}";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = delete;
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            READ();
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

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid senderGrid = (DataGrid)sender;
            try
            {
                if (datagrid.Items.Count > 0)
                {
                    lbl_ssd_id.Content = ((DataRowView)datagrid.SelectedItem).Row[0].ToString();
                    cbox_ssd_brand.Text = ((DataRowView)datagrid.SelectedItem).Row[1].ToString();
                    txt_ssd_model.Text = ((DataRowView)datagrid.SelectedItem).Row[2].ToString();
                    cbox_ssd_connectivity.Text = ((DataRowView)datagrid.SelectedItem).Row[3].ToString();
                    txt_ssd_storage.Text = ((DataRowView)datagrid.SelectedItem).Row[4].ToString();
                    cbox_ssd_nvme.Text = ((DataRowView)datagrid.SelectedItem).Row[5].ToString();
                    txt_ssd_recording_speed.Text = ((DataRowView)datagrid.SelectedItem).Row[6].ToString();
                    txt_ssd_reading_speed.Text = ((DataRowView)datagrid.SelectedItem).Row[7].ToString();
                    txt_ssd_price.Text = ((DataRowView)datagrid.SelectedItem).Row[8].ToString();
                    cbox_ssd_status.Text = ((DataRowView)datagrid.SelectedItem).Row[9].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
