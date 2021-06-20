namespace СВГК
{
    partial class Glavnoe_menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavnoe_menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сметыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сравнениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.проектыToolStripMenuItem,
            this.сметыToolStripMenuItem,
            this.выполнениеToolStripMenuItem,
            this.сравнениеToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // проектыToolStripMenuItem
            // 
            this.проектыToolStripMenuItem.Name = "проектыToolStripMenuItem";
            this.проектыToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.проектыToolStripMenuItem.Text = "Проекты";
            this.проектыToolStripMenuItem.Click += new System.EventHandler(this.проектыToolStripMenuItem_Click);
            // 
            // сметыToolStripMenuItem
            // 
            this.сметыToolStripMenuItem.Name = "сметыToolStripMenuItem";
            this.сметыToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.сметыToolStripMenuItem.Text = "Сметы";
            this.сметыToolStripMenuItem.Click += new System.EventHandler(this.сметыToolStripMenuItem_Click);
            // 
            // выполнениеToolStripMenuItem
            // 
            this.выполнениеToolStripMenuItem.Name = "выполнениеToolStripMenuItem";
            this.выполнениеToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.выполнениеToolStripMenuItem.Text = "Выполнение";
            this.выполнениеToolStripMenuItem.Click += new System.EventHandler(this.выполнениеToolStripMenuItem_Click);
            // 
            // сравнениеToolStripMenuItem
            // 
            this.сравнениеToolStripMenuItem.Name = "сравнениеToolStripMenuItem";
            this.сравнениеToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.сравнениеToolStripMenuItem.Text = "Сравнение";
            this.сравнениеToolStripMenuItem.Click += new System.EventHandler(this.сравнениеToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "СРЕДНЕВОЛЖСКАЯ ГАЗОВАЯ КОМПАНИЯ";
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio.Location = new System.Drawing.Point(386, 38);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(42, 23);
            this.fio.TabIndex = 3;
            this.fio.Text = "FIO";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::СВГК.Properties.Resources.n_U9fnNHzgA;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(80, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 260);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Glavnoe_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(528, 384);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavnoe_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сметыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сравнениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label fio;
        private System.Windows.Forms.Timer timer1;
    }
}