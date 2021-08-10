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
    public partial class Main : Form
    {
        List<string> ListImage = new List<string>()
        { "black.png","blue_1.png","blue_2.png","blue_3.png","blue_4.png","blue_5.png",
          "green.png","pink.png","red_1.png","red_2.png","red_3.png","red_4.png",
          "red_5.png","red_6.png","yellow_1.png","yellow_2.png"};

        Random random = new Random();

        int posision;

        public bool close = true;

        public Main()
        {
            InitializeComponent();             
            btnStart.FlatAppearance.BorderSize = 0;
            btnAbout.FlatAppearance.BorderSize = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GamePlay gamePlay = new GamePlay();
            gamePlay.posisionPre = posision;
            gamePlay.main = this;
            gamePlay.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            posision = random.Next(16);
            pictureBox.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\" + ListImage[posision]);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                close = false;
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Bạn muốn thoát game?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                    close = true;
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.main = this;
            this.Hide();
            about.ShowDialog();
        }
    }
}
