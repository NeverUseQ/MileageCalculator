using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double TotalMilesDriven = 0;
        public float GasPrice = 3.50f;
        public int MilesPerGallon = 24;

        private void oneWayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numUpDown_EndingMileage.Value += 19;
        }

        private void roundTripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numUpDown_EndingMileage.Value += 38;
        }

        private void pickUpBenjaminAndHannahroundTripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numUpDown_EndingMileage.Value += 15;
        }

        private void oneWayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            numUpDown_EndingMileage.Value += 27;
        }

        private void roundTripToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            numUpDown_EndingMileage.Value = 54;
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            TotalMilesDriven = (double)numUpDown_EndingMileage.Value - (double)numUpDown_StartingMileage.Value;

            double TotalGasCost = ((TotalMilesDriven / trackBar_minMaxMPG.Value) * GasPrice);
            string Message = "Your Total Trip was " + (numUpDown_EndingMileage.Value - numUpDown_StartingMileage.Value) + " miles, and will cost: $" + TotalGasCost.ToString("###,###.00") + ".";
            if(trackBar_minMaxMPG.Value < 10)
            {
                Message +=" Either let up off the gas pedal, or consider a trade-in";
            }
            MessageBox.Show(Message, "Travel expense estimate");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numUpDown_StartingMileage.Value = numUpDown_EndingMileage.Value;
        }

        private void numUpDown_GasPrice_ValueChanged(object sender, EventArgs e)
        {
            GasPrice = (float)numUpDown_GasPrice.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numUpDown_StartingMileage.Value = 0;
            numUpDown_EndingMileage.Value = 0;

            GasPrice = (float)3.50;
            numUpDown_GasPrice.Value = 3.50M;
        }

        private void aboutMileageCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Travel cost estimator 1.0\nDeveloped by: Richard Miller", "Travel cost estimator");
        }

        private void quitMileageCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            numUpDown_StartingMileage.Value = 0;
            numUpDown_EndingMileage.Value = 0;

            GasPrice = (float)3.50;
            numUpDown_GasPrice.Value = 3.50M;
        }

        private void carSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CarSettings().Show();
        }

        private void trackBar_minMaxMPG_Scroll(object sender, EventArgs e)
        {
            if(trackBar_minMaxMPG.Value < 12)
            {
                Text_MPG.ForeColor = Color.Red;
            } else { Text_MPG.ForeColor = Color.Black; }

            Text_MPG.Text = trackBar_minMaxMPG.Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
