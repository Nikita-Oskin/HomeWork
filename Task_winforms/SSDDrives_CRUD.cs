using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pcshop
{
    public partial class SSDDrives_CRUD : Form
    {
        CRUD dl;

        public SSDDrives_CRUD()
        {
            dl = new CRUD();
            InitializeComponent();
        }

        public void READ()
        {
            dataGridView1.DataSource = null;
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
            dataGridView1.DataSource = dl.dt;
        }

        public void Clear_box()
        {
            txt_ssd_model.Text = txt_ssd_price.Text = txt_ssd_reading_speed.Text = txt_ssd_recording_speed.Text = txt_ssd_storage.Text = string.Empty;
            cbox_ssd_brand.SelectedIndex = cbox_ssd_connectivity.SelectedIndex = cbox_ssd_nvme.SelectedIndex = cbox_ssd_status.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO ssd_drives(ssd_brand, ssd_model, ssd_connectivity, ssd_storage, ssd_nvme, ssd_recording_speed, ssd_reading_speed, ssd_price, ssd_status) " +
                           $"VALUES('{cbox_ssd_brand.SelectedItem}', '{txt_ssd_model.Text}', '{cbox_ssd_connectivity.SelectedItem}', {txt_ssd_storage.Text}, '{cbox_ssd_nvme.SelectedItem}', {txt_ssd_recording_speed.Text}, {txt_ssd_reading_speed.Text}, {txt_ssd_price.Text}, '{cbox_ssd_status.SelectedItem}')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = insert;
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            READ();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string update = $"UPDATE ssd_drives SET ssd_brand ='{cbox_ssd_brand.SelectedItem}', ssd_model ='{txt_ssd_model.Text}', ssd_connectivity ='{cbox_ssd_connectivity.SelectedItem}', ssd_storage ={txt_ssd_storage.Text}, " +
                            $"ssd_nvme='{cbox_ssd_nvme.SelectedItem}', ssd_recording_speed={txt_ssd_recording_speed.Text}, ssd_reading_speed = {txt_ssd_reading_speed.Text}, ssd_price={txt_ssd_price.Text}, ssd_status='{cbox_ssd_status.SelectedItem}' WHERE ssd_id={int.Parse(lbl_ssd_id.Text)}";

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = update;

            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");

            READ();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string delete = $"DELETE FROM ssd_drives WHERE ssd_id={int.Parse(lbl_ssd_id.Text)}";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = delete;
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            READ();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Clear_box();
        }

        private void SSDDrives_CRUD_Load(object sender, EventArgs e)
        {
            READ();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    lbl_ssd_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cbox_ssd_brand.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txt_ssd_model.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    cbox_ssd_connectivity.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txt_ssd_storage.Text = (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                    cbox_ssd_nvme.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                    txt_ssd_recording_speed.Text = (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                    txt_ssd_reading_speed.Text= (dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
                    txt_ssd_price.Text = (dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
                    cbox_ssd_status.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Don't Click the Header");
            }
        }

        
    }
}
