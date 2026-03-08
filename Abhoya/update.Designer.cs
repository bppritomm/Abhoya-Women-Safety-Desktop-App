namespace Abhoya
{
    partial class update
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
            panel1 = new Panel();
            label1 = new Label();
            txtCaseId = new TextBox();
            btnSearch = new Label();
            btnUpdate = new Label();
            txtRemark = new TextBox();
            comboStatus = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 63);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(534, 17);
            label1.Name = "label1";
            label1.Size = new Size(178, 35);
            label1.TabIndex = 0;
            label1.Text = "UPDATE CASE";
            // 
            // txtCaseId
            // 
            txtCaseId.Location = new Point(478, 127);
            txtCaseId.Name = "txtCaseId";
            txtCaseId.PlaceholderText = "Case ID";
            txtCaseId.Size = new Size(292, 27);
            txtCaseId.TabIndex = 1;
            txtCaseId.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.RoyalBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(818, 127);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 28);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = Color.ForestGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(575, 435);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 31);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtRemark
            // 
            txtRemark.Location = new Point(478, 314);
            txtRemark.Multiline = true;
            txtRemark.Name = "txtRemark";
            txtRemark.PlaceholderText = "Remark";
            txtRemark.Size = new Size(292, 80);
            txtRemark.TabIndex = 4;
            txtRemark.TextAlign = HorizontalAlignment.Center;
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "Pending", "Investigating", "Resolved" });
            comboStatus.Location = new Point(478, 244);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(292, 28);
            comboStatus.TabIndex = 5;
            comboStatus.Text = "Select Status";
            // 
            // update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(comboStatus);
            Controls.Add(txtRemark);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(txtCaseId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "update";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "update";
            Load += update_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtCaseId;
        private Label btnSearch;
        private Label btnUpdate;
        private TextBox txtRemark;
        private ComboBox comboStatus;
    }
}