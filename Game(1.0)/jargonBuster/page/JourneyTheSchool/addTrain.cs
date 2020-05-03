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
    public partial class addTrain : Form
    {
        SqlCommand cm;
        SqlDataAdapter da;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NH68NBE;Initial Catalog=dbJourneySchool;Integrated Security=True");
        public addTrain()
        {
            InitializeComponent();

        }

        private void pcbPowerOff_Click(object sender, EventArgs e)
        {
            trainForm trainForm = new trainForm();
            trainForm.Show();
            this.Hide();
        }
        int count = 1;
        private void addTrain_Load(object sender, EventArgs e)
        {
            cmbVehicle.SelectedIndex = 0;
            lblAge.Text = cmbVehicle.SelectedIndex.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

          
            if (txtAge.Text.Length >= 1 && txtDistance.Text.Length >= 1 &&
                 txtFrends.Text.Length >= 1 && cmbVehicle.SelectedIndex != 0)
            {
                string sorgu = "INSERT INTO tbl_movement(age,distance,friends,vehicle) VALUES  (@_age,@_distance,@_friends,@_vehicle)";
                cm = new SqlCommand(sorgu, conn);
                cm.Parameters.AddWithValue("@_age", txtAge.Text);
                cm.Parameters.AddWithValue("@_distance", txtDistance.Text);
                cm.Parameters.AddWithValue("@_friends", txtFrends.Text);
                cm.Parameters.AddWithValue("@_vehicle", cmbVehicle.Text);
                conn.Open();
                cm.ExecuteNonQuery();
                conn.Close();
               
                MessageBox.Show("Successfully Saved", count+" Data added");
                count++;
                txtAge.Text = "";
                txtDistance.Text = "";
                txtFrends.Text = "";
                cmbVehicle.SelectedIndex = 0;
           
              

            }
            else
            {
                MessageBox.Show("Please Choose", "Error Saved");
            }

            if (count == 7)
            {
                
                trainForm trainForm = new trainForm();
                trainForm.Show();
                this.Hide();
            }
           
            
            
        }
    }
}
