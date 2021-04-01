using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Students_Mangement_System
{
    class Database_Connection
    {
        public  SqlConnection sqlconnection;
         public Database_Connection()
        {

            sqlconnection = new SqlConnection(@"Data Source=. ;Database = Office_Tutorials;Integrated Security=True;");
       
        }

        public void Open()
        {

            if (sqlconnection.State != ConnectionState.Open)
            {

                sqlconnection.Open();
            }
        }

        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
    }
}
