
namespace pcshop
{
    partial class RAM_CRUD
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
            this.lbl_ssd_status = new System.Windows.Forms.Label();
            this.lbl_ram_id = new System.Windows.Forms.Label();
            this.lbl_cpu_graphics = new System.Windows.Forms.Label();
            this.lbl_cpu_max_turbo = new System.Windows.Forms.Label();
            this.lbl_cpu_base_speed = new System.Windows.Forms.Label();
            this.lbl_cpu_threads = new System.Windows.Forms.Label();
            this.lbl_cpu_cores = new System.Windows.Forms.Label();
            this.lbl_cpu_socket = new System.Windows.Forms.Label();
            this.lbl_cpu_model = new System.Windows.Forms.Label();
            this.lbl_cpu_brand = new System.Windows.Forms.Label();
            this.txt_ram_rgb = new System.Windows.Forms.TextBox();
            this.txt_ram_speed = new System.Windows.Forms.TextBox();
            this.txt_ram_count = new System.Windows.Forms.TextBox();
            this.txt_ram_memory_size = new System.Windows.Forms.TextBox();
            this.cbox_ram_type_memory = new System.Windows.Forms.ComboBox();
            this.txt_ram_model = new System.Windows.Forms.TextBox();
            this.cbox_ram_brand = new System.Windows.Forms.ComboBox();
            this.cbox_ram_status = new System.Windows.Forms.ComboBox();
            this.txt_ram_price = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ssd_status
            // 
            this.lbl_ssd_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ssd_status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ssd_status.ForeColor = System.Drawing.Color.Snow;
            this.lbl_ssd_status.Location = new System.Drawing.Point(11, 405);
            this.lbl_ssd_status.Name = "lbl_ssd_status";
            this.lbl_ssd_status.Size = new System.Drawing.Size(140, 23);
            this.lbl_ssd_status.TabIndex = 66;
            this.lbl_ssd_status.Text = "Статус";
            this.lbl_ssd_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ram_id
            // 
            this.lbl_ram_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ram_id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ram_id.ForeColor = System.Drawing.Color.Snow;
            this.lbl_ram_id.Location = new System.Drawing.Point(11, 18);
            this.lbl_ram_id.Name = "lbl_ram_id";
            this.lbl_ram_id.Size = new System.Drawing.Size(140, 23);
            this.lbl_ram_id.TabIndex = 65;
            this.lbl_ram_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_graphics
            // 
            this.lbl_cpu_graphics.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_graphics.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu_graphics.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_graphics.Location = new System.Drawing.Point(11, 368);
            this.lbl_cpu_graphics.Name = "lbl_cpu_graphics";
            this.lbl_cpu_graphics.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_graphics.TabIndex = 64;
            this.lbl_cpu_graphics.Text = "Цена";
            this.lbl_cpu_graphics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_max_turbo
            // 
            this.lbl_cpu_max_turbo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_max_turbo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_max_turbo.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_max_turbo.Location = new System.Drawing.Point(11, 323);
            this.lbl_cpu_max_turbo.Name = "lbl_cpu_max_turbo";
            this.lbl_cpu_max_turbo.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_max_turbo.TabIndex = 63;
            this.lbl_cpu_max_turbo.Text = "RGB подсветка\t";
            this.lbl_cpu_max_turbo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_base_speed
            // 
            this.lbl_cpu_base_speed.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_base_speed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_base_speed.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_base_speed.Location = new System.Drawing.Point(11, 277);
            this.lbl_cpu_base_speed.Name = "lbl_cpu_base_speed";
            this.lbl_cpu_base_speed.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_base_speed.TabIndex = 62;
            this.lbl_cpu_base_speed.Text = "Тактовая частота\t";
            this.lbl_cpu_base_speed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_threads
            // 
            this.lbl_cpu_threads.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_threads.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.lbl_cpu_threads.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_threads.Location = new System.Drawing.Point(11, 227);
            this.lbl_cpu_threads.Name = "lbl_cpu_threads";
            this.lbl_cpu_threads.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_threads.TabIndex = 61;
            this.lbl_cpu_threads.Text = "Количество модулей \t";
            this.lbl_cpu_threads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_cores
            // 
            this.lbl_cpu_cores.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_cores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_cores.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_cores.Location = new System.Drawing.Point(11, 181);
            this.lbl_cpu_cores.Name = "lbl_cpu_cores";
            this.lbl_cpu_cores.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_cores.TabIndex = 60;
            this.lbl_cpu_cores.Text = "Объем накопителя\t";
            this.lbl_cpu_cores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_socket
            // 
            this.lbl_cpu_socket.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_socket.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_socket.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_socket.Location = new System.Drawing.Point(11, 141);
            this.lbl_cpu_socket.Name = "lbl_cpu_socket";
            this.lbl_cpu_socket.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_socket.TabIndex = 59;
            this.lbl_cpu_socket.Text = "Тип памяти\t";
            this.lbl_cpu_socket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_model
            // 
            this.lbl_cpu_model.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_model.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_model.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_model.Location = new System.Drawing.Point(11, 98);
            this.lbl_cpu_model.Name = "lbl_cpu_model";
            this.lbl_cpu_model.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_model.TabIndex = 58;
            this.lbl_cpu_model.Text = "Марка";
            this.lbl_cpu_model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_brand
            // 
            this.lbl_cpu_brand.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_brand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_brand.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_brand.Location = new System.Drawing.Point(11, 53);
            this.lbl_cpu_brand.Name = "lbl_cpu_brand";
            this.lbl_cpu_brand.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_brand.TabIndex = 57;
            this.lbl_cpu_brand.Text = "Производитель";
            this.lbl_cpu_brand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ram_rgb
            // 
            this.txt_ram_rgb.BackColor = System.Drawing.Color.Snow;
            this.txt_ram_rgb.ForeColor = System.Drawing.Color.Black;
            this.txt_ram_rgb.Location = new System.Drawing.Point(157, 326);
            this.txt_ram_rgb.Multiline = true;
            this.txt_ram_rgb.Name = "txt_ram_rgb";
            this.txt_ram_rgb.Size = new System.Drawing.Size(223, 20);
            this.txt_ram_rgb.TabIndex = 73;
            // 
            // txt_ram_speed
            // 
            this.txt_ram_speed.BackColor = System.Drawing.Color.Snow;
            this.txt_ram_speed.ForeColor = System.Drawing.Color.Black;
            this.txt_ram_speed.Location = new System.Drawing.Point(157, 280);
            this.txt_ram_speed.Multiline = true;
            this.txt_ram_speed.Name = "txt_ram_speed";
            this.txt_ram_speed.Size = new System.Drawing.Size(223, 20);
            this.txt_ram_speed.TabIndex = 72;
            // 
            // txt_ram_count
            // 
            this.txt_ram_count.BackColor = System.Drawing.Color.Snow;
            this.txt_ram_count.ForeColor = System.Drawing.Color.Black;
            this.txt_ram_count.Location = new System.Drawing.Point(157, 230);
            this.txt_ram_count.Multiline = true;
            this.txt_ram_count.Name = "txt_ram_count";
            this.txt_ram_count.Size = new System.Drawing.Size(223, 20);
            this.txt_ram_count.TabIndex = 71;
            // 
            // txt_ram_memory_size
            // 
            this.txt_ram_memory_size.BackColor = System.Drawing.Color.Snow;
            this.txt_ram_memory_size.ForeColor = System.Drawing.Color.Black;
            this.txt_ram_memory_size.Location = new System.Drawing.Point(157, 184);
            this.txt_ram_memory_size.Multiline = true;
            this.txt_ram_memory_size.Name = "txt_ram_memory_size";
            this.txt_ram_memory_size.Size = new System.Drawing.Size(223, 20);
            this.txt_ram_memory_size.TabIndex = 70;
            // 
            // cbox_ram_type_memory
            // 
            this.cbox_ram_type_memory.FormattingEnabled = true;
            this.cbox_ram_type_memory.Items.AddRange(new object[] {
            "DDR3",
            "DDR4",
            "DDR5"});
            this.cbox_ram_type_memory.Location = new System.Drawing.Point(157, 144);
            this.cbox_ram_type_memory.Name = "cbox_ram_type_memory";
            this.cbox_ram_type_memory.Size = new System.Drawing.Size(223, 21);
            this.cbox_ram_type_memory.TabIndex = 69;
            // 
            // txt_ram_model
            // 
            this.txt_ram_model.BackColor = System.Drawing.Color.Snow;
            this.txt_ram_model.ForeColor = System.Drawing.Color.Black;
            this.txt_ram_model.Location = new System.Drawing.Point(157, 101);
            this.txt_ram_model.Multiline = true;
            this.txt_ram_model.Name = "txt_ram_model";
            this.txt_ram_model.Size = new System.Drawing.Size(223, 20);
            this.txt_ram_model.TabIndex = 68;
            // 
            // cbox_ram_brand
            // 
            this.cbox_ram_brand.FormattingEnabled = true;
            this.cbox_ram_brand.Items.AddRange(new object[] {
            "Lexar",
            "Corsair",
            "Kingston"});
            this.cbox_ram_brand.Location = new System.Drawing.Point(157, 56);
            this.cbox_ram_brand.Name = "cbox_ram_brand";
            this.cbox_ram_brand.Size = new System.Drawing.Size(223, 21);
            this.cbox_ram_brand.TabIndex = 67;
            // 
            // cbox_ram_status
            // 
            this.cbox_ram_status.FormattingEnabled = true;
            this.cbox_ram_status.Items.AddRange(new object[] {
            "published",
            "draft"});
            this.cbox_ram_status.Location = new System.Drawing.Point(157, 408);
            this.cbox_ram_status.Name = "cbox_ram_status";
            this.cbox_ram_status.Size = new System.Drawing.Size(223, 21);
            this.cbox_ram_status.TabIndex = 75;
            // 
            // txt_ram_price
            // 
            this.txt_ram_price.BackColor = System.Drawing.Color.Snow;
            this.txt_ram_price.ForeColor = System.Drawing.Color.Black;
            this.txt_ram_price.Location = new System.Drawing.Point(157, 368);
            this.txt_ram_price.Multiline = true;
            this.txt_ram_price.Name = "txt_ram_price";
            this.txt_ram_price.Size = new System.Drawing.Size(223, 20);
            this.txt_ram_price.TabIndex = 74;
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
            this.dataGridView1.Location = new System.Drawing.Point(436, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(816, 551);
            this.dataGridView1.TabIndex = 76;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.Clear_btn.TabIndex = 81;
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
            this.delete_btn.TabIndex = 80;
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
            this.update_btn.TabIndex = 79;
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
            this.Insert_btn.TabIndex = 78;
            this.Insert_btn.Text = "Добавить";
            this.Insert_btn.UseVisualStyleBackColor = false;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
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
            this.Back_btn.TabIndex = 77;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // RAM_CRUD
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
            this.Controls.Add(this.cbox_ram_status);
            this.Controls.Add(this.txt_ram_price);
            this.Controls.Add(this.txt_ram_rgb);
            this.Controls.Add(this.txt_ram_speed);
            this.Controls.Add(this.txt_ram_count);
            this.Controls.Add(this.txt_ram_memory_size);
            this.Controls.Add(this.cbox_ram_type_memory);
            this.Controls.Add(this.txt_ram_model);
            this.Controls.Add(this.cbox_ram_brand);
            this.Controls.Add(this.lbl_ssd_status);
            this.Controls.Add(this.lbl_ram_id);
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
            this.Name = "RAM_CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAM_CRUD";
            this.Load += new System.EventHandler(this.RAM_CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ssd_status;
        private System.Windows.Forms.Label lbl_ram_id;
        private System.Windows.Forms.Label lbl_cpu_graphics;
        private System.Windows.Forms.Label lbl_cpu_max_turbo;
        private System.Windows.Forms.Label lbl_cpu_base_speed;
        private System.Windows.Forms.Label lbl_cpu_threads;
        private System.Windows.Forms.Label lbl_cpu_cores;
        private System.Windows.Forms.Label lbl_cpu_socket;
        private System.Windows.Forms.Label lbl_cpu_model;
        private System.Windows.Forms.Label lbl_cpu_brand;
        private System.Windows.Forms.TextBox txt_ram_rgb;
        private System.Windows.Forms.TextBox txt_ram_speed;
        private System.Windows.Forms.TextBox txt_ram_count;
        private System.Windows.Forms.TextBox txt_ram_memory_size;
        private System.Windows.Forms.ComboBox cbox_ram_type_memory;
        private System.Windows.Forms.TextBox txt_ram_model;
        private System.Windows.Forms.ComboBox cbox_ram_brand;
        private System.Windows.Forms.ComboBox cbox_ram_status;
        private System.Windows.Forms.TextBox txt_ram_price;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Button Back_btn;
    }
}