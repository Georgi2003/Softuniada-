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
    public partial class Form4 : Form
    {
        Level1F4 l1 = new Level1F4("Подробна информация", "Осветлението в къщата", 3, 1);
        Information i1 = new Information("Подробна информация", "Осветлението в къщата");

        public Form4()
        {
            InitializeComponent();

            lamp1.Visible = true;
            lamp2.Visible = false;

            bab1.Visible = false;
            bab2.Visible = true;

            lampion2.Visible = false;
            lampion1.Visible = true;

            LampC2.Visible = false;
            LampC1.Visible = true;

            label4.Text = "0%";
            label5.Text = "0%";

            label1.Text = i1.levels(1).ToString();            
            label2.Text = i1.ToString();
            label3.Text = l1.ToString();
            label6.Text = l1.CountPoints(30).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            lamp1.Visible = false;
            lamp2.Visible = true;

            bab1.Visible = true;
            bab2.Visible = false;

            lampion2.Visible = true;
            lampion1.Visible = false;

            LampC2.Visible = true;
            LampC1.Visible = false;

            label4.Text = "100%";
            label5.Text = "100%";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            lamp1.Visible = true;
            lamp2.Visible = false;

            bab1.Visible = false;
            bab2.Visible = true;

            lampion2.Visible = false;
            lampion1.Visible = true;

            LampC2.Visible = false;
            LampC1.Visible = true;

            label4.Text = "0%";
            label5.Text = "0%";
        }

        private void nextForm_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            a.ShowDialog();
            this.Close();
        }

        private void visualization1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void visualization2_Click(object sender, EventArgs e)
        {
            lamp1.Visible = true;
            lamp2.Visible = false;

            bab1.Visible = false;
            bab2.Visible = true;

            lampion2.Visible = false;
            lampion1.Visible = true;

            LampC2.Visible = false;
            LampC1.Visible = true;

            label4.Text = "0%";
            label5.Text = "0%";

            visualization2.Visible = false;
            visualization1.Visible = true;
        }

        private void visualization1_Click(object sender, EventArgs e)
        {
            lamp1.Visible = false;
            lamp2.Visible = true;

            bab1.Visible = true;
            bab2.Visible = false;

            lampion2.Visible = true;
            lampion1.Visible = false;

            LampC2.Visible = true;
            LampC1.Visible = false;

            label4.Text = "100%";
            label5.Text = "100%";

            visualization1.Visible = false;
            visualization2.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 a = new Form9();
            a.ShowDialog();
            this.Close();
        }        
    }
}
