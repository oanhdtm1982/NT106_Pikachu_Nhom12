using Game_Pikachu.PlayViewProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Game_Pikachu
{
    public partial class PlayForm : Form
    {
        Sounds sound = new Sounds(AppDomain.CurrentDomain.BaseDirectory + "//Sounds and img Sounds//Content//102-palette town theme.mp3");
        int i_sounds = 1;
        public PlayForm()
        {
            InitializeComponent();
            // Chạy timer, có tác dụng ở progressBar            
            timer.Start();
            InitialProcessEvent InitialProcessPlay = new InitialProcessEvent();
            DrawPanelContainIcon drawPanelContainIcon = new DrawPanelContainIcon();
            InitialProcessPlay.ProcessEvent(drawPanelContainIcon, panelContainIcon);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBarTime.PerformStep();
            if(progressBarTime.Value == progressBarTime.Maximum)
            {
                this.Close();
                MessageBox.Show("Finish");
            }    
           
        }
        private void PlayForm_Load(object sender, EventArgs e)
        {
            // ProgressBar chạy thời gian.
            progressBarTime.PerformStep();
            if (i_sounds % 2 == 0)
            {
                sound.Pause();
            }
            else
            {
                sound.Resume();
            }
        }

        // Exit Game
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Play again
        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newPlayForm = new PlayForm();
            newPlayForm.StartPosition = FormStartPosition.CenterScreen;
            newPlayForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            i_sounds++;
            PlayForm_Load(sender, e);
        }
    }
}
