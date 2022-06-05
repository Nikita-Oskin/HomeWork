using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcshop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cpu_db_Click(object sender, EventArgs e)
        {
            this.Hide();
            CPU newForm = new CPU();
            newForm.Show();
        }


        private void motherboard_db_Click(object sender, EventArgs e)
        {
            this.Hide();
            Motherboard_CRUD motherboard_CRUD = new Motherboard_CRUD();
            motherboard_CRUD.Show();
        }

       

        private void videocard_db_Click(object sender, EventArgs e)
        {
            this.Hide();
            Videocards_CRUD newForm = new Videocards_CRUD();
            newForm.Show();
        }

        private void ssd_db_Click(object sender, EventArgs e)
        {
            this.Hide();
            SSDDrives_CRUD newform = new SSDDrives_CRUD();
            newform.Show();
        }

        private void ram_db_Click(object sender, EventArgs e)
        {
            this.Hide();
            RAM_CRUD newform = new RAM_CRUD();
            newform.Show();
        }

        

        
    }
}
