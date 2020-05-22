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
    public partial class StaffManager : Form
    {

        //other mandatory variables
        public string cid;
        MyDB db = new MyDB();

        public StaffManager(string cid)
        {
            InitializeComponent();
            this.cid = cid;
        }

        private void StaffManager_Load(object sender, EventArgs e)
        {
            dataGridEmployees.RowHeadersVisible = false;
            dataGridEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEmployees.MultiSelect = false;

            db.openConnection();

            MySqlCommand command =
          new MySqlCommand("SELECT employee.Employee_Name, job.Job_Name, employee.Employee_Phone, employee.Employee_Email, employee.Employee_ID FROM employee " +
          "JOIN job on employee.Job_ID = job.Job_ID " +
          "WHERE employee.Cinema_ID = @cid " +
          "ORDER BY employee.Employee_Name;", db.getConnection);

            command.Parameters.Add(new MySqlParameter("@cid", cid));

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridEmployees.DataSource = dt;
        }

        private void dataGridEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
