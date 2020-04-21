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
    public partial class CinemaSelector : Form
    {
        public CinemaSelector()
        {
            InitializeComponent();
        }


        private void CinemaSelector_Load(object sender, EventArgs e)
        {
            MyDB db = new MyDB();
            try
            {
                db.openConnection();

                DataSet ds = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter(
                    "SELECT * from cinema", db.getConnection);

                adapter.Fill(ds);
                this.listCinema.DataSource = ds.Tables[0];
                this.listCinema.DisplayMember = "Cinema_Name";
                db.closeConnection();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Database Problem");
            }
        }

        public string currentCinema {get;set;}
        public string currentCinemaID { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.currentCinema = ((DataRowView)this.listCinema.SelectedItem)["Cinema_Name"].ToString();
            this.currentCinemaID = ((DataRowView)this.listCinema.SelectedItem)["Cinema_ID"].ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
