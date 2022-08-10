using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogukanBaser
{
    public partial class oyun : Form
    {

        bool goLeft;
        bool goRight;
        bool shooting;
        bool isGameOver;

        int score;
        int playerspeed = 13 ;
        int enemyspeed;
        int bulletspeed;
        Random rnd = new Random();
        
        
        
        
        
        
        
        public oyun()
        {
            InitializeComponent();
            resetGame();
        }

        private void oyunsüresiolayı(object sender, EventArgs e)
        {

            txtskor.Text = score.ToString();


            dusman1.Top += enemyspeed;
            dusman2.Top += enemyspeed;
            dusman3.Top += enemyspeed;

            if(dusman1.Top > 650 || dusman2.Top > 650 || dusman3.Top > 650 ) 
            {
                gameOver();
            }


            // player hareket eylemi başlangıcı
            if(goLeft == true && player.Left > 0)
            {

                player.Left -= playerspeed;

            }

            if(goRight == true && player.Left < 500)
            {

                player.Left += playerspeed;

            }

            // player hareket eylemi sonu

            if(shooting == true)
            {

                bulletspeed = 20;
                mermi.Top -= bulletspeed;

            }
            
            else

            {

                mermi.Left = -300;
                bulletspeed = 0;

            }

            if(mermi.Top < -30)
            {

                shooting = false;

            }

            if(mermi.Bounds.IntersectsWith(dusman1.Bounds))
            {
                score += 1;
                dusman1.Top = -400;
                dusman1.Left = rnd.Next(20,500);
                shooting = false;


            }

            if (mermi.Bounds.IntersectsWith(dusman2.Bounds))
            {
                score += 1;
                dusman2.Top = -500;
                dusman2.Left = rnd.Next(20, 500);
                shooting = false;


            }

            if (mermi.Bounds.IntersectsWith(dusman3.Bounds))
            {
                score += 1;
                dusman3.Top = -600;
                dusman3.Left = rnd.Next(20, 500);
                shooting = false;


            }

            //skora göre düşman hızı

            if(score == 5)
            {

                enemyspeed = 5;

            }

            if(score == 10)
            {

                enemyspeed = 10;

            }

            if (score == 20)
            {

                enemyspeed = 15;

            }

            if (score == 30)
            {

                enemyspeed = 20;

            }

            // skora göre bizim hızımız

            if (score == 10)
            {

                playerspeed = 18;

            }

            if (score == 20)
            {

                playerspeed = 28;

            }

            if (score == 30)
            {

                playerspeed = 38;

            }

        }

        private void mermi_Click(object sender, EventArgs e)
        {

        }

        

        private void keysup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if(e.KeyCode == Keys.Space && shooting == false)
            {

                shooting = true;
                
                mermi.Top = player.Top - 30;
                mermi.Left = player.Left + (player.Width /2);

            }
            if(e.KeyCode == Keys.Enter && isGameOver == true)
            {

                resetGame();
            }

            if (e.KeyCode == Keys.M && isGameOver == true)
            {

                Form2 oyun = new Form2();
                oyun.Show();  // form2 göster diyoruz
                this.Hide();

            }


        }

        private void dusman2_Click(object sender, EventArgs e)
        {

        }

        private void keysdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void resetGame()
        {

            oyunsüresi.Start();
            enemyspeed = 5;



            dusman1.Left = rnd.Next(20, 550);
            dusman2.Left = rnd.Next(20, 550);
            dusman3.Left = rnd.Next(20, 550);


            dusman1.Top = rnd.Next(0, 200) * -1 ;
            dusman2.Top = rnd.Next(0, 400) * -1 ;
            dusman3.Top = rnd.Next(0, 550) * -1 ;


            score = 0;
            bulletspeed = 0;
            mermi.Left = - 300;
            shooting = false;

            txtskor.Text = score.ToString();
        }

        private void gameOver()
        {
            isGameOver = true;
            oyunsüresi.Stop();
            txtskor.Text += Environment.NewLine + "Oyun Bitti!!" + Environment.NewLine + "Enter tuşuna bas ve tekrar başla - Menüye Dönmek İçin M tuşuna bas";
        }



    }
}
