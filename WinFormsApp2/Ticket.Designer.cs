namespace ParkingTicketSimulator
{
    partial class Ticket
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            carInfoBox = new GroupBox();
            licenseTextBox = new TextBox();
            licenseLabel = new Label();
            colorTextBox = new TextBox();
            colorLabel = new Label();
            modelTextBox = new TextBox();
            modelLabel = new Label();
            makeTextBox = new TextBox();
            makeLabel = new Label();
            officerBox = new GroupBox();
            badgeTextBox = new TextBox();
            badgeLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            violationBox = new GroupBox();
            fineTextBox = new TextBox();
            fineLabel = new Label();
            parkedTextBox = new TextBox();
            parkedLabel = new Label();
            purchaseTextBox = new TextBox();
            purchaseLabel = new Label();
            closeButton = new Button();
            carInfoBox.SuspendLayout();
            officerBox.SuspendLayout();
            violationBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 0;
            label1.Text = "Parking Ticket";
            // 
            // carInfoBox
            // 
            carInfoBox.Controls.Add(licenseTextBox);
            carInfoBox.Controls.Add(licenseLabel);
            carInfoBox.Controls.Add(colorTextBox);
            carInfoBox.Controls.Add(colorLabel);
            carInfoBox.Controls.Add(modelTextBox);
            carInfoBox.Controls.Add(modelLabel);
            carInfoBox.Controls.Add(makeTextBox);
            carInfoBox.Controls.Add(makeLabel);
            carInfoBox.Location = new Point(12, 46);
            carInfoBox.Name = "carInfoBox";
            carInfoBox.Size = new Size(275, 144);
            carInfoBox.TabIndex = 1;
            carInfoBox.TabStop = false;
            carInfoBox.Text = "Issued For This Car";
            // 
            // licenseTextBox
            // 
            licenseTextBox.Enabled = false;
            licenseTextBox.Location = new Point(65, 109);
            licenseTextBox.Name = "licenseTextBox";
            licenseTextBox.Size = new Size(198, 23);
            licenseTextBox.TabIndex = 7;
            // 
            // licenseLabel
            // 
            licenseLabel.AutoSize = true;
            licenseLabel.Location = new Point(10, 112);
            licenseLabel.Name = "licenseLabel";
            licenseLabel.Size = new Size(49, 15);
            licenseLabel.TabIndex = 6;
            licenseLabel.Text = "License:";
            // 
            // colorTextBox
            // 
            colorTextBox.Enabled = false;
            colorTextBox.Location = new Point(65, 80);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(198, 23);
            colorTextBox.TabIndex = 5;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(20, 83);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(39, 15);
            colorLabel.TabIndex = 4;
            colorLabel.Text = "Color:";
            // 
            // modelTextBox
            // 
            modelTextBox.Enabled = false;
            modelTextBox.Location = new Point(65, 51);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(198, 23);
            modelTextBox.TabIndex = 3;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(15, 54);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(44, 15);
            modelLabel.TabIndex = 2;
            modelLabel.Text = "Model:";
            // 
            // makeTextBox
            // 
            makeTextBox.Enabled = false;
            makeTextBox.Location = new Point(65, 22);
            makeTextBox.Name = "makeTextBox";
            makeTextBox.Size = new Size(198, 23);
            makeTextBox.TabIndex = 1;
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new Point(20, 25);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(39, 15);
            makeLabel.TabIndex = 0;
            makeLabel.Text = "Make:";
            // 
            // officerBox
            // 
            officerBox.Controls.Add(badgeTextBox);
            officerBox.Controls.Add(badgeLabel);
            officerBox.Controls.Add(nameTextBox);
            officerBox.Controls.Add(nameLabel);
            officerBox.Location = new Point(12, 196);
            officerBox.Name = "officerBox";
            officerBox.Size = new Size(275, 84);
            officerBox.TabIndex = 2;
            officerBox.TabStop = false;
            officerBox.Text = "Issuing Officer";
            // 
            // badgeTextBox
            // 
            badgeTextBox.Enabled = false;
            badgeTextBox.Location = new Point(109, 51);
            badgeTextBox.Name = "badgeTextBox";
            badgeTextBox.Size = new Size(154, 23);
            badgeTextBox.TabIndex = 11;
            // 
            // badgeLabel
            // 
            badgeLabel.AutoSize = true;
            badgeLabel.Location = new Point(15, 54);
            badgeLabel.Name = "badgeLabel";
            badgeLabel.Size = new Size(90, 15);
            badgeLabel.TabIndex = 10;
            badgeLabel.Text = "Badge Number:";
            // 
            // nameTextBox
            // 
            nameTextBox.Enabled = false;
            nameTextBox.Location = new Point(109, 22);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(154, 23);
            nameTextBox.TabIndex = 9;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(61, 25);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // violationBox
            // 
            violationBox.Controls.Add(fineTextBox);
            violationBox.Controls.Add(fineLabel);
            violationBox.Controls.Add(parkedTextBox);
            violationBox.Controls.Add(parkedLabel);
            violationBox.Controls.Add(purchaseTextBox);
            violationBox.Controls.Add(purchaseLabel);
            violationBox.Location = new Point(12, 286);
            violationBox.Name = "violationBox";
            violationBox.Size = new Size(275, 121);
            violationBox.TabIndex = 3;
            violationBox.TabStop = false;
            violationBox.Text = "Violation Info";
            // 
            // fineTextBox
            // 
            fineTextBox.Enabled = false;
            fineTextBox.Location = new Point(155, 80);
            fineTextBox.Name = "fineTextBox";
            fineTextBox.Size = new Size(108, 23);
            fineTextBox.TabIndex = 17;
            // 
            // fineLabel
            // 
            fineLabel.AutoSize = true;
            fineLabel.Location = new Point(117, 83);
            fineLabel.Name = "fineLabel";
            fineLabel.Size = new Size(32, 15);
            fineLabel.TabIndex = 16;
            fineLabel.Text = "Fine:";
            // 
            // parkedTextBox
            // 
            parkedTextBox.Enabled = false;
            parkedTextBox.Location = new Point(155, 51);
            parkedTextBox.Name = "parkedTextBox";
            parkedTextBox.Size = new Size(108, 23);
            parkedTextBox.TabIndex = 15;
            // 
            // parkedLabel
            // 
            parkedLabel.AutoSize = true;
            parkedLabel.Location = new Point(57, 54);
            parkedLabel.Name = "parkedLabel";
            parkedLabel.Size = new Size(92, 15);
            parkedLabel.TabIndex = 14;
            parkedLabel.Text = "Minutes Parked:";
            // 
            // purchaseTextBox
            // 
            purchaseTextBox.Enabled = false;
            purchaseTextBox.Location = new Point(155, 22);
            purchaseTextBox.Name = "purchaseTextBox";
            purchaseTextBox.Size = new Size(108, 23);
            purchaseTextBox.TabIndex = 13;
            // 
            // purchaseLabel
            // 
            purchaseLabel.AutoSize = true;
            purchaseLabel.Location = new Point(38, 25);
            purchaseLabel.Name = "purchaseLabel";
            purchaseLabel.Size = new Size(111, 15);
            purchaseLabel.TabIndex = 12;
            purchaseLabel.Text = "Minutes Purchased:";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(107, 415);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 4;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 450);
            Controls.Add(closeButton);
            Controls.Add(violationBox);
            Controls.Add(officerBox);
            Controls.Add(carInfoBox);
            Controls.Add(label1);
            Name = "Ticket";
            Text = "Parking Ticket";
            carInfoBox.ResumeLayout(false);
            carInfoBox.PerformLayout();
            officerBox.ResumeLayout(false);
            officerBox.PerformLayout();
            violationBox.ResumeLayout(false);
            violationBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox carInfoBox;
        private Label licenseLabel;
        private Label colorLabel;
        private Label modelLabel;
        private Label makeLabel;
        private GroupBox officerBox;
        private Label badgeLabel;
        private Label nameLabel;
        private GroupBox violationBox;
        private Label fineLabel;
        private Label parkedLabel;
        private Label purchaseLabel;
        private Button closeButton;
        public TextBox licenseTextBox;
        public TextBox colorTextBox;
        public TextBox modelTextBox;
        public TextBox makeTextBox;
        public TextBox badgeTextBox;
        public TextBox nameTextBox;
        public TextBox fineTextBox;
        public TextBox parkedTextBox;
        public TextBox purchaseTextBox;
    }
}