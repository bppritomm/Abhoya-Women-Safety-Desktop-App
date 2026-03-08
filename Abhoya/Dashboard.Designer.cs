namespace Abhoya
{
    partial class Dashboard
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
            labellogout = new Label();
            dataGridView1 = new DataGridView();
            labelresolvedcase = new Label();
            labelhighriskzones = new Label();
            labeltotalcase = new Label();
            labeladdnew = new Label();
            labelsearchcaseid = new Label();
            textcaseid = new TextBox();
            labelsearch = new Label();
            label1 = new Label();
            labelupdatecase = new Label();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labellogout
            // 
            labellogout.Anchor = AnchorStyles.None;
            labellogout.AutoSize = true;
            labellogout.BackColor = Color.Tomato;
            labellogout.FlatStyle = FlatStyle.Flat;
            labellogout.ForeColor = Color.White;
            labellogout.Location = new Point(1194, 19);
            labellogout.Name = "labellogout";
            labellogout.Size = new Size(56, 20);
            labellogout.TabIndex = 0;
            labellogout.Text = "Logout";
            labellogout.Click += labellogout_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 206);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1263, 403);
            dataGridView1.TabIndex = 2;
            // 
            // labelresolvedcase
            // 
            labelresolvedcase.Anchor = AnchorStyles.None;
            labelresolvedcase.BackColor = Color.SeaGreen;
            labelresolvedcase.Font = new Font("Segoe UI", 15F);
            labelresolvedcase.ForeColor = Color.White;
            labelresolvedcase.Location = new Point(487, 95);
            labelresolvedcase.Name = "labelresolvedcase";
            labelresolvedcase.Size = new Size(270, 42);
            labelresolvedcase.TabIndex = 5;
            labelresolvedcase.Text = "Resolved Cases : 0";
            labelresolvedcase.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelhighriskzones
            // 
            labelhighriskzones.Anchor = AnchorStyles.None;
            labelhighriskzones.BackColor = Color.Red;
            labelhighriskzones.Font = new Font("Segoe UI", 15F);
            labelhighriskzones.ForeColor = Color.White;
            labelhighriskzones.Location = new Point(948, 95);
            labelhighriskzones.Name = "labelhighriskzones";
            labelhighriskzones.Size = new Size(270, 42);
            labelhighriskzones.TabIndex = 6;
            labelhighriskzones.Text = "High Risk Zones ";
            labelhighriskzones.TextAlign = ContentAlignment.MiddleCenter;
            labelhighriskzones.Click += labelhighriskzones_Click;
            // 
            // labeltotalcase
            // 
            labeltotalcase.Anchor = AnchorStyles.None;
            labeltotalcase.BackColor = Color.MidnightBlue;
            labeltotalcase.Font = new Font("Segoe UI", 15F);
            labeltotalcase.ForeColor = Color.White;
            labeltotalcase.Location = new Point(43, 95);
            labeltotalcase.Name = "labeltotalcase";
            labeltotalcase.Size = new Size(270, 42);
            labeltotalcase.TabIndex = 7;
            labeltotalcase.Text = "Total Cases : 0";
            labeltotalcase.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labeladdnew
            // 
            labeladdnew.Anchor = AnchorStyles.None;
            labeladdnew.BackColor = Color.Teal;
            labeladdnew.FlatStyle = FlatStyle.Flat;
            labeladdnew.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeladdnew.ForeColor = Color.White;
            labeladdnew.Location = new Point(534, 624);
            labeladdnew.Name = "labeladdnew";
            labeladdnew.Size = new Size(186, 29);
            labeladdnew.TabIndex = 8;
            labeladdnew.Text = "➕ Add New Case";
            labeladdnew.TextAlign = ContentAlignment.MiddleCenter;
            labeladdnew.Click += labeladdnew_Click;
            // 
            // labelsearchcaseid
            // 
            labelsearchcaseid.Anchor = AnchorStyles.None;
            labelsearchcaseid.AutoSize = true;
            labelsearchcaseid.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelsearchcaseid.ForeColor = Color.SlateGray;
            labelsearchcaseid.Location = new Point(780, 173);
            labelsearchcaseid.Name = "labelsearchcaseid";
            labelsearchcaseid.Size = new Size(137, 23);
            labelsearchcaseid.TabIndex = 9;
            labelsearchcaseid.Text = "Search Case ID :";
            // 
            // textcaseid
            // 
            textcaseid.Anchor = AnchorStyles.None;
            textcaseid.BorderStyle = BorderStyle.FixedSingle;
            textcaseid.Location = new Point(934, 173);
            textcaseid.Name = "textcaseid";
            textcaseid.Size = new Size(225, 27);
            textcaseid.TabIndex = 10;
            // 
            // labelsearch
            // 
            labelsearch.Anchor = AnchorStyles.Right;
            labelsearch.AutoSize = true;
            labelsearch.BackColor = Color.MidnightBlue;
            labelsearch.FlatStyle = FlatStyle.Flat;
            labelsearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelsearch.ForeColor = Color.White;
            labelsearch.Location = new Point(1188, 173);
            labelsearch.Name = "labelsearch";
            labelsearch.Size = new Size(63, 23);
            labelsearch.TabIndex = 11;
            labelsearch.Text = "Search";
            labelsearch.Click += labelsearch_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Red;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(992, 624);
            label1.Name = "label1";
            label1.Size = new Size(226, 38);
            label1.TabIndex = 12;
            label1.Text = "Ask for Help?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // labelupdatecase
            // 
            labelupdatecase.BackColor = Color.DarkBlue;
            labelupdatecase.FlatStyle = FlatStyle.Flat;
            labelupdatecase.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelupdatecase.ForeColor = Color.White;
            labelupdatecase.Location = new Point(75, 626);
            labelupdatecase.Name = "labelupdatecase";
            labelupdatecase.Size = new Size(186, 29);
            labelupdatecase.TabIndex = 13;
            labelupdatecase.Text = "✏️ Update Case";
            labelupdatecase.TextAlign = ContentAlignment.MiddleCenter;
            labelupdatecase.Click += labelupdatecase_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labellogout);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1263, 74);
            panel1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(549, 21);
            label2.Name = "label2";
            label2.Size = new Size(171, 35);
            label2.TabIndex = 0;
            label2.Text = "DASHBOARD";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel1);
            Controls.Add(labelupdatecase);
            Controls.Add(label1);
            Controls.Add(labelsearch);
            Controls.Add(textcaseid);
            Controls.Add(labelsearchcaseid);
            Controls.Add(labeladdnew);
            Controls.Add(labeltotalcase);
            Controls.Add(labelhighriskzones);
            Controls.Add(labelresolvedcase);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            FormClosed += Dashboard_FormClosed;
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labellogout;
        private DataGridView dataGridView1;
        private Label labelresolvedcase;
        private Label labelhighriskzones;
        private Label labeltotalcase;
        private Label labeladdnew;
        private Label labelsearchcaseid;
        private TextBox textcaseid;
        private Label labelsearch;
        private Label label1;
        private Label labelupdatecase;
        private Panel panel1;
        private Label label2;
    }
}