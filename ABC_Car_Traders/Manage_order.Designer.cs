namespace ABC_Car_Traders
{
    partial class Manage_order
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
            AutoID = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ColEdit = new DataGridViewButtonColumn();
            ColDelete = new DataGridViewButtonColumn();
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
            panel1.TabIndex = 2;
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
            Dgv.Columns.AddRange(new DataGridViewColumn[] { AutoID, Column1, Column2, Column3, Column4, Column5, Column6, ColEdit, ColDelete });
            Dgv.Location = new Point(0, 3);
            Dgv.Name = "Dgv";
            Dgv.ReadOnly = true;
            Dgv.RowHeadersVisible = false;
            Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv.Size = new Size(773, 357);
            Dgv.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 2;
            label1.Text = "Manage Orders";
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
            Column2.HeaderText = "Order Type";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Order Model";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 99;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Quantity";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 78;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Order Date";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 89;
            // 
            // Column6
            // 
            Column6.HeaderText = "Payment Type";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // ColEdit
            // 
            ColEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColEdit.HeaderText = "Pending/ Approve";
            ColEdit.Name = "ColEdit";
            ColEdit.ReadOnly = true;
            ColEdit.Text = "Edit";
            ColEdit.UseColumnTextForButtonValue = true;
            ColEdit.Width = 99;
            // 
            // ColDelete
            // 
            ColDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColDelete.HeaderText = "Reject";
            ColDelete.Name = "ColDelete";
            ColDelete.ReadOnly = true;
            ColDelete.Text = "Delete";
            ColDelete.UseColumnTextForButtonValue = true;
            ColDelete.Width = 45;
            // 
            // Manage_order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Manage_order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage_order";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnLogin;
        private Panel panel2;
        private DataGridView Dgv;
        private Label label1;
        private DataGridViewTextBoxColumn AutoID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewButtonColumn ColEdit;
        private DataGridViewButtonColumn ColDelete;
    }
}