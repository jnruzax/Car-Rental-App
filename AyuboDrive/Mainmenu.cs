using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AyuboDrive
{
    public partial class Mainmenu : Form
    {
     

        public Mainmenu()
        {           
            
            InitializeComponent();                   
        
        }

    
        //Panel Calling
        private void playformpanle(object formplay)
        {

            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);

            Form fh = formplay as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(fh);
            this.MainPanel.Tag = fh;
            fh.Show();

        }


        private void btnVehicleRentle_Click(object sender, EventArgs e)
        {

            playformpanle(new Form1());
            
            sidepanel.Visible = true;//Visible
            sidepanel.Height = btnVehicleRentle.Height;//Side panel
            sidepanel.Top = btnVehicleRentle.Top;

            subpanel3.Visible = false;//Sub panel

        }

        private void btnPckgDetails_Click(object sender, EventArgs e)
        {

            playformpanle(new PackageDetails());

            sidepanel.Visible = true;//Visible
            sidepanel.Height = btnPckgDetails.Height;//Side panel
            sidepanel.Top = btnPckgDetails.Top;

            subpanel3.Visible = false;//Sub panel
        }


        private void btnTour_Click_1(object sender, EventArgs e)
        {
            
            subpanel3.Visible = true;//Sub panel

            sidepanel.Visible = true;//Visible
            sidepanel.Height = btnTour.Height;//Side panel
            sidepanel.Top = btnTour.Top;
        }

        private void btnPackageTour_Click(object sender, EventArgs e)
        {
            panel2.Height = btnPackageTour.Height;//Side panel
            panel2.Top = btnPackageTour.Top;


            playformpanle(new VehicleRental());
        }


        private void btnDayT_Click(object sender, EventArgs e)
        {
            panel2.Height = btnDayT.Height;//Side panel
            panel2.Top = btnDayT.Top;

            playformpanle(new DayTour());
            
        }

        private void btnLongT_Click(object sender, EventArgs e)
        {
            panel2.Height = btnLongT.Height;//Side panel
            panel2.Top = btnLongT.Top;


            playformpanle(new LongTour());
           
        }

       
        private void btnmnmz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//Minimize
        }

        private void BtnExt_Click(object sender, EventArgs e)
        {
            Login aa = new Login();//Exit 
            aa.Show();
            this.Hide();
        }

        private void Mainmenu_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            playformpanle(new Home());//Home for call
        }

        private void btnMaximizer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizer.Visible = false;
            btnNormal.Visible = true;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnNormal.Visible = false;
            btnMaximizer.Visible = true;
        }

      
    }
 }


