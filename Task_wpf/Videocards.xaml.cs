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
    /// Interaction logic for Videocards.xaml
    /// </summary>
    public partial class Videocards : Window
    {
        CRUD dl;
        public Videocards()
        {
            dl = new CRUD();
            InitializeComponent();
            READ();
        }

        public void READ()
        {
            datagrid.ItemsSource = null;
            dl.Read_data("SELECT " +
                "v_id as id," +
                "v_brand as brand," +
                "v_model as model," +
                "v_memory_size as memory_size," +
                "v_type_memory as type_memory," +
                "v_speed as speed," +
                "v_connectors as connectors," +
                "v_price as price," +
                "v_status as status," +
                "v_access_id as a_id FROM videocards");
            datagrid.ItemsSource = dl.dt.DefaultView;
        }
        public void Clear_box()
        {
            lbl_v_id.Content = txt_v_connectors.Text = txt_v_memory_size.Text = txt_v_model.Text = txt_v_price.Text = txt_v_speed.Text = txt_v_type_memory.Text = string.Empty;
            cbox_v_brand.SelectedIndex = cbox_v_status.SelectedIndex = -1;
        }

        private void Insert_btn_Click_2(object sender, RoutedEventArgs e)
        {
            string insert = "INSERT INTO videocards(v_brand, v_model, v_memory_size, v_type_memory, v_speed, v_connectors, v_price, v_status) " +
                           $"VALUES('{cbox_v_brand.Text}', '{txt_v_model.Text}', {txt_v_memory_size.Text}, '{txt_v_type_memory.Text}', {txt_v_speed.Text}, '{txt_v_connectors.Text}', {txt_v_price.Text}, '{cbox_v_status.Text}')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = insert;
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            READ();
        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            string update = $"UPDATE videocards SET v_brand ='{cbox_v_brand.Text}', v_model ='{txt_v_model.Text}', v_memory_size ={txt_v_memory_size.Text}, v_type_memory ='{txt_v_type_memory.Text}', v_speed={txt_v_speed.Text}, v_connectors='{txt_v_connectors.Text}', v_price={txt_v_price.Text}, v_status='{cbox_v_status.Text}' WHERE v_id={lbl_v_id.Content}";

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = update;

            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");

            READ();
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            string delete = $"DELETE FROM videocards WHERE v_id={lbl_v_id.Content}";
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
                    lbl_v_id.Content = ((DataRowView)datagrid.SelectedItem).Row[0].ToString();
                    cbox_v_brand.Text = ((DataRowView)datagrid.SelectedItem).Row[1].ToString();
                    txt_v_model.Text = ((DataRowView)datagrid.SelectedItem).Row[2].ToString();
                    txt_v_memory_size.Text = ((DataRowView)datagrid.SelectedItem).Row[3].ToString();
                    txt_v_type_memory.Text = ((DataRowView)datagrid.SelectedItem).Row[4].ToString();
                    txt_v_speed.Text = ((DataRowView)datagrid.SelectedItem).Row[5].ToString();
                    txt_v_connectors.Text = ((DataRowView)datagrid.SelectedItem).Row[6].ToString();
                    txt_v_price.Text = ((DataRowView)datagrid.SelectedItem).Row[7].ToString();
                    cbox_v_status.Text = ((DataRowView)datagrid.SelectedItem).Row[8].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
