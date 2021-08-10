using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angry_Birds
{
    public partial class GamePlay : Form
    {
        List<string> ListImage = new List<string>()
        { "black.png","blue_1.png","blue_2.png","blue_3.png","blue_4.png","blue_5.png",
          "green.png","pink.png","red_1.png","red_2.png","red_3.png","red_4.png",
          "red_5.png","red_6.png","yellow_1.png","yellow_2.png"};

        public int posision, posisionPre, point, dem = 0, time = 30, kt;

        public Main main;

        Random random = new Random();

        bool close = true;

        private void GamePlay_Load(object sender, EventArgs e)
        {
            posision = random.Next(16);
            pictureBox.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\" + ListImage[posision]);
            main.Hide();
        }

        private void GamePlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                close = false;
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Bạn muốn thoát game?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    main.close = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                    close = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            close = false;
            timer1.Stop();
            main.Show();
            this.Close();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            lbTime.Text = "Thời Gian: " + time.ToString();
            if (time < 0)
            {
                EndGame endGame = new EndGame();
                endGame.point = point;
                endGame.main = main;
                close = false;
                timer1.Stop();                
                endGame.Show();
                this.Close();
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (posision != posisionPre)
            {
                if (dem < 5) dem++;
                point += 10 * dem;
            }
            else
            {
                point -= 10;
                dem = 0;
            }
            posisionPre = posision;
            lbPoint.Text = "Đểm: " + point.ToString();
            kt = random.Next(100);
            if (kt%2==1)
            {
                posision = random.Next(16);
                pictureBox.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\" + ListImage[posision]);
            }                
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (posision==posisionPre)
            {
                if (dem < 5) dem++;
                point += 10 * dem;
            }
            else
            {
                point -= 10;
                dem = 0;
            }
            posisionPre = posision;
            lbPoint.Text = "Đểm: " + point.ToString();
            kt = random.Next(1000);
            if (kt%2==1)
            {
                posision = random.Next(16);
                pictureBox.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\" + ListImage[posision]);
            }    
        }

        public GamePlay()
        {
            InitializeComponent();
            btnYes.FlatAppearance.BorderSize = 0;
            btnNo.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            timer1.Start();
        }
    }    
}
