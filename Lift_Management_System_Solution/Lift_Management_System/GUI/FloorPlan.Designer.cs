namespace Lift_Management_System
{
    partial class FloorPlan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lift = new PictureBox();
            leftDoor = new PictureBox();
            rightDoor = new PictureBox();
            liftCallButton = new PictureBox();
            firstFloor = new PictureBox();
            secondFloor = new PictureBox();
            floorIndicator = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)lift).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftDoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightDoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)liftCallButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firstFloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondFloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)floorIndicator).BeginInit();
            SuspendLayout();
            // 
            // lift
            // 
            lift.Image = Properties.Resources.elevator_door;
            lift.Location = new Point(166, 98);
            lift.Margin = new Padding(4, 5, 4, 5);
            lift.Name = "lift";
            lift.Size = new Size(400, 647);
            lift.SizeMode = PictureBoxSizeMode.StretchImage;
            lift.TabIndex = 0;
            lift.TabStop = false;
            // 
            // leftDoor
            // 
            leftDoor.Image = Properties.Resources.elevator_doors;
            leftDoor.Location = new Point(207, 168);
            leftDoor.Margin = new Padding(4, 5, 4, 5);
            leftDoor.Name = "leftDoor";
            leftDoor.Size = new Size(157, 517);
            leftDoor.SizeMode = PictureBoxSizeMode.StretchImage;
            leftDoor.TabIndex = 1;
            leftDoor.TabStop = false;
            // 
            // rightDoor
            // 
            rightDoor.Image = Properties.Resources.elevator_doors;
            rightDoor.Location = new Point(362, 168);
            rightDoor.Margin = new Padding(4, 5, 4, 5);
            rightDoor.Name = "rightDoor";
            rightDoor.Size = new Size(157, 517);
            rightDoor.SizeMode = PictureBoxSizeMode.StretchImage;
            rightDoor.TabIndex = 2;
            rightDoor.TabStop = false;
            // 
            // liftCallButton
            // 
            liftCallButton.Image = Properties.Resources.elevator_button;
            liftCallButton.Location = new Point(611, 357);
            liftCallButton.Margin = new Padding(4, 5, 4, 5);
            liftCallButton.Name = "liftCallButton";
            liftCallButton.Size = new Size(64, 75);
            liftCallButton.SizeMode = PictureBoxSizeMode.StretchImage;
            liftCallButton.TabIndex = 3;
            liftCallButton.TabStop = false;
            // 
            // firstFloor
            // 
            firstFloor.Image = Properties.Resources.elevator_floor_1_button;
            firstFloor.Location = new Point(380, 342);
            firstFloor.Margin = new Padding(4, 5, 4, 5);
            firstFloor.Name = "firstFloor";
            firstFloor.Size = new Size(89, 90);
            firstFloor.SizeMode = PictureBoxSizeMode.StretchImage;
            firstFloor.TabIndex = 5;
            firstFloor.TabStop = false;
            // 
            // secondFloor
            // 
            secondFloor.Image = Properties.Resources.elevator_floor_button;
            secondFloor.Location = new Point(259, 342);
            secondFloor.Margin = new Padding(4, 5, 4, 5);
            secondFloor.Name = "secondFloor";
            secondFloor.Size = new Size(89, 90);
            secondFloor.SizeMode = PictureBoxSizeMode.StretchImage;
            secondFloor.TabIndex = 6;
            secondFloor.TabStop = false;
            // 
            // floorIndicator
            // 
            floorIndicator.Image = Properties.Resources.indicator_floor1;
            floorIndicator.Location = new Point(294, 98);
            floorIndicator.Margin = new Padding(4, 5, 4, 5);
            floorIndicator.Name = "floorIndicator";
            floorIndicator.Size = new Size(139, 42);
            floorIndicator.SizeMode = PictureBoxSizeMode.StretchImage;
            floorIndicator.TabIndex = 7;
            floorIndicator.TabStop = false;
            // 
            // FloorPlan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rightDoor);
            Controls.Add(leftDoor);
            Controls.Add(firstFloor);
            Controls.Add(secondFloor);
            Controls.Add(liftCallButton);
            Controls.Add(floorIndicator);
            Controls.Add(lift);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FloorPlan";
            Size = new Size(1326, 837);
            Load += FloorPlan_Load;
            ((System.ComponentModel.ISupportInitialize)lift).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftDoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightDoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)liftCallButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)firstFloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondFloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)floorIndicator).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox lift;
        private PictureBox leftDoor;
        private PictureBox rightDoor;
        private PictureBox liftCallButton;
        private PictureBox firstFloor;
        private PictureBox secondFloor;
        private PictureBox floorIndicator;

        public PictureBox UpButton => liftCallButton;
        public PictureBox Floor1Button => firstFloor;
        public PictureBox Floor2Button => secondFloor;
        public PictureBox Indicator => floorIndicator;

    }
}
