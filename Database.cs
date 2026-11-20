
using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace AlAmanPharmacyUI
{
    public class Database
    {
        private static string connectionString =
    "User Id=PHARMSE;" +
    "Password=work;" +
    "Data Source=(DESCRIPTION=" +
    "(ADDRESS=(PROTOCOL=TCP)(HOST=127.0.0.1)(PORT=1521))" +
    "(CONNECT_DATA=(SERVICE_NAME=orcl)));" +
    "Pooling=false;" +
    "Connection Timeout=30;";

        public static OracleConnection GetConnection()
        {
            return new OracleConnection(connectionString);
        }

        public static void TestConnection()
        {
            try
            {
                using (OracleConnection con = GetConnection())
                {
                    con.Open();
                    MessageBox.Show("Connection Successful!");
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(
     "Error Number: " + ex.Number +
     "\nMessage: " + ex.Message +
     "\nSource: " + ex.Source
 );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
