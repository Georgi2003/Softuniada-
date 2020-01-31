using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form9 : Form
    {
        Level1F9 l1 = new Level1F9("Подробна информация", "Печката в къщата", "Човекът в колата захранва печката!");
        Information i1 = new Information("Подробна информация", "Печката в къщата");

        public Form9()
        {
            InitializeComponent();
            thermometer100C4.Visible = false;
            label4.Text = "0%";
            label7.Text = "0%";

            lampGreen.Visible = true;
            lampRed.Visible = false;

            cook1.Visible = false;

            label1.Text = i1.levels(4).ToString();
            label2.Text = i1.ToString();
            label3.Text = l1.ToString();
            label5.Text = l1.Car().ToString();
            label6.Text = l1.CountPoints(36).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            a.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.ShowDialog();
            this.Close();
        }

        private void nextForm_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.ShowDialog();
            this.Close();
        }

        private void visualization1_Click(object sender, EventArgs e)
        {
            thermometer100C4.Visible = true;
            thermometer0C4.Visible = false;

            label4.Text = "100%";
            label7.Text = "100%";

            visualization1.Visible = false;
            visualization2.Visible = true;

            cook1.Visible = true;
            cook2S.Visible = false;
        }

        private void visualization2_Click(object sender, EventArgs e)
        {
            thermometer100C4.Visible = false;
            thermometer0C4.Visible = true;

            label4.Text = "0%";
            label7.Text = "0%";

            visualization2.Visible = false;
            visualization1.Visible = true;

            cook1.Visible = false;
            cook2S.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.ShowDialog();
            this.Close();
        }
    }
}
