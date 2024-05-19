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
    public partial class Form1 : Form
    {
        //SQL Connection
        SqlConnection con = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");
        public Form1()
        {
            InitializeComponent();
        }

        private void txtID_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
        }

        private void btnSrch_Click_1(object sender, EventArgs e)
        {

            try
            {
                string sqlsrch = "Select * from RENT_VEHICLE where REGNO='" + txtID.Text + "'";//Select
                SqlCommand cmd = new SqlCommand(sqlsrch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader(); //Search Item
                if (dr.Read())
                {
                    txtMake.Text = dr["MAKE"].ToString();
                    cmbType.Text = dr["VTYPE"].ToString();
                    txtDay.Text = dr["DAYRATE"].ToString();
                    txtWeek.Text = dr["WEEKRATE"].ToString();
                    txtMonth.Text = dr["MONTHRATE"].ToString();
                    txtDriver.Text = dr["DRIVERRATE"].ToString();
                }
                else
                    MessageBox.Show("Vehicle not found", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                con.Close();
            }//END TRY
            catch (Exception)
            {
                MessageBox.Show("Invalid Database operation");
            }
        }//End Search

        //Second Search for enter key press


        private void BtnSav_Click(object sender, EventArgs e)
        {

            try
            {

                //Add Item
                SqlConnection con = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");
                string sqlsv = "INSERT INTO RENT_VEHICLE(REGNO,MAKE,DAYRATE,WEEKRATE,MONTHRATE,DRIVERRATE,VTYPE) VALUES('" + txtID.Text + "','" + txtMake.Text + "','" + txtDay.Text + "','" + txtWeek.Text + "','" + txtMonth.Text + "','" + txtDriver.Text + "', '" + cmbType.Text + "')";
                SqlCommand cmnd = new SqlCommand(sqlsv, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                txtID.Text = "";
                txtMake.Text = "";
                txtDay.Text = "";
                txtWeek.Text = "";
                txtMonth.Text = "";
                txtDriver.Text = "";
                MessageBox.Show("Data Saved Successfully");
                con.Close();
            }//End Try
            catch (Exception)
            {
                MessageBox.Show("invalid Input Try Again");
            }

        }//End Save



        private void BtnUpd_Click(object sender, EventArgs e)
        {

            try
            {

                //Update Item
                SqlConnection con = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");
                con.Open();
                string sqlupd = "UPDATE RENT_VEHICLE SET MAKE='" + txtMake.Text + "', DAYRATE='" + txtDay.Text + "', WEEKRATE='" + txtWeek.Text + "', MONTHRATE='" + txtMonth.Text + "', DRIVERRATE='" + txtDriver.Text + "', VTYPE='" + cmbType.Text + "' where REGNO='" + txtID.Text + "'";
                SqlCommand cmnd1 = new SqlCommand(sqlupd, con);
                cmnd1.ExecuteNonQuery();
                txtID.Text = "";
                txtMake.Text = "";
                txtDay.Text = "";
                txtWeek.Text = "";
                txtMonth.Text = "";
                txtDriver.Text = "";
                cmbType.Text = "";
                MessageBox.Show("Data Updated Successfully");
                con.Close();
            }//End Try
            catch (Exception)
            {
                MessageBox.Show("Invalid Operation");
            }
        }//End Update



        private void BtnDel_Click(object sender, EventArgs e)
        {

            try
            {

                //Delete Item

                SqlConnection con = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");
                con.Open();
                string sqldel = "DELETE FROM RENT_VEHICLE WHERE REGNO='" + txtID.Text + "'";
                SqlCommand cmnd2 = new SqlCommand(sqldel, con);
                cmnd2.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");

                    txtID.Text = "";
                    txtMake.Text = "";
                    txtDay.Text = "";
                    txtWeek.Text = "";
                    txtMonth.Text = "";
                    txtDriver.Text = "";
                    cmbType.Text = "";
                           
                    con.Close();
                

            }//End Try
            catch (Exception)
            {
                MessageBox.Show("Invalid Database Operation");
            }
        } //End Delete
        

        private void BtnClr_Click(object sender, EventArgs e)
        {
            //Clear Item
            txtID.Clear();
            txtMake.Clear();
            txtDay.Clear();
            txtWeek.Clear();
            txtMonth.Clear();
            txtDriver.Clear();
            cmbType.Text = "";

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//End Clear

       
    }
 }
    


