namespace WinFormsApp2
{
    partial class Main
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
            carInfoBox = new GroupBox();
            licenseLabel = new Label();
            colorLabel = new Label();
            modelLabel = new Label();
            makeLabel = new Label();
            licenseTextBox = new TextBox();
            colorTextBox = new TextBox();
            modelTextBox = new TextBox();
            makeTextBox = new TextBox();
            policeOfficerBox = new GroupBox();
            badgeNumberValue = new NumericUpDown();
            badgeLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            parkingInfoBox = new GroupBox();
            minutesPurchasedValue = new NumericUpDown();
            minutesParkedValue = new NumericUpDown();
            parkedLabel = new Label();
            purchasedLabel = new Label();
            checkButton = new Button();
            carInfoBox.SuspendLayout();
            policeOfficerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)badgeNumberValue).BeginInit();
            parkingInfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minutesPurchasedValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minutesParkedValue).BeginInit();
            SuspendLayout();
            // 
            // carInfoBox
            // 
            carInfoBox.Controls.Add(licenseLabel);
            carInfoBox.Controls.Add(colorLabel);
            carInfoBox.Controls.Add(modelLabel);
            carInfoBox.Controls.Add(makeLabel);
            carInfoBox.Controls.Add(licenseTextBox);
            carInfoBox.Controls.Add(colorTextBox);
            carInfoBox.Controls.Add(modelTextBox);
            carInfoBox.Controls.Add(makeTextBox);
            carInfoBox.Location = new Point(12, 12);
            carInfoBox.Name = "carInfoBox";
            carInfoBox.Size = new Size(209, 146);
            carInfoBox.TabIndex = 0;
            carInfoBox.TabStop = false;
            carInfoBox.Text = "Car Info";
            // 
            // licenseLabel
            // 
            licenseLabel.AutoSize = true;
            licenseLabel.Location = new Point(23, 112);
            licenseLabel.Name = "licenseLabel";
            licenseLabel.Size = new Size(49, 15);
            licenseLabel.TabIndex = 7;
            licenseLabel.Text = "License:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(32, 83);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(39, 15);
            colorLabel.TabIndex = 6;
            colorLabel.Text = "Color:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(27, 54);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(44, 15);
            modelLabel.TabIndex = 5;
            modelLabel.Text = "Model:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new Point(33, 25);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(39, 15);
            makeLabel.TabIndex = 4;
            makeLabel.Text = "Make:";
            // 
            // licenseTextBox
            // 
            licenseTextBox.Location = new Point(77, 109);
            licenseTextBox.Name = "licenseTextBox";
            licenseTextBox.Size = new Size(126, 23);
            licenseTextBox.TabIndex = 3;
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(77, 80);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(126, 23);
            colorTextBox.TabIndex = 2;
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(77, 51);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(126, 23);
            modelTextBox.TabIndex = 1;
            // 
            // makeTextBox
            // 
            makeTextBox.Location = new Point(77, 22);
            makeTextBox.Name = "makeTextBox";
            makeTextBox.Size = new Size(126, 23);
            makeTextBox.TabIndex = 0;
            // 
            // policeOfficerBox
            // 
            policeOfficerBox.Controls.Add(badgeNumberValue);
            policeOfficerBox.Controls.Add(badgeLabel);
            policeOfficerBox.Controls.Add(nameLabel);
            policeOfficerBox.Controls.Add(nameTextBox);
            policeOfficerBox.Location = new Point(227, 12);
            policeOfficerBox.Name = "policeOfficerBox";
            policeOfficerBox.Size = new Size(236, 146);
            policeOfficerBox.TabIndex = 1;
            policeOfficerBox.TabStop = false;
            policeOfficerBox.Text = "Police Officer Info";
            // 
            // badgeNumberValue
            // 
            badgeNumberValue.Location = new Point(100, 80);
            badgeNumberValue.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            badgeNumberValue.Name = "badgeNumberValue";
            badgeNumberValue.Size = new Size(126, 23);
            badgeNumberValue.TabIndex = 17;
            // 
            // badgeLabel
            // 
            badgeLabel.AutoSize = true;
            badgeLabel.Location = new Point(6, 83);
            badgeLabel.Name = "badgeLabel";
            badgeLabel.Size = new Size(90, 15);
            badgeLabel.TabIndex = 11;
            badgeLabel.Text = "Badge Number:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(56, 54);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(100, 51);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(126, 23);
            nameTextBox.TabIndex = 8;
            // 
            // parkingInfoBox
            // 
            parkingInfoBox.Controls.Add(minutesPurchasedValue);
            parkingInfoBox.Controls.Add(minutesParkedValue);
            parkingInfoBox.Controls.Add(parkedLabel);
            parkingInfoBox.Controls.Add(purchasedLabel);
            parkingInfoBox.Location = new Point(12, 164);
            parkingInfoBox.Name = "parkingInfoBox";
            parkingInfoBox.Size = new Size(451, 100);
            parkingInfoBox.TabIndex = 2;
            parkingInfoBox.TabStop = false;
            parkingInfoBox.Text = "Parking Info";
            // 
            // minutesPurchasedValue
            // 
            minutesPurchasedValue.Location = new Point(221, 23);
            minutesPurchasedValue.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            minutesPurchasedValue.Name = "minutesPurchasedValue";
            minutesPurchasedValue.Size = new Size(120, 23);
            minutesPurchasedValue.TabIndex = 16;
            // 
            // minutesParkedValue
            // 
            minutesParkedValue.Location = new Point(221, 52);
            minutesParkedValue.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            minutesParkedValue.Name = "minutesParkedValue";
            minutesParkedValue.Size = new Size(120, 23);
            minutesParkedValue.TabIndex = 15;
            // 
            // parkedLabel
            // 
            parkedLabel.AutoSize = true;
            parkedLabel.Location = new Point(123, 54);
            parkedLabel.Name = "parkedLabel";
            parkedLabel.Size = new Size(92, 15);
            parkedLabel.TabIndex = 14;
            parkedLabel.Text = "Minutes Parked:";
            // 
            // purchasedLabel
            // 
            purchasedLabel.AutoSize = true;
            purchasedLabel.Location = new Point(104, 25);
            purchasedLabel.Name = "purchasedLabel";
            purchasedLabel.Size = new Size(111, 15);
            purchasedLabel.TabIndex = 12;
            purchasedLabel.Text = "Minutes Purchased:";
            // 
            // checkButton
            // 
            checkButton.Location = new Point(135, 286);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(217, 23);
            checkButton.TabIndex = 3;
            checkButton.Text = "Check This Car For a Parking Violation";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 327);
            Controls.Add(checkButton);
            Controls.Add(parkingInfoBox);
            Controls.Add(policeOfficerBox);
            Controls.Add(carInfoBox);
            Name = "Main";
            Text = "Parking Ticket Simulator";
            carInfoBox.ResumeLayout(false);
            carInfoBox.PerformLayout();
            policeOfficerBox.ResumeLayout(false);
            policeOfficerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)badgeNumberValue).EndInit();
            parkingInfoBox.ResumeLayout(false);
            parkingInfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minutesPurchasedValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)minutesParkedValue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox carInfoBox;
        private GroupBox policeOfficerBox;
        private Label licenseLabel;
        private Label colorLabel;
        private Label modelLabel;
        private Label makeLabel;
        private TextBox licenseTextBox;
        private TextBox colorTextBox;
        private TextBox modelTextBox;
        private TextBox makeTextBox;
        private Label badgeLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private GroupBox parkingInfoBox;
        private NumericUpDown badgeNumberValue;
        private NumericUpDown minutesPurchasedValue;
        private NumericUpDown minutesParkedValue;
        private Label parkedLabel;
        private Label purchasedLabel;
        public Button checkButton;
    }
}
