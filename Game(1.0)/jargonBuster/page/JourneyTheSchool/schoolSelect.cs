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
    public partial class schoolSelect : Form
    {
        public schoolSelect()
        {
            InitializeComponent();
        }

        private void pcbPowerOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            addTrain addTrain = new addTrain();
            addTrain.Show();
            this.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            testForm testForm = new testForm();
            testForm.Show();
            this.Hide();
        }
    }
}
