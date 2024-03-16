namespace ABC_Car_Traders
{
    partial class Car_Details
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
            BtnLogin = new Button();
            panel2 = new Panel();
            Dgv = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            AutoID = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(BtnLogin);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 1;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.LightSkyBlue;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.Location = new Point(749, 0);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(27, 26);
            BtnLogin.TabIndex = 9;
            BtnLogin.Text = "X";
            BtnLogin.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(Dgv);
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 363);
            panel2.TabIndex = 3;
            // 
            // Dgv
            // 
            Dgv.AllowUserToAddRows = false;
            Dgv.AllowUserToDeleteRows = false;
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dgv.BackgroundColor = Color.White;
            Dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv.Columns.AddRange(new DataGridViewColumn[] { AutoID, Column1, Column2, Column3, Column4 });
            Dgv.Location = new Point(0, 138);
            Dgv.Name = "Dgv";
            Dgv.ReadOnly = true;
            Dgv.RowHeadersVisible = false;
            Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv.Size = new Size(773, 222);
            Dgv.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 2;
            label1.Text = "Car Details";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 15);
            label2.Name = "label2";
            label2.Size = new Size(52, 18);
            label2.TabIndex = 2;
            label2.Text = "Car ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 48);
            label3.Name = "label3";
            label3.Size = new Size(75, 18);
            label3.TabIndex = 3;
            label3.Text = "Car Name :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(392, 93);
            button1.Name = "button1";
            button1.Size = new Size(74, 27);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(492, 93);
            button2.Name = "button2";
            button2.Size = new Size(75, 27);
            button2.TabIndex = 6;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(390, 16);
            label4.Name = "label4";
            label4.Size = new Size(76, 18);
            label4.TabIndex = 7;
            label4.Text = "Car Model :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(390, 53);
            label5.Name = "label5";
            label5.Size = new Size(72, 18);
            label5.TabIndex = 8;
            label5.Text = "Car Color :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(472, 14);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 23);
            textBox3.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Red", "Blue", "Black", "White", "Ash" });
            comboBox1.Location = new Point(472, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(193, 23);
            comboBox1.TabIndex = 10;
            // 
            // AutoID
            // 
            AutoID.HeaderText = "Column1";
            AutoID.Name = "AutoID";
            AutoID.ReadOnly = true;
            AutoID.Visible = false;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Car Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Car Color";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 82;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Car Model";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 87;
            // 
            // Car_Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Car_Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car_Details";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnLogin;
        private Panel panel2;
        private DataGridView Dgv;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private DataGridViewTextBoxColumn AutoID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}