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
    public partial class UserForm : Form
    {
        Sounds sound1 = new Sounds(AppDomain.CurrentDomain.BaseDirectory + "//Sounds and img Sounds//Content//102-palette town theme.mp3");
        int i_sounds1 = 1;
        public UserForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            sound1.Stop();
            PlayForm pf = new PlayForm();
            pf.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            i_sounds1++;
            UserForm_Load(sender, e);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (i_sounds1 % 2 == 0)
            {
                sound1.Pause();
            }
            else
            {
                sound1.Resume();
            }
        }
    }
}
