using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Resistor2Calculate
{
    public partial class Form1 : Form
    {

        bool parallelseriel = true;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Calculation berechnung = new Calculation();

            berechnung.setRes1(Convert.ToInt32(textBox1.Text));
            berechnung.setRes2(Convert.ToInt32(textBox2.Text));
            berechnung.setParaSer(parallelseriel);

            textBox3.Text = Convert.ToString(berechnung.getResistance());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            parallelseriel = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            parallelseriel = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult beenden = MessageBox.Show("Willst du wirklich beenden?", "Program beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (beenden == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
