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
    public partial class RAM_CRUD : Form
    {
        CRUD dl;
        public RAM_CRUD()
        {
            dl = new CRUD();
            InitializeComponent();
        }

        public void READ()
        {
            dataGridView1.DataSource = null;
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
            dataGridView1.DataSource = dl.dt;
        }

        public void Clear_box()
        {
            txt_ram_model.Text = txt_ram_price.Text = txt_ram_count.Text = txt_ram_memory_size.Text = txt_ram_model.Text = txt_ram_rgb.Text = txt_ram_speed.Text = string.Empty;
            cbox_ram_brand.SelectedIndex = cbox_ram_type_memory.SelectedIndex = cbox_ram_status.SelectedIndex = -1;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void RAM_CRUD_Load(object sender, EventArgs e)
        {
            READ();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO ram(ram_brand, ram_model, ram_type_memory, ram_memory_size, ram_count, ram_speed, ram_rgb, ram_price, ram_status) " +
                           $"VALUES('{cbox_ram_brand.SelectedItem}', '{txt_ram_model.Text}', '{cbox_ram_type_memory.SelectedItem}', {txt_ram_memory_size.Text}, {txt_ram_count.Text}, {txt_ram_speed.Text}, '{txt_ram_rgb.Text}', {txt_ram_price.Text}, '{cbox_ram_status.SelectedItem}')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = insert;
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            READ();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string update = $"UPDATE ram SET ram_brand ='{cbox_ram_brand.SelectedItem}', ram_model ='{txt_ram_model.Text}', ram_type_memory ='{cbox_ram_type_memory.SelectedItem}', ram_memory_size ={txt_ram_memory_size.Text}, " +
                            $"ram_count={txt_ram_count.Text}, ram_speed={txt_ram_speed.Text}, ram_rgb = '{txt_ram_rgb.Text}', ram_price={txt_ram_price.Text}, ram_status='{cbox_ram_status.SelectedItem}' WHERE ram_id={int.Parse(lbl_ram_id.Text)}";

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = update;

            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");

            READ();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string delete = $"DELETE FROM ram WHERE ram_id={int.Parse(lbl_ram_id.Text)}";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = delete;
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            READ();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Clear_box();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    lbl_ram_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cbox_ram_brand.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txt_ram_model.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    cbox_ram_type_memory.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txt_ram_memory_size.Text = (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                    txt_ram_count.Text = (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                    txt_ram_speed.Text = (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                    txt_ram_rgb.Text = (dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
                    txt_ram_price.Text = (dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
                    cbox_ram_status.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Don't Click the Header");
            }
        }

        
    }
}
