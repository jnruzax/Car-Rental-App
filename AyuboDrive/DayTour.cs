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
    public partial class DayTour : Form
    {
        public DayTour()
        {
            InitializeComponent();
        }

        //SQL Connection
        SqlConnection con = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");

        //Global Variables
        int toHrs, mxHrs, noKm, mxKM;
        int exKM, exHr;
        double exHrcost, exKmcost, toCost;

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {

                string sqlsrch = "Select * from Package where PID='" + txtPackageid.Text + "'";//Select
                SqlCommand cmd = new SqlCommand(sqlsrch, con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();//Search
                if (dr.Read())
                {
                    txtPackagename.Text = dr["PName"].ToString();
                    txtPackagerate.Text = dr["PRate"].ToString();
                    txtMaxkm.Text = dr["MaxKM"].ToString();
                    txtMaxhrs.Text = dr["MaxHrs"].ToString();
                    txtExtrahourscharge.Text = dr["ExHrChg"].ToString();
                    txtExtrakmcharge.Text = dr["ExKMChg"].ToString();

                }
                else
                    MessageBox.Show("Package not found");
                con.Close();
            }//End Try
            catch (Exception)
            {
                MessageBox.Show("Invalid Database operation");
            }
        }//End Search 

       


        //Second Search code for enter key
        private void txtPackageid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string sqlsrch = "Select * from Package where PID='" + txtPackageid.Text + "'";//Select
                    SqlCommand cmd = new SqlCommand(sqlsrch, con);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader(); //Search
                    if (dr.Read())
                    {
                        txtPackageid.Text = dr["PID"].ToString();
                        txtPackagename.Text = dr["PName"].ToString();
                        txtPackagerate.Text = dr["PRate"].ToString();
                        txtMaxkm.Text = dr["MaxKM"].ToString();
                        txtMaxhrs.Text = dr["MaxHrs"].ToString();
                        txtExtrahourscharge.Text = dr["ExHrChg"].ToString();
                        txtExtrakmcharge.Text = dr["ExKMChg"].ToString();
                    }
                    else
                        MessageBox.Show("Package not found");
                    con.Close();

                }//End Try
                catch (Exception)
                {
                    MessageBox.Show("Invalid Database operation");
                }
            }//End Search
        }


        private void btnCalculatekm_Click_1(object sender, EventArgs e)
        {
            //Local Variables
            int StartKm, EndKm;

            //Calculate KM
            StartKm = int.Parse(txtStartkmreading.Text);
            EndKm = int.Parse(txtEndkmreading.Text);
            noKm = EndKm - StartKm;
            txtNoofkm.Text = Convert.ToString(noKm);

            //Calculate Extra KM
            mxKM = int.Parse(txtMaxkm.Text);

            if (noKm > mxKM)
            {
                exKM = noKm - mxKM;
            }
            else
            {
                MessageBox.Show("No Extra KM");
            }
            txtExtrakm.Text = Convert.ToString(exKM);
        }//End Calculate KM

        private void btnCalculatehours_Click_1(object sender, EventArgs e)
        {
            //Local Variables
            DateTime strttm;
            DateTime endtm;
            TimeSpan tmsp;

            //Calculate Hour Difference
            strttm = DateTime.Parse(tmStart.Text);
            endtm = DateTime.Parse(tmEnd.Text);
            tmsp = endtm - strttm;
            toHrs = tmsp.Hours;
            txtNoofhours.Text = Convert.ToString(toHrs);

            //Calculate Extra Hours
            mxHrs = int.Parse(txtMaxhrs.Text);
            toHrs = int.Parse(txtNoofhours.Text);
            if (toHrs > mxHrs)
            {
                double hrchg = double.Parse(txtExtrahourscharge.Text);
                exHr = toHrs - mxHrs;

                txtExtrahours.Text = Convert.ToString(exHr);
                exHrcost = exHr * hrchg;
            }
            else
            {
                MessageBox.Show("No Extra Hours");
            }
        }//End Calculate Hours
    

        private void btnCalculatedayhire_Click_1(object sender, EventArgs e)
        {
            double basecharge;
            basecharge = double.Parse(txtPackagerate.Text);

            //Calculate Day Hire
            toCost = basecharge + exHrcost + exKmcost;
            txtTotalcost.Text = Convert.ToString(toCost);

        }//End Calculate Day Hire
    

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            //Clear 
            txtPackageid.Clear();
            txtPackagename.Clear();
            txtPackagerate.Clear();
            txtMaxkm.Clear();
            txtMaxhrs.Clear();
            txtNoofhours.Clear();
            txtExtrahours.Clear();
            txtExtrahourscharge.Clear();
            txtStartkmreading.Clear();
            txtEndkmreading.Clear();
            txtNoofkm.Clear();
            txtExtrakm.Clear();
            txtExtrakmcharge.Clear();
            txtTotalcost.Clear();
        }//End Clear
            

        private void txtPackageid_Click(object sender, EventArgs e)
        {
            txtPackageid.Text = "";
        }
    }
}
