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
    public partial class Motherboard_CRUD : Form
    {
        CRUD dl;
        public Motherboard_CRUD()
        {
            dl = new CRUD();
            InitializeComponent();
        }

        private void Motherboard_CRUD_Load(object sender, EventArgs e)
        {
            READ();
        }
        public void READ()
        {
            dataGridView1.DataSource = null;
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
            dataGridView1.DataSource = dl.dt;
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO motherboards(m_brand, m_model, m_cpu_type, m_ram_memory, m_form_factor, m_memory_slots, m_max_memory, m_socket, m_sata_slots, m_usb_count, m_price, m_status)" +
                            $"VALUES('{cbox_m_brand.SelectedItem}', '{txt_m_model.Text}', '{cbox_m_cpu_type.SelectedItem}', '{cbox_m_ram_memory.SelectedItem}', '{txt_m_form_factor.Text}', {txt_m_memory_slots.Text}, {txt_m_max_memory.Text}, '{txt_m_socket.Text}', {txt_m_sata_slots.Text}, {txt_m_usb_slots.Text}, {txt_m_price.Text}, '{cbox_m_status.SelectedItem}')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = insert;

            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");

            READ();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 newForm = new Form2();
            newForm.Show();
        }
        public void Clear_box()
        {
            lbl_m_id.Text = txt_m_form_factor.Text = txt_m_max_memory.Text = txt_m_memory_slots.Text = txt_m_model.Text = txt_m_price.Text = txt_m_sata_slots.Text = txt_m_socket.Text = txt_m_usb_slots.Text = string.Empty;
            cbox_m_brand.SelectedIndex = cbox_m_cpu_type.SelectedIndex = cbox_m_ram_memory.SelectedIndex = cbox_m_status.SelectedIndex = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    lbl_m_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cbox_m_brand.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txt_m_model.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    cbox_m_cpu_type.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    cbox_m_ram_memory.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                    txt_m_form_factor.Text = (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                    txt_m_memory_slots.Text = (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                    txt_m_max_memory.Text = (dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
                    txt_m_socket.Text = (dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
                    txt_m_sata_slots.Text = (dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
                    txt_m_usb_slots.Text = (dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString());
                    txt_m_price.Text = (dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString());
                    cbox_m_status.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString());

                }
            }
            catch
            {
                MessageBox.Show("Don't Click the Header");
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Clear_box();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string update = $"UPDATE motherboards SET m_brand = '{cbox_m_brand.SelectedItem}', m_model = '{txt_m_model.Text}', m_cpu_type = '{cbox_m_cpu_type.SelectedItem}', m_ram_memory = '{cbox_m_ram_memory.SelectedItem}', m_form_factor = '{txt_m_form_factor.Text}', m_memory_slots = '{txt_m_memory_slots.Text}', m_max_memory = {txt_m_max_memory.Text}, m_socket = '{txt_m_socket.Text}', m_sata_slots = {txt_m_sata_slots.Text}, m_usb_count = {txt_m_usb_slots.Text}, m_price ={txt_m_price.Text} , m_status = '{cbox_m_status.SelectedItem}' WHERE m_id = {int.Parse(lbl_m_id.Text)}";

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = update;

            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");

            READ();
        }


        private void delete_btn_Click_1(object sender, EventArgs e)
        {
            string delete = $"DELETE FROM motherboards WHERE m_id={int.Parse(lbl_m_id.Text)}";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = delete;
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            READ();
        }




    }
}
