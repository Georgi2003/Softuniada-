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
    public partial class Form5 : Form
    {
        Level1F5 l1 = new Level1F5("Подробна информация", "Отоплението в къщата", "Човекът в колата захранва отоплението!", 3);
        Information i1 = new Information("Подробна информация", "Отоплението в къщата");

        public Form5()
        {
            InitializeComponent();

            airCond2.Visible = false;
            airCond1.Visible = true;

            heater1.Visible = true;
            heater2.Visible = false;

            terr1.Visible = false;
            terr2.Visible = true;

            label4.Text = "0%";
            label5.Text = "0%";

            label1.Text = i1.levels(2).ToString();
            label2.Text = i1.ToString();
            label3.Text = l1.ToString();
            label6.Text = l1.CountPoints(20).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
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
            airCond2.Visible = true;
            airCond1.Visible = false;

            heater1.Visible = false;
            heater2.Visible = true;

            terr1.Visible = true;
            terr2.Visible = false;

            label4.Text = "100%";
            label5.Text = "100%";            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            airCond2.Visible = false;
            airCond1.Visible = true;

            heater1.Visible = true;
            heater2.Visible = false;

            terr1.Visible = false;
            terr2.Visible = true;

            label4.Text = "0%";
            label5.Text = "0%";
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void visualization1_Click(object sender, EventArgs e)
        {
            airCond2.Visible = true;
            airCond1.Visible = false;

            heater1.Visible = false;
            heater2.Visible = true;

            terr1.Visible = true;
            terr2.Visible = false;

            label4.Text = "100%";
            label5.Text = "100%";

            visualization1.Visible = false;
            visualization2.Visible = true;
        }

        private void visualization2_Click(object sender, EventArgs e)
        {
            airCond2.Visible = false;
            airCond1.Visible = true;

            heater1.Visible = true;
            heater2.Visible = false;

            terr1.Visible = false;
            terr2.Visible = true;

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
