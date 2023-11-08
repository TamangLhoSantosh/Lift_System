using System;
using System.Windows.Forms;
using Lift_Management_System.Database;
using Lift_Management_System.Middleware;

namespace Lift_Management_System
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Initialize application-wide settings and configurations
            ApplicationConfiguration.Initialize();

            // Generating a new Windows Form
            var appForm = new LiftFloors();

            // Establish a database connection
            var connection = new DBConnection();
            var databaseConnection = connection.Connect();

            // Create DataAccess with the database connection
            var dataAccess = new DataRequest(databaseConnection);

            // Create and initialize the Manager with the form, DataAccess, and database connection
            var manager = new Manager(appForm, dataAccess, databaseConnection);

            // Run the application
            Application.Run(appForm);
        }
    }
}
