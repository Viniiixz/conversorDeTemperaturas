using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe3_CVSDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double tempC = 0, tempF = 0, tempK = 0;

            tempC = double.Parse(txtTempC.Text);
         
            //°F = °C x 1,8 + 32
            tempF = tempC * 1.8 + (32);
            txtTempF.Text = tempF.ToString("f") + " °F ";

            //°K = ℃ + 273.15
            tempK = tempC + 273.15;
            txtTempK.Text = tempK.ToString("f") + " °K ";

        }
    }
}
