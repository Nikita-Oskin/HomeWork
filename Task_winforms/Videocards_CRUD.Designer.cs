
namespace pcshop
{
    partial class Videocards_CRUD
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

        private void InitializeComponent()
        {
            this.lbl_cpu_graphics = new System.Windows.Forms.Label();
            this.lbl_cpu_max_turbo = new System.Windows.Forms.Label();
            this.lbl_cpu_base_speed = new System.Windows.Forms.Label();
            this.lbl_cpu_threads = new System.Windows.Forms.Label();
            this.lbl_cpu_cores = new System.Windows.Forms.Label();
            this.lbl_cpu_socket = new System.Windows.Forms.Label();
            this.lbl_cpu_model = new System.Windows.Forms.Label();
            this.lbl_cpu_brand = new System.Windows.Forms.Label();
            this.lbl_v_id = new System.Windows.Forms.Label();
            this.cbox_v_brand = new System.Windows.Forms.ComboBox();
            this.txt_v_model = new System.Windows.Forms.TextBox();
            this.txt_v_memory_size = new System.Windows.Forms.TextBox();
            this.txt_v_type_memory = new System.Windows.Forms.TextBox();
            this.txt_v_speed = new System.Windows.Forms.TextBox();
            this.txt_v_connectors = new System.Windows.Forms.TextBox();
            this.txt_v_price = new System.Windows.Forms.TextBox();
            this.cbox_v_status = new System.Windows.Forms.ComboBox();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cpu_graphics
            // 
            this.lbl_cpu_graphics.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_graphics.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu_graphics.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_graphics.Location = new System.Drawing.Point(12, 359);
            this.lbl_cpu_graphics.Name = "lbl_cpu_graphics";
            this.lbl_cpu_graphics.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_graphics.TabIndex = 39;
            this.lbl_cpu_graphics.Text = "Статус";
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
            this.lbl_cpu_max_turbo.TabIndex = 38;
            this.lbl_cpu_max_turbo.Text = "Цена";
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
            this.lbl_cpu_base_speed.TabIndex = 37;
            this.lbl_cpu_base_speed.Text = "Видео разъемы";
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
            this.lbl_cpu_threads.TabIndex = 36;
            this.lbl_cpu_threads.Text = "Частота памяти";
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
            this.lbl_cpu_cores.TabIndex = 35;
            this.lbl_cpu_cores.Text = "Тип памяти";
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
            this.lbl_cpu_socket.TabIndex = 34;
            this.lbl_cpu_socket.Text = "Объем памяти";
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
            this.lbl_cpu_model.TabIndex = 33;
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
            this.lbl_cpu_brand.TabIndex = 32;
            this.lbl_cpu_brand.Text = "Производитель";
            this.lbl_cpu_brand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_v_id
            // 
            this.lbl_v_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_v_id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_v_id.ForeColor = System.Drawing.Color.Snow;
            this.lbl_v_id.Location = new System.Drawing.Point(12, 9);
            this.lbl_v_id.Name = "lbl_v_id";
            this.lbl_v_id.Size = new System.Drawing.Size(140, 23);
            this.lbl_v_id.TabIndex = 46;
            this.lbl_v_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbox_v_brand
            // 
            this.cbox_v_brand.FormattingEnabled = true;
            this.cbox_v_brand.Items.AddRange(new object[] {
            "Palit",
            "MSI",
            "Gigabyte"});
            this.cbox_v_brand.Location = new System.Drawing.Point(158, 47);
            this.cbox_v_brand.Name = "cbox_v_brand";
            this.cbox_v_brand.Size = new System.Drawing.Size(223, 21);
            this.cbox_v_brand.TabIndex = 47;
            // 
            // txt_v_model
            // 
            this.txt_v_model.BackColor = System.Drawing.Color.Snow;
            this.txt_v_model.ForeColor = System.Drawing.Color.Black;
            this.txt_v_model.Location = new System.Drawing.Point(158, 92);
            this.txt_v_model.Multiline = true;
            this.txt_v_model.Name = "txt_v_model";
            this.txt_v_model.Size = new System.Drawing.Size(223, 20);
            this.txt_v_model.TabIndex = 48;
            // 
            // txt_v_memory_size
            // 
            this.txt_v_memory_size.BackColor = System.Drawing.Color.Snow;
            this.txt_v_memory_size.ForeColor = System.Drawing.Color.Black;
            this.txt_v_memory_size.Location = new System.Drawing.Point(158, 135);
            this.txt_v_memory_size.Multiline = true;
            this.txt_v_memory_size.Name = "txt_v_memory_size";
            this.txt_v_memory_size.Size = new System.Drawing.Size(223, 20);
            this.txt_v_memory_size.TabIndex = 49;
            // 
            // txt_v_type_memory
            // 
            this.txt_v_type_memory.BackColor = System.Drawing.Color.Snow;
            this.txt_v_type_memory.ForeColor = System.Drawing.Color.Black;
            this.txt_v_type_memory.Location = new System.Drawing.Point(158, 175);
            this.txt_v_type_memory.Multiline = true;
            this.txt_v_type_memory.Name = "txt_v_type_memory";
            this.txt_v_type_memory.Size = new System.Drawing.Size(223, 20);
            this.txt_v_type_memory.TabIndex = 50;
            // 
            // txt_v_speed
            // 
            this.txt_v_speed.BackColor = System.Drawing.Color.Snow;
            this.txt_v_speed.ForeColor = System.Drawing.Color.Black;
            this.txt_v_speed.Location = new System.Drawing.Point(158, 221);
            this.txt_v_speed.Multiline = true;
            this.txt_v_speed.Name = "txt_v_speed";
            this.txt_v_speed.Size = new System.Drawing.Size(223, 20);
            this.txt_v_speed.TabIndex = 51;
            // 
            // txt_v_connectors
            // 
            this.txt_v_connectors.BackColor = System.Drawing.Color.Snow;
            this.txt_v_connectors.ForeColor = System.Drawing.Color.Black;
            this.txt_v_connectors.Location = new System.Drawing.Point(158, 271);
            this.txt_v_connectors.Multiline = true;
            this.txt_v_connectors.Name = "txt_v_connectors";
            this.txt_v_connectors.Size = new System.Drawing.Size(223, 20);
            this.txt_v_connectors.TabIndex = 52;
            // 
            // txt_v_price
            // 
            this.txt_v_price.BackColor = System.Drawing.Color.Snow;
            this.txt_v_price.ForeColor = System.Drawing.Color.Black;
            this.txt_v_price.Location = new System.Drawing.Point(158, 317);
            this.txt_v_price.Multiline = true;
            this.txt_v_price.Name = "txt_v_price";
            this.txt_v_price.Size = new System.Drawing.Size(223, 20);
            this.txt_v_price.TabIndex = 53;
            // 
            // cbox_v_status
            // 
            this.cbox_v_status.FormattingEnabled = true;
            this.cbox_v_status.Items.AddRange(new object[] {
            "published",
            "draft"});
            this.cbox_v_status.Location = new System.Drawing.Point(158, 362);
            this.cbox_v_status.Name = "cbox_v_status";
            this.cbox_v_status.Size = new System.Drawing.Size(223, 21);
            this.cbox_v_status.TabIndex = 54;
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
            this.Clear_btn.TabIndex = 58;
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
            this.delete_btn.TabIndex = 57;
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
            this.update_btn.TabIndex = 56;
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
            this.Insert_btn.TabIndex = 55;
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
            this.dataGridView1.Location = new System.Drawing.Point(436, 44);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(816, 560);
            this.dataGridView1.TabIndex = 59;
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
            this.Back_btn.TabIndex = 60;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Videocards_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.cbox_v_status);
            this.Controls.Add(this.txt_v_price);
            this.Controls.Add(this.txt_v_connectors);
            this.Controls.Add(this.txt_v_speed);
            this.Controls.Add(this.txt_v_type_memory);
            this.Controls.Add(this.txt_v_memory_size);
            this.Controls.Add(this.txt_v_model);
            this.Controls.Add(this.cbox_v_brand);
            this.Controls.Add(this.lbl_v_id);
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
            this.Name = "Videocards_CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Videocards_CRUD";
            this.Load += new System.EventHandler(this.Videocards_CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cpu_graphics;
        private System.Windows.Forms.Label lbl_cpu_max_turbo;
        private System.Windows.Forms.Label lbl_cpu_base_speed;
        private System.Windows.Forms.Label lbl_cpu_threads;
        private System.Windows.Forms.Label lbl_cpu_cores;
        private System.Windows.Forms.Label lbl_cpu_socket;
        private System.Windows.Forms.Label lbl_cpu_model;
        private System.Windows.Forms.Label lbl_cpu_brand;
        private System.Windows.Forms.Label lbl_v_id;
        private System.Windows.Forms.ComboBox cbox_v_brand;
        private System.Windows.Forms.TextBox txt_v_model;
        private System.Windows.Forms.TextBox txt_v_memory_size;
        private System.Windows.Forms.TextBox txt_v_type_memory;
        private System.Windows.Forms.TextBox txt_v_speed;
        private System.Windows.Forms.TextBox txt_v_connectors;
        private System.Windows.Forms.TextBox txt_v_price;
        private System.Windows.Forms.ComboBox cbox_v_status;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back_btn;
    }
}
