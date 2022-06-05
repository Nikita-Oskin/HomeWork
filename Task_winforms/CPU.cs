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
    public partial class CPU : Form
    {        
        CRUD dl;        

        public CPU()
        {
            dl = new CRUD();
            InitializeComponent();            
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO processors(cpu_brand, cpu_model, cpu_socket, cpu_cores, cpu_threads, cpu_base_speed, cpu_max_speed, cpu_graphics, cpu_cache, cpu_tdp, cpu_equipment, cpu_price, cpu_status) " +
                           $"VALUES('{cbox_cpu_brand.SelectedItem}', '{txt_cpu_model.Text}', '{txt_cpu_socket.Text}', {txt_cpu_cores.Text}, {txt_cpu_threads.Text}, {txt_cpu_base_speed.Text}, {txt_cpu_max_turbo.Text}, '{txt_cpu_graphics.Text}', {txt_cpu_cache.Text}, {txt_cpu_tdp.Text}, '{cbox_cpu_equipment.SelectedItem}', {txt_cpu_price.Text}, '{cbox_cpu_status.SelectedItem}')";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = insert;
            
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            
            READ();
            
        }

        private void CPU_Load(object sender, EventArgs e)
        {
            READ();            
        }

        public void READ()
        {
            dataGridView1.DataSource = null;
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
            dataGridView1.DataSource = dl.dt;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 newForm = new Form2();
            newForm.Show();
        }
        public void Clear_box()
        {
            lbl_cpu_id.Text = txt_cpu_base_speed.Text = txt_cpu_cache.Text = txt_cpu_cores.Text = txt_cpu_graphics.Text = txt_cpu_max_turbo.Text = txt_cpu_model.Text = txt_cpu_price.Text = txt_cpu_socket.Text = txt_cpu_tdp.Text = txt_cpu_threads.Text = string.Empty;
            cbox_cpu_brand.SelectedIndex = cbox_cpu_equipment.SelectedIndex = cbox_cpu_status.SelectedIndex = -1;
        }

        private void Brand_name_label_Click(object sender, EventArgs e)
        {

        }

        private void txtConfiguration_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    lbl_cpu_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();                  
                    cbox_cpu_brand.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());                    
                    txt_cpu_model.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());                    
                    txt_cpu_socket.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txt_cpu_cores.Text = (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                    txt_cpu_threads.Text = (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                    txt_cpu_base_speed.Text = (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()); 
                    txt_cpu_max_turbo.Text = (dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());                     
                    txt_cpu_cache.Text = (dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString()); 
                    txt_cpu_tdp.Text = (dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString()); 
                    txt_cpu_graphics.Text = (dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString()); 
                    cbox_cpu_equipment.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString()); 
                    txt_cpu_price.Text = (dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString()); 
                    cbox_cpu_status.SelectedItem = (dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString()); 

                }
            }
            catch
            {
                MessageBox.Show("Don't Click the Header");
            }
        }

        

        private void update_btn_Click(object sender, EventArgs e)
        {            
            string update = $"UPDATE processors SET cpu_brand='{cbox_cpu_brand.SelectedItem}', cpu_model='{txt_cpu_model.Text}', cpu_socket='{txt_cpu_socket.Text}', cpu_cores={txt_cpu_cores.Text}, cpu_threads={txt_cpu_threads.Text}, cpu_base_speed={txt_cpu_base_speed.Text}, cpu_max_speed={txt_cpu_max_turbo.Text}, cpu_cache={txt_cpu_cache.Text}, cpu_tdp={txt_cpu_tdp.Text}, cpu_graphics='{txt_cpu_graphics.Text}', cpu_equipment='{cbox_cpu_equipment.SelectedItem}', cpu_price={txt_cpu_price.Text}, cpu_status='{cbox_cpu_status.SelectedItem}' WHERE cpu_id={int.Parse(lbl_cpu_id.Text)}";

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = update;
            
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            
            READ();      
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string delete = $"DELETE FROM processors WHERE cpu_id={int.Parse(lbl_cpu_id.Text)}";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = delete;
            MessageBox.Show(dl.custominsertupdatedelete(cmd), "Save");
            READ();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Clear_box();
        }

        
    }
}
