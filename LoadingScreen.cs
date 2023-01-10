using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biomarkt
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }
        private int LoadingBarValue;

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            LoadingBarTimer.Start();
        }
        private void LoadingBarTimer_Tick(object sender, EventArgs e)
        {
            LoadingBarValue += 1;
            lbltimer.Text = LoadingBarValue.ToString() + "%";
            progressBar1.Value = LoadingBarValue;

            if (LoadingBarValue >= progressBar1.Maximum)
            {
                LoadingBarTimer.Stop();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
