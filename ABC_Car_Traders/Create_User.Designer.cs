namespace ABC_Car_Traders
{
    partial class Create_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_User));
            panel1 = new Panel();
            panel2 = new Panel();
            ComboRole = new ComboBox();
            label4 = new Label();
            BtnReturn = new Button();
            BtnCreateuser = new Button();
            TxtPassword = new TextBox();
            TxtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ComboRole);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(BtnReturn);
            panel1.Controls.Add(BtnCreateuser);
            panel1.Controls.Add(TxtPassword);
            panel1.Controls.Add(TxtUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(24, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 385);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Location = new Point(6, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 186);
            panel2.TabIndex = 9;
            // 
            // ComboRole
            // 
            ComboRole.FormattingEnabled = true;
            ComboRole.Items.AddRange(new object[] { "Admin", "Customer" });
            ComboRole.Location = new Point(299, 215);
            ComboRole.Name = "ComboRole";
            ComboRole.Size = new Size(226, 23);
            ComboRole.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(207, 213);
            label4.Name = "label4";
            label4.Size = new Size(51, 22);
            label4.TabIndex = 7;
            label4.Text = "Role :";
            // 
            // BtnReturn
            // 
            BtnReturn.BackColor = Color.LightSkyBlue;
            BtnReturn.FlatStyle = FlatStyle.Flat;
            BtnReturn.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReturn.Location = new Point(317, 314);
            BtnReturn.Name = "BtnReturn";
            BtnReturn.Size = new Size(208, 38);
            BtnReturn.TabIndex = 6;
            BtnReturn.Text = "Return Login";
            BtnReturn.UseVisualStyleBackColor = false;
            BtnReturn.Click += BtnReturn_Click;
            // 
            // BtnCreateuser
            // 
            BtnCreateuser.BackColor = Color.LightSkyBlue;
            BtnCreateuser.FlatStyle = FlatStyle.Flat;
            BtnCreateuser.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCreateuser.Location = new Point(207, 260);
            BtnCreateuser.Name = "BtnCreateuser";
            BtnCreateuser.Size = new Size(318, 38);
            BtnCreateuser.TabIndex = 5;
            BtnCreateuser.Text = "Create New User";
            BtnCreateuser.UseVisualStyleBackColor = false;
            BtnCreateuser.Click += BtnCreateuser_Click;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(299, 170);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(226, 23);
            TxtPassword.TabIndex = 4;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(299, 125);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(226, 23);
            TxtUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(200, 168);
            label3.Name = "label3";
            label3.Size = new Size(89, 22);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 123);
            label2.Name = "label2";
            label2.Size = new Size(93, 22);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 35);
            label1.Name = "label1";
            label1.Size = new Size(176, 28);
            label1.TabIndex = 0;
            label1.Text = "Create New User";
            // 
            // Create_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(683, 428);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Create_User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create_User";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox TxtPassword;
        private TextBox TxtUsername;
        private Label label3;
        private Label label2;
        private Button BtnCreateuser;
        private Button BtnReturn;
        private ComboBox ComboRole;
        private Label label4;
        private Panel panel2;
    }
}