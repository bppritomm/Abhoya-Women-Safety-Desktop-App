namespace Abhoya
{
    partial class Login_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Screen));
            labelusername = new Label();
            textBoxusername = new TextBox();
            textBoxpassword = new TextBox();
            labelpassword = new Label();
            labellogin = new Label();
            labelpublic = new Label();
            pictureBoxlogo = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).BeginInit();
            SuspendLayout();
            // 
            // labelusername
            // 
            labelusername.Anchor = AnchorStyles.Top;
            labelusername.AutoSize = true;
            labelusername.Location = new Point(407, 377);
            labelusername.Name = "labelusername";
            labelusername.Size = new Size(78, 20);
            labelusername.TabIndex = 1;
            labelusername.Text = "Username:";
            // 
            // textBoxusername
            // 
            textBoxusername.Anchor = AnchorStyles.Top;
            textBoxusername.Location = new Point(496, 370);
            textBoxusername.Name = "textBoxusername";
            textBoxusername.Size = new Size(282, 27);
            textBoxusername.TabIndex = 2;
            // 
            // textBoxpassword
            // 
            textBoxpassword.Anchor = AnchorStyles.Top;
            textBoxpassword.Location = new Point(496, 433);
            textBoxpassword.Name = "textBoxpassword";
            textBoxpassword.PasswordChar = '*';
            textBoxpassword.Size = new Size(282, 27);
            textBoxpassword.TabIndex = 4;
            textBoxpassword.UseSystemPasswordChar = true;
            // 
            // labelpassword
            // 
            labelpassword.Anchor = AnchorStyles.Top;
            labelpassword.AutoSize = true;
            labelpassword.Location = new Point(415, 433);
            labelpassword.Name = "labelpassword";
            labelpassword.Size = new Size(73, 20);
            labelpassword.TabIndex = 3;
            labelpassword.Text = "Password:";
            // 
            // labellogin
            // 
            labellogin.Anchor = AnchorStyles.Top;
            labellogin.BackColor = SystemColors.MenuHighlight;
            labellogin.FlatStyle = FlatStyle.Flat;
            labellogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labellogin.ForeColor = SystemColors.ButtonFace;
            labellogin.Location = new Point(565, 489);
            labellogin.Name = "labellogin";
            labellogin.Size = new Size(93, 33);
            labellogin.TabIndex = 5;
            labellogin.Text = "Login";
            labellogin.TextAlign = ContentAlignment.MiddleCenter;
            labellogin.Click += labellogin_Click;
            // 
            // labelpublic
            // 
            labelpublic.Anchor = AnchorStyles.Top;
            labelpublic.BackColor = Color.Transparent;
            labelpublic.BorderStyle = BorderStyle.FixedSingle;
            labelpublic.FlatStyle = FlatStyle.Flat;
            labelpublic.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelpublic.ForeColor = Color.DarkBlue;
            labelpublic.Location = new Point(526, 536);
            labelpublic.Name = "labelpublic";
            labelpublic.Size = new Size(170, 33);
            labelpublic.TabIndex = 7;
            labelpublic.Text = "Continue as Public";
            labelpublic.TextAlign = ContentAlignment.MiddleCenter;
            labelpublic.Click += labelpublic_Click;
            // 
            // pictureBoxlogo
            // 
            pictureBoxlogo.Anchor = AnchorStyles.Top;
            pictureBoxlogo.BackColor = Color.Transparent;
            pictureBoxlogo.Image = (Image)resources.GetObject("pictureBoxlogo.Image");
            pictureBoxlogo.Location = new Point(372, 81);
            pictureBoxlogo.Name = "pictureBoxlogo";
            pictureBoxlogo.Size = new Size(480, 271);
            pictureBoxlogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxlogo.TabIndex = 0;
            pictureBoxlogo.TabStop = false;
            pictureBoxlogo.Click += pictureBoxlogo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(1020, 644);
            label1.Name = "label1";
            label1.Size = new Size(230, 20);
            label1.TabIndex = 8;
            label1.Text = "© 2026 Pritom. All rights reserved.";
            // 
            // Login_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(label1);
            Controls.Add(labelpublic);
            Controls.Add(labellogin);
            Controls.Add(textBoxpassword);
            Controls.Add(labelpassword);
            Controls.Add(textBoxusername);
            Controls.Add(labelusername);
            Controls.Add(pictureBoxlogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login_Screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Screen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelusername;
        private TextBox textBoxusername;
        private TextBox textBoxpassword;
        private Label labelpassword;
        private Label labellogin;
        private Label labelpublic;
        private PictureBox pictureBoxlogo;
        private Label label1;
    }
}
