namespace Abhoya
{
    partial class Updatecase
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
            labelupdatecase = new Label();
            label2 = new Label();
            labelsearch = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelupdatecase
            // 
            labelupdatecase.AutoSize = true;
            labelupdatecase.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelupdatecase.ForeColor = Color.White;
            labelupdatecase.Location = new Point(325, 9);
            labelupdatecase.Name = "labelupdatecase";
            labelupdatecase.Size = new Size(162, 35);
            labelupdatecase.TabIndex = 0;
            labelupdatecase.Text = "Update Case";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(396, 237);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // labelsearch
            // 
            labelsearch.AutoSize = true;
            labelsearch.Location = new Point(520, 76);
            labelsearch.Name = "labelsearch";
            labelsearch.Size = new Size(53, 20);
            labelsearch.TabIndex = 2;
            labelsearch.Text = "Search";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(labelupdatecase);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 55);
            panel1.TabIndex = 3;
            // 
            // Updatecase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 495);
            Controls.Add(panel1);
            Controls.Add(labelsearch);
            Controls.Add(label2);
            Name = "Updatecase";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelupdatecase;
        private Label label2;
        private Label labelsearch;
        private Panel panel1;
    }
}