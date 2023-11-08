using Lift_Management_System.Database;
using Lift_Management_System.Enum;
using Lift_Management_System.Helper;
using MySqlConnector;

namespace Lift_Management_System.Middleware
{

    // Main Controller file that handles all the events created by GUI
    // This file also read and write in the database
    public class Manager
    {
        private FloorPlan[] controls = new FloorPlan[2];
        private bool isMoving = false;
        private readonly DataRequest dataAcess;
        private readonly MySqlConnection connection;

        public Manager(LiftFloors form1, DataRequest dataAccess, MySqlConnection databaseConnection)
        {
            this.controls[0] = form1.GetFloor1;
            this.controls[1] = form1.GetFloor2;

            this.dataAcess = dataAccess ?? throw new ArgumentNullException(nameof(dataAccess));
            this.connection = databaseConnection ?? throw new ArgumentNullException(nameof(databaseConnection));

            foreach (var item in controls)
            {
                var floor = item as FloorPlan;

                floor.UpButton.Click += async (object sender, EventArgs e) =>
                {
                    if (!isMoving)
                    {
                        isMoving = true;

                        if (LiftState.FloorValue == floor)
                        {
                            floor.openDoor();
                        }
                        else
                        {
                            if (LiftState.FloorValue == controls[0])
                            {
                                await MoveUp();
                            }
                            else
                            {
                                await MoveDown();
                            }
                        }

                        isMoving = false;
                    }
                };

                // Example of abstract method
                floor.Floor1Button.Click += async (object sender, EventArgs e) => {
                    await MoveDown();
                };

                floor.Floor2Button.Click += async (object sender, EventArgs e) => {
                    await MoveUp();
                };

                InitializeElevatorState();
            }
        }

        private void InitializeElevatorState()
        {
            LiftState.FloorValue = controls[0];
            LiftState.StateValue = State.Stopped;
            LiftState.DirectionValue = Direction.Up;
        }

        private async Task MoveUp()
        {
            if (!LiftState.FloorValue.IsDoorClose)
            {
                LiftState.FloorValue.CloseDoor();
            }
            
            LiftState.StateValue = State.Moving;
            dataAcess.ExecuteQuery("INSERT INTO Lift_Logs (message) VALUES ('Lift request came from floor 2.')");
            LiftState.DirectionValue = Direction.Up;

            foreach (var floor in controls)
            {
                floor.Indicator.Image = Properties.Resources.indicator_up;
            }

            await Task.Delay(5000);

            LiftState.FloorValue = controls[1];
            LiftState.StateValue = State.Stopped;
            dataAcess.ExecuteQuery("INSERT INTO Lift_Logs (message) VALUES ('Lift going up.')");


            await Task.Delay(1000);

            foreach (var floor in controls)
            {
                floor.Indicator.Image = Properties.Resources.indicator_f2;
            }

            LiftState.FloorValue.openDoor();
            dataAcess.ExecuteQuery("INSERT INTO Lift_Logs (message) VALUES ('Lift arrived at floor 2.')");

            await Task.Delay(5000);
            LiftState.FloorValue.CloseDoor();
        }

        private async Task MoveDown()
        {
            if (!LiftState.FloorValue.IsDoorClose)
            {
                LiftState.FloorValue.CloseDoor();
            }

            LiftState.StateValue = State.Moving;
            dataAcess.ExecuteQuery("INSERT INTO Lift_Logs (message) VALUES ('Lift request came from floor 1.')");

            LiftState.DirectionValue = Direction.Down;

            foreach (var floor in controls)
            {
                floor.Indicator.Image = Properties.Resources.indicator_down;
            }

            await Task.Delay(5000);
            dataAcess.ExecuteQuery("INSERT INTO Lift_Logs (message) VALUES ('Lift going down.')");

            LiftState.FloorValue = controls[0];
            LiftState.StateValue = State.Stopped;

            await Task.Delay(1000);

            foreach (var floor in controls)
            {
                floor.Indicator.Image = Properties.Resources.indicator_floor1;
            }

            LiftState.FloorValue.openDoor();
            dataAcess.ExecuteQuery("INSERT INTO Lift_Logs (message) VALUES ('Lift arrived at floor 1.')");

        }
    }
}
