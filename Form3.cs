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
    public partial class Form3 : Form
    {
        Game g1 = new Game(3, "❦Основна информация❦", "");
        Information i1 = new Information("❦Основна информация❦", "");

        public Form3()
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

            label6.Text = "0%";
            label7.Text = "0%";

            label1.Text = g1.ToString();
            label2.Text = g1.Ret().ToString();
            label3.Text = g1.Purpose().ToString();
            label4.Text = g1.Coins().ToString();
            label5.Text = g1.Bombs().ToString();

            label8.Text = "Увеличаване" + "\r\n" + "        на" + "\r\n" + "  скоростта".ToString();
            label9.Text = "Десен" + "\r\n" + "завой".ToString();
            label10.Text = "Ляв" + "\r\n" + "завой".ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void nextForm_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            lamp1.Visible = false;
            lamp2.Visible = true;

            bab1.Visible = true;
            bab2.Visible = false;

            lampion2.Visible = true;
            lampion1.Visible = false;

            LampC2.Visible = true;
            LampC1.Visible = false;

            label6.Text = "100%";
            label7.Text = "100%";
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 a = new Form9();
            a.ShowDialog();
            this.Close();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // клавиш Left
            {
                this.Close();
            }
        }
    }
}
