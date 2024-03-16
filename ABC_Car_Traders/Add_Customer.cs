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
    public partial class Add_Customer : Form
    {
        Customer_Category f = new Customer_Category();
        public Add_Customer(Customer_Category f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.OpenImage(pic);
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("insert into tbl_customer (cus_name, cus_Id,cus_contact, cus_address, cus_img) values (@cus_name, @cus_Id,@cus_contact, @cus_address, @cus_img)",db.cn);
            db.cm.Parameters.AddWithValue("@cus_name", TxtCusName.Text);
            db.cm.Parameters.AddWithValue("@cus_Id", TxtCusID.Text);
            db.cm.Parameters.AddWithValue("@cus_contact", TxtCusCon.Text);
            db.cm.Parameters.AddWithValue("@cus_address", TxtAddress.Text);
            db.ConvertImageToSave(pic);
            db.cm.Parameters.AddWithValue("@cus_img", db._img);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Customer added Successfully");
            db.cn.Close();
            f.LoadCustomer();
            TxtAddress.Clear();
            TxtCusCon.Clear();
            TxtCusID.Clear();
            TxtCusName.Clear();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("update tbl_customer set cus_name= @cus_name, cus_Id=@cus_Id,cus_contact=@cus_contact, cus_address=@cus_address, cus_img=@cus_img where id=@id", db.cn);
            db.cm.Parameters.AddWithValue("@id", db._id);
            db.cm.Parameters.AddWithValue("@cus_name", TxtCusName.Text);
            db.cm.Parameters.AddWithValue("@cus_Id", TxtCusID.Text);
            db.cm.Parameters.AddWithValue("@cus_contact", TxtCusCon.Text);
            db.cm.Parameters.AddWithValue("@cus_address", TxtAddress.Text);
            db.ConvertImageToSave(pic);
            db.cm.Parameters.AddWithValue("@cus_img", db._img);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Customer Updated Successfully");
            db.cn.Close();
            f.LoadCustomer();
            Dispose();
        }
    }
}
