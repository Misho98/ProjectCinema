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
    public partial class AddEmployee : Form
    {
        public string empName = "none";
        public string empPhone = "none";
        public string empEmail = "none";
        public string jobID = "none";

        public string empID = "none";

        //other mandatory variables
        public string cid;
        MyDB db = new MyDB();

        public AddEmployee(string cid)
        {
            InitializeComponent();
            this.cid = cid;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            dataGridJobs.RowHeadersVisible = false;
            dataGridJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridJobs.MultiSelect = false;

            db.openConnection();

            MySqlCommand command =
          new MySqlCommand("SELECT employee.Employee_ID FROM employee " +
          "ORDER BY employee.Employee_ID DESC ;", db.getConnection);

            var queryResult = command.ExecuteScalar(); //Return an object so first check for null
            //if there are no employees
            if (queryResult == null) empID = "0";

            //calculate next employee id
            if (queryResult != null)
            {
                int empTemp = Convert.ToInt32(queryResult);
                empTemp++;
                empID = Convert.ToString(empTemp);
            }
            //-------------------------

           command =
          new MySqlCommand("SELECT * from job ", db.getConnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridJobs.DataSource = dt;

            db.closeConnection();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            empName = textBox1.Text.ToString();
            empPhone = textBox2.Text.ToString();
            empEmail = textBox3.Text.ToString();

            //check if all necessary info is available
            if ((empID == "none") || (empName == "none") || (empPhone == "none") || (empEmail == "none") || (jobID == "none"))
            {
                MessageBox.Show("Please select all details and try again");
                return;
            }

            //create new employee

            db.openConnection();

            MySqlCommand command =
           new MySqlCommand("INSERT INTO employee(Employee_ID, Employee_Name, Employee_Phone, Employee_Email, Job_ID, Cinema_ID)" +
           " values('" + empID + "','" + empName + "','" + empPhone + "','" + empEmail + "','" + jobID + "','" + cid +  "')", db.getConnection);
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

        private void dataGridJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridJobs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                jobID = dataGridJobs.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
