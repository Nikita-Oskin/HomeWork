
namespace pcshop
{
    partial class SSDDrives_CRUD
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
            this.lbl_ssd_id = new System.Windows.Forms.Label();
            this.lbl_cpu_graphics = new System.Windows.Forms.Label();
            this.lbl_cpu_max_turbo = new System.Windows.Forms.Label();
            this.lbl_cpu_base_speed = new System.Windows.Forms.Label();
            this.lbl_cpu_threads = new System.Windows.Forms.Label();
            this.lbl_cpu_cores = new System.Windows.Forms.Label();
            this.lbl_cpu_socket = new System.Windows.Forms.Label();
            this.lbl_cpu_model = new System.Windows.Forms.Label();
            this.lbl_cpu_brand = new System.Windows.Forms.Label();
            this.lbl_ssd_status = new System.Windows.Forms.Label();
            this.cbox_ssd_brand = new System.Windows.Forms.ComboBox();
            this.txt_ssd_model = new System.Windows.Forms.TextBox();
            this.cbox_ssd_connectivity = new System.Windows.Forms.ComboBox();
            this.txt_ssd_storage = new System.Windows.Forms.TextBox();
            this.cbox_ssd_nvme = new System.Windows.Forms.ComboBox();
            this.txt_ssd_recording_speed = new System.Windows.Forms.TextBox();
            this.txt_ssd_reading_speed = new System.Windows.Forms.TextBox();
            this.txt_ssd_price = new System.Windows.Forms.TextBox();
            this.cbox_ssd_status = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.Insert_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ssd_id
            // 
            this.lbl_ssd_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ssd_id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ssd_id.ForeColor = System.Drawing.Color.Snow;
            this.lbl_ssd_id.Location = new System.Drawing.Point(12, 9);
            this.lbl_ssd_id.Name = "lbl_ssd_id";
            this.lbl_ssd_id.Size = new System.Drawing.Size(140, 23);
            this.lbl_ssd_id.TabIndex = 55;
            this.lbl_ssd_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_graphics
            // 
            this.lbl_cpu_graphics.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_graphics.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu_graphics.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_graphics.Location = new System.Drawing.Point(12, 359);
            this.lbl_cpu_graphics.Name = "lbl_cpu_graphics";
            this.lbl_cpu_graphics.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_graphics.TabIndex = 54;
            this.lbl_cpu_graphics.Text = "Цена";
            this.lbl_cpu_graphics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_max_turbo
            // 
            this.lbl_cpu_max_turbo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_max_turbo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_max_turbo.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_max_turbo.Location = new System.Drawing.Point(12, 314);
            this.lbl_cpu_max_turbo.Name = "lbl_cpu_max_turbo";
            this.lbl_cpu_max_turbo.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_max_turbo.TabIndex = 53;
            this.lbl_cpu_max_turbo.Text = "Скорость чтения";
            this.lbl_cpu_max_turbo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_base_speed
            // 
            this.lbl_cpu_base_speed.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_base_speed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_base_speed.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_base_speed.Location = new System.Drawing.Point(12, 268);
            this.lbl_cpu_base_speed.Name = "lbl_cpu_base_speed";
            this.lbl_cpu_base_speed.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_base_speed.TabIndex = 52;
            this.lbl_cpu_base_speed.Text = "Скорость записи";
            this.lbl_cpu_base_speed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_threads
            // 
            this.lbl_cpu_threads.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_threads.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_threads.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_threads.Location = new System.Drawing.Point(12, 218);
            this.lbl_cpu_threads.Name = "lbl_cpu_threads";
            this.lbl_cpu_threads.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_threads.TabIndex = 51;
            this.lbl_cpu_threads.Text = "NVMe";
            this.lbl_cpu_threads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_cores
            // 
            this.lbl_cpu_cores.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_cores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_cores.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_cores.Location = new System.Drawing.Point(12, 172);
            this.lbl_cpu_cores.Name = "lbl_cpu_cores";
            this.lbl_cpu_cores.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_cores.TabIndex = 50;
            this.lbl_cpu_cores.Text = "Объем накопителя\t";
            this.lbl_cpu_cores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_socket
            // 
            this.lbl_cpu_socket.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_socket.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_socket.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_socket.Location = new System.Drawing.Point(12, 132);
            this.lbl_cpu_socket.Name = "lbl_cpu_socket";
            this.lbl_cpu_socket.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_socket.TabIndex = 49;
            this.lbl_cpu_socket.Text = "Физ интерфейс";
            this.lbl_cpu_socket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_model
            // 
            this.lbl_cpu_model.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_model.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_model.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_model.Location = new System.Drawing.Point(12, 89);
            this.lbl_cpu_model.Name = "lbl_cpu_model";
            this.lbl_cpu_model.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_model.TabIndex = 48;
            this.lbl_cpu_model.Text = "Марка";
            this.lbl_cpu_model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_brand
            // 
            this.lbl_cpu_brand.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_brand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_brand.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_brand.Location = new System.Drawing.Point(12, 44);
            this.lbl_cpu_brand.Name = "lbl_cpu_brand";
            this.lbl_cpu_brand.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_brand.TabIndex = 47;
            this.lbl_cpu_brand.Text = "Производитель";
            this.lbl_cpu_brand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ssd_status
            // 
            this.lbl_ssd_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ssd_status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ssd_status.ForeColor = System.Drawing.Color.Snow;
            this.lbl_ssd_status.Location = new System.Drawing.Point(12, 396);
            this.lbl_ssd_status.Name = "lbl_ssd_status";
            this.lbl_ssd_status.Size = new System.Drawing.Size(140, 23);
            this.lbl_ssd_status.TabIndex = 56;
            this.lbl_ssd_status.Text = "Статус";
            this.lbl_ssd_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ssd_status.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbox_ssd_brand
            // 
            this.cbox_ssd_brand.FormattingEnabled = true;
            this.cbox_ssd_brand.Items.AddRange(new object[] {
            "Lexar",
            "MSI",
            "Gigabyte"});
            this.cbox_ssd_brand.Location = new System.Drawing.Point(158, 47);
            this.cbox_ssd_brand.Name = "cbox_ssd_brand";
            this.cbox_ssd_brand.Size = new System.Drawing.Size(223, 21);
            this.cbox_ssd_brand.TabIndex = 57;
            // 
            // txt_ssd_model
            // 
            this.txt_ssd_model.BackColor = System.Drawing.Color.Snow;
            this.txt_ssd_model.ForeColor = System.Drawing.Color.Black;
            this.txt_ssd_model.Location = new System.Drawing.Point(158, 92);
            this.txt_ssd_model.Multiline = true;
            this.txt_ssd_model.Name = "txt_ssd_model";
            this.txt_ssd_model.Size = new System.Drawing.Size(223, 20);
            this.txt_ssd_model.TabIndex = 58;
            // 
            // cbox_ssd_connectivity
            // 
            this.cbox_ssd_connectivity.FormattingEnabled = true;
            this.cbox_ssd_connectivity.Items.AddRange(new object[] {
            "SATA III",
            "M. 2"});
            this.cbox_ssd_connectivity.Location = new System.Drawing.Point(158, 135);
            this.cbox_ssd_connectivity.Name = "cbox_ssd_connectivity";
            this.cbox_ssd_connectivity.Size = new System.Drawing.Size(223, 21);
            this.cbox_ssd_connectivity.TabIndex = 59;
            // 
            // txt_ssd_storage
            // 
            this.txt_ssd_storage.BackColor = System.Drawing.Color.Snow;
            this.txt_ssd_storage.ForeColor = System.Drawing.Color.Black;
            this.txt_ssd_storage.Location = new System.Drawing.Point(158, 175);
            this.txt_ssd_storage.Multiline = true;
            this.txt_ssd_storage.Name = "txt_ssd_storage";
            this.txt_ssd_storage.Size = new System.Drawing.Size(223, 20);
            this.txt_ssd_storage.TabIndex = 60;
            // 
            // cbox_ssd_nvme
            // 
            this.cbox_ssd_nvme.FormattingEnabled = true;
            this.cbox_ssd_nvme.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.cbox_ssd_nvme.Location = new System.Drawing.Point(158, 221);
            this.cbox_ssd_nvme.Name = "cbox_ssd_nvme";
            this.cbox_ssd_nvme.Size = new System.Drawing.Size(223, 21);
            this.cbox_ssd_nvme.TabIndex = 61;
            // 
            // txt_ssd_recording_speed
            // 
            this.txt_ssd_recording_speed.BackColor = System.Drawing.Color.Snow;
            this.txt_ssd_recording_speed.ForeColor = System.Drawing.Color.Black;
            this.txt_ssd_recording_speed.Location = new System.Drawing.Point(158, 271);
            this.txt_ssd_recording_speed.Multiline = true;
            this.txt_ssd_recording_speed.Name = "txt_ssd_recording_speed";
            this.txt_ssd_recording_speed.Size = new System.Drawing.Size(223, 20);
            this.txt_ssd_recording_speed.TabIndex = 62;
            // 
            // txt_ssd_reading_speed
            // 
            this.txt_ssd_reading_speed.BackColor = System.Drawing.Color.Snow;
            this.txt_ssd_reading_speed.ForeColor = System.Drawing.Color.Black;
            this.txt_ssd_reading_speed.Location = new System.Drawing.Point(158, 317);
            this.txt_ssd_reading_speed.Multiline = true;
            this.txt_ssd_reading_speed.Name = "txt_ssd_reading_speed";
            this.txt_ssd_reading_speed.Size = new System.Drawing.Size(223, 20);
            this.txt_ssd_reading_speed.TabIndex = 63;
            // 
            // txt_ssd_price
            // 
            this.txt_ssd_price.BackColor = System.Drawing.Color.Snow;
            this.txt_ssd_price.ForeColor = System.Drawing.Color.Black;
            this.txt_ssd_price.Location = new System.Drawing.Point(158, 362);
            this.txt_ssd_price.Multiline = true;
            this.txt_ssd_price.Name = "txt_ssd_price";
            this.txt_ssd_price.Size = new System.Drawing.Size(223, 20);
            this.txt_ssd_price.TabIndex = 64;
            // 
            // cbox_ssd_status
            // 
            this.cbox_ssd_status.FormattingEnabled = true;
            this.cbox_ssd_status.Items.AddRange(new object[] {
            "published",
            "draft"});
            this.cbox_ssd_status.Location = new System.Drawing.Point(158, 399);
            this.cbox_ssd_status.Name = "cbox_ssd_status";
            this.cbox_ssd_status.Size = new System.Drawing.Size(223, 21);
            this.cbox_ssd_status.TabIndex = 65;
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
            this.dataGridView1.Location = new System.Drawing.Point(436, 44);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(816, 560);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.Back_btn.TabIndex = 67;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.Color.Snow;
            this.Clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_btn.ForeColor = System.Drawing.Color.Black;
            this.Clear_btn.Location = new System.Drawing.Point(330, 629);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(100, 40);
            this.Clear_btn.TabIndex = 71;
            this.Clear_btn.Text = "Очистить";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Snow;
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Location = new System.Drawing.Point(224, 629);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(100, 40);
            this.delete_btn.TabIndex = 70;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Snow;
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.Location = new System.Drawing.Point(118, 629);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(100, 40);
            this.update_btn.TabIndex = 69;
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
            this.Insert_btn.Location = new System.Drawing.Point(12, 629);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(100, 40);
            this.Insert_btn.TabIndex = 68;
            this.Insert_btn.Text = "Добавить";
            this.Insert_btn.UseVisualStyleBackColor = false;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // SSDDrives_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbox_ssd_status);
            this.Controls.Add(this.txt_ssd_price);
            this.Controls.Add(this.txt_ssd_reading_speed);
            this.Controls.Add(this.txt_ssd_recording_speed);
            this.Controls.Add(this.cbox_ssd_nvme);
            this.Controls.Add(this.txt_ssd_storage);
            this.Controls.Add(this.cbox_ssd_connectivity);
            this.Controls.Add(this.txt_ssd_model);
            this.Controls.Add(this.cbox_ssd_brand);
            this.Controls.Add(this.lbl_ssd_status);
            this.Controls.Add(this.lbl_ssd_id);
            this.Controls.Add(this.lbl_cpu_graphics);
            this.Controls.Add(this.lbl_cpu_max_turbo);
            this.Controls.Add(this.lbl_cpu_base_speed);
            this.Controls.Add(this.lbl_cpu_threads);
            this.Controls.Add(this.lbl_cpu_cores);
            this.Controls.Add(this.lbl_cpu_socket);
            this.Controls.Add(this.lbl_cpu_model);
            this.Controls.Add(this.lbl_cpu_brand);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "SSDDrives_CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSDDrives_CRUD";
            this.Load += new System.EventHandler(this.SSDDrives_CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ssd_id;
        private System.Windows.Forms.Label lbl_cpu_graphics;
        private System.Windows.Forms.Label lbl_cpu_max_turbo;
        private System.Windows.Forms.Label lbl_cpu_base_speed;
        private System.Windows.Forms.Label lbl_cpu_threads;
        private System.Windows.Forms.Label lbl_cpu_cores;
        private System.Windows.Forms.Label lbl_cpu_socket;
        private System.Windows.Forms.Label lbl_cpu_model;
        private System.Windows.Forms.Label lbl_cpu_brand;
        private System.Windows.Forms.Label lbl_ssd_status;
        private System.Windows.Forms.ComboBox cbox_ssd_brand;
        private System.Windows.Forms.TextBox txt_ssd_model;
        private System.Windows.Forms.ComboBox cbox_ssd_connectivity;
        private System.Windows.Forms.TextBox txt_ssd_storage;
        private System.Windows.Forms.ComboBox cbox_ssd_nvme;
        private System.Windows.Forms.TextBox txt_ssd_recording_speed;
        private System.Windows.Forms.TextBox txt_ssd_reading_speed;
        private System.Windows.Forms.TextBox txt_ssd_price;
        private System.Windows.Forms.ComboBox cbox_ssd_status;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button Insert_btn;
    }
}