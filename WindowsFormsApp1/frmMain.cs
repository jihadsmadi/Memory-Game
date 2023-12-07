using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public enum ModeTheGame { OnePlayer = 1, TwoPlayer = 2 };
        public ModeTheGame Mode;

        public enum PicturesMode { enAnimals=1,enWondorsOfWorld=2,enSocialMidea=3,enDahabAndGhasan=4}
        public PicturesMode PicMode;
       

      
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if(rbOnePlayer.Checked == true)
            {
                Mode = ModeTheGame.OnePlayer;
               
            }else if(rbTwoPlayer.Checked == true)
            {
                Mode = ModeTheGame.TwoPlayer;
            }else
            {
                MessageBox.Show("You should choise the mode ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if(rbAnimals.Checked == true)
            {
                PicMode= PicturesMode.enAnimals;
            }else if (rbSocialMedia.Checked == true)
            {
                PicMode = PicturesMode.enSocialMidea;
            }else if(rbWonderWorld.Checked == true)
            {
                PicMode = PicturesMode.enWondorsOfWorld;
            }else if(rbDahabAndGhasan.Checked == true)
            {
                PicMode = PicturesMode.enDahabAndGhasan;
            }
            else
            {
                MessageBox.Show("You should choise Picture mode ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Form frm = new frmGame(Mode,PicMode);
            frm.Show();
        }
    }
}
