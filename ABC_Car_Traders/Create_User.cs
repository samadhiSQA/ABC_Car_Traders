using CSharp_ABC_Car_Traders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class Create_User : Form
    {
        public Create_User()
        {
            InitializeComponent();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreateuser_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("Insert into tbl_user(Username, Password)values(@Username,@Password)", db.cn);
            db.cm.Parameters.AddWithValue("@Username", TxtUsername.Text);
            db.cm.Parameters.AddWithValue("Password", TxtPassword.Text);
            db.cm.ExecuteNonQuery();
            TxtPassword.Clear();
            TxtUsername.Clear();
            MessageBox.Show("User has been created");
            db.cn.Close();
            Login f = new Login();
            f.Show();
            this.Dispose();


        }
    }
}
