using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Lift_Management_System
{
    public abstract partial class FloorPlan : UserControl
    {
        private bool _doorClose = true;
        public FloorPlan()
        {
            InitializeComponent();
        }

        public void openDoor(
            )
        {
            if (!_doorClose) return;

            Timer doorTimer = new Timer();
            doorTimer.Interval = 70;
            doorTimer.Tick += (s, args) =>
            {
                if (leftDoor.Width <= 0 && rightDoor.Width <= 0)
                {
                    doorTimer.Stop();
                    _doorClose = false;

                }
                else
                {
                    if (leftDoor.Width > 0)
                    {
                        leftDoor.Width -= 5;
                    }
                    if (rightDoor.Width > 0)
                    {
                        rightDoor.Width -= 5;
                        rightDoor.Left += 5;
                    }
                }
            };
            doorTimer.Start();

        }

        public void CloseDoor()
        {
            if (_doorClose) return;
            var originalDoorWidth = 157;
            Timer doorTimer = new Timer();
            doorTimer.Interval = 70;
            doorTimer.Tick += (s, args) =>
            {
                if (leftDoor.Width >= originalDoorWidth && rightDoor.Width >= originalDoorWidth)
                {
                    doorTimer.Stop();
                    _doorClose = true;

                }
                else
                {
                    if (leftDoor.Width < originalDoorWidth)
                    {
                        leftDoor.Width += 5;
                    }
                    if (rightDoor.Width < originalDoorWidth)
                    {
                        rightDoor.Width += 5;
                        rightDoor.Left -= 5;
                    }
                }
            };
            doorTimer.Start();
        }


        public abstract int GetFloorNumber();

        private void FloorPlan_Load(object sender, EventArgs e)
        {

        }

        public bool IsDoorClose => _doorClose;
    }
}
