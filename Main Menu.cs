using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_7__Web_Site_Simulation_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quickExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitOnDemandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(390, 71);
            Point pnt_picBox = new Point(317,140);
            Point pnt_btnExit = new Point(615,614);
            Point pnt_btnStay = new Point(317,614);

            lbl_Exit.Location = pnt_lbl;
            picBox_Exit.Location = pnt_picBox;
            btn_Exit.Location = pnt_btnExit;
            btn_stay.Location = pnt_btnStay;

            lbl_Exit.Visible = true;
            btn_Exit.Visible = true;
            btn_stay.Visible = true;
            picBox_Exit.Visible = true;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_stay_Click(object sender, EventArgs e)
        {
            btn_Exit.Visible = false;
            btn_stay.Visible = false;
            lbl_Exit.Visible = false;
            picBox_Exit.Visible = false;
        }

        private void projectMakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This project is done by Ata KALELİ!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;

        }

        private void aliceBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void aquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void beigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
        }

        private void burlyWoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.BurlyWood;
        }

        private void goldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gold;
        }

        private void ınformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(352, 65);
            Point pnt_picBox = new Point(284, 147);
            Point pnt_btn = new Point(508, 610);

            lbl_Python.Location = pnt_lbl;
            picBox_Python.Location = pnt_picBox;
            btn_PythonBack.Location = pnt_btn;


            picBox_Python.Visible = true;
            lbl_Python.Visible = true;
            btn_PythonBack.Visible = true;


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_Python.Visible = false;
            picBox_Python.Visible = false;
            btn_PythonBack.Visible = false;
        }

        private void advantagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(252, 65);
            Point pnt_picBox = new Point(84, 147);
            Point pnt_btn = new Point(308, 610);

            lbl_PythonAdv.Location = pnt_lbl;
            picBox_PythonAdv.Location = pnt_picBox;
            btn_PythonAdv.Location = pnt_btn;

            lbl_PythonAdv.Visible = true;
            picBox_PythonAdv.Visible = true;
            btn_PythonAdv.Visible = true;
        }

        private void btn_PythonAdv_Click(object sender, EventArgs e)
        {
            lbl_PythonAdv.Visible = false;
            btn_PythonAdv.Visible = false;
            picBox_PythonAdv.Visible = false;
        }

        private void disadvantagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(902,65);
            Point pnt_picBox = new Point(834, 147);
            Point pnt_btn = new Point(958,610);

            lbl_PythonDisadv.Location = pnt_lbl;
            picBox_PythonDisadv.Location = pnt_picBox;
            btn_PythonDisadv.Location = pnt_btn;


            lbl_PythonDisadv.Visible = true;
            picBox_PythonDisadv.Visible = true;
            btn_PythonDisadv.Visible = true;

            
        }

        private void btn_PythonDisadv_Click(object sender, EventArgs e)
        {
            lbl_PythonDisadv.Visible = false;
            picBox_PythonDisadv.Visible = false;
            btn_PythonDisadv.Visible = false;
        }

        private void ınformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(345,84);
            Point pnt_picBox = new Point(205,140);
            Point pnt_btn = new Point(383,625);

            lbl_JavaInf.Location = pnt_lbl;
            picBox_JavaInf.Location = pnt_picBox;
            btn_JavaInf.Location = pnt_btn;

            lbl_JavaInf.Visible = true;
            picBox_JavaInf.Visible = true;
            btn_JavaInf.Visible = true;

        }

        private void btn_JavaInf_Click(object sender, EventArgs e)
        {
            lbl_JavaInf.Visible = false;
            picBox_JavaInf.Visible = false;
            btn_JavaInf.Visible = false;

        }

        private void advantagesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(252, 65);
            Point pnt_picBox = new Point(84, 147);
            Point pnt_btn = new Point(308, 610);

            lbl_JavaAdv.Location = pnt_lbl;
            picBox_JavaAdv.Location = pnt_picBox;
            btn_JavaAdv.Location = pnt_btn;

            lbl_JavaAdv.Visible = true;
            picBox_JavaAdv.Visible = true;
            btn_JavaAdv.Visible = true;
        }

        private void btn_JavaAdv_Click(object sender, EventArgs e)
        {
            lbl_JavaAdv.Visible = false;
            picBox_JavaAdv.Visible = false;
            btn_JavaAdv.Visible = false;
        }

        private void disadvantagesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(902, 65);
            Point pnt_picBox = new Point(834, 147);
            Point pnt_btn = new Point(958, 610);

            lbl_JavaDisAdv.Location = pnt_lbl;
            picBox_JavaDisAdv.Location = pnt_picBox;
            btn_JavaDisAdv.Location = pnt_btn;

            lbl_JavaDisAdv.Visible = true;
            picBox_JavaDisAdv.Visible = true;
            btn_JavaDisAdv.Visible = true;
        }

        private void btn_JavaDisAdv_Click(object sender, EventArgs e)
        {
            lbl_JavaDisAdv.Visible = false;
            picBox_JavaDisAdv.Visible = false;
            btn_JavaDisAdv.Visible = false;
        }

        

        private void ınformationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(347,71);
            Point pnt_picBox = new Point(219,140);
            Point pnt_btn = new Point(420,607);

            
            lbl_javascInf.Location = pnt_lbl;
            picBox_javascInf.Location = pnt_picBox;
            btn_javascInf.Location = pnt_btn;

            lbl_javascInf.Visible = true;
            picBox_javascInf.Visible = true;
            btn_javascInf.Visible = true;
        }

        private void btn_javascInf_Click(object sender, EventArgs e)
        {
            lbl_javascInf.Visible = false;
            picBox_javascInf.Visible = false;
            btn_javascInf.Visible = false;
        }

        private void advantagesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(252, 65);
            Point pnt_picBox = new Point(184, 147);
            Point pnt_btn = new Point(308, 660);

            lbl_JavascAdv.Location = pnt_lbl;
            picBox_JavascAdv.Location = pnt_picBox;
            btn_JavascAdv.Location = pnt_btn;

            lbl_JavascAdv.Visible = true;
            picBox_JavascAdv.Visible = true;
            btn_JavascAdv.Visible = true;
        }

        private void btn_JavascAdv_Click(object sender, EventArgs e)
        {
            lbl_JavascAdv.Visible = false;
            picBox_JavascAdv.Visible = false;
            btn_JavascAdv.Visible = false;
        }

        private void disadvantagesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(852, 65);
            Point pnt_picBox = new Point(784, 147);
            Point pnt_btn = new Point(908, 660);

            lbl_JavascDisadv.Location = pnt_lbl;
            picBox_JavascDisadv.Location = pnt_picBox;
            btn_JavascDisadv.Location = pnt_btn;

            lbl_JavascDisadv.Visible = true;
            picBox_JavascDisadv.Visible = true;
            btn_JavascDisadv.Visible = true;
        }

        private void btn_JavascDisadv_Click(object sender, EventArgs e)
        {
            lbl_JavascDisadv.Visible = false;
            picBox_JavascDisadv.Visible = false;
            btn_JavascDisadv.Visible = false;
        }

        private void ınformationToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(352, 65);
            Point pnt_picBox = new Point(284, 147);
            Point pnt_btn = new Point(408, 660);

            lbl_phpInf.Location = pnt_lbl;
            picBox_phpInf.Location = pnt_picBox;
            btn_phpInf.Location = pnt_btn;

            lbl_phpInf.Visible = true;
            picBox_phpInf.Visible = true;
            btn_phpInf.Visible = true;
        }

        private void btn_phpInf_Click(object sender, EventArgs e)
        {
            lbl_phpInf.Visible = false;
            picBox_phpInf.Visible = false;
            btn_phpInf.Visible = false;
        }

        private void advantagesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(252, 65);
            Point pnt_picBox = new Point(184, 147);
            Point pnt_btn = new Point(308, 660);

            lbl_phpAdv.Location = pnt_lbl;
            picBox_phpAdv.Location = pnt_picBox;
            btn_phpAdv.Location = pnt_btn;

            lbl_phpAdv.Visible = true;
            picBox_phpAdv.Visible = true;
            btn_phpAdv.Visible = true;
        }

        private void btn_phpAdv_Click(object sender, EventArgs e)
        {
            lbl_phpAdv.Visible = false;
            picBox_phpAdv.Visible = false;
            btn_phpAdv.Visible = false;
        }

        private void disadvantagesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(852, 65);
            Point pnt_picBox = new Point(784, 147);
            Point pnt_btn = new Point(908, 660);

            lbl_phpDisadv.Location = pnt_lbl;
            picBox_phpDisadv.Location = pnt_picBox;
            btn_phpDisadv.Location = pnt_btn;

            lbl_phpDisadv.Visible = true;
            picBox_phpDisadv.Visible = true;
            btn_phpDisadv.Visible = true;
        }

        private void btn_phpDisadv_Click(object sender, EventArgs e)
        {
            lbl_phpDisadv.Visible = false;
            picBox_phpDisadv.Visible = false;
            btn_phpDisadv.Visible = false;
        }

        private void ınformationToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(347, 71);
            Point pnt_picBox = new Point(219, 140);
            Point pnt_btn = new Point(420, 657);


            lbl_CsharpInf.Location = pnt_lbl;
            picBox_CsharpInf.Location = pnt_picBox;
            btn_CsharpInf.Location = pnt_btn;

            lbl_CsharpInf.Visible = true;
            picBox_CsharpInf.Visible = true;
            btn_CsharpInf.Visible = true;
        }

        private void btn_CsharpInf_Click(object sender, EventArgs e)
        {
            lbl_CsharpInf.Visible = false;
            picBox_CsharpInf.Visible = false;
            btn_CsharpInf.Visible = false;
        }

        private void advantagesToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(252, 65);
            Point pnt_picBox = new Point(284, 347);
            Point pnt_btn = new Point(308, 660);

            lbl_CsharpAdv.Location = pnt_lbl;
            picBox_CsharpAdv.Location = pnt_picBox;
            btn_CsharpAdv.Location = pnt_btn;

            lbl_CsharpAdv.Visible = true;
            picBox_CsharpAdv.Visible = true;
            btn_CsharpAdv.Visible = true;
        }

        private void btn_CsharpAdv_Click(object sender, EventArgs e)
        {
            lbl_CsharpAdv.Visible = false;
            picBox_CsharpAdv.Visible = false;
            btn_CsharpAdv.Visible = false;
        }

        private void disadvantagesToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Point pnt_lbl = new Point(852, 65);
            Point pnt_picBox = new Point(484, 547);
            Point pnt_btn = new Point(908, 660);

            lbl_CsharpdisAdv.Location = pnt_lbl;
            picBox_CsharpdisAdv.Location = pnt_picBox;
            btn_CsharpdisAdv.Location = pnt_btn;

            lbl_CsharpdisAdv.Visible = true;
            picBox_CsharpdisAdv.Visible = true;
            btn_CsharpdisAdv.Visible = true;
        }

        private void btn_CsharpdisAdv_Click(object sender, EventArgs e)
        {
            lbl_CsharpdisAdv.Visible = false;
            picBox_CsharpdisAdv.Visible = false;
            btn_CsharpdisAdv.Visible = false;
        }

        private void btn_trailer_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            webBrowser1.Visible = false;
            btn_trailer.Visible = false;
            webBrowser1.Navigate("");
        }

        



        private void türkİşiDondurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Türk İşi Dondurma";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=Wkl3mY2SnBk&ab_channel=T%C3%BCrk%C4%B0%C5%9FiDondurma");
        }

        

        private void organizeİşlerSazanSarmalıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Organize İşler Sazan Sarmalı";
            webBrowser1.Navigate(" https://www.youtube.com/watch?v=f5AkQJzvCgw&ab_channel=Be%C5%9Fikta%C5%9FK%C3%BClt%C3%BCrMerkezi%28BKM%29");
       
        }

        private void delilerFatihinFermanıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Deliler Fatihin Fermanı";
            webBrowser1.Navigate(" https://www.youtube.com/watch?v=VhaOgRR2CUk&ab_channel=DelilerFilm");
        
        }

        private void sevimliFrankenştaynToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Sevimli Frankeştayn";
            webBrowser1.Navigate(" https://www.izlesene.com/video/turk-usulu-frankenstein-bulent-kayabas/7959827");
        
        }

        private void turistÖmerUzayYolundaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Turist Ömer Uzay Yolunda";
            webBrowser1.Navigate("  https://www.youtube.com/watch?v=5Br_C1lYmmg&ab_channel=MuratDural");
       
        }

        private void battalGaziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Battal Gazi";
            webBrowser1.Navigate(" https://www.youtube.com/watch?v=vSRyYGyS5_Q&ab_channel=haybedenkaybeden");
        }

        private void cinMusallatıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Cin Musallatı";
            webBrowser1.Navigate(" https://www.youtube.com/watch?v=GtwR3B7SgbY&ab_channel=blackfilmprod%C3%BCksiyon");
        }

        private void dabbe6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Dabbe 6";
            webBrowser1.Navigate(" https://www.youtube.com/watch?v=OdMaNzdhJSc&ab_channel=TAFFPictures");
        }

        private void küçükKıyametToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Küçük Kıyamet";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=cgng-Lkd8Yc&ab_channel=ericdraven76");
        }

        private void aROGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "AROG";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=s_jGIs9Vs-I&ab_channel=CMYLMZFikirSanat");
        }

        private void recepİvedik2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Recep İvedik 2";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=jUkm-Qz3wjc&ab_channel=Recep%C4%B0vedik");
        }

        private void çakallarlaDansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Çakallarla Dans";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hGES4CUbGKo&ab_channel=ErhanKarkucak");
        }

        private void sevmekZamanıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Sevmek Zamanı";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=T5KFTvtrO4E&ab_channel=mubiturkiye");
        }

        private void başkaDildeAşkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Başka Dilde Aşk";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=08g3sAhmJ88&ab_channel=PeriAvunc");
        }

        private void aşkTesadüfleriSeverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Aşk Tesadüfleri Sever";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=7rWPl-ecCQo&ab_channel=sudenazg%C3%BCm%C3%BC%C5%9F");
        }

        private void ınceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Inception";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=YoHD9XEInc0&ab_channel=MovieclipsClassicTrailers");

        }

        private void theDarkKnightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "The Dark Knight";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=EXeTwQWrcwY&ab_channel=MovieclipsClassicTrailers");
        }

        private void alienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Alien";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=svnAD0TApb8&ab_channel=AlienAnthology");
        }

        private void underTheSkinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Under The Skin";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CcR5KHjoc-0&ab_channel=MovieclipsComingSoon");
        }

        private void arrivalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Arrival";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=tFMo3UJ4B4g&ab_channel=ParamountPictures");
        }

        private void wallEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Wall E";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=8-_9n5DtKOc&ab_channel=TheGuidedLost");
        }

        private void sAWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "SAW";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=S-1QgOMQ-ls&ab_channel=MovieclipsClassicTrailers");
        }

        private void paranormalActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Paranormal Activity";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=F_UxLEqd074&ab_channel=watchCulturetainment");
        }

        private void annabelle2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Annabelle 2";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=11taaQy2KBg&ab_channel=KinoCheckInternational");
        }

        private void thisIsSpinalTapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "This is Spinal Tap";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=N63XSUpe-0o&ab_channel=ryy79");
        }

        private void caddyshackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Caddyshack";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=x9Nl39uWEYk&ab_channel=MovieclipsClassicTrailers");
        }

        private void annieHallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Annie Hall";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=OqVgCfZX-yE&ab_channel=MovieclipsClassicTrailers");
        }

        private void fiveFeetApartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Five Feet Apart";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=XtgCqMZofqM&ab_channel=MovieclipsTrailers");
        }

        private void lifeInAYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Life In a Year";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=l_NRguVzZrw&ab_channel=MovieTrailersSource");
        }

        private void meBeforeYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            webBrowser1.Visible = true;
            btn_trailer.Visible = true;
            label1.Text = "Me Before You";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=Eh993__rOxA&ab_channel=MovieclipsTrailers");
        }

        private void whoAmIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        

        private void showResourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void screenKeyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("main.cpl");

        }

        private void systemSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mmsys.cpl");
            
        }

        private void showCalenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();

            frm6.Show();
        }

        private void showCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();

            frm4.Show();
        }

        private void metinArdaKökerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It was a very good project!", "Metin Arda Köker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ataBoğaçHoşgülToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good job brother!", "Ata Boğaç Hoşgül", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
