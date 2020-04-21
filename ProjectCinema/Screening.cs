using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjectCinema
{
    public partial class Screening : Form
    {
        public string projectionID = "none";

        //other mandatory variables
        public string cid;
        MyDB db = new MyDB();
        public Screening(string cid)
        {
            InitializeComponent();
            this.cid = cid;
        }

        private void Screening_Load(object sender, EventArgs e)
        {
            dataGridScreenings.RowHeadersVisible = false;
            dataGridScreenings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridScreenings.MultiSelect = false;

            dataGridSClients.RowHeadersVisible = false;
            dataGridSClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSClients.MultiSelect = false;

            db.openConnection();

            MySqlCommand command =
          new MySqlCommand("SELECT projection.Date, movie.Movie_Name, projection.Time, hallsize.HallSize_Seats, projection.Projection_ID FROM projection " +
          "JOIN movie on projection.Movie_ID = movie.Movie_ID " +
          "JOIN hall on projection.Hall_ID = hall.Hall_ID " +
          "JOIN hallsize on hall.HallSize_ID = hallsize.HallSize_ID " +
          "WHERE hall.Cinema_ID = @cid " +
          "ORDER BY projection.Date DESC; ", db.getConnection);

            command.Parameters.Add(new MySqlParameter("@cid", cid));

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridScreenings.DataSource = dt;
        }

        private void dataGridScreenings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridScreenings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                projectionID = dataGridScreenings.Rows[e.RowIndex].Cells[5].Value.ToString();
               
                //Show selected screening clients
                DataSet ds = new DataSet();
                MySqlCommand commandSeat = new MySqlCommand(
                    "SELECT seat.Seat_Number, client.Client_Name, client.Client_Email FROM tickets " +
                    "JOIN client on tickets.Client_ID = client.Client_ID " +
                    "JOIN seat on tickets.Seat_ID = seat.Seat_ID " +
                    "WHERE tickets.Projection_ID = @proj " +
                    "ORDER BY seat.Seat_Number;", db.getConnection);

                commandSeat.Parameters.Add(new MySqlParameter("@proj", projectionID));

                MySqlDataAdapter adapter = new MySqlDataAdapter(commandSeat);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridSClients.DataSource = dt;

                labelTotal.Text = "Total Clients for this screening: " + dataGridSClients.Rows.Count.ToString();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
