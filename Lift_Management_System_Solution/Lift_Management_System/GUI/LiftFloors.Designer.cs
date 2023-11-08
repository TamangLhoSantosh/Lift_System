using Lift_Management_System.Views;

namespace Lift_Management_System
{
    partial class LiftFloors
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userControl11 = new Floor1();
            userControl12 = new Floor2();
            logsDisplay = new ListBox();
            logsButton = new Button();
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.Location = new Point(571, 667);
            userControl11.Margin = new Padding(6, 8, 6, 8);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(774, 837);
            userControl11.TabIndex = 0;
            // 
            // userControl12
            // 
            userControl12.Location = new Point(580, -83);
            userControl12.Margin = new Padding(6, 8, 6, 8);
            userControl12.Name = "userControl12";
            userControl12.Size = new Size(686, 837);
            userControl12.TabIndex = 1;
            // 
            // logsDisplay
            // 
            logsDisplay.FormattingEnabled = true;
            logsDisplay.HorizontalScrollbar = true;
            logsDisplay.ItemHeight = 25;
            logsDisplay.Location = new Point(74, 140);
            logsDisplay.Name = "logsDisplay";
            logsDisplay.ScrollAlwaysVisible = true;
            logsDisplay.Size = new Size(545, 529);
            logsDisplay.TabIndex = 5;
            logsDisplay.Visible = false;
            // 
            // logsButton
            // 
            logsButton.Location = new Point(279, 57);
            logsButton.Name = "logsButton";
            logsButton.Size = new Size(154, 67);
            logsButton.TabIndex = 4;
            logsButton.Text = "Toggle Logs Details";
            logsButton.UseVisualStyleBackColor = true;
            logsButton.Click += logsButton_Click;
            // 
            // LiftFloors
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1370, 748);
            Controls.Add(userControl11);
            Controls.Add(logsDisplay);
            Controls.Add(logsButton);
            Controls.Add(userControl12);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LiftFloors";
            Text = "Lift System";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Floor1 userControl11;
        private Floor2 userControl12;
        private ListBox logsDisplay;
        private Button logsButton;
    }
}