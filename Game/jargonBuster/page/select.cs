using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jargonBuster.page
{
    public partial class select : Form
    {
        public select()
        {
            InitializeComponent();
        }

        private void pcbPowerOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            trainJargon trainJargon = new trainJargon();
            trainJargon.Show();
            this.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            testJargon testJargon = new testJargon();
            testJargon.Show();
            this.Hide();
        }
    }
}
