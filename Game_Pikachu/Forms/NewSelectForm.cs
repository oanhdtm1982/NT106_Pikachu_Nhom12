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
    public partial class NewSelectForm : Form
    {
        Sounds sound2 = new Sounds(AppDomain.CurrentDomain.BaseDirectory + "Sounds and img Sounds//Content//101-opening (online-audio-converter.com).wav");
        int i_sounds2 = 1;
        public NewSelectForm()
        {
            InitializeComponent();
        }

        #region Click to Button Start
        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            this.Hide();
            sound2.Stop();
            Form UserForm1 = new UserForm();
            UserForm1.Show();

        }
        #endregion

        #region Click to Button Continue
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            buttonContinue.Visible = false;
        }
        #endregion

        #region Click to Button Guide
        private void buttonGuide_Click(object sender, EventArgs e)
        {
            buttonGuide.Visible = false;
        }
        #endregion

        #region Click to Button About
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            buttonAbout.Visible = false;
        }
        #endregion

        #region Click to Button Exit
        private void buttonExit_Click(object sender, EventArgs e)
        {
            buttonExit.Visible = false;
            this.Close();
        }


        #endregion

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            i_sounds2++;
            NewSelectForm_Load(sender, e);
        }

        private void NewSelectForm_Load(object sender, EventArgs e)
        {
            if (i_sounds2 % 2 == 0)
            {
                sound2.Pause();
            }
            else
            {
                sound2.Resume();
            }
        }
    }
}
