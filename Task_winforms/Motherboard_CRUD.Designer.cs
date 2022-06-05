
namespace pcshop
{
    partial class Motherboard_CRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbox_m_brand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_m_id = new System.Windows.Forms.Label();
            this.txt_m_model = new System.Windows.Forms.TextBox();
            this.cbox_m_cpu_type = new System.Windows.Forms.ComboBox();
            this.cbox_m_ram_memory = new System.Windows.Forms.ComboBox();
            this.txt_m_form_factor = new System.Windows.Forms.TextBox();
            this.txt_m_memory_slots = new System.Windows.Forms.TextBox();
            this.txt_m_max_memory = new System.Windows.Forms.TextBox();
            this.txt_m_socket = new System.Windows.Forms.TextBox();
            this.txt_m_sata_slots = new System.Windows.Forms.TextBox();
            this.txt_m_usb_slots = new System.Windows.Forms.TextBox();
            this.txt_m_price = new System.Windows.Forms.TextBox();
            this.cbox_m_status = new System.Windows.Forms.ComboBox();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbox_m_brand
            // 
            this.cbox_m_brand.FormattingEnabled = true;
            this.cbox_m_brand.Items.AddRange(new object[] {
            "ASRock",
            "Gigabyte",
            "MSI"});
            this.cbox_m_brand.Location = new System.Drawing.Point(177, 49);
            this.cbox_m_brand.Name = "cbox_m_brand";
            this.cbox_m_brand.Size = new System.Drawing.Size(223, 21);
            this.cbox_m_brand.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Производитель";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "Модель";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "Тип памяти";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "Тип процессора";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(12, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 57;
            this.label5.Text = "Сокет";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(12, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 23);
            this.label6.TabIndex = 55;
            this.label6.Text = "Макс. объем ОЗУ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(12, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 23);
            this.label7.TabIndex = 53;
            this.label7.Text = "Кол-во слотов ОЗУ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(12, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 23);
            this.label8.TabIndex = 51;
            this.label8.Text = "Форм-фактор";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(12, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 23);
            this.label9.TabIndex = 65;
            this.label9.Text = "Статус";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(12, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 23);
            this.label10.TabIndex = 63;
            this.label10.Text = "Цена";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Snow;
            this.label11.Location = new System.Drawing.Point(12, 459);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 23);
            this.label11.TabIndex = 61;
            this.label11.Text = "Кол-во USB2/3";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(12, 414);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 23);
            this.label12.TabIndex = 59;
            this.label12.Text = "SATA3";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Snow;
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Location = new System.Drawing.Point(227, 629);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(100, 40);
            this.delete_btn.TabIndex = 70;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click_1);
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.Color.Snow;
            this.Clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_btn.ForeColor = System.Drawing.Color.Black;
            this.Clear_btn.Location = new System.Drawing.Point(333, 629);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(100, 40);
            this.Clear_btn.TabIndex = 69;
            this.Clear_btn.Text = "Очистить";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Snow;
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.Location = new System.Drawing.Point(121, 629);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(100, 40);
            this.update_btn.TabIndex = 68;
            this.update_btn.Text = "Изменить";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // Insert_btn
            // 
            this.Insert_btn.BackColor = System.Drawing.Color.Snow;
            this.Insert_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Insert_btn.ForeColor = System.Drawing.Color.Black;
            this.Insert_btn.Location = new System.Drawing.Point(15, 629);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(100, 40);
            this.Insert_btn.TabIndex = 67;
            this.Insert_btn.Text = "Добавить";
            this.Insert_btn.UseVisualStyleBackColor = false;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(436, 49);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(816, 560);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_m_id
            // 
            this.lbl_m_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_m_id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_m_id.ForeColor = System.Drawing.Color.Snow;
            this.lbl_m_id.Location = new System.Drawing.Point(12, 9);
            this.lbl_m_id.Name = "lbl_m_id";
            this.lbl_m_id.Size = new System.Drawing.Size(140, 23);
            this.lbl_m_id.TabIndex = 72;
            this.lbl_m_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_m_model
            // 
            this.txt_m_model.Location = new System.Drawing.Point(177, 97);
            this.txt_m_model.Name = "txt_m_model";
            this.txt_m_model.Size = new System.Drawing.Size(223, 20);
            this.txt_m_model.TabIndex = 73;
            // 
            // cbox_m_cpu_type
            // 
            this.cbox_m_cpu_type.FormattingEnabled = true;
            this.cbox_m_cpu_type.Items.AddRange(new object[] {
            "INTEL",
            "AMD"});
            this.cbox_m_cpu_type.Location = new System.Drawing.Point(177, 143);
            this.cbox_m_cpu_type.Name = "cbox_m_cpu_type";
            this.cbox_m_cpu_type.Size = new System.Drawing.Size(223, 21);
            this.cbox_m_cpu_type.TabIndex = 74;
            // 
            // cbox_m_ram_memory
            // 
            this.cbox_m_ram_memory.FormattingEnabled = true;
            this.cbox_m_ram_memory.Items.AddRange(new object[] {
            "DDR3",
            "DDR4",
            "DDR5"});
            this.cbox_m_ram_memory.Location = new System.Drawing.Point(177, 188);
            this.cbox_m_ram_memory.Name = "cbox_m_ram_memory";
            this.cbox_m_ram_memory.Size = new System.Drawing.Size(223, 21);
            this.cbox_m_ram_memory.TabIndex = 75;
            // 
            // txt_m_form_factor
            // 
            this.txt_m_form_factor.Location = new System.Drawing.Point(177, 233);
            this.txt_m_form_factor.Name = "txt_m_form_factor";
            this.txt_m_form_factor.Size = new System.Drawing.Size(223, 20);
            this.txt_m_form_factor.TabIndex = 76;
            // 
            // txt_m_memory_slots
            // 
            this.txt_m_memory_slots.Location = new System.Drawing.Point(177, 278);
            this.txt_m_memory_slots.Name = "txt_m_memory_slots";
            this.txt_m_memory_slots.Size = new System.Drawing.Size(223, 20);
            this.txt_m_memory_slots.TabIndex = 77;
            // 
            // txt_m_max_memory
            // 
            this.txt_m_max_memory.Location = new System.Drawing.Point(177, 324);
            this.txt_m_max_memory.Name = "txt_m_max_memory";
            this.txt_m_max_memory.Size = new System.Drawing.Size(223, 20);
            this.txt_m_max_memory.TabIndex = 78;
            // 
            // txt_m_socket
            // 
            this.txt_m_socket.Location = new System.Drawing.Point(177, 369);
            this.txt_m_socket.Name = "txt_m_socket";
            this.txt_m_socket.Size = new System.Drawing.Size(223, 20);
            this.txt_m_socket.TabIndex = 79;
            // 
            // txt_m_sata_slots
            // 
            this.txt_m_sata_slots.Location = new System.Drawing.Point(177, 417);
            this.txt_m_sata_slots.Name = "txt_m_sata_slots";
            this.txt_m_sata_slots.Size = new System.Drawing.Size(223, 20);
            this.txt_m_sata_slots.TabIndex = 80;
            // 
            // txt_m_usb_slots
            // 
            this.txt_m_usb_slots.Location = new System.Drawing.Point(177, 462);
            this.txt_m_usb_slots.Name = "txt_m_usb_slots";
            this.txt_m_usb_slots.Size = new System.Drawing.Size(223, 20);
            this.txt_m_usb_slots.TabIndex = 81;
            // 
            // txt_m_price
            // 
            this.txt_m_price.Location = new System.Drawing.Point(177, 508);
            this.txt_m_price.Name = "txt_m_price";
            this.txt_m_price.Size = new System.Drawing.Size(223, 20);
            this.txt_m_price.TabIndex = 82;
            // 
            // cbox_m_status
            // 
            this.cbox_m_status.FormattingEnabled = true;
            this.cbox_m_status.Items.AddRange(new object[] {
            "published",
            "draft"});
            this.cbox_m_status.Location = new System.Drawing.Point(177, 553);
            this.cbox_m_status.Name = "cbox_m_status";
            this.cbox_m_status.Size = new System.Drawing.Size(223, 21);
            this.cbox_m_status.TabIndex = 83;
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Snow;
            this.Back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_btn.ForeColor = System.Drawing.Color.Black;
            this.Back_btn.Location = new System.Drawing.Point(1152, 629);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(100, 40);
            this.Back_btn.TabIndex = 84;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Motherboard_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.cbox_m_status);
            this.Controls.Add(this.txt_m_price);
            this.Controls.Add(this.txt_m_usb_slots);
            this.Controls.Add(this.txt_m_sata_slots);
            this.Controls.Add(this.txt_m_socket);
            this.Controls.Add(this.txt_m_max_memory);
            this.Controls.Add(this.txt_m_memory_slots);
            this.Controls.Add(this.txt_m_form_factor);
            this.Controls.Add(this.cbox_m_ram_memory);
            this.Controls.Add(this.cbox_m_cpu_type);
            this.Controls.Add(this.txt_m_model);
            this.Controls.Add(this.lbl_m_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox_m_brand);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Motherboard_CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motherboard_CRUD";
            this.Load += new System.EventHandler(this.Motherboard_CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_m_brand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_m_id;
        private System.Windows.Forms.TextBox txt_m_model;
        private System.Windows.Forms.ComboBox cbox_m_cpu_type;
        private System.Windows.Forms.ComboBox cbox_m_ram_memory;
        private System.Windows.Forms.TextBox txt_m_form_factor;
        private System.Windows.Forms.TextBox txt_m_memory_slots;
        private System.Windows.Forms.TextBox txt_m_max_memory;
        private System.Windows.Forms.TextBox txt_m_socket;
        private System.Windows.Forms.TextBox txt_m_sata_slots;
        private System.Windows.Forms.TextBox txt_m_usb_slots;
        private System.Windows.Forms.TextBox txt_m_price;
        private System.Windows.Forms.ComboBox cbox_m_status;
        private System.Windows.Forms.Button Back_btn;
    }
}