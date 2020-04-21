using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjectCinema
{
    class MyDB
    {
        //DB connection
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=cinema;database=cinemadb");

        //return connection
        public MySqlConnection getConnection 
        {
            get 
            {
                return con;
            }
        }

        //open connection
        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        //close connection
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
