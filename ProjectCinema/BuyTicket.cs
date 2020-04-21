using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProjectCinema
{
    public partial class BuyTicket : Form
    {
        //variables for new ticket
        public string projectionID = "none";
        public string clientID = "none";
        public string typeID = "none";
        public string seatID = "none";

        public string hallsize;

        //other mandatory variables
        public string cid;
        MyDB db = new MyDB();
        public BuyTicket(string cid)
        {
            InitializeComponent();
            this.cid = cid;
        }

        private void BuyTicket_Load(object sender, EventArgs e)
        {
            
            dataGridMovies.RowHeadersVisible = false;
            dataGridMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMovies.MultiSelect = false;

            dataGridClients.RowHeadersVisible = false;
            dataGridClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClients.MultiSelect = false;

            dataGridPrice.RowHeadersVisible = false;
            dataGridPrice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPrice.MultiSelect = false;

            db.openConnection();

            //Clients List
            MySqlCommand command2 =
            new MySqlCommand("SELECT * FROM client", db.getConnection);

            MySqlDataAdapter adapter2 = new MySqlDataAdapter(command2);
            DataTable dt2 = new DataTable();

            adapter2.Fill(dt2);
            dataGridClients.DataSource = dt2;

            //Pricing List
            MySqlCommand command3 =
            new MySqlCommand("SELECT * FROM ticket_type ORDER BY Price", db.getConnection);

            MySqlDataAdapter adapter3 = new MySqlDataAdapter(command3);
            DataTable dt3 = new DataTable();

            adapter3.Fill(dt3);
            dataGridPrice.DataSource = dt3;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string selDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

           /* MySqlCommand command =
            new MySqlCommand("SELECT typeprojection.Type_Name, projection.Time, movie.Movie_Name, genre.Genre_Name, movie.Rating, movie.year, projection.Projection_ID, hallsize.HallSIze_Seats from movie " +
            "JOIN genre on movie.Genre_ID = genre.Genre_ID " +
            "JOIN projection on movie.Movie_ID = projection.Projection_ID " +
            "JOIN typeprojection on projection.TypeProjection_ID = typeprojection.TypeProjection_ID " +
            "JOIN hall on projection.Hall_ID = hall.Hall_ID " +
            "JOIN hallsize on hall.HallSize_ID = hallsize.HallSize_ID " +
            "WHERE hall.Cinema_ID = @cid and projection.Date = @date", db.getConnection);
            */

            MySqlCommand command =
           new MySqlCommand("SELECT typeprojection.Type_Name, projection.Time, movie.Movie_Name, genre.Genre_Name, movie.Rating, movie.year, projection.Projection_ID, hallsize.HallSIze_Seats from projection " +
           "JOIN hall on projection.Hall_ID = hall.Hall_ID " +
           "JOIN movie on projection.Movie_ID = movie.Movie_ID " +
           "JOIN cinema on hall.Cinema_ID = cinema.Cinema_ID " +
           "JOIN typeprojection on projection.TypeProjection_ID = typeprojection.TypeProjection_ID " +
           "JOIN genre on movie.Genre_ID = genre.Genre_ID " +
           "JOIN hallsize on hall.HallSize_ID = hallsize.HallSize_ID " +
           "WHERE hall.Cinema_ID = @cid and projection.Date = @date ;", db.getConnection);

            command.Parameters.Add(new MySqlParameter("@cid", cid));
            command.Parameters.Add(new MySqlParameter("@date", selDate));

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridMovies.DataSource = dt;

            labelDate.Text = "Date: " + selDate;
        }

        private void dataGridPrice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridPrice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                typeID = dataGridPrice.Rows[e.RowIndex].Cells[0].Value.ToString();

                labelPrice.Text = "Price: " + dataGridPrice.Rows[e.RowIndex].Cells[2].Value.ToString() + "lv.";
            }
        }

        private void dataGridMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridMovies.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                projectionID = dataGridMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
                hallsize = dataGridMovies.Rows[e.RowIndex].Cells[7].Value.ToString();

                labelTime.Text = "Starts at: " + dataGridMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                labelMovie.Text = "Movie: " + dataGridMovies.Rows[e.RowIndex].Cells[2].Value.ToString();

                //seats visualisation
                listBoxSeat.Items.Clear();
                for (int i = 0; i < Int32.Parse(hallsize); i++)
                {
                    listBoxSeat.Items.Add((i + 1));
                }

                //removing taken seats
                DataSet ds = new DataSet();
                MySqlCommand commandSeat = new MySqlCommand(
                    "SELECT seat.Seat_ID FROM Seat " +
                    "JOIN tickets on seat.Seat_ID = tickets.Seat_ID " +
                    "WHERE tickets.Projection_ID = @proj", db.getConnection);
                commandSeat.Parameters.Add(new MySqlParameter("@proj", projectionID));

                MySqlDataAdapter adapterSeat = new MySqlDataAdapter(commandSeat);

                adapterSeat.Fill(ds);

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        listBoxSeat.Items.Remove(Int32.Parse(dr["Seat_ID"].ToString()));
                    }
                }
                listBoxSeat.Refresh();
            }
        }

        private void dataGridClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridClients.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                clientID = dataGridClients.Rows[e.RowIndex].Cells[0].Value.ToString();

                labelClient.Text = "Client: " + dataGridClients.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void listBoxSeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatID = listBoxSeat.SelectedItem.ToString();
            labelSeat.Text = "Seat: " + seatID;
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            //check if all necessary info is available
            if ((projectionID == "none") || (clientID == "none") || (typeID == "none") || (seatID == "none"))
            {
                MessageBox.Show("Please select all details and try again");
                return;
            }

            //create new ticket
            MySqlCommand command =
           new MySqlCommand("INSERT INTO Tickets(Projection_ID, Client_ID, Ticket_Type_ID, Seat_ID)" +
           " values('" + projectionID + "','" + clientID + "','" + typeID + "','" + seatID + "')", db.getConnection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("DATA UPDATED");
                }
                else
                {
                    MessageBox.Show("Connection error. Data NOT UPDATED");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
