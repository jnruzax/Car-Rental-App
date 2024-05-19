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
    public partial class VehicleRental : Form
    {
        public VehicleRental()
        {
            InitializeComponent();
        }

        //SQL Connection
        SqlConnection cnctn = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");

        //Global Variables
        int gap;
        int months, weeks, days, remainder;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
               
                string sqlsrch = "Select * from RENT_VEHICLE where REGNO='" + txtID.Text + "'";//Select
                SqlCommand cmnd = new SqlCommand(sqlsrch, cnctn);
                cnctn.Open();
                SqlDataReader dr = cmnd.ExecuteReader();
                if (dr.Read())
                {
                    //Search Item
                    txtMake.Text = dr["MAKE"].ToString();
                    txtDay.Text = dr["DAYRATE"].ToString();
                    txtWeek.Text = dr["WEEKRATE"].ToString();
                    txtMonth.Text = dr["MONTHRATE"].ToString();
                    txtDriver.Text = dr["DRIVERRATE"].ToString();
                }
                else
                    MessageBox.Show("Vehicle not found");
                cnctn.Close();
            }//End Try
            catch (Exception)
            {
                MessageBox.Show("Invalid Database Operation");
            }
        }//End Search

        //Second Search code for enter key
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                try
                {

                    string sqlsrch = "Select * from RENT_VEHICLE where REGNO='" + txtID.Text + "'";
                    SqlCommand cmnd = new SqlCommand(sqlsrch, cnctn);
                    cnctn.Open();
                    SqlDataReader dr = cmnd.ExecuteReader();
                    if (dr.Read())
                    {
                        //Search Item
                        txtID.Text = dr["REGNO"].ToString();
                        txtMake.Text = dr["MAKE"].ToString();
                        txtDay.Text = dr["DAYRATE"].ToString();
                        txtWeek.Text = dr["WEEKRATE"].ToString();
                        txtMonth.Text = dr["MONTHRATE"].ToString();
                        txtDriver.Text = dr["DRIVERRATE"].ToString();
                    }
                    else
                        MessageBox.Show("Vehicle not found");
                    cnctn.Close();
                }//End Try
                catch (Exception)
                {
                    MessageBox.Show("Invalid Database operation");
                }
        }//End Search

        private void btnAmount_Click(object sender, EventArgs e)
        {
            double dayR = Convert.ToDouble(txtDay.Text);
            double weekR = Convert.ToDouble(txtWeek.Text);
            double monthR = Convert.ToDouble(txtMonth.Text);
            double amnt;

            if (chkDriver.Checked == true)
            {
                double drvrrt = Convert.ToDouble(txtDriver.Text);
                amnt = (months * monthR) + (days * dayR) + (weeks * weekR) + drvrrt * gap;//Calculate Amount With driver
            }
            else
            {
                amnt = (months * monthR) + (days * dayR) + (weeks * weekR);//Calulate Amount Without Driver
            }
            txtAmnt.Text = Convert.ToString(amnt);
        }//End Calculate Amount



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Local Variables
            DateTime startDate, endDate;
            TimeSpan remainDate;


            startDate = DateTime.Parse(dtStart.Text);
            endDate = DateTime.Parse(dtEnd.Text);

            //Calculate Date Difference
            remainDate = endDate - startDate;
            double gp = remainDate.TotalDays;
            txtTotaldys.Text = Convert.ToString(gp);
            gap = Convert.ToInt16(txtTotaldys.Text);

            //find Month, Week, Days
            months = gap / 30;     //Find months
            remainder = gap % 30;  //Find remainding days
            weeks = remainder / 7; //Find weeks
            days = remainder % 7;  //Find days

            //Convert
            txtMonths.Text = Convert.ToString(months);
            txtWeeks.Text = Convert.ToString(weeks);
            txtDays.Text = Convert.ToString(days);

        }//End Calculate Date 

        private void txtID_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

    }
}//End
