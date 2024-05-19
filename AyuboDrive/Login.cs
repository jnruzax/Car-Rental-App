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
    public partial class Login : Form
    {
        SqlConnection sqlcon = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");
        public Login()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 2;
            if (progressBar1.Value > 30)
            {
                Mainmenu f = new Mainmenu();
                f.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }
    
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");
            string query = "Select * from Login where Username='" + txtUserN.Text.Trim() + "' and Password='" + txtPswrd.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {

                timer1.Enabled = true;
                pictureBox3.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Username and Password");
            }
        }

        //Keydown login
        private void txtPswrd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection sqlcon = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");
                string query = "Select * from Login where Username='" + txtUserN.Text.Trim() + "' and Password='" + txtPswrd.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {

                    timer1.Enabled = true;
                    pictureBox3.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid Username and Password");
                }
            }
        }

        private void txtUserN_Click_1(object sender, EventArgs e)
        {
            
            txtUserN.Text = "";
          
        }


        private void txtPswrd_Enter(object sender, EventArgs e)
        {
            txtPswrd.UseSystemPasswordChar = true;
            txtPswrd.Text = "";
        }
        private void txtPswrd_Click(object sender, EventArgs e)
        {
            txtPswrd.UseSystemPasswordChar = true;
            txtPswrd.Text = "";
        }



        private void ForgettenLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            panelForgot.Visible = true;
            panelLogin.Visible = false;
            BtnEt.Visible = true;
        }

        //Forgot panel

        private void BtnEt_Click(object sender, EventArgs e)
        {
            Login aa = new Login();
            aa.Show();
            BtnEt.Visible = true;
        }

        private void BtnSubmit_Click_1(object sender, EventArgs e)
        {
             try
             {

                    //Update Item
                    sqlcon.Open();
                    string sqlupd = "UPDATE Login SET Password='" + TxtPaswrd.Text + "' where Username='" + TxtUsrnm.Text + "'";
                    SqlCommand cmnd1 = new SqlCommand(sqlupd, sqlcon);
                    cmnd1.ExecuteNonQuery();
                    TxtPaswrd.Text = "";
                    TxtUsrnm.Text = "";

                    MessageBox.Show("Your Password Changed Successfully ");
                    sqlcon.Close();
             }//End Try
                catch (Exception)
                {
                    MessageBox.Show("Invalid Operation");
                }
        }//End Update

        //Keydown Update
        private void TxtPaswrd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                try
                {

                    //Update Item
                    sqlcon.Open();
                    string sqlupd = "UPDATE Login SET Password='" + TxtPaswrd.Text + "' where Username='" + TxtUsrnm.Text + "'";
                    SqlCommand cmnd1 = new SqlCommand(sqlupd, sqlcon);
                    cmnd1.ExecuteNonQuery();
                    TxtPaswrd.Text = "";
                    TxtUsrnm.Text = "";

                    MessageBox.Show("Password Changed Successfully ");
                    sqlcon.Close();
                }//End Try
                catch (Exception)
                {
                    MessageBox.Show("Invalid Operation");
                }
        }//End Keydown Update

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUsrnm_Click(object sender, EventArgs e)
        {
            
            TxtUsrnm.Text = "";
        }

        private void TxtPaswrd_Enter(object sender, EventArgs e)
        {
            TxtPaswrd.UseSystemPasswordChar = true;
            TxtPaswrd.Text = "";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp aa = new SignUp();
            aa.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp aa = new SignUp();
            aa.Show();
            this.Hide();
        }

        private void txtUserN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPswrd_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}

