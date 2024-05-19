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
    public partial class PackageDetails : Form
    {
        //SQL Connection
        SqlConnection con = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");
        public PackageDetails()
        {
            InitializeComponent();
        }

        private void TxtPacID_Click_1(object sender, EventArgs e)
        {
            TxtPacID.Text = "";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlsrch = "Select * from Package where PID='" + TxtPacID.Text + "'";//Select
                SqlCommand cmd = new SqlCommand(sqlsrch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader(); //Search Item
                if (dr.Read())
                {
                    TxtPckgNam.Text = dr["PName"].ToString();
                    TxtPckgRat.Text = dr["PRate"].ToString();
                    TxtMaxKm.Text = dr["MaxKM"].ToString();
                    TxtMaxHrs.Text = dr["MaxHrs"].ToString();
                    TxtExtraKmChrg.Text = dr["ExKMChg"].ToString();
                    TxtExtraHrChg.Text = dr["ExHrChg"].ToString();
                    TxtDrvrNgtChg.Text = dr["DrNightChg"].ToString();
                    TxtVcleNghtChg.Text = dr["VehiNightChg"].ToString();
                }
                else
                    MessageBox.Show("Package not found", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                con.Close();
            }//END TRY
            catch (Exception)
            {
                MessageBox.Show("Invalid Database operation");
            }
        }//End Search

       

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                //Add Item
                SqlConnection con = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");
                string sqlsv = "INSERT INTO Package(PID,PName,PRate,MaxKM,MaxHrs,ExKMChg,ExHrChg,DrNightChg,VehiNightChg) VALUES('" + TxtPacID.Text + "','" + TxtPckgNam.Text + "','" + TxtPckgRat.Text + "','" + TxtMaxKm.Text + "','" + TxtMaxHrs.Text + "','" + TxtExtraKmChrg.Text + "', '" + TxtExtraHrChg.Text + "','" + TxtDrvrNgtChg.Text + "','" + TxtVcleNghtChg.Text + "')";
                SqlCommand cmnd = new SqlCommand(sqlsv, con);
                con.Open();
                cmnd.ExecuteNonQuery();

                TxtPacID.Text = "";
                TxtPckgNam.Text = "";
                TxtPckgRat.Text = "";
                TxtMaxKm.Text = "";
                TxtMaxHrs.Text = "";
                TxtExtraKmChrg.Text = "";
                TxtExtraHrChg.Text = "";
                TxtDrvrNgtChg.Text = "";
                TxtVcleNghtChg.Text = "";

                MessageBox.Show("Data Saved Successfully");
                con.Close();
            }//End Try
            catch (Exception)
            {
                MessageBox.Show("invalid Input Try Again");
            }

        }//End Save

        private void BtnUpdtae_Click(object sender, EventArgs e)
        {
            try
            {

                //Update Item
                SqlConnection con = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");
                con.Open();
                string sqlupd = "UPDATE Package SET PName='" + TxtPckgNam.Text + "', PRate='" + TxtPckgRat.Text + "', MaxKM='" + TxtMaxKm.Text + "', MaxHrs='" + TxtMaxHrs.Text + "', ExKMChg='" + TxtExtraKmChrg.Text + "',ExHrChg='" + TxtExtraHrChg.Text + "', DrNightChg='" + TxtDrvrNgtChg.Text + "', VehiNightChg='" + TxtVcleNghtChg.Text + "'where PID='" + TxtPacID.Text + "'";
                SqlCommand cmnd1 = new SqlCommand(sqlupd, con);
                cmnd1.ExecuteNonQuery();
                TxtPacID.Text = "";
                TxtPckgNam.Text = "";
                TxtPckgRat.Text = "";
                TxtMaxKm.Text = "";
                TxtMaxHrs.Text = "";
                TxtExtraKmChrg.Text = "";
                TxtExtraHrChg.Text = "";
                TxtDrvrNgtChg.Text = "";
                TxtVcleNghtChg.Text = "";
                MessageBox.Show("Data Updated Successfully");
                con.Close();
            }//End Try
            catch (Exception)
            {
                MessageBox.Show("Invalid Operation");
            }
        }//End Update

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {

                //Delete Item
                SqlConnection con = new SqlConnection("server=JEEWANTHA;initial catalog=AYUBOV;integrated security=yes");
                con.Open();
                string sqldel = "DELETE FROM Package WHERE PID='" + TxtPacID.Text + "'";
                SqlCommand cmnd2 = new SqlCommand(sqldel, con);
                cmnd2.ExecuteNonQuery();



                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)

                    return;
                else
                {
                    TxtPacID.Text = "";
                    TxtPckgNam.Text = "";
                    TxtPckgRat.Text = "";
                    TxtMaxKm.Text = "";
                    TxtMaxHrs.Text = "";
                    TxtExtraKmChrg.Text = "";
                    TxtExtraHrChg.Text = "";
                    TxtDrvrNgtChg.Text = "";
                    TxtVcleNghtChg.Text = "";

                    MessageBox.Show("Data Deleted Successfully");

                    con.Close();
                }

            }//End Try
            catch (Exception)
            {
                MessageBox.Show("Invalid Database Operation");
            }
        }//End Delete

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //Clear Item
            TxtPacID.Clear();
            TxtPckgNam.Clear();
            TxtPckgRat.Clear();
            TxtMaxKm.Clear();
            TxtMaxHrs.Clear();
            TxtExtraKmChrg.Clear();
            TxtExtraHrChg.Clear();
            TxtDrvrNgtChg.Clear();
            TxtVcleNghtChg.Clear();

        }

        private void CmbVanType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//End Clear

    }
}
    
    
    
    

