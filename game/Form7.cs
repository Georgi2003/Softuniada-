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
    public partial class Form7 : Form
    {
        Level1F7 l1 = new Level1F7("Подробна информация", "Бойлерът в къщата", "Бойлерът загрява водата до 100°C", 1);
        Information i1 = new Information("Подробна информация", "Бойлерът в къщат");

        public Form7()
        {
            InitializeComponent();
            thermometer100C4.Visible = false;
            lampGreen.Visible = false;

            label4.Text = "0%";
            label5.Text = "0%";

            label1.Text = i1.levels(3).ToString();
            label2.Text = i1.ToString();
            label3.Text = l1.ToString();
            label6.Text = l1.CountPoints(36).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void nextForm_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            thermometer100C4.Visible = true;
            thermometer0C4.Visible = false;

            lampGreen.Visible = true;
            lampRed.Visible = true;

            label4.Text = "100%";
            label5.Text = "100%";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            thermometer100C4.Visible = false;
            thermometer0C4.Visible = true;

            lampGreen.Visible = false;
            lampRed.Visible = true;

            label4.Text = "0%";
            label5.Text = "0%";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.ShowDialog();
            this.Close();
        }

        private void visualization1_Click(object sender, EventArgs e)
        {
            thermometer100C4.Visible = true;
            thermometer0C4.Visible = false;

            lampGreen.Visible = true;
            lampRed.Visible = true;

            label4.Text = "100%";
            label5.Text = "100%";

            visualization1.Visible = false;
            visualization2.Visible = true;
        }

        private void visualization2_Click(object sender, EventArgs e)
        {
            thermometer100C4.Visible = false;
            thermometer0C4.Visible = true;

            lampGreen.Visible = false;
            lampRed.Visible = true;

            label4.Text = "0%";
            label5.Text = "0%";

            visualization2.Visible = false;
            visualization1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 a = new Form9();
            a.ShowDialog();
            this.Close();
        }
    }
}
