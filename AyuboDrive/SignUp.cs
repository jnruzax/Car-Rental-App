using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AyuboDrive
{
    public partial class SignUp : Form
    {
        SqlConnection sqlcon = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSgnUp_Click(object sender, EventArgs e)
        {

            try
            {

                //Add Item
                SqlConnection sqlcon = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");
                string sqlsv = "INSERT INTO Login(Username,Password) VALUES('" + txtUserNm.Text + "','" + txtPswr.Text + "')";
                SqlCommand cmnd = new SqlCommand(sqlsv, sqlcon);
                sqlcon.Open();
                cmnd.ExecuteNonQuery();
                txtUserNm.Text = "";
                txtPswr.Text = "";
               
                MessageBox.Show("Your Account Has Created");
                sqlcon.Close();
            }//End Try
            catch (Exception)
            {
                MessageBox.Show("invalid Input Try Again");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login aa = new Login();
            aa.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserNm_Click(object sender, EventArgs e)
        {
            txtUserNm.Text = "";
        }

        private void txtPswr_Enter(object sender, EventArgs e)
        {
            txtPswr.UseSystemPasswordChar = true;
            txtPswr.Text = "";
        }
    }
}
