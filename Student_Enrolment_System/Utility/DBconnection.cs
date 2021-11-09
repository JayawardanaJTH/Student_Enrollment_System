using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Enrolment_System.Utility
{
    class DBconnection
    {
        private static MySqlConnection connection = null;
        
        //avoid create objects from this class
        private DBconnection()
        {

        }

        public static MySqlConnection getConnection()
        {
            try
            {
            //check is the connection is closed or not
                if (connection == null){
                    var server = ConfigurationManager.AppSettings["server"];
                    var database = ConfigurationManager.AppSettings["database"];
                    var username = ConfigurationManager.AppSettings["username"];
                    var password = ConfigurationManager.AppSettings["password"];

                    string connectionString = string.Format("SERVER = '{0}'; DATABASE = '{1}'; UID=  '{2}'; PASSWORD= '{3}';",server,database,username,password);
                    connection = new MySqlConnection(connectionString);
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           return connection;           
        }
    }
}
