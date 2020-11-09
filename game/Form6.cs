using System;
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
    public partial class Form6 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        bool hasFinished = false;

        public Form6()
        {
            InitializeComponent();
            player.URL = "panteraRosa.mp3";
            axWindowsMediaPlayer1.Visible = false;
            pictureBox2.Visible = false;
            over.Visible = false;
            label5.Text = "Бойлерът е изключен!!!".ToString();
            nextForm.Visible = false;
            label4.Visible = false;          
            StartGame.Visible = false;
            thermometer100C.Visible = false;
            thermometer100C4.Visible = false;
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

        private void Form2_Load(object sender, EventArgs e)
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

            if (gamespeed == 0)
            {
                thermometer0C.Visible = true;
                thermometer20C.Visible = false;
                thermometer40C.Visible = false;
                thermometer60C.Visible = false;
                thermometer80C.Visible = false;
                thermometer100C.Visible = false;
                thermometer80C2.Visible = false;
                thermometer60C2.Visible = false;
                thermometer40C2.Visible = false;
                thermometer20C2.Visible = false;
                thermometer40C3.Visible = false;
                thermometer60C3.Visible = false;
                thermometer80C3.Visible = false;
                thermometer100C3.Visible = false;

                lampGreen.Visible = false;
                lampRed.Visible = true;

                label2.Text = "0%";
                label3.Text = "0%";
                player.controls.stop();

                plaY.Visible = true;
                pictureBox2.Visible = false;

                hasFinished = false;
            }

            if (timer1.Enabled == false && collectedCoin!= 36) { label5.Text = "Бойлерът е изключен!!!".ToString(); }          
        }

        int collectedCoin = 0; // начален бр. монети

        //
        Random r = new Random();
        int x;
        void enemy(int speed)
        {
            if (enemy1.Top >= 500) // движение на кола1
            {
                x = r.Next(-3, 200);
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                x = r.Next(200, 384);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 384);
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }
        }

        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 500)
            {
                x = r.Next(50, 300);
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
                timer4.Enabled = false;
                over.Visible = true;

                gamespeed = 0;
            }

            if (Car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                timer4.Enabled = false;
                over.Visible = true;

                gamespeed = 0;
            }

            if (Car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                timer4.Enabled = false;
                over.Visible = true;

                gamespeed = 0;
            }
            
            //
            if (collectedCoin > 35)
            {
                thermometer80C3.Visible = false;
                thermometer100C3.Visible = true;
            }

            if (collectedCoin > 33 && collectedCoin <= 35)
            {
                thermometer100C3.Visible = false;
                thermometer80C3.Visible = true;
            }

            if (collectedCoin > 33)
            {
                thermometer60C3.Visible = false;
                thermometer80C3.Visible = true;
            }

            if (collectedCoin > 30 &&  collectedCoin <= 33)
            {
                thermometer80C3.Visible = false;
                thermometer60C3.Visible = true;
            }

            if (collectedCoin > 30)
            {
                thermometer40C3.Visible = false;
                thermometer60C3.Visible = true;
            }

            if (collectedCoin > 22 && collectedCoin <= 30)
            {
               thermometer60C3.Visible = false;
               thermometer40C3.Visible = true;
            }

            if (collectedCoin > 22)
            {
               thermometer20C2.Visible = false;
               thermometer40C3.Visible = true;
            }

            if (collectedCoin > 20 && collectedCoin <= 22)
            {
               thermometer40C3.Visible = false;
               thermometer20C2.Visible = true;
            }

            /* */
            if (collectedCoin > 20)
            {
                thermometer40C2.Visible = false;
                thermometer20C2.Visible = true;
            }

            if (collectedCoin > 19)
            {
                thermometer60C2.Visible = false;
                thermometer40C.Visible = true;
            }

            if (collectedCoin > 18)
            {
                thermometer80C2.Visible = false;
                thermometer60C2.Visible = true;
            }

            if (collectedCoin > 17)
            {
                thermometer100C.Visible = false;
                thermometer80C2.Visible = true;
               
                lampGreen.Visible = false;
                lampRed.Visible = true;
            }

            /* */
            if (collectedCoin > 14)
            {
                thermometer80C.Visible = false;
                thermometer100C.Visible = true;
            }

            if (collectedCoin <= 14)
            {
                thermometer100C.Visible = false;
                thermometer80C.Visible = true;
            }

            if (collectedCoin > 12)
            {
                thermometer60C.Visible = false;
                thermometer80C.Visible = true;
            }

            if (collectedCoin <= 12)
            {
                thermometer80C.Visible = false;
                thermometer60C.Visible = true;
            }

            if (collectedCoin > 10)
            {
                thermometer40C.Visible = false;
                thermometer60C.Visible = true;
            }

            if (collectedCoin <= 10)
            {
                thermometer60C.Visible = false;
                thermometer40C.Visible = true;
            }

            if (collectedCoin > 7)
            {
                thermometer20C.Visible = false;
                thermometer40C.Visible = true;
            }

            if (collectedCoin <= 7)
            {
                thermometer40C.Visible = false;
                thermometer20C.Visible = true;
            }

            if (collectedCoin == 5)
            {
                thermometer0C.Visible = false;
                thermometer20C.Visible = true;
                
                lampGreen.Visible = true;
                lampRed.Visible = false;
            }

            if (collectedCoin < 5)
            {
                thermometer0C.Visible = true;
                thermometer20C.Visible = false;

                lampGreen.Visible = false;
                lampRed.Visible = true;
            }

            if (collectedCoin >= 5 && collectedCoin <= 14) { label5.Text = "Бойлерът загрява водата!!!".ToString(); lampGreen.Visible = true; lampRed.Visible = false; }

            if (collectedCoin > 17 && collectedCoin < 20) { label5.Text = "Бойлерът е изключен!!!".ToString(); lampGreen.Visible = false; lampRed.Visible = true; }

            if (collectedCoin >= 22 && collectedCoin <= 35) { label5.Text = "Бойлерът загрява водата!!!".ToString(); lampGreen.Visible = true; lampRed.Visible = false; }

            if (collectedCoin == 36) // спиране на колата при постигнат бр. точки
            {
                timer1.Enabled = false; // спиране на колата
                timer4.Enabled = false;
                nextForm.Visible = true;
                lampGreen.Visible = true;
                thermometer100C4.Visible = true;
                label5.Text = "Бойлерът загря водата!!!".ToString();
                gamespeed = 0;
            }

            // Зареждане на батерията
            if (collectedCoin >= 5) { label2.Text = "10%"; } else if (collectedCoin <= 5 && collectedCoin > 7) { label2.Text = "0%"; }
            if (collectedCoin > 7) { label2.Text = "20%"; } else if (collectedCoin < 7 && collectedCoin > 10) { label2.Text = "10%"; }
            if (collectedCoin > 10) { label2.Text = "30%"; } else if (collectedCoin < 10 && collectedCoin > 12) { label2.Text = "20%"; }
            if (collectedCoin > 12) { label2.Text = "40%"; } else if (collectedCoin < 12 && collectedCoin >= 14) { label2.Text = "30%"; }
            if (collectedCoin > 14) { label2.Text = "50%"; } else if (collectedCoin < 14 && collectedCoin >= 20) { label2.Text = "40%"; }

            if (collectedCoin > 20) { label3.Text = "50%"; } else if (collectedCoin < 20 && collectedCoin >= 25) { label3.Text = "0%"; }
            if (collectedCoin > 36) { label3.Text = "100%"; } else if (collectedCoin < 25 && collectedCoin >= 30) { label3.Text = "50%"; }

            if (collectedCoin < 5) { label2.Text = "0%"; }

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
                nav.Visible = false;
                Level1.Visible = false;
                hasFinished = true;
                if (gamespeed < 1)
                {
                    player.controls.play();
                    stoP.Visible = false;
                    pictureBox2.Visible = true;
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
                    gamespeed = 1; // намаляне на скорост
                }
            }

            if (e.KeyCode == Keys.R) // клавиш Left
            {
                Form6 a = new Form6();
                a.ShowDialog();
                this.Close();
            }

            if (e.KeyCode == Keys.Escape) // клавиш Left
            {
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void restart_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.ShowDialog();
            this.Close();
        }

        int tim = 0;
        private void timer4_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (gamespeed != 0) { tim++; }

            if (tim == 10)
            {
                collectedCoin = collectedCoin - 3;
                label1.Text = "Монети: " + collectedCoin.ToString();
                label4.Visible = true;
                label4.Text = "Консумира се Е";
            }
            else if (tim > 10 && tim < 20) { label4.Visible = false; }

            if (tim == 20)
            {
                collectedCoin = collectedCoin - 3;
                label1.Text = "Монети: " + collectedCoin.ToString();
                label4.Visible = true;
                label4.Text = "Консумира се Е";
            }
            else if (tim > 20 && tim < 30) { label4.Visible = false; }
        }

        private void plaY_Click(object sender, EventArgs e)
        {
            player.controls.play();
            plaY.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            player.controls.pause();
            plaY.Visible = true;
            pictureBox2.Visible = false;
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
            if (gamespeed == 0)
            {
                Form3 a = new Form3();
                a.ShowDialog();
                this.Close();
            }
        }

        private void nextForm_Click_1(object sender, EventArgs e)
        {

        }

        private void nextForm_Click(object sender, EventArgs e)
        {
            Lable a = new Lable();
            a.ShowDialog();
            this.Close();
        }
    }
}