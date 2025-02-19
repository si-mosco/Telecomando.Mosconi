﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telecomando.Mosconi
{
    public partial class Form1 : Form
    {
        private Telecomando tec;
        private Televisione tev;
        private Termostato ter;
        private Caldaia cal;
        public Form1()
        {
            InitializeComponent();

            tev = new Televisione("Sony", "Bravia", "Hdmi", "1");
            tec = new Telecomando("Sony", "Bravia", "Wi-Fi", tev, "1");
            cal = new Caldaia("Class One", "Ariston", "chenneso", 177013);
            ter = new Termostato("Class Two", "Ariston", 366547, cal);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //accendi
        {
            tec.accendi();
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            textBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e) //spegni
        {
            tec.spegni();
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            textBox1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tec.aumentaVolume();
            MessageBox.Show($"{tev.getVolume()}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tec.diminuisciVolume();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int c1 = int.Parse(textBox1.Text);
                tec.setCanale(c1);
                textBox1.Text = "";
                MessageBox.Show($"{tev.getCanale()}");
            }
            catch
            {
                MessageBox.Show("Inserire un valore Valido");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"{tev.getStato()}");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"{tev.getVolume()}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{tev.getCanale()}");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            tec.aumentaVolume();
        }
    }
}
