using MySqlConnector;
using System.Data;

namespace Lift_Management_System.Database
{

    // This class was created to reduce the code to execute sql queries
    public class DataRequest
    {
        private MySqlConnection conn;

        public DataRequest(MySqlConnection connection)
        {
            conn = connection;
        }

        // Executing query
        public DataTable ExecuteQuery(string query)
        {
            DataTable tableData = new DataTable();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(tableData);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return tableData;
        }
        
        // Executing query
        public int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return rowsAffected;
        }
    }
}
