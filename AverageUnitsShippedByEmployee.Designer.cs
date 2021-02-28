
namespace AverageUnitsShippedByEmployee
{
    partial class AverageUnitsShippedByEmployee
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
            this.components = new System.ComponentModel.Container();
            this.labelDay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUnitsInput = new System.Windows.Forms.TextBox();
            this.labelEmployee1 = new System.Windows.Forms.Label();
            this.textBoxEmployee1PastInputs = new System.Windows.Forms.TextBox();
            this.labelEmployee1AverageOutput = new System.Windows.Forms.Label();
            this.labelEmployee2 = new System.Windows.Forms.Label();
            this.textBoxEmployee2PastInputs = new System.Windows.Forms.TextBox();
            this.labelEmployee2AverageOutput = new System.Windows.Forms.Label();
            this.labelEmployee3 = new System.Windows.Forms.Label();
            this.textBoxEmployee3PastInputs = new System.Windows.Forms.TextBox();
            this.labelOverallAverageOutput = new System.Windows.Forms.Label();
            this.buttonToEnter = new System.Windows.Forms.Button();
            this.buttontoReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelEmployee3AverageOutput = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(26, 25);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(68, 29);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "Day 1";
            this.toolTip1.SetToolTip(this.labelDay, "Shipment Days ");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Units: ";
            this.toolTip1.SetToolTip(this.label1, "Units");
            // 
            // textBoxUnitsInput
            // 
            this.textBoxUnitsInput.Location = new System.Drawing.Point(90, 69);
            this.textBoxUnitsInput.Name = "textBoxUnitsInput";
            this.textBoxUnitsInput.Size = new System.Drawing.Size(86, 31);
            this.textBoxUnitsInput.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxUnitsInput, "Enter your unit");
            // 
            // labelEmployee1
            // 
            this.labelEmployee1.Location = new System.Drawing.Point(47, 112);
            this.labelEmployee1.Name = "labelEmployee1";
            this.labelEmployee1.Size = new System.Drawing.Size(117, 32);
            this.labelEmployee1.TabIndex = 3;
            this.labelEmployee1.Text = "Employee &1";
            this.labelEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEmployee1PastInputs
            // 
            this.textBoxEmployee1PastInputs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxEmployee1PastInputs.Location = new System.Drawing.Point(26, 147);
            this.textBoxEmployee1PastInputs.Multiline = true;
            this.textBoxEmployee1PastInputs.Name = "textBoxEmployee1PastInputs";
            this.textBoxEmployee1PastInputs.ReadOnly = true;
            this.textBoxEmployee1PastInputs.Size = new System.Drawing.Size(199, 178);
            this.textBoxEmployee1PastInputs.TabIndex = 4;
            // 
            // labelEmployee1AverageOutput
            // 
            this.labelEmployee1AverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployee1AverageOutput.Location = new System.Drawing.Point(26, 337);
            this.labelEmployee1AverageOutput.Name = "labelEmployee1AverageOutput";
            this.labelEmployee1AverageOutput.Size = new System.Drawing.Size(199, 38);
            this.labelEmployee1AverageOutput.TabIndex = 5;
            this.labelEmployee1AverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelEmployee1AverageOutput, "Average for Employee 1");
            // 
            // labelEmployee2
            // 
            this.labelEmployee2.Location = new System.Drawing.Point(287, 111);
            this.labelEmployee2.Name = "labelEmployee2";
            this.labelEmployee2.Size = new System.Drawing.Size(117, 32);
            this.labelEmployee2.TabIndex = 6;
            this.labelEmployee2.Text = "Employee &2";
            this.labelEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEmployee2PastInputs
            // 
            this.textBoxEmployee2PastInputs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxEmployee2PastInputs.Location = new System.Drawing.Point(246, 147);
            this.textBoxEmployee2PastInputs.Multiline = true;
            this.textBoxEmployee2PastInputs.Name = "textBoxEmployee2PastInputs";
            this.textBoxEmployee2PastInputs.ReadOnly = true;
            this.textBoxEmployee2PastInputs.Size = new System.Drawing.Size(199, 178);
            this.textBoxEmployee2PastInputs.TabIndex = 7;
            // 
            // labelEmployee2AverageOutput
            // 
            this.labelEmployee2AverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployee2AverageOutput.Location = new System.Drawing.Point(246, 337);
            this.labelEmployee2AverageOutput.Name = "labelEmployee2AverageOutput";
            this.labelEmployee2AverageOutput.Size = new System.Drawing.Size(199, 38);
            this.labelEmployee2AverageOutput.TabIndex = 8;
            this.labelEmployee2AverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelEmployee2AverageOutput, "Average for Employee 2");
            // 
            // labelEmployee3
            // 
            this.labelEmployee3.Location = new System.Drawing.Point(515, 111);
            this.labelEmployee3.Name = "labelEmployee3";
            this.labelEmployee3.Size = new System.Drawing.Size(117, 32);
            this.labelEmployee3.TabIndex = 9;
            this.labelEmployee3.Text = "Employee &3";
            this.labelEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEmployee3PastInputs
            // 
            this.textBoxEmployee3PastInputs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxEmployee3PastInputs.Location = new System.Drawing.Point(464, 146);
            this.textBoxEmployee3PastInputs.Multiline = true;
            this.textBoxEmployee3PastInputs.Name = "textBoxEmployee3PastInputs";
            this.textBoxEmployee3PastInputs.ReadOnly = true;
            this.textBoxEmployee3PastInputs.Size = new System.Drawing.Size(199, 178);
            this.textBoxEmployee3PastInputs.TabIndex = 10;
            // 
            // labelOverallAverageOutput
            // 
            this.labelOverallAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOverallAverageOutput.Location = new System.Drawing.Point(26, 395);
            this.labelOverallAverageOutput.Name = "labelOverallAverageOutput";
            this.labelOverallAverageOutput.Size = new System.Drawing.Size(635, 38);
            this.labelOverallAverageOutput.TabIndex = 12;
            this.labelOverallAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonToEnter
            // 
            this.buttonToEnter.Location = new System.Drawing.Point(26, 447);
            this.buttonToEnter.Name = "buttonToEnter";
            this.buttonToEnter.Size = new System.Drawing.Size(150, 38);
            this.buttonToEnter.TabIndex = 13;
            this.buttonToEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonToEnter, "Press enter for functionalility ");
            this.buttonToEnter.UseVisualStyleBackColor = true;
            this.buttonToEnter.Click += new System.EventHandler(this.ButtonToEnterClick);
            // 
            // buttontoReset
            // 
            this.buttontoReset.Location = new System.Drawing.Point(219, 449);
            this.buttontoReset.Name = "buttontoReset";
            this.buttontoReset.Size = new System.Drawing.Size(175, 36);
            this.buttontoReset.TabIndex = 16;
            this.buttontoReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttontoReset, "Please Press Reset to clear the form");
            this.buttontoReset.UseVisualStyleBackColor = true;
            this.buttontoReset.Click += new System.EventHandler(this.ButtonToResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(416, 447);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(174, 38);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.buttonExit, "Press exit to Quit the application.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonToExitClick);
            // 
            // labelEmployee3AverageOutput
            // 
            this.labelEmployee3AverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployee3AverageOutput.Location = new System.Drawing.Point(462, 337);
            this.labelEmployee3AverageOutput.Name = "labelEmployee3AverageOutput";
            this.labelEmployee3AverageOutput.Size = new System.Drawing.Size(199, 38);
            this.labelEmployee3AverageOutput.TabIndex = 18;
            this.labelEmployee3AverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelEmployee3AverageOutput, "Average for employee 3");
            // 
            // AverageUnitsShippedByEmployee
            // 
            this.AcceptButton = this.buttonToEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttontoReset;
            this.ClientSize = new System.Drawing.Size(675, 507);
            this.Controls.Add(this.labelEmployee3AverageOutput);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttontoReset);
            this.Controls.Add(this.buttonToEnter);
            this.Controls.Add(this.labelOverallAverageOutput);
            this.Controls.Add(this.textBoxEmployee3PastInputs);
            this.Controls.Add(this.labelEmployee3);
            this.Controls.Add(this.labelEmployee2AverageOutput);
            this.Controls.Add(this.textBoxEmployee2PastInputs);
            this.Controls.Add(this.labelEmployee2);
            this.Controls.Add(this.labelEmployee1AverageOutput);
            this.Controls.Add(this.textBoxEmployee1PastInputs);
            this.Controls.Add(this.labelEmployee1);
            this.Controls.Add(this.textBoxUnitsInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AverageUnitsShippedByEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped By Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUnitsInput;
        private System.Windows.Forms.Label labelEmployee1;
        private System.Windows.Forms.TextBox textBoxEmployee1PastInputs;
        private System.Windows.Forms.Label labelEmployee1AverageOutput;
        private System.Windows.Forms.Label labelEmployee2;
        private System.Windows.Forms.TextBox textBoxEmployee2PastInputs;
        private System.Windows.Forms.Label labelEmployee2AverageOutput;
        private System.Windows.Forms.Label labelEmployee3;
        private System.Windows.Forms.TextBox textBoxEmployee3PastInputs;
        private System.Windows.Forms.Label labelOverallAverageOutput;
        private System.Windows.Forms.Button buttonToEnter;
        private System.Windows.Forms.Button buttontoReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelEmployee3AverageOutput;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

