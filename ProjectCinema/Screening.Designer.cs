namespace ProjectCinema
{
    partial class Screening
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
            this.dataGridScreenings = new System.Windows.Forms.DataGridView();
            this.cc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cc3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cc4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cc5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridSClients = new System.Windows.Forms.DataGridView();
            this.ccc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccc3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScreenings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridScreenings
            // 
            this.dataGridScreenings.AllowUserToAddRows = false;
            this.dataGridScreenings.AllowUserToDeleteRows = false;
            this.dataGridScreenings.AllowUserToResizeRows = false;
            this.dataGridScreenings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridScreenings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridScreenings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cc1,
            this.cc2,
            this.cc3,
            this.cc4,
            this.cc5});
            this.dataGridScreenings.Location = new System.Drawing.Point(15, 25);
            this.dataGridScreenings.Name = "dataGridScreenings";
            this.dataGridScreenings.ReadOnly = true;
            this.dataGridScreenings.Size = new System.Drawing.Size(535, 152);
            this.dataGridScreenings.TabIndex = 6;
            this.dataGridScreenings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridScreenings_CellContentClick);
            // 
            // cc1
            // 
            this.cc1.DataPropertyName = "Date";
            this.cc1.HeaderText = "Date";
            this.cc1.Name = "cc1";
            this.cc1.ReadOnly = true;
            // 
            // cc2
            // 
            this.cc2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cc2.DataPropertyName = "Movie_Name";
            this.cc2.HeaderText = "Movie";
            this.cc2.Name = "cc2";
            this.cc2.ReadOnly = true;
            // 
            // cc3
            // 
            this.cc3.DataPropertyName = "Time";
            this.cc3.HeaderText = "Starts At";
            this.cc3.Name = "cc3";
            this.cc3.ReadOnly = true;
            // 
            // cc4
            // 
            this.cc4.DataPropertyName = "HallSize_Seats";
            this.cc4.HeaderText = "Hall Size";
            this.cc4.Name = "cc4";
            this.cc4.ReadOnly = true;
            // 
            // cc5
            // 
            this.cc5.HeaderText = "ProjectID";
            this.cc5.Name = "cc5";
            this.cc5.ReadOnly = true;
            this.cc5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose Screening:";
            // 
            // dataGridSClients
            // 
            this.dataGridSClients.AllowUserToAddRows = false;
            this.dataGridSClients.AllowUserToDeleteRows = false;
            this.dataGridSClients.AllowUserToResizeRows = false;
            this.dataGridSClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccc1,
            this.ccc2,
            this.ccc3});
            this.dataGridSClients.Location = new System.Drawing.Point(15, 218);
            this.dataGridSClients.Name = "dataGridSClients";
            this.dataGridSClients.ReadOnly = true;
            this.dataGridSClients.Size = new System.Drawing.Size(535, 152);
            this.dataGridSClients.TabIndex = 10;
            // 
            // ccc1
            // 
            this.ccc1.DataPropertyName = "Seat_Number";
            this.ccc1.HeaderText = "Seat";
            this.ccc1.Name = "ccc1";
            this.ccc1.ReadOnly = true;
            // 
            // ccc2
            // 
            this.ccc2.DataPropertyName = "Client_Name";
            this.ccc2.HeaderText = "Client Name";
            this.ccc2.Name = "ccc2";
            this.ccc2.ReadOnly = true;
            // 
            // ccc3
            // 
            this.ccc3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ccc3.DataPropertyName = "Client_Email";
            this.ccc3.HeaderText = "E-mail";
            this.ccc3.Name = "ccc3";
            this.ccc3.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Clients For The Selected Screening:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(15, 377);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 13);
            this.labelTotal.TabIndex = 12;
            // 
            // Screening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 428);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridSClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridScreenings);
            this.Name = "Screening";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Screening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScreenings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridScreenings;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridSClients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccc3;
    }
}