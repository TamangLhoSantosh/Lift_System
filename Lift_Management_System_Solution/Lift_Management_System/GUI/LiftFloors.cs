using Lift_Management_System.Database;
using Lift_Management_System.Views;
using Microsoft.VisualBasic.Logging;
using MySqlConnector;
using System.Data;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Lift_Management_System
{
    public partial class LiftFloors : Form
    {
        private readonly DataRequest dataAcess;
        private readonly MySqlConnection connection;
        private Timer timer;
        public LiftFloors()
        {
            InitializeComponent();
            var connection = new DBConnection();
            var databaseConnection = connection.Connect();
            dataAcess = new DataRequest(databaseConnection);
            timer = new Timer();
            timer.Interval = 2000; // Set the refresh interval (5 seconds in this example).
            timer.Tick += Timer_Tick;
            timer.Start();

            // Initial log update.
            UpdateLogListBox();
        }

        private void UpdateLogListBox()
        {
            string query = "SELECT Message, created FROM Lift_Logs ORDER BY created DESC"; // Replace with your SQL query
            DataTable dataTable = dataAcess.ExecuteQuery(query);

            logsDisplay.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                logsDisplay.Items.Add(row["Message"].ToString());
                logsDisplay.Items.Add(row["created"].ToString());
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Timer tick event handler; this is called at the specified interval.
            UpdateLogListBox();
        }

        private void logsButton_Click(object sender, EventArgs e)
        {
            logsDisplay.Visible = !logsDisplay.Visible;
        }

        public Floor1 GetFloor1 => userControl11;
        public Floor2 GetFloor2 => userControl12;

    }
}