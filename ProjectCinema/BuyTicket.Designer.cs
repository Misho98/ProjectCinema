namespace ProjectCinema
{
    partial class BuyTicket
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
            this.dataGridMovies = new System.Windows.Forms.DataGridView();
            this.Format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projection_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallSize_Seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Buy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridPrice = new System.Windows.Forms.DataGridView();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxSeat = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMovie = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelSeat = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a Movie:";
            // 
            // dataGridMovies
            // 
            this.dataGridMovies.AllowUserToAddRows = false;
            this.dataGridMovies.AllowUserToDeleteRows = false;
            this.dataGridMovies.AllowUserToResizeRows = false;
            this.dataGridMovies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Format,
            this.coltime,
            this.Movie,
            this.Genre,
            this.Rating,
            this.Year,
            this.Projection_ID,
            this.HallSize_Seats});
            this.dataGridMovies.Location = new System.Drawing.Point(18, 66);
            this.dataGridMovies.Name = "dataGridMovies";
            this.dataGridMovies.ReadOnly = true;
            this.dataGridMovies.Size = new System.Drawing.Size(623, 152);
            this.dataGridMovies.TabIndex = 1;
            this.dataGridMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMovies_CellContentClick);
            // 
            // Format
            // 
            this.Format.DataPropertyName = "Type_Name";
            this.Format.HeaderText = "Format";
            this.Format.Name = "Format";
            this.Format.ReadOnly = true;
            this.Format.Width = 81;
            // 
            // coltime
            // 
            this.coltime.DataPropertyName = "Time";
            this.coltime.HeaderText = "Starts at";
            this.coltime.Name = "coltime";
            this.coltime.ReadOnly = true;
            // 
            // Movie
            // 
            this.Movie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Movie.DataPropertyName = "Movie_Name";
            this.Movie.HeaderText = "Name";
            this.Movie.Name = "Movie";
            this.Movie.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre_Name";
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Width = 50;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "year";
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 70;
            // 
            // Projection_ID
            // 
            this.Projection_ID.DataPropertyName = "Projection_ID";
            this.Projection_ID.HeaderText = "Projection_ID";
            this.Projection_ID.Name = "Projection_ID";
            this.Projection_ID.ReadOnly = true;
            this.Projection_ID.Visible = false;
            // 
            // HallSize_Seats
            // 
            this.HallSize_Seats.DataPropertyName = "HallSIze_Seats";
            this.HallSize_Seats.HeaderText = "HallSize_Seats";
            this.HallSize_Seats.Name = "HallSize_Seats";
            this.HallSize_Seats.ReadOnly = true;
            this.HallSize_Seats.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Client:";
            // 
            // dataGridClients
            // 
            this.dataGridClients.AllowUserToAddRows = false;
            this.dataGridClients.AllowUserToDeleteRows = false;
            this.dataGridClients.AllowUserToResizeRows = false;
            this.dataGridClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.hCol});
            this.dataGridClients.Location = new System.Drawing.Point(18, 250);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.ReadOnly = true;
            this.dataGridClients.Size = new System.Drawing.Size(384, 152);
            this.dataGridClients.TabIndex = 3;
            this.dataGridClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClients_CellContentClick);
            // 
            // c1
            // 
            this.c1.DataPropertyName = "Client_Name";
            this.c1.HeaderText = "Name";
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Width = 200;
            // 
            // c2
            // 
            this.c2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c2.DataPropertyName = "Client_Email";
            this.c2.HeaderText = "E-mail";
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            // 
            // hCol
            // 
            this.hCol.DataPropertyName = "Client_ID";
            this.hCol.HeaderText = "ID";
            this.hCol.Name = "hCol";
            this.hCol.ReadOnly = true;
            this.hCol.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pick Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 12);
            this.dateTimePicker1.MaxDate = new System.DateTime(2098, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Buy
            // 
            this.Buy.Location = new System.Drawing.Point(142, 87);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(65, 23);
            this.Buy.TabIndex = 6;
            this.Buy.Text = "Buy";
            this.Buy.UseVisualStyleBackColor = true;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ticket type:";
            // 
            // dataGridPrice
            // 
            this.dataGridPrice.AllowUserToAddRows = false;
            this.dataGridPrice.AllowUserToDeleteRows = false;
            this.dataGridPrice.AllowUserToResizeRows = false;
            this.dataGridPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TT,
            this.TP,
            this.TTID});
            this.dataGridPrice.Location = new System.Drawing.Point(425, 250);
            this.dataGridPrice.Name = "dataGridPrice";
            this.dataGridPrice.ReadOnly = true;
            this.dataGridPrice.Size = new System.Drawing.Size(216, 152);
            this.dataGridPrice.TabIndex = 8;
            this.dataGridPrice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPrice_CellContentClick);
            // 
            // TT
            // 
            this.TT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TT.DataPropertyName = "Type_Name";
            this.TT.HeaderText = "Ticket Type";
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            // 
            // TP
            // 
            this.TP.DataPropertyName = "Price";
            this.TP.HeaderText = "Price";
            this.TP.Name = "TP";
            this.TP.ReadOnly = true;
            // 
            // TTID
            // 
            this.TTID.DataPropertyName = "Ticket_Type_ID";
            this.TTID.HeaderText = "TicketTypeID";
            this.TTID.Name = "TTID";
            this.TTID.ReadOnly = true;
            this.TTID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Choose a seat (select ticket type to refresh):";
            // 
            // listBoxSeat
            // 
            this.listBoxSeat.FormattingEnabled = true;
            this.listBoxSeat.Location = new System.Drawing.Point(238, 418);
            this.listBoxSeat.Name = "listBoxSeat";
            this.listBoxSeat.Size = new System.Drawing.Size(120, 121);
            this.listBoxSeat.TabIndex = 10;
            this.listBoxSeat.SelectedIndexChanged += new System.EventHandler(this.listBoxSeat_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelClient);
            this.groupBox1.Controls.Add(this.labelTime);
            this.groupBox1.Controls.Add(this.labelSeat);
            this.groupBox1.Controls.Add(this.labelDate);
            this.groupBox1.Controls.Add(this.labelMovie);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Controls.Add(this.Buy);
            this.groupBox1.Location = new System.Drawing.Point(425, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 121);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Final Ticket Confirmation";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(6, 97);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(95, 13);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price: not selected";
            // 
            // labelMovie
            // 
            this.labelMovie.AutoSize = true;
            this.labelMovie.Location = new System.Drawing.Point(6, 29);
            this.labelMovie.Name = "labelMovie";
            this.labelMovie.Size = new System.Drawing.Size(100, 13);
            this.labelMovie.TabIndex = 8;
            this.labelMovie.Text = "Movie: not selected";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(6, 16);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(94, 13);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "Date: not selected";
            // 
            // labelSeat
            // 
            this.labelSeat.AutoSize = true;
            this.labelSeat.Location = new System.Drawing.Point(6, 42);
            this.labelSeat.Name = "labelSeat";
            this.labelSeat.Size = new System.Drawing.Size(93, 13);
            this.labelSeat.TabIndex = 10;
            this.labelSeat.Text = "Seat: not selected";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(113, 16);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(94, 13);
            this.labelTime.TabIndex = 11;
            this.labelTime.Text = "Time: not selected";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(6, 84);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(97, 13);
            this.labelClient.TabIndex = 12;
            this.labelClient.Text = "Client: not selected";
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxSeat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridClients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridMovies);
            this.Controls.Add(this.label1);
            this.Name = "BuyTicket";
            this.Text = "BuyTicket";
            this.Load += new System.EventHandler(this.BuyTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridMovies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxSeat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Format;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projection_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallSize_Seats;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelSeat;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMovie;
        private System.Windows.Forms.Label labelPrice;
    }
}