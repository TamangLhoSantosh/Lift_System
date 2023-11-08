using MySqlConnector;

namespace Lift_Management_System.Database
{
    public class DBConnection
    {
        private MySqlConnection conn = null;
        private string url = "datasource=localhost; database=Lift_Management_System; port=3306; User=root; Password=fastrack";
        
        // Creating a new connection with the database
        public MySqlConnection Connect()
        {
            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return conn;
        }
        
        // Closing the open connection
        public bool Close(MySqlConnection conn)
        {
            bool result = false;
            try
            {
                conn.Close();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }
    }
}