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
    public partial class MainMenu : Form
    {
        MyDB db = new MyDB();
        public string curCinemaID = "none";
        public MainMenu()
        {
            InitializeComponent();
        }
        private void selectCinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CinemaSelector selector = new CinemaSelector();
            var res = selector.ShowDialog();
            if (res == DialogResult.OK)
            {
                this.currentCinemaToolStripMenuItem.Text = "Current Cinema: " + selector.currentCinema;
                curCinemaID = selector.currentCinemaID;
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuyTicket_Click(object sender, EventArgs e)
        {
            if (curCinemaID == "none")
            {
                MessageBox.Show("You haven't selected a cinema.");
                return;
            }
            BuyTicket ticket = new BuyTicket(curCinemaID);
            ticket.ShowDialog();
        }

        private void infoScreening_Click(object sender, EventArgs e)
        {
            if (curCinemaID == "none")
            {
                MessageBox.Show("You haven't selected a cinema.");
                return;
            }
            Screening scr = new Screening(curCinemaID);
            scr.ShowDialog();
        }

        private void infoWatched_Click(object sender, EventArgs e)
        {
            MostViewed mv = new MostViewed();
            mv.ShowDialog();
        }

        private void staffManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (curCinemaID == "none")
            {
                MessageBox.Show("You haven't selected a cinema.");
                return;
            }
            StaffManager sm = new StaffManager(curCinemaID);
            sm.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
