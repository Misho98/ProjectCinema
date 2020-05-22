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
        string empID = "none";

        //other mandatory variables
        public string cid;
        MyDB db = new MyDB();

        public StaffManager(string cid)
        {
            InitializeComponent();
            this.cid = cid;
        }

        private void FillEmps()
        {
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

            db.closeConnection();
        }

        private void StaffManager_Load(object sender, EventArgs e)
        {
            dataGridEmployees.RowHeadersVisible = false;
            dataGridEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEmployees.MultiSelect = false;

            //fill data grid with employees data
            FillEmps();
        }

        private void dataGridEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                empID = dataGridEmployees.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            AddEmployee sm = new AddEmployee(cid);
            sm.ShowDialog();

            //refresh employees data grid
            FillEmps();
        }

        private void RemoveEmp_Click(object sender, EventArgs e)
        {
            //check if an employee is selected
            if (empID == "none")
            {
                MessageBox.Show("Please select an employee");
                return;
            }

            //confirm employee removal
            DialogResult dialogResult = MessageBox.Show("Are you sure? ", "Remove selected employee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.openConnection();

                MySqlCommand command =
              new MySqlCommand("DELETE FROM employee " +
              "WHERE employee.Employee_ID = @eid ;", db.getConnection);

                command.Parameters.Add(new MySqlParameter("@eid", empID));
                command.ExecuteNonQuery();

                //refresh data grid
                FillEmps();
                MessageBox.Show("Employee removed");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
            db.closeConnection();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
