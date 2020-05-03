using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jargonBuster.page
{
    public partial class testJargon : Form
    {
        SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
        SpeechSynthesizer ss = new SpeechSynthesizer();
        bool _isPermit;
        public testJargon()
        {
            InitializeComponent();
        }
        private void pcbVoice_Click(object sender, EventArgs e)
        {
            pcbVoice.ImageLocation = "C:/Users/Emre/source/repos/Game/jargonBuster/img/micPassif.png";
            voiceSettings();
            _isPermit = true;
            sr.RecognizeAsync();
        }
        void voiceSettings()
        {
            Grammar gr = new DictationGrammar();
            sr.LoadGrammar(gr);
            //mikrofon driver seçiliyor
            sr.SetInputToDefaultAudioDevice();
            //ses algılandığında
            sr.SpeechRecognized += voiceRecognition;
        }
        private void voiceRecognition(object sender, SpeechRecognizedEventArgs e)
        {
            //erkek bir konuşmacı belirliyoruz
            ss.SelectVoiceByHints(VoiceGender.Male);
            if (_isPermit)
            {
                pcbVoice.ImageLocation = "C:/Users/Emre/source/repos/Game/jargonBuster/img/micActive.png";
                _isPermit = false;
                //sonuç panelimiz yansıtıyoruz
                pnlResult.Visible = true;



                lblResult.Text = e.Result.Text;
                meaning();

                //sonucumuzu okutuyoruz
                ss.SpeakAsync(e.Result.Text);
                // microfonumuzu kapatıyoruz
                pcbVoice.Enabled = false;

            }

        }
        private void meaning()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NH68NBE;Initial Catalog=dbJargon;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
           

            cmd = new SqlCommand("select * from word where wordName=@_wordName", con);
            con.Open();
            cmd.Parameters.AddWithValue("@_wordName", lblResult.Text);
            dr = cmd.ExecuteReader();
           
            while (dr.Read())
            {
               
                lblResultMean.Text = dr["wordMean"].ToString(); ;
            }

            if (lblResultMean.Text== "resultMean")
            {
                pnlNotSucces.Visible = true;
                pnlResult.Visible = false;
            }
           

            con.Close();

            
        }
        private void pcbPowerOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblResultMean.Text = "resultMean";
            pnlResult.Visible = false;
            pcbVoice.Enabled = true;
        }

        private void btnNotNext_Click(object sender, EventArgs e)
        {
            pnlResult.Visible = false;
            pcbVoice.Enabled = true;
            pnlNotSucces.Visible = false;
        }
    }
}
