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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                pictureBox1.Visible = false; 
                pictureBox2.Visible = false; 
                pictureBox3.Visible = false; 
                pictureBox4.Visible = false; 
                pictureBox5.Visible = false; 
                pictureBox6.Visible = false; 
                pictureBox7.Visible = false; 
                pictureBox8.Visible = false; 
                pictureBox9.Visible = false; 

            string name = comboBox1.Text;

            switch (name)
            {
                case "First Year - First Semester": pictureBox1.Visible = true; break;
                case "First Year - Second Semester": pictureBox2.Visible = true; break;
                case "Second Year - First Semester": pictureBox3.Visible = true; break;
                case "Second Year - Second Semester": pictureBox4.Visible = true; break;
                case "Third Year - First Semester": pictureBox5.Visible = true; break;
                case "Third Year - Second Semester": pictureBox6.Visible = true; break;
                case "Fourth Year - First Semester": pictureBox7.Visible = true; break;
                case "Fourth Year - Second Semester": pictureBox8.Visible = true; break;
                case "Course Prerequisite Chain": pictureBox9.Visible = true; break;

            }
        }
    }
}
