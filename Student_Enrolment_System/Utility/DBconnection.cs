using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Enrolment_System.Utility
{
    class DbConnection
    {
        private static MySqlConnection connection = new MySqlConnection();

        //avoid create objects from this class
        private DbConnection()
        {

        }

        public static MySqlConnection getConnection()
        {
            try
            {
                //check is the connection is closed or not
                if (connection.State == ConnectionState.Closed)
                {
                    var server = ConfigurationManager.AppSettings["server"];
                    var database = ConfigurationManager.AppSettings["database"];
                    var username = ConfigurationManager.AppSettings["username"];
                    var password = ConfigurationManager.AppSettings["password"];

                    string connectionString = string.Format("SERVER = '{0}'; DATABASE = '{1}'; UID=  '{2}'; PASSWORD= '{3}';", server, database, username, password);
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

        public static void closeConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
