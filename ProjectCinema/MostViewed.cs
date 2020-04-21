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
    public partial class MostViewed : Form
    {
        MyDB db = new MyDB();
        public MostViewed()
        {
            InitializeComponent();
        }

        private void MostViewed_Load(object sender, EventArgs e)
        {
            dataGridMostViewed.RowHeadersVisible = false;
            dataGridMostViewed.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMostViewed.MultiSelect = false;

            db.openConnection();

            MySqlCommand command =
            new MySqlCommand("SELECT movie.Movie_Name, count(*) FROM projection " +
            "JOIN movie on projection.Movie_ID = movie.Movie_ID " +
            "JOIN tickets on projection.Projection_ID = tickets.Projection_ID " +
            "GROUP BY Movie_Name " +
            "ORDER BY count(*) DESC", db.getConnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridMostViewed.DataSource = dt;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
