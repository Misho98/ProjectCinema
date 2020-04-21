namespace ProjectCinema
{
    partial class MostViewed
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
            this.dataGridMostViewed = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccc4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostViewed)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMostViewed
            // 
            this.dataGridMostViewed.AllowUserToAddRows = false;
            this.dataGridMostViewed.AllowUserToDeleteRows = false;
            this.dataGridMostViewed.AllowUserToResizeRows = false;
            this.dataGridMostViewed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMostViewed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMostViewed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cc2,
            this.cccc4});
            this.dataGridMostViewed.Location = new System.Drawing.Point(12, 29);
            this.dataGridMostViewed.Name = "dataGridMostViewed";
            this.dataGridMostViewed.ReadOnly = true;
            this.dataGridMostViewed.Size = new System.Drawing.Size(497, 138);
            this.dataGridMostViewed.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Most watched movies:";
            // 
            // cc2
            // 
            this.cc2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cc2.DataPropertyName = "Movie_Name";
            this.cc2.HeaderText = "Movie";
            this.cc2.Name = "cc2";
            this.cc2.ReadOnly = true;
            // 
            // cccc4
            // 
            this.cccc4.DataPropertyName = "count(*)";
            this.cccc4.HeaderText = "Total Views";
            this.cccc4.Name = "cccc4";
            this.cccc4.ReadOnly = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(224, 188);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Close";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MostViewed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 223);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridMostViewed);
            this.Name = "MostViewed";
            this.Text = "Most Watched (All Cinemas)";
            this.Load += new System.EventHandler(this.MostViewed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostViewed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMostViewed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccc4;
        private System.Windows.Forms.Button Exit;
    }
}