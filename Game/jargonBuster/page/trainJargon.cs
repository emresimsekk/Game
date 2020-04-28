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
    public partial class trainJargon : Form
    {
        SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
        SpeechSynthesizer ss = new SpeechSynthesizer();
        bool _isPermit;
        int trainCount = 0;
        string[] word = new string[8];
        string[] wordMean = new string[8];

        public trainJargon()
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
        //mikrofon ayarşaro
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
                //sonucumuzu okutuyoruz
                ss.SpeakAsync(e.Result.Text);
                // microfonumuzu kapatıyoruz
                pcbVoice.Enabled = false;

            }

        }
        private void pcbPowerOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            
          

            //kelime anlamı 10 karakterden küçükse
            if (rtMeaning.Text.Length < 10)
                lblError.Visible = true;
            
            else
            {
                //kelimeleri diziye atıyoruz
                word[trainCount] = lblResult.Text;
                // kelime anlamlarını diziye atıyoruz
                wordMean[trainCount] = rtMeaning.Text;

                trainCount = trainCount + 1;

                pnlResult.Visible = false;
                pcbVoice.Enabled = true;
                lblError.Visible = false;
                rtMeaning.Text = "";
              
            }
            
            //8 kelimenin eğitimi tamamlanırsa veritabanına kaydedilecek
            if (trainCount == 8)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NH68NBE;Initial Catalog=dbJargon;Integrated Security=True");
                SqlCommand cmd;
                for (int i = 0; i < word.Length; i++)
                {

                    cmd = new SqlCommand("insert into word(wordName,wordMean) values(@_wordName,@_wordMean)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@_wordName", word[i].ToString());
                    cmd.Parameters.AddWithValue("@_wordMean", wordMean[i].ToString());

                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                pcbVoice.Visible = false;
                pnlSucces.Visible = true;
                pnlResult.Visible = false;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            pnlResult.Visible = false;
            pcbVoice.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            testJargon testJargon = new testJargon();
            this.Hide();
            testJargon.Show();
        }
    }
}
