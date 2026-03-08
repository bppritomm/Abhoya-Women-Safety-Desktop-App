namespace Abhoya
{
    partial class addnewcase
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
            labelcasenumber = new Label();
            labeldate = new Label();
            labelcaseupdate = new Label();
            labelage = new Label();
            labelcasestatus = new Label();
            labeldistict = new Label();
            labelsavecase = new Label();
            labelcancel = new Label();
            textBoxcaseno = new TextBox();
            comboBoxdistrict = new ComboBox();
            comboBoxagegroup = new ComboBox();
            dateTimePickerdate = new DateTimePicker();
            comboBoxcasestatus = new ComboBox();
            textBoxupdate = new TextBox();
            labelcasedetails = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelcasenumber
            // 
            labelcasenumber.AutoSize = true;
            labelcasenumber.Font = new Font("Segoe UI", 12F);
            labelcasenumber.Location = new Point(276, 118);
            labelcasenumber.Name = "labelcasenumber";
            labelcasenumber.RightToLeft = RightToLeft.No;
            labelcasenumber.Size = new Size(138, 28);
            labelcasenumber.TabIndex = 1;
            labelcasenumber.Text = "Case Number :";
            // 
            // labeldate
            // 
            labeldate.AutoSize = true;
            labeldate.Font = new Font("Segoe UI", 12F);
            labeldate.Location = new Point(277, 265);
            labeldate.Name = "labeldate";
            labeldate.RightToLeft = RightToLeft.No;
            labeldate.Size = new Size(137, 28);
            labeldate.TabIndex = 2;
            labeldate.Text = "Incident Date :";
            // 
            // labelcaseupdate
            // 
            labelcaseupdate.AutoSize = true;
            labelcaseupdate.Font = new Font("Segoe UI", 12F);
            labelcaseupdate.Location = new Point(283, 374);
            labelcaseupdate.Name = "labelcaseupdate";
            labelcaseupdate.RightToLeft = RightToLeft.No;
            labelcaseupdate.Size = new Size(131, 28);
            labelcaseupdate.TabIndex = 3;
            labelcaseupdate.Text = "Case Update :";
            // 
            // labelage
            // 
            labelage.AutoSize = true;
            labelage.Font = new Font("Segoe UI", 12F);
            labelage.Location = new Point(237, 213);
            labelage.Name = "labelage";
            labelage.RightToLeft = RightToLeft.No;
            labelage.Size = new Size(177, 28);
            labelage.TabIndex = 4;
            labelage.Text = "Victim Age Group :";
            labelage.Click += labelage_Click;
            // 
            // labelcasestatus
            // 
            labelcasestatus.AutoSize = true;
            labelcasestatus.Font = new Font("Segoe UI", 12F);
            labelcasestatus.Location = new Point(295, 320);
            labelcasestatus.Name = "labelcasestatus";
            labelcasestatus.RightToLeft = RightToLeft.No;
            labelcasestatus.Size = new Size(119, 28);
            labelcasestatus.TabIndex = 5;
            labelcasestatus.Text = "Case Status :";
            labelcasestatus.Click += label4_Click;
            // 
            // labeldistict
            // 
            labeldistict.AutoSize = true;
            labeldistict.Font = new Font("Segoe UI", 12F);
            labeldistict.Location = new Point(331, 166);
            labeldistict.Name = "labeldistict";
            labeldistict.RightToLeft = RightToLeft.No;
            labeldistict.Size = new Size(83, 28);
            labeldistict.TabIndex = 6;
            labeldistict.Text = "Distirct :";
            labeldistict.Click += labeldistict_Click;
            // 
            // labelsavecase
            // 
            labelsavecase.AutoSize = true;
            labelsavecase.BackColor = Color.DarkBlue;
            labelsavecase.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelsavecase.ForeColor = Color.White;
            labelsavecase.Location = new Point(1145, 598);
            labelsavecase.Name = "labelsavecase";
            labelsavecase.Size = new Size(105, 28);
            labelsavecase.TabIndex = 7;
            labelsavecase.Text = "Save Case";
            labelsavecase.Click += labelsavecase_Click;
            // 
            // labelcancel
            // 
            labelcancel.AutoSize = true;
            labelcancel.BackColor = Color.Gray;
            labelcancel.Font = new Font("Segoe UI", 10F);
            labelcancel.ForeColor = Color.White;
            labelcancel.Location = new Point(1166, 636);
            labelcancel.Name = "labelcancel";
            labelcancel.Size = new Size(61, 23);
            labelcancel.TabIndex = 8;
            labelcancel.Text = "Cancel";
            labelcancel.Click += labelcancel_Click;
            // 
            // textBoxcaseno
            // 
            textBoxcaseno.Location = new Point(440, 122);
            textBoxcaseno.Name = "textBoxcaseno";
            textBoxcaseno.Size = new Size(345, 27);
            textBoxcaseno.TabIndex = 9;
            // 
            // comboBoxdistrict
            // 
            comboBoxdistrict.FormattingEnabled = true;
            comboBoxdistrict.Items.AddRange(new object[] { "Dhaka", "Khulna", "Chittagong", "Barishal", "Rajshahi", "Pirojpur", "Feni", "Narsingdi", "Rangpur", "Satkhira", "Jessore" });
            comboBoxdistrict.Location = new Point(440, 170);
            comboBoxdistrict.Name = "comboBoxdistrict";
            comboBoxdistrict.Size = new Size(345, 28);
            comboBoxdistrict.TabIndex = 10;
            // 
            // comboBoxagegroup
            // 
            comboBoxagegroup.FormattingEnabled = true;
            comboBoxagegroup.Items.AddRange(new object[] { "Under 10", "11-18", "19-30", "Above 30" });
            comboBoxagegroup.Location = new Point(440, 217);
            comboBoxagegroup.Name = "comboBoxagegroup";
            comboBoxagegroup.Size = new Size(345, 28);
            comboBoxagegroup.TabIndex = 11;
            // 
            // dateTimePickerdate
            // 
            dateTimePickerdate.Location = new Point(440, 267);
            dateTimePickerdate.Name = "dateTimePickerdate";
            dateTimePickerdate.Size = new Size(345, 27);
            dateTimePickerdate.TabIndex = 12;
            // 
            // comboBoxcasestatus
            // 
            comboBoxcasestatus.AutoCompleteCustomSource.AddRange(new string[] { "Pending", "Investigating", "Resolved" });
            comboBoxcasestatus.FormattingEnabled = true;
            comboBoxcasestatus.Items.AddRange(new object[] { "Pending", "Investigating", "Resolved" });
            comboBoxcasestatus.Location = new Point(440, 324);
            comboBoxcasestatus.Name = "comboBoxcasestatus";
            comboBoxcasestatus.Size = new Size(345, 28);
            comboBoxcasestatus.TabIndex = 13;
            // 
            // textBoxupdate
            // 
            textBoxupdate.Location = new Point(440, 384);
            textBoxupdate.Multiline = true;
            textBoxupdate.Name = "textBoxupdate";
            textBoxupdate.Size = new Size(345, 103);
            textBoxupdate.TabIndex = 14;
            // 
            // labelcasedetails
            // 
            labelcasedetails.AutoSize = true;
            labelcasedetails.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcasedetails.ForeColor = Color.White;
            labelcasedetails.Location = new Point(438, 12);
            labelcasedetails.Name = "labelcasedetails";
            labelcasedetails.Size = new Size(341, 41);
            labelcasedetails.TabIndex = 0;
            labelcasedetails.Text = "Enter New Case Details";
            labelcasedetails.Click += labelcasedetails_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(labelcasedetails);
            panel1.Location = new Point(2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 69);
            panel1.TabIndex = 15;
            // 
            // addnewcase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel1);
            Controls.Add(textBoxupdate);
            Controls.Add(comboBoxcasestatus);
            Controls.Add(dateTimePickerdate);
            Controls.Add(comboBoxagegroup);
            Controls.Add(comboBoxdistrict);
            Controls.Add(textBoxcaseno);
            Controls.Add(labelcancel);
            Controls.Add(labelsavecase);
            Controls.Add(labeldistict);
            Controls.Add(labelcasestatus);
            Controls.Add(labelage);
            Controls.Add(labelcaseupdate);
            Controls.Add(labeldate);
            Controls.Add(labelcasenumber);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "addnewcase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addnewcase";
            Load += addnewcase_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelcasenumber;
        private Label labeldate;
        private Label labelcaseupdate;
        private Label labelage;
        private Label labelcasestatus;
        private Label labeldistict;
        private Label labelsavecase;
        private Label labelcancel;
        private TextBox textBoxcaseno;
        private ComboBox comboBoxdistrict;
        private ComboBox comboBoxagegroup;
        private DateTimePicker dateTimePickerdate;
        private ComboBox comboBoxcasestatus;
        private TextBox textBoxupdate;
        private Label labelcasedetails;
        private Panel panel1;
    }
}