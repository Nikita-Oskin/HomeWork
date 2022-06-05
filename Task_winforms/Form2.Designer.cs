
namespace pcshop
{
    partial class Form2
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
            this.ssd_db = new System.Windows.Forms.Button();
            this.ram_db = new System.Windows.Forms.Button();
            this.videocard_db = new System.Windows.Forms.Button();
            this.motherboard_db = new System.Windows.Forms.Button();
            this.cpu_db = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ssd_db
            // 
            this.ssd_db.BackColor = System.Drawing.Color.Black;
            this.ssd_db.Font = new System.Drawing.Font("Minion Pro Cond", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssd_db.ForeColor = System.Drawing.Color.White;
            this.ssd_db.Location = new System.Drawing.Point(291, 439);
            this.ssd_db.Name = "ssd_db";
            this.ssd_db.Size = new System.Drawing.Size(177, 50);
            this.ssd_db.TabIndex = 5;
            this.ssd_db.Text = "SSD НАКОПИТЕЛИ";
            this.ssd_db.UseVisualStyleBackColor = false;
            this.ssd_db.Click += new System.EventHandler(this.ssd_db_Click);
            // 
            // ram_db
            // 
            this.ram_db.BackColor = System.Drawing.Color.Black;
            this.ram_db.Font = new System.Drawing.Font("Minion Pro Cond", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_db.ForeColor = System.Drawing.Color.White;
            this.ram_db.Location = new System.Drawing.Point(795, 307);
            this.ram_db.Name = "ram_db";
            this.ram_db.Size = new System.Drawing.Size(177, 50);
            this.ram_db.TabIndex = 4;
            this.ram_db.Text = "ОПЕРАТИВНАЯ ПАМЯТЬ";
            this.ram_db.UseVisualStyleBackColor = false;
            this.ram_db.Click += new System.EventHandler(this.ram_db_Click);
            // 
            // videocard_db
            // 
            this.videocard_db.BackColor = System.Drawing.Color.Black;
            this.videocard_db.Font = new System.Drawing.Font("Minion Pro Cond", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videocard_db.ForeColor = System.Drawing.Color.White;
            this.videocard_db.Location = new System.Drawing.Point(291, 307);
            this.videocard_db.Name = "videocard_db";
            this.videocard_db.Size = new System.Drawing.Size(177, 50);
            this.videocard_db.TabIndex = 3;
            this.videocard_db.Text = "ВИДЕОКАРТЫ";
            this.videocard_db.UseVisualStyleBackColor = false;
            this.videocard_db.Click += new System.EventHandler(this.videocard_db_Click);
            // 
            // motherboard_db
            // 
            this.motherboard_db.BackColor = System.Drawing.Color.Black;
            this.motherboard_db.Font = new System.Drawing.Font("Minion Pro Cond", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherboard_db.ForeColor = System.Drawing.Color.White;
            this.motherboard_db.Location = new System.Drawing.Point(795, 183);
            this.motherboard_db.Name = "motherboard_db";
            this.motherboard_db.Size = new System.Drawing.Size(177, 50);
            this.motherboard_db.TabIndex = 2;
            this.motherboard_db.Text = "МАТ. ПЛАТЫ";
            this.motherboard_db.UseVisualStyleBackColor = false;
            this.motherboard_db.Click += new System.EventHandler(this.motherboard_db_Click);
            // 
            // cpu_db
            // 
            this.cpu_db.BackColor = System.Drawing.Color.Black;
            this.cpu_db.Font = new System.Drawing.Font("Minion Pro Cond", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_db.ForeColor = System.Drawing.Color.White;
            this.cpu_db.Location = new System.Drawing.Point(291, 183);
            this.cpu_db.Name = "cpu_db";
            this.cpu_db.Size = new System.Drawing.Size(177, 50);
            this.cpu_db.TabIndex = 1;
            this.cpu_db.Text = "ПРОЦЕССОРЫ";
            this.cpu_db.UseVisualStyleBackColor = false;
            this.cpu_db.Click += new System.EventHandler(this.cpu_db_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ssd_db);
            this.Controls.Add(this.cpu_db);
            this.Controls.Add(this.ram_db);
            this.Controls.Add(this.motherboard_db);
            this.Controls.Add(this.videocard_db);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ssd_db;
        private System.Windows.Forms.Button ram_db;
        private System.Windows.Forms.Button videocard_db;
        private System.Windows.Forms.Button motherboard_db;
        private System.Windows.Forms.Button cpu_db;
    }
}
