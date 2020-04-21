namespace ProjectCinema
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.BuyTicket = new System.Windows.Forms.Button();
            this.infoScreening = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.currentCinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativeToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.infoWatched = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyTicket
            // 
            this.BuyTicket.BackColor = System.Drawing.Color.Maroon;
            this.BuyTicket.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyTicket.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BuyTicket.Location = new System.Drawing.Point(244, 49);
            this.BuyTicket.Name = "BuyTicket";
            this.BuyTicket.Size = new System.Drawing.Size(142, 68);
            this.BuyTicket.TabIndex = 0;
            this.BuyTicket.Text = "Buy Ticket";
            this.BuyTicket.UseVisualStyleBackColor = false;
            this.BuyTicket.Click += new System.EventHandler(this.BuyTicket_Click);
            // 
            // infoScreening
            // 
            this.infoScreening.Location = new System.Drawing.Point(6, 30);
            this.infoScreening.Name = "infoScreening";
            this.infoScreening.Size = new System.Drawing.Size(176, 23);
            this.infoScreening.TabIndex = 1;
            this.infoScreening.Text = "Screening Info";
            this.infoScreening.UseVisualStyleBackColor = true;
            this.infoScreening.Click += new System.EventHandler(this.infoScreening_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentCinemaToolStripMenuItem,
            this.administrativeToolsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // currentCinemaToolStripMenuItem
            // 
            this.currentCinemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectCinemaToolStripMenuItem});
            this.currentCinemaToolStripMenuItem.Name = "currentCinemaToolStripMenuItem";
            this.currentCinemaToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.currentCinemaToolStripMenuItem.Text = "Current Cinema: None";
            // 
            // selectCinemaToolStripMenuItem
            // 
            this.selectCinemaToolStripMenuItem.Name = "selectCinemaToolStripMenuItem";
            this.selectCinemaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.selectCinemaToolStripMenuItem.Text = "Select Cinema";
            this.selectCinemaToolStripMenuItem.Click += new System.EventHandler(this.selectCinemaToolStripMenuItem_Click);
            // 
            // administrativeToolsToolStripMenuItem
            // 
            this.administrativeToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffManagerToolStripMenuItem});
            this.administrativeToolsToolStripMenuItem.Name = "administrativeToolsToolStripMenuItem";
            this.administrativeToolsToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.administrativeToolsToolStripMenuItem.Text = "Administrative Tools";
            // 
            // staffManagerToolStripMenuItem
            // 
            this.staffManagerToolStripMenuItem.Name = "staffManagerToolStripMenuItem";
            this.staffManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.staffManagerToolStripMenuItem.Text = "Staff Manager";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.infoWatched);
            this.groupBox1.Controls.Add(this.infoScreening);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "ProjectCinema";
            // 
            // infoWatched
            // 
            this.infoWatched.Location = new System.Drawing.Point(205, 30);
            this.infoWatched.Name = "infoWatched";
            this.infoWatched.Size = new System.Drawing.Size(169, 23);
            this.infoWatched.TabIndex = 2;
            this.infoWatched.Text = "Most Watched";
            this.infoWatched.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 245);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BuyTicket);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "ProjectCinema";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuyTicket;
        private System.Windows.Forms.Button infoScreening;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem currentCinemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectCinemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativeToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffManagerToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button infoWatched;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

