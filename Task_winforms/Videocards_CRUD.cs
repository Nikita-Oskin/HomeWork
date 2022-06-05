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
    public partial class Videocards_CRUD : Form
    {
        CRUD dl;

        public Videocards_CRUD()
        {
            dl = new CRUD();
            InitializeComponent();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO videocards(v_brand, v_model, v_memory_size, v_type_memory, v_speed, v_connectors, v_price, v_status) " +
                           $"VALUES('{cbox_v_brand.SelectedItem}', '{txt_v_model.Text}', {txt_v_memory_size.Text}, '{txt_v_type_memory.Text}', {txt_v_speed.Text}, '{txt_v_connectors.Text}', {txt_v_price.Text}, '{cbox_v_status.SelectedItem}')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = insert;
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            READ();
        }

        public void READ()
        {
            dataGridView1.DataSource = null;
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
            dataGridView1.DataSource = dl.dt;
        }

        public void Clear_box()
        {
            txt_v_connectors.Text = txt_v_memory_size.Text = txt_v_model.Text = txt_v_price.Text = txt_v_speed.Text = txt_v_type_memory.Text = string.Empty;
            cbox_v_brand.SelectedIndex =cbox_v_status.SelectedIndex = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    lbl_v_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cbox_v_brand.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txt_v_model.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txt_v_memory_size.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txt_v_type_memory.Text = (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                    txt_v_speed.Text = (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                    txt_v_connectors.Text = (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                    txt_v_price.Text = (dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
                    cbox_v_status.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Don't Click the Header");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string update = $"UPDATE videocards SET v_brand ='{cbox_v_brand.SelectedItem}', v_model ='{txt_v_model.Text}', v_memory_size ={txt_v_memory_size.Text}, v_type_memory ='{txt_v_type_memory.Text}', v_speed={txt_v_speed.Text}, v_connectors='{txt_v_connectors.Text}', v_price={txt_v_price.Text}, v_status='{cbox_v_status.SelectedItem}' WHERE v_id={int.Parse(lbl_v_id.Text)}";

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = update;

            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");

            READ();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string delete = $"DELETE FROM videocards WHERE v_id={int.Parse(lbl_v_id.Text)}";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = delete;
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            READ();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Clear_box();
        }

        private void Videocards_CRUD_Load(object sender, EventArgs e)
        {
            READ();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 newForm = new Form2();
            newForm.Show();
        }

        
    }
}
