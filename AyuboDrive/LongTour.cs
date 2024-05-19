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
    public partial class LongTour : Form
    {
        public LongTour()
        {
            InitializeComponent();
        }

        //SQL connection
        SqlConnection con = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");
        //Global variables
        int gap;
        int noKm, mxKM;
        int exKM;
        

        
        private void btnSearch_Click(object sender, EventArgs e)
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
                    txtAdditionalkm.Text = dr["ExKMChg"].ToString();
                    txtDriverNightC.Text = dr["DrNightChg"].ToString();
                    txtVehiNightChg.Text = dr["VehiNightChg"].ToString();
                }
                else
                    MessageBox.Show("Package is not available");
                con.Close();
            }//END TRY
            catch (Exception)
            {
                MessageBox.Show("Invalid operation");
            }
        }//End Search


        //Second search for enter key press
        private void txtPackageid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Enter ky press
            {
                try
                {

                    string sqlsrch = "Select * from Package where PID='" + txtPackageid.Text + "'";//Select
                    SqlCommand cmd = new SqlCommand(sqlsrch, con);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();//Search
                    if (dr.Read())
                    {
                        txtPackageid.Text = dr["PID"].ToString();
                        txtPackagename.Text = dr["PName"].ToString();
                        txtPackagerate.Text = dr["PRate"].ToString();
                        txtMaxkm.Text = dr["MaxKM"].ToString();
                        txtMaxhrs.Text = dr["MaxHrs"].ToString();
                        txtAdditionalkm.Text = dr["ExKMChg"].ToString();
                        txtDriverNightC.Text = dr["DrNightChg"].ToString();
                        txtVehiNightChg.Text = dr["VehiNightChg"].ToString();
                    }
                    else
                        MessageBox.Show("Package is not available");
                    con.Close();
                }//END TRY
                catch (Exception)
                {
                    MessageBox.Show("Invalid operation");
                }
            }
        }//End Search

        private void btnCalculateTDays_Click(object sender, EventArgs e)
        {
            //Local Variables
            DateTime startDate, endDate;
            TimeSpan remainDate;


            //Day Difference Calculation
            startDate = DateTime.Parse(dtStart.Text);//Ps
            endDate = DateTime.Parse(dtEnd.Text);//Ps

            remainDate = endDate - startDate;
            double gp = remainDate.TotalDays;
            txtNoofdays.Text = Convert.ToString(gp);
            gap = Convert.ToInt16(txtNoofdays.Text);
        }//End Calculate Days


        private void btnCalculatekm_Click(object sender, EventArgs e)
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

        private void txtCalculateLongHire_Click(object sender, EventArgs e)
        {
            //Local variables
            int noDays, maxKm;
            double Kmchg, exKmchg;
            double baseChg, drNghtChg, vhclngtchg, overnghtchg;

            exKmchg = 0;
            maxKm = int.Parse(txtMaxkm.Text);
            Kmchg = double.Parse(txtAdditionalkm.Text);
            noDays = int.Parse(txtNoofdays.Text);
            baseChg = double.Parse(txtPackagerate.Text);
            drNghtChg = double.Parse(txtDriverNightC.Text);
            vhclngtchg = double.Parse(txtVehiNightChg.Text);

            //Calculate Base Hire Charge
            baseChg = baseChg * noDays;
            txtBaseHC.Text = Convert.ToString(baseChg);

            //Calculate Over Night Charge
            overnghtchg = (drNghtChg + vhclngtchg);
            txtOverNChrg.Text = Convert.ToString(overnghtchg);

            //Calculate Total Cost
            int permiterKms = maxKm * noDays;
            if (exKM > permiterKms)
            {
                exKmchg =  (exKM - permiterKms) * Kmchg; //Calculate extra Km charge
                txtExtraKMChrg.Text = Convert.ToString(exKmchg);
            }
            else
                txtExtraKMChrg.Text = "0";
            double tot = baseChg + overnghtchg + exKmchg;
            txtTotalcost.Text = Convert.ToString(tot);
        }//End Calculate Long Hire

      
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear
            txtPackageid.Clear();
            txtPackagename.Clear();
            txtPackagerate.Clear();
            txtMaxkm.Clear();
            txtMaxhrs.Clear();
            txtAdditionalkm.Clear();
            txtNoofdays.Clear();
            txtStartkmreading.Clear();
            txtEndkmreading.Clear();
            txtNoofkm.Clear();
            txtExtraKMChrg.Clear();
            txtExtrakm.Clear();
            txtTotalcost.Clear();
            txtVehiNightChg.Clear();
            txtDriverNightC.Clear();
            txtOverNChrg.Clear();
            txtBaseHC.Clear();
        }//End Clear

       
        private void txtPackageid_Click(object sender, EventArgs e)
        {
            txtPackageid.Text = "";
        }

    }
}
