using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jargonBuster.page.JourneyTheSchool
{
    public partial class trainForm : Form
    {
        int count = 0;
        string[] age = new string [7];
        string[] distance = new string[7];
        string[] friends = new string[7];
        string[] vehicle = new string[7];

        public trainForm()
        {
            InitializeComponent();

       
        }

        private void pcbPowerOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void trainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Saved", "Added 6 data successfully, now you can pass the test");
            data();

        }
        public void data()
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NH68NBE;Initial Catalog=dbJourneySchool;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;


            cmd = new SqlCommand("select top 6 * from tbl_movement", con);
            con.Open();
        
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                age[count] = dr["age"].ToString();
                distance[count] = dr["distance"].ToString();
                friends[count] = dr["friends"].ToString();
                vehicle[count] = dr["vehicle"].ToString();
                count++;
            }

            
            for (int i = 0; i < 6; i++)
            {
                Label lbl = new Label();
                lbl.Text =
                    "Age : "+age[i].ToString() + "\n\n" +
                    "Distance : " + distance[i].ToString()   +"\n\n" +
                    "Friends : " + friends[i].ToString()    + "\n\n" +
                    "Vehicle : " + vehicle[i].ToString();
                lbl.AutoSize = false;
                lbl.ForeColor = System.Drawing.Color.White;
                lbl.Padding = new Padding(6);
                lbl.Margin = new Padding(9);
                lbl.BackColor = System.Drawing.Color.LightSlateGray;
                lbl.Width = 120;
                lbl.Height = 105;

                pnlContent.Controls.Add(lbl);
            }




            con.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}
