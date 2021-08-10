using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angry_Birds
{
    public partial class About : Form
    {
        public Main main;
        public About()
        {
            InitializeComponent();
            Gecko.Xpcom.Initialize(Application.StartupPath + "\\xulrunner");
            geckoWebBrowser1.Navigate("https://linktr.ee/ngoctien.TNT");
            geckoWebBrowser1.CreateWindow2 += GeckoWebBrowser1_CreateWindow2;
            geckoWebBrowser1.NoDefaultContextMenu = true;
        }

        private void GeckoWebBrowser1_CreateWindow2(object sender, Gecko.GeckoCreateWindow2EventArgs e)
        {
            Process.Start(e.Uri);
            e.Cancel = true;
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
        }
    }
}
