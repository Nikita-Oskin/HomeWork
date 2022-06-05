
namespace pcshop
{
    partial class CPU
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
            this.Insert_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.lbl_cpu_brand = new System.Windows.Forms.Label();
            this.lbl_cpu_model = new System.Windows.Forms.Label();
            this.txt_cpu_model = new System.Windows.Forms.TextBox();
            this.lbl_cpu_cores = new System.Windows.Forms.Label();
            this.txt_cpu_cores = new System.Windows.Forms.TextBox();
            this.lbl_cpu_socket = new System.Windows.Forms.Label();
            this.txt_cpu_socket = new System.Windows.Forms.TextBox();
            this.lbl_cpu_graphics = new System.Windows.Forms.Label();
            this.txt_cpu_graphics = new System.Windows.Forms.TextBox();
            this.lbl_cpu_max_turbo = new System.Windows.Forms.Label();
            this.txt_cpu_max_turbo = new System.Windows.Forms.TextBox();
            this.lbl_cpu_base_speed = new System.Windows.Forms.Label();
            this.txt_cpu_base_speed = new System.Windows.Forms.TextBox();
            this.lbl_cpu_threads = new System.Windows.Forms.Label();
            this.txt_cpu_threads = new System.Windows.Forms.TextBox();
            this.lbl_cpu_equipment = new System.Windows.Forms.Label();
            this.lbl_cpu_tdp = new System.Windows.Forms.Label();
            this.txt_cpu_tdp = new System.Windows.Forms.TextBox();
            this.lbl_cpu_cache = new System.Windows.Forms.Label();
            this.txt_cpu_cache = new System.Windows.Forms.TextBox();
            this.lbl_cpu_status = new System.Windows.Forms.Label();
            this.lbl_cpu_price = new System.Windows.Forms.Label();
            this.txt_cpu_price = new System.Windows.Forms.TextBox();
            this.cbox_cpu_brand = new System.Windows.Forms.ComboBox();
            this.cbox_cpu_equipment = new System.Windows.Forms.ComboBox();
            this.cbox_cpu_status = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_cpu_id = new System.Windows.Forms.Label();
            this.Clear_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.Insert_btn.TabIndex = 10;
            this.Insert_btn.Text = "Добавить";
            this.Insert_btn.UseVisualStyleBackColor = false;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
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
            this.update_btn.TabIndex = 11;
            this.update_btn.Text = "Изменить";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
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
            this.Back_btn.TabIndex = 14;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
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
            this.delete_btn.TabIndex = 15;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // lbl_cpu_brand
            // 
            this.lbl_cpu_brand.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_brand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_brand.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_brand.Location = new System.Drawing.Point(15, 51);
            this.lbl_cpu_brand.Name = "lbl_cpu_brand";
            this.lbl_cpu_brand.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_brand.TabIndex = 17;
            this.lbl_cpu_brand.Text = "Производитель";
            this.lbl_cpu_brand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_model
            // 
            this.lbl_cpu_model.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_model.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_model.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_model.Location = new System.Drawing.Point(15, 96);
            this.lbl_cpu_model.Name = "lbl_cpu_model";
            this.lbl_cpu_model.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_model.TabIndex = 19;
            this.lbl_cpu_model.Text = "Марка";
            this.lbl_cpu_model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cpu_model
            // 
            this.txt_cpu_model.BackColor = System.Drawing.Color.Snow;
            this.txt_cpu_model.ForeColor = System.Drawing.Color.Black;
            this.txt_cpu_model.Location = new System.Drawing.Point(180, 96);
            this.txt_cpu_model.Multiline = true;
            this.txt_cpu_model.Name = "txt_cpu_model";
            this.txt_cpu_model.Size = new System.Drawing.Size(223, 20);
            this.txt_cpu_model.TabIndex = 18;
            // 
            // lbl_cpu_cores
            // 
            this.lbl_cpu_cores.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_cores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_cores.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_cores.Location = new System.Drawing.Point(15, 179);
            this.lbl_cpu_cores.Name = "lbl_cpu_cores";
            this.lbl_cpu_cores.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_cores.TabIndex = 23;
            this.lbl_cpu_cores.Text = "Кол-во ядер\t";
            this.lbl_cpu_cores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cpu_cores
            // 
            this.txt_cpu_cores.BackColor = System.Drawing.Color.Snow;
            this.txt_cpu_cores.ForeColor = System.Drawing.Color.Black;
            this.txt_cpu_cores.Location = new System.Drawing.Point(180, 179);
            this.txt_cpu_cores.Multiline = true;
            this.txt_cpu_cores.Name = "txt_cpu_cores";
            this.txt_cpu_cores.Size = new System.Drawing.Size(223, 20);
            this.txt_cpu_cores.TabIndex = 22;
            // 
            // lbl_cpu_socket
            // 
            this.lbl_cpu_socket.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_socket.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_socket.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_socket.Location = new System.Drawing.Point(15, 139);
            this.lbl_cpu_socket.Name = "lbl_cpu_socket";
            this.lbl_cpu_socket.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_socket.TabIndex = 21;
            this.lbl_cpu_socket.Text = "Сокет";
            this.lbl_cpu_socket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cpu_socket
            // 
            this.txt_cpu_socket.BackColor = System.Drawing.Color.Snow;
            this.txt_cpu_socket.ForeColor = System.Drawing.Color.Black;
            this.txt_cpu_socket.Location = new System.Drawing.Point(180, 139);
            this.txt_cpu_socket.Multiline = true;
            this.txt_cpu_socket.Name = "txt_cpu_socket";
            this.txt_cpu_socket.Size = new System.Drawing.Size(223, 20);
            this.txt_cpu_socket.TabIndex = 20;
            // 
            // lbl_cpu_graphics
            // 
            this.lbl_cpu_graphics.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_graphics.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu_graphics.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_graphics.Location = new System.Drawing.Point(15, 366);
            this.lbl_cpu_graphics.Name = "lbl_cpu_graphics";
            this.lbl_cpu_graphics.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_graphics.TabIndex = 31;
            this.lbl_cpu_graphics.Text = "Видеоядро";
            this.lbl_cpu_graphics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cpu_graphics
            // 
            this.txt_cpu_graphics.BackColor = System.Drawing.Color.Snow;
            this.txt_cpu_graphics.ForeColor = System.Drawing.Color.Black;
            this.txt_cpu_graphics.Location = new System.Drawing.Point(180, 366);
            this.txt_cpu_graphics.Multiline = true;
            this.txt_cpu_graphics.Name = "txt_cpu_graphics";
            this.txt_cpu_graphics.Size = new System.Drawing.Size(223, 20);
            this.txt_cpu_graphics.TabIndex = 30;
            // 
            // lbl_cpu_max_turbo
            // 
            this.lbl_cpu_max_turbo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_max_turbo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_max_turbo.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_max_turbo.Location = new System.Drawing.Point(15, 321);
            this.lbl_cpu_max_turbo.Name = "lbl_cpu_max_turbo";
            this.lbl_cpu_max_turbo.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_max_turbo.TabIndex = 29;
            this.lbl_cpu_max_turbo.Text = "Частота в бусте\t";
            this.lbl_cpu_max_turbo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cpu_max_turbo
            // 
            this.txt_cpu_max_turbo.BackColor = System.Drawing.Color.Snow;
            this.txt_cpu_max_turbo.ForeColor = System.Drawing.Color.Black;
            this.txt_cpu_max_turbo.Location = new System.Drawing.Point(180, 321);
            this.txt_cpu_max_turbo.Multiline = true;
            this.txt_cpu_max_turbo.Name = "txt_cpu_max_turbo";
            this.txt_cpu_max_turbo.Size = new System.Drawing.Size(223, 20);
            this.txt_cpu_max_turbo.TabIndex = 28;
            // 
            // lbl_cpu_base_speed
            // 
            this.lbl_cpu_base_speed.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_base_speed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_base_speed.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_base_speed.Location = new System.Drawing.Point(15, 275);
            this.lbl_cpu_base_speed.Name = "lbl_cpu_base_speed";
            this.lbl_cpu_base_speed.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_base_speed.TabIndex = 27;
            this.lbl_cpu_base_speed.Text = "Частота в стоке";
            this.lbl_cpu_base_speed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cpu_base_speed
            // 
            this.txt_cpu_base_speed.BackColor = System.Drawing.Color.Snow;
            this.txt_cpu_base_speed.ForeColor = System.Drawing.Color.Black;
            this.txt_cpu_base_speed.Location = new System.Drawing.Point(180, 275);
            this.txt_cpu_base_speed.Multiline = true;
            this.txt_cpu_base_speed.Name = "txt_cpu_base_speed";
            this.txt_cpu_base_speed.Size = new System.Drawing.Size(223, 20);
            this.txt_cpu_base_speed.TabIndex = 26;
            // 
            // lbl_cpu_threads
            // 
            this.lbl_cpu_threads.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_threads.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_threads.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_threads.Location = new System.Drawing.Point(15, 225);
            this.lbl_cpu_threads.Name = "lbl_cpu_threads";
            this.lbl_cpu_threads.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_threads.TabIndex = 25;
            this.lbl_cpu_threads.Text = "Кол-во потоков";
            this.lbl_cpu_threads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cpu_threads
            // 
            this.txt_cpu_threads.BackColor = System.Drawing.Color.Snow;
            this.txt_cpu_threads.ForeColor = System.Drawing.Color.Black;
            this.txt_cpu_threads.Location = new System.Drawing.Point(180, 225);
            this.txt_cpu_threads.Multiline = true;
            this.txt_cpu_threads.Name = "txt_cpu_threads";
            this.txt_cpu_threads.Size = new System.Drawing.Size(223, 20);
            this.txt_cpu_threads.TabIndex = 24;
            // 
            // lbl_cpu_equipment
            // 
            this.lbl_cpu_equipment.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_equipment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu_equipment.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_equipment.Location = new System.Drawing.Point(15, 503);
            this.lbl_cpu_equipment.Name = "lbl_cpu_equipment";
            this.lbl_cpu_equipment.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_equipment.TabIndex = 37;
            this.lbl_cpu_equipment.Text = "Комплектация";
            this.lbl_cpu_equipment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_tdp
            // 
            this.lbl_cpu_tdp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_tdp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu_tdp.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_tdp.Location = new System.Drawing.Point(15, 458);
            this.lbl_cpu_tdp.Name = "lbl_cpu_tdp";
            this.lbl_cpu_tdp.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_tdp.TabIndex = 35;
            this.lbl_cpu_tdp.Text = "Тепловыделение";
            this.lbl_cpu_tdp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cpu_tdp
            // 
            this.txt_cpu_tdp.BackColor = System.Drawing.Color.Snow;
            this.txt_cpu_tdp.ForeColor = System.Drawing.Color.Black;
            this.txt_cpu_tdp.Location = new System.Drawing.Point(180, 458);
            this.txt_cpu_tdp.Multiline = true;
            this.txt_cpu_tdp.Name = "txt_cpu_tdp";
            this.txt_cpu_tdp.Size = new System.Drawing.Size(223, 20);
            this.txt_cpu_tdp.TabIndex = 34;
            // 
            // lbl_cpu_cache
            // 
            this.lbl_cpu_cache.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_cache.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu_cache.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_cache.Location = new System.Drawing.Point(15, 411);
            this.lbl_cpu_cache.Name = "lbl_cpu_cache";
            this.lbl_cpu_cache.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_cache.TabIndex = 33;
            this.lbl_cpu_cache.Text = "Кэш";
            this.lbl_cpu_cache.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cpu_cache
            // 
            this.txt_cpu_cache.BackColor = System.Drawing.Color.Snow;
            this.txt_cpu_cache.ForeColor = System.Drawing.Color.Black;
            this.txt_cpu_cache.Location = new System.Drawing.Point(180, 411);
            this.txt_cpu_cache.Multiline = true;
            this.txt_cpu_cache.Name = "txt_cpu_cache";
            this.txt_cpu_cache.Size = new System.Drawing.Size(223, 20);
            this.txt_cpu_cache.TabIndex = 32;
            // 
            // lbl_cpu_status
            // 
            this.lbl_cpu_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu_status.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_status.Location = new System.Drawing.Point(15, 588);
            this.lbl_cpu_status.Name = "lbl_cpu_status";
            this.lbl_cpu_status.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_status.TabIndex = 41;
            this.lbl_cpu_status.Text = "Статус";
            this.lbl_cpu_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cpu_price
            // 
            this.lbl_cpu_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu_price.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_price.Location = new System.Drawing.Point(15, 545);
            this.lbl_cpu_price.Name = "lbl_cpu_price";
            this.lbl_cpu_price.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_price.TabIndex = 39;
            this.lbl_cpu_price.Text = "Цена";
            this.lbl_cpu_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cpu_price
            // 
            this.txt_cpu_price.BackColor = System.Drawing.Color.Snow;
            this.txt_cpu_price.ForeColor = System.Drawing.Color.Black;
            this.txt_cpu_price.Location = new System.Drawing.Point(180, 545);
            this.txt_cpu_price.Multiline = true;
            this.txt_cpu_price.Name = "txt_cpu_price";
            this.txt_cpu_price.Size = new System.Drawing.Size(223, 20);
            this.txt_cpu_price.TabIndex = 38;
            // 
            // cbox_cpu_brand
            // 
            this.cbox_cpu_brand.FormattingEnabled = true;
            this.cbox_cpu_brand.Items.AddRange(new object[] {
            "INTEL",
            "AMD"});
            this.cbox_cpu_brand.Location = new System.Drawing.Point(180, 51);
            this.cbox_cpu_brand.Name = "cbox_cpu_brand";
            this.cbox_cpu_brand.Size = new System.Drawing.Size(223, 21);
            this.cbox_cpu_brand.TabIndex = 42;
            // 
            // cbox_cpu_equipment
            // 
            this.cbox_cpu_equipment.FormattingEnabled = true;
            this.cbox_cpu_equipment.Items.AddRange(new object[] {
            "tray",
            "box",
            "OEM"});
            this.cbox_cpu_equipment.Location = new System.Drawing.Point(180, 503);
            this.cbox_cpu_equipment.Name = "cbox_cpu_equipment";
            this.cbox_cpu_equipment.Size = new System.Drawing.Size(223, 21);
            this.cbox_cpu_equipment.TabIndex = 43;
            // 
            // cbox_cpu_status
            // 
            this.cbox_cpu_status.FormattingEnabled = true;
            this.cbox_cpu_status.Items.AddRange(new object[] {
            "published",
            "draft"});
            this.cbox_cpu_status.Location = new System.Drawing.Point(180, 591);
            this.cbox_cpu_status.Name = "cbox_cpu_status";
            this.cbox_cpu_status.Size = new System.Drawing.Size(223, 21);
            this.cbox_cpu_status.TabIndex = 44;
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
            this.dataGridView1.Location = new System.Drawing.Point(436, 51);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(816, 560);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_cpu_id
            // 
            this.lbl_cpu_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cpu_id.ForeColor = System.Drawing.Color.Snow;
            this.lbl_cpu_id.Location = new System.Drawing.Point(15, 19);
            this.lbl_cpu_id.Name = "lbl_cpu_id";
            this.lbl_cpu_id.Size = new System.Drawing.Size(140, 23);
            this.lbl_cpu_id.TabIndex = 45;
            this.lbl_cpu_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Clear_btn.TabIndex = 46;
            this.Clear_btn.Text = "Очистить";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // CPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.lbl_cpu_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbox_cpu_status);
            this.Controls.Add(this.cbox_cpu_equipment);
            this.Controls.Add(this.cbox_cpu_brand);
            this.Controls.Add(this.lbl_cpu_status);
            this.Controls.Add(this.lbl_cpu_price);
            this.Controls.Add(this.txt_cpu_price);
            this.Controls.Add(this.lbl_cpu_equipment);
            this.Controls.Add(this.lbl_cpu_tdp);
            this.Controls.Add(this.txt_cpu_tdp);
            this.Controls.Add(this.lbl_cpu_cache);
            this.Controls.Add(this.txt_cpu_cache);
            this.Controls.Add(this.lbl_cpu_graphics);
            this.Controls.Add(this.txt_cpu_graphics);
            this.Controls.Add(this.lbl_cpu_max_turbo);
            this.Controls.Add(this.txt_cpu_max_turbo);
            this.Controls.Add(this.lbl_cpu_base_speed);
            this.Controls.Add(this.txt_cpu_base_speed);
            this.Controls.Add(this.lbl_cpu_threads);
            this.Controls.Add(this.txt_cpu_threads);
            this.Controls.Add(this.lbl_cpu_cores);
            this.Controls.Add(this.txt_cpu_cores);
            this.Controls.Add(this.lbl_cpu_socket);
            this.Controls.Add(this.txt_cpu_socket);
            this.Controls.Add(this.lbl_cpu_model);
            this.Controls.Add(this.txt_cpu_model);
            this.Controls.Add(this.lbl_cpu_brand);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.Insert_btn);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "CPU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU";
            this.Load += new System.EventHandler(this.CPU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label lbl_cpu_brand;
        private System.Windows.Forms.Label lbl_cpu_model;
        private System.Windows.Forms.TextBox txt_cpu_model;
        private System.Windows.Forms.Label lbl_cpu_cores;
        private System.Windows.Forms.TextBox txt_cpu_cores;
        private System.Windows.Forms.Label lbl_cpu_socket;
        private System.Windows.Forms.TextBox txt_cpu_socket;
        private System.Windows.Forms.Label lbl_cpu_graphics;
        private System.Windows.Forms.TextBox txt_cpu_graphics;
        private System.Windows.Forms.Label lbl_cpu_max_turbo;
        private System.Windows.Forms.TextBox txt_cpu_max_turbo;
        private System.Windows.Forms.Label lbl_cpu_base_speed;
        private System.Windows.Forms.TextBox txt_cpu_base_speed;
        private System.Windows.Forms.Label lbl_cpu_threads;
        private System.Windows.Forms.TextBox txt_cpu_threads;
        private System.Windows.Forms.Label lbl_cpu_equipment;
        private System.Windows.Forms.Label lbl_cpu_tdp;
        private System.Windows.Forms.TextBox txt_cpu_tdp;
        private System.Windows.Forms.Label lbl_cpu_cache;
        private System.Windows.Forms.TextBox txt_cpu_cache;
        private System.Windows.Forms.Label lbl_cpu_status;
        private System.Windows.Forms.Label lbl_cpu_price;
        private System.Windows.Forms.TextBox txt_cpu_price;
        private System.Windows.Forms.ComboBox cbox_cpu_brand;
        private System.Windows.Forms.ComboBox cbox_cpu_equipment;
        private System.Windows.Forms.ComboBox cbox_cpu_status;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_cpu_id;
        private System.Windows.Forms.Button Clear_btn;
    }
}
