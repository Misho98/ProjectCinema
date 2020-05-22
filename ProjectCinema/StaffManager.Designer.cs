namespace ProjectCinema
{
    partial class StaffManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.dataGridEmployees = new System.Windows.Forms.DataGridView();
            this.Ename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees list:";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(491, 363);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "Close";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // dataGridEmployees
            // 
            this.dataGridEmployees.AllowUserToAddRows = false;
            this.dataGridEmployees.AllowUserToDeleteRows = false;
            this.dataGridEmployees.AllowUserToResizeRows = false;
            this.dataGridEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ename,
            this.Ejob,
            this.Ephone,
            this.Eemail,
            this.Eid});
            this.dataGridEmployees.Location = new System.Drawing.Point(15, 25);
            this.dataGridEmployees.Name = "dataGridEmployees";
            this.dataGridEmployees.ReadOnly = true;
            this.dataGridEmployees.Size = new System.Drawing.Size(587, 152);
            this.dataGridEmployees.TabIndex = 14;
            this.dataGridEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployees_CellContentClick);
            // 
            // Ename
            // 
            this.Ename.DataPropertyName = "Employee_Name";
            this.Ename.HeaderText = "Name";
            this.Ename.Name = "Ename";
            this.Ename.ReadOnly = true;
            // 
            // Ejob
            // 
            this.Ejob.DataPropertyName = "Job_Name";
            this.Ejob.HeaderText = "Job Title";
            this.Ejob.Name = "Ejob";
            this.Ejob.ReadOnly = true;
            // 
            // Ephone
            // 
            this.Ephone.DataPropertyName = "Employee_Phone";
            this.Ephone.HeaderText = "Phone";
            this.Ephone.Name = "Ephone";
            this.Ephone.ReadOnly = true;
            // 
            // Eemail
            // 
            this.Eemail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Eemail.DataPropertyName = "Employee_Email";
            this.Eemail.HeaderText = "Email";
            this.Eemail.Name = "Eemail";
            this.Eemail.ReadOnly = true;
            // 
            // Eid
            // 
            this.Eid.DataPropertyName = "Employee_ID";
            this.Eid.HeaderText = "Employee_ID";
            this.Eid.Name = "Eid";
            this.Eid.ReadOnly = true;
            this.Eid.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Remove Selected Employee";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StaffManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataGridEmployees);
            this.Controls.Add(this.label1);
            this.Name = "StaffManager";
            this.Text = "StaffManager";
            this.Load += new System.EventHandler(this.StaffManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView dataGridEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eid;
        private System.Windows.Forms.Button button1;
    }
}