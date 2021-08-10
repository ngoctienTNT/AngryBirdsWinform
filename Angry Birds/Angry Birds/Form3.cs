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
    public partial class EndGame : Form
    {
        public int point;

        public Main main;

        bool close = true;
        public EndGame()
        {
            InitializeComponent();
            btnExit.FlatAppearance.BorderSize = 0;
        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            label1.Text = "Điểm của bạn:\n" + point.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            close = false;
            main.Show();
            this.Close();
        }

        private void EndGame_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
