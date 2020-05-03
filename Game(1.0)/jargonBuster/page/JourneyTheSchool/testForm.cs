using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jargonBuster.page.JourneyTheSchool
{
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
        }

        private void pcbPowerOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            testMethod ();
        }
        private void testMethod()
        {
            int Age = Convert.ToInt32(txtAge.Text);
            int Friend = Convert.ToInt32(txtFrends.Text);
            int Dist = Convert.ToInt32(txtDistance.Text);
            if (Age <= 6)
            {
                lblResult.Text = "Not Valid";
            }
            if (Age >= 36)
            {
                lblResult.Text = "Not Valid";
            }
            if (Dist <= 0)// 9 0 2 girince patlıyo
            {
                lblResult.Text = "Not Valid";
            }
            if (Dist > 30)
            {
                lblResult.Text = "%98.5 Car";
            }
            if (Dist <= 1 && Age >= 12 && Age <= 14 && Friend >= 0 && Friend < 4)
            {
                lblResult.Text = "%95 Walk";
            }
            if (Age >= 9 && Age <= 11 && Dist < 4)
            {
                lblResult.Text = "%67 Car";
            }
            if (Age >= 9 && Age <= 11 && Dist < 4 && Dist >= 2 && Friend > 1 && Friend <= 3)
            {
                lblResult.Text = "%58 Car";
            }
            if (Age >= 9 && Age <= 11 && Dist < 4 && Dist >= 2 && Friend > 4 && Friend <= 20)
            {
                lblResult.Text = "%86 Car";
            }
            if (Age >= 9 && Age <= 11 && Dist < 4 && Dist >= 2 && Friend >= 0 && Friend <= 6)
            {
                lblResult.Text = "%75 Car";
            }
            if (Age >= 9 && Age <= 11 && Dist < 10 && Dist >= 5 && Friend >= 0 && Friend <= 2000)
            {
                lblResult.Text = "%96 Car";
            }
            if (Age > 6 && Age <= 7 && Dist > 0 && Dist < 1 && Friend >= 0 && Friend < 2)//yeni eklediklerim
            {
                lblResult.Text = "%87 Cycle";
            }
            if (Age >= 6 && Age <= 7 && Dist > 0 && Dist < 1 && Friend >= 2 && Friend < 800)
            {
                lblResult.Text = "%90 Cycle";
            }
            if (Age >= 7 && Age <= 8 && Dist > 0 && Dist < 1 && Friend >= 0 && Friend < 800)
            {
                lblResult.Text = "%84 Cycle";
            }
            if (Age >= 7 && Age <= 8 && Dist > 1 && Dist < 3 && Friend >= 0 && Friend < 800)
            {
                lblResult.Text = "%72 Car";
            }
            if (Age >= 7 && Age <= 35 && Dist > 10 && Dist < 300 && Friend >= 0 && Friend < 800)
            {
                lblResult.Text = "%99.1 Car";
            }
            if (Age >= 8 && Age <= 10 && Dist > 1 && Dist <= 2 && Friend >= 1 && Friend < 3)
            {
                lblResult.Text = "%54 Cycle";
            }
            if (Age >= 8 && Age <= 9 && Dist >= 0 && Dist <= 1 && Friend >= 0 && Friend < 3)
            {
                lblResult.Text = "%61.4 Walk";
            }
            if (Age >= 8 && Age <= 9 && Dist >= 0.5 && Dist <= 1 && Friend >= 0 && Friend < 2)
            {
                lblResult.Text = "%73.2 Walk";
            }
            if (Age >= 8 && Age <= 9 && Dist >= 0.9 && Dist <= 1.8 && Friend >= 4 && Friend < 1500)
            {
                lblResult.Text = "%71 Cycle";
            }
            if (Age >= 8 && Age <= 9 && Dist >= 0.9 && Dist <= 1.8 && Friend >= 7 && Friend < 1500)
            {
                lblResult.Text = "%62 Cycle";
            }//car için
            if (Age >= 10 && Age <= 12 && Dist < 4 && Dist >= 1.5)
            {
                lblResult.Text = "%72.5 Car";
            }
            if (Age >= 10 && Age <= 16 && Dist > 0 && Dist <= 2 && Dist > 1 && Friend > 1 && Friend <= 3)
            {
                lblResult.Text = "%54 Car";
            }
            if (Age > 9 && Age <= 15 && Dist < 100 && Dist >= 3.6 && Friend >= 0 && Friend <= 2000)
            {
                lblResult.Text = "%90.4 Car";
            }
            if (Age >= 11 && Age <= 15 && Dist > 2.2 && Dist <= 3)
            {
                lblResult.Text = "%82 Car";
            }
            if (Age >= 9 && Age <= 16 && Dist < 15 && Dist >= 10 && Friend >= 0 && Friend <= 2000)
            {
                lblResult.Text = "%96 Car";
            }
            //-----------------------------------
            //walk için
            if (Age >= 11 && Age <= 15 && Dist >= 0 && Dist <= 0.9 && Friend == 0)
            {
                lblResult.Text = "%62 Walk";
            }
            if (Age >= 11 && Age <= 15 && Dist >= 0 && Dist <= 0.8 && Friend >= 1 && Friend < 1500)
            {
                lblResult.Text = "%76.6 Walk";
            }
            if (Age >= 11 && Age <= 15 && Dist >= 0 && Dist <= 1 && Friend >= 1 && Friend < 1500)
            {
                lblResult.Text = "%71 Walk";
            }
            if (Age >= 11 && Age <= 15 && Dist >= 0 && Dist <= 1.2 && Friend >= 1 && Friend < 1500)
            {
                lblResult.Text = "%51.3 Walk";
            }
            //Cycle için-------------------//
            if (Age > 6 && Age <= 11 && Dist > 0.8 && Dist <= 1.3 && Friend >= 0 && Friend <= 2)//yeni eklediklerim
            {
                lblResult.Text = "%59 Cycle";
            }
            if (Age >= 9 && Age <= 15 && Dist >= 0 && Dist < 0.8 && Friend >= 0 && Friend < 3)
            {
                lblResult.Text = "%54 Cycle";
            }
            if (Age >= 14 && Age <= 20 && Dist > 0 && Dist < 3 && Friend >= 0 && Friend < 800)
            {
                lblResult.Text = "%50.4 Cycle";
            }
            if (Age >= 20 && Age <= 30 && Dist > 3 && Dist < 4.2 && Friend >= 0 && Friend < 800)
            {
                lblResult.Text = "%87 Car";
            }
        }
    }
}
