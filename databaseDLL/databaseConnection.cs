using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseDLL
{
    public class databaseConnection
    {
        public static MySqlConnection openConnection()
        {
            string myConnection = "server=223.27.22.124;" +
                                   "User Id=martin01;password=l-l3110oO;" +
                                   "database=041602461_ComHRInvoiceSystem";

            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            return myConn;
        }//END openConenction()

    }
}
