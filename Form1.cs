﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool hasFinished = false;
        WindowsMediaPlayer player = new WindowsMediaPlayer();
       
        public Form1()
        {
            InitializeComponent();
            player.URL = "panteraRosa.mp3";
            axWindowsMediaPlayer1.Visible = false;
            stoP.Visible = false;
            over.Visible = false;
            nextForm.Visible = false;
            label4.Visible = false;
            StartGame.Visible = false;
            label2.Text = "0%";
            label3.Text = "0%";
        }

        private void timer2_Tick(object sender, EventArgs e) // Люлеене на Бабичката
        {
            Lbab2.Visible = false;
            timer2.Enabled = false;
            Lbab1.Visible = true;
            timer3.Enabled = true;
            timer3.Interval = 400;
        }

        private void timer3_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Lbab1.Visible = false;
            timer3.Enabled = false;
            Lbab2.Visible = true;
            timer2.Enabled = true;
            timer2.Interval = 400;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movelaine(gamespeed);        
            enemy(gamespeed); // движение на колите
            gameover(); // блъскане с др. коли
            coins(gamespeed); // движение на парите
            coinscollectedCoin(); // събиране на парите
            curtain(2); // завеса

            if (gamespeed == 0)
            {
                lamp1.Visible = true;
                lamp2.Visible = false;

                bab1.Visible = false;
                bab2.Visible = true;

                lampion2.Visible = false;
                lampion1.Visible = true;

                LampC2.Visible = false;
                LampC1.Visible = true;

                label2.Text = "0%";
                label3.Text = "0%";

                player.controls.stop();
                plaY.Visible = true;
                stoP.Visible = false;

                hasFinished = false;
            }

            if (collectedCoin == 30)
            {
                lamp1.Visible = false;
                lamp2.Visible = true;

                bab1.Visible = true;
                bab2.Visible = false;

                lampion2.Visible = true;
                lampion1.Visible = false;

                LampC2.Visible = true;
                LampC1.Visible = false;

                label2.Text = "100%";
                label3.Text = "100%";
            }

            if (collectedCoin > 2)
            {
                curtain1.Visible = false;
                curtain2.Visible = false;
            }
        }
       
        int collectedCoin = 0; // начален бр. монети
        Random r = new Random();
        int x;
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)// движение на кола1
            {
                x = r.Next(-3, 200);//
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                x = r.Next(200, 384);//
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 384);//
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }         
        }

        void curtain(int speed)
        {
            curtain2.Left += 2;
            curtain1.Left += -2;  
        }

        private void curtain2_Click(object sender, EventArgs e)
        {
                
        }

        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(-3, 200);//
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 500)
            {
                x = r.Next(200, 400);//
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 500)
            {
                x = r.Next(195, 300);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top >= 500)
            {
                x = r.Next(0, 400);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }
            //
            if (bom1.Top >= 500) // бомба1
            {
                x = r.Next(0, 400);
                bom1.Location = new Point(x, 0);
            }
            else
            {
                bom1.Top += speed;
            }

            if (bom2.Top >= 500) // бомба2
            {
                x = r.Next(0, 400);
                bom2.Location = new Point(x, 0);
            }
            else
            {
                bom2.Top += speed;
            }

            if (bom3.Top >= 500) // бомба3
            {
                x = r.Next(0, 400);
                bom3.Location = new Point(x, 0);
            }
            else
            {
                bom3.Top += speed;
            }
        }       

        void gameover()
        {
            if (Car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;

                lamp1.Visible = true;
                lamp2.Visible = false;

                bab1.Visible = false;
                bab2.Visible = true;
                
                lampion2.Visible = false;
                lampion1.Visible = true;

                LampC2.Visible = false;
                LampC1.Visible = true;
                gamespeed = 0;
            }

            if (Car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;

                lamp1.Visible = true;
                lamp2.Visible = false;

                bab1.Visible = false;
                bab2.Visible = true;

                lampion2.Visible = false;
                lampion1.Visible = true;

                LampC2.Visible = false;
                LampC1.Visible = true;
                gamespeed = 0;
            }

            if (Car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;

                lamp1.Visible = true;
                lamp2.Visible = false;

                bab1.Visible = false;
                bab2.Visible = true;

                lampion2.Visible = false;
                lampion1.Visible = true;

                LampC2.Visible = false;
                LampC1.Visible = true;
                gamespeed = 0;
            } 

            if (collectedCoin > 15) 
            {
                bab1.Visible = true;
                bab2.Visible = false;
            }

            if (collectedCoin <= 15) 
            {
                bab1.Visible = false;
                bab2.Visible = true;
            }

            if (collectedCoin > 12)
            {
                LampC1.Visible = false;
                LampC2.Visible = true;
            }

            if (collectedCoin <= 12)
            {
                LampC2.Visible = false;
                LampC1.Visible = true;
            }

            if (collectedCoin > 8)
            {              
                lampion1.Visible = false;
                lampion2.Visible = true;
            }

            if (collectedCoin <= 8)
            {
                lampion2.Visible = false;
                lampion1.Visible = true;
            }

            if (collectedCoin == 5)
            {                
                lamp1.Visible = false;
                lamp2.Visible = true;            
            }
           
            if (collectedCoin < 5)
            {
                lamp1.Visible = true;
                lamp2.Visible = false;
            }

            // Зареждане на батерията
            if (collectedCoin >= 5) { label2.Text = "40%"; } else if (collectedCoin <= 5 && collectedCoin > 8) { label2.Text = "0%"; }
            if (collectedCoin > 8) { label2.Text = "60%"; } else if (collectedCoin < 8 && collectedCoin > 12) { label2.Text = "40%"; }
            if (collectedCoin > 12) { label2.Text = "80%"; } else if (collectedCoin < 12 && collectedCoin > 15) { label2.Text = "60%"; }
            if (collectedCoin > 15) { label2.Text = "100%"; } else if (collectedCoin < 15 && collectedCoin >= 20) { label2.Text = "80%"; }

            if (collectedCoin > 20) { label3.Text = "50%"; } else if (collectedCoin < 20 && collectedCoin >= 25) { label3.Text = "0%"; }
            if (collectedCoin > 25) { label3.Text = "100%"; } else if (collectedCoin < 25 && collectedCoin >= 30) { label3.Text = "50%"; }

            if (collectedCoin < 5) { label2.Text = "0%"; }
           
            if (collectedCoin == 30) // спиране на колата при постигнат бр. точки
            {
                timer1.Enabled = false;
                hasFinished = false;
                nextForm.Visible = true;
                gamespeed = 0;
            }

            if (collectedCoin <= 0) { collectedCoin = 0; label1.Text = "Монети: " + "0"; }
        } 
       
        void movelaine(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }

            pictureBox1.Top += speed;
            pictureBox3.Top += speed;
            pictureBox4.Top += speed;
            pictureBox5.Top += speed;
        }
        
        /* */
        void coinscollectedCoin()
        {
            if (Car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedCoin++;
                label1.Text = "Монети: " + collectedCoin.ToString();

                x = r.Next(20, 200);
                coin1.Location = new Point(x, 0);
            }

            if (Car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedCoin++;
                label1.Text = "Монети: " + collectedCoin.ToString();

                x = r.Next(20, 200);
                coin2.Location = new Point(x, 0);
            }

            if (Car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedCoin++;
                label1.Text = "Монети: " + collectedCoin.ToString();

                x = r.Next(20, 200);
                coin3.Location = new Point(x, 0);
            }

            if (Car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedCoin++; // събиран бр. на монети
                label1.Text = "Монети: " + collectedCoin.ToString();

                x = r.Next(50, 200);
                coin4.Location = new Point(x, 0);
            }
            //
            if (Car.Bounds.IntersectsWith(bom1.Bounds)) // бомба
            {
                collectedCoin--; // събиран бр. на монети
                label1.Text = "Монети: " + collectedCoin.ToString();

                x = r.Next(20, 200);
                bom1.Location = new Point(x, 0);
            }

            if (Car.Bounds.IntersectsWith(bom2.Bounds)) // бомба
            {
                collectedCoin--; // събиран бр. на монети
                label1.Text = "Монети: " + collectedCoin.ToString();

                x = r.Next(20, 200);
                bom2.Location = new Point(x, 0);
            }

            if (Car.Bounds.IntersectsWith(bom3.Bounds)) // бомба
            {
                collectedCoin--; // събиран бр. на монети
                label1.Text = "Монети: " + collectedCoin.ToString();

                x = r.Next(20, 200);
                bom3.Location = new Point(x, 0);                
            }
        }
       
        int gamespeed = 0; // начална скорост
       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (hasFinished == true) 
            { 
                if (e.KeyCode == Keys.Left) // клавиш Left
                {
                     if (Car.Left > 10)                   
                     Car.Left += -18;              
                }

                if (e.KeyCode == Keys.Right) // клавиш Right
                {               
                    if (Car.Right < 381)
                    Car.Left += 18;
                }
            }

            if (e.KeyCode == Keys.Up) // клавиш нагоре
            {
                hasFinished = true;
                nav.Visible = false;
                Level1.Visible = false;
                dom.Visible = false;
                if (gamespeed < 1)
                {
                    plaY.Visible = false;
                    stoP.Visible = true;
                    player.controls.play();
                }
          
                if (gamespeed < 21)
                {
                    gamespeed++; // увеличаване на скорост
                }
            }

            if (e.KeyCode == Keys.Down) // клавиш надолу
            {
                if (gamespeed > 0)
                {
                    gamespeed--; // намаляне на скорост
                }

                if (gamespeed == 0)
                {
                    gamespeed=1; // намаляне на скорост
                }
            }

            if (e.KeyCode == Keys.R) // клавиш Left
            {
                timer1.Enabled = false;
                Form1 a = new Form1();
                a.ShowDialog();
                this.Close();
            }
      
            if (e.KeyCode == Keys.Escape) // клавиш Left
            {
                this.Close();
            }           
        }

        //      
        private void over_Click(object sender, EventArgs e)
        {

        }

        private void nextForm_Click(object sender, EventArgs e)
        {
            if (collectedCoin == 30)
            {
                Form2 a = new Form2();
                a.ShowDialog();
                this.Close();
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form1 a = new Form1();
            a.ShowDialog();
            this.Close();
        }

        int tim = 0;
        private void timer4_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (gamespeed != 0) { tim++; }

            if (tim == 30)
            {
                collectedCoin = collectedCoin - 3;
                label1.Text = "Монети: " + collectedCoin.ToString();
                label4.Visible = true;
                label4.Text = "Консумира се Е";
            }
            else if (tim > 30 && tim < 45) { label4.Visible = false; }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void stoP_Click(object sender, EventArgs e)
        {
            player.controls.pause();
            plaY.Visible = true;
            stoP.Visible = false;         
        }

        private void plaY_Click(object sender, EventArgs e)
        {
            player.controls.play();
            plaY.Visible = false;
            stoP.Visible = true;
        }

        private void PauseGame_Click(object sender, EventArgs e)
        {
            if (gamespeed > 0)
            {
                timer1.Enabled = false;
                PauseGame.Visible = false;
                StartGame.Visible = true;
            }          
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            if (gamespeed > 0)
            {
                timer1.Enabled = true;
                PauseGame.Visible = true;
                StartGame.Visible = false;
            }           
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if(gamespeed == 0)
            {
                Form3 a = new Form3();
                a.ShowDialog();
                this.Close();              
            }           
        }     
    }
}