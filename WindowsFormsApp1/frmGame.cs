using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using static WindowsFormsApp1.frmMain;

namespace WindowsFormsApp1
{

    public partial class frmGame : Form
    {
        frmMain.ModeTheGame Mode;
        frmMain.PicturesMode picMode;

        private enum PlayerTurn { PlayerOne = 1, playerTwo = 2 };
        PlayerTurn NowTurn = PlayerTurn.PlayerOne;

        

        private short CountOfTheGame = 0, playerOne = 0, PlayerTwo = 0;
        private string[] images = new string[20];

        private PictureBox prevPicture = null;
        
        
        


        public frmGame(frmMain.ModeTheGame Mode,frmMain.PicturesMode PicMode)
        {
            InitializeComponent();
            this.Mode = Mode;
            this.picMode = PicMode;

            if (this.Mode == ModeTheGame.OnePlayer)
                LBPlayerTwoResult.Visible = false;
            else 
                LBPlayerTwoResult.Visible = true;
            
        }

      
        private void frmGame_Load(object sender, EventArgs e)
        {
            if (this.Mode == frmMain.ModeTheGame.OnePlayer)
                lbModeResult.Text = "One Player";
            else
                lbModeResult.Text = "Two Player";

            AllocationPicture();
        }
        private void SwapImage(ref string image1,ref string image2)
        {
            string temp;
            temp = image1;
            image1 = image2;
            image2 = temp;
        }
        private void ShufellImages(string[] images)
        {
            Random rnd = new Random();

            for(int i=0;i<images.Length-1;i++)
            {
                SwapImage(ref images[rnd.Next(0,19)],ref  images[rnd.Next(0,19)]);
            }
        }
        private void DownloadPicturesAndPutItAtTag()
        {

            switch (picMode)
            {
                case (PicturesMode.enAnimals):
                    images[0] = "Octupus";
                    images[1] = "Banda";
                    images[2] = "Lion";
                    images[3] = "Fish";
                    images[4] = "Hourse";
                    images[5] = "Rabit";
                    images[6] = "Bird";
                    images[7] = "Chicken";
                    images[8] = "Dog";
                    images[9] = "Goat";

                    images[10] = "Octupus"; ;
                    images[11] = "Banda";
                    images[12] = "Lion";
                    images[13] = "Fish";
                    images[14] = "Hourse";
                    images[15] = "Rabit";
                    images[16] = "Bird";
                    images[17] = "Chicken"; ;
                    images[18] = "Dog";
                    images[19] = "Goat";
                    break;
                case (PicturesMode.enWondorsOfWorld):
                    images[0] = "Babil";
                    images[1] = "RealMadridjpg";
                    images[2] = "Maldif";
                    images[3] = "KhalifaTawer";
                    images[4] = "TajMahal";
                    images[5] = "AboAlhole";
                    images[6] = "Tower";
                    images[7] = "GreatWall";
                    images[8] = "Colosseum";
                    images[9] = "Pyramids";

                    images[10] = "Babil";
                    images[11] = "RealMadridjpg";
                    images[12] = "Maldif";
                    images[13] = "KhalifaTawer";
                    images[14] = "TajMahal";
                    images[15] = "AboAlhole";
                    images[16] = "Tower";
                    images[17] = "GreatWall";
                    images[18] = "Colosseum";
                    images[19] = "Pyramids";
                    break;
                case (PicturesMode.enSocialMidea):
                    images[0] = "Instagram";
                    images[1] = "Linkedin";
                    images[2] = "Pint";
                    images[3] = "Snapchat";
                    images[4] = "Ticktok";
                    images[5] = "Twitter";
                    images[6] = "Whats";
                    images[7] = "Whatsapp";
                    images[8] = "Youtube";
                    images[9] = "Google";

                    images[10] = "Instagram";
                    images[11] = "Linkedin";
                    images[12] = "Pint";
                    images[13] = "Snapchat";
                    images[14] = "Ticktok";
                    images[15] = "Twitter";
                    images[16] = "Whats";
                    images[17] = "Whatsapp";
                    images[18] = "Youtube";
                    images[19] = "Google";
                    break;
                case (PicturesMode.enDahabAndGhasan):
                    images[0] = "Dahab1";
                    images[1] = "Dahab2";
                    images[2] = "Dahab3";
                    images[3] = "Dahab4";
                    images[4] = "Dahab5";
                    images[5] = "Ghasan1";
                    images[6] = "Ghasan2";
                    images[7] = "Ghasan3";
                    images[8] = "Ghasan4";
                    images[9] = "Ghasan5";

                    images[10] = "Dahab1";
                    images[11] = "Dahab2";
                    images[12] = "Dahab3";
                    images[13] = "Dahab4";
                    images[14] = "Dahab5";
                    images[15] = "Ghasan1";
                    images[16] = "Ghasan2";
                    images[17] = "Ghasan3";
                    images[18] = "Ghasan4";
                    images[19] = "Ghasan5";
                    break;
            }


            

        }
        private void AllocationPicture()
        {

            pictureBox1.Image = Resources.QustionMark;
            pictureBox2.Image = Resources.QustionMark;
            pictureBox3.Image = Resources.QustionMark;
            pictureBox4.Image = Resources.QustionMark;
            pictureBox5.Image = Resources.QustionMark;
            pictureBox6.Image = Resources.QustionMark;
            pictureBox7.Image = Resources.QustionMark;
            pictureBox8.Image = Resources.QustionMark;
            pictureBox9.Image = Resources.QustionMark;
            pictureBox10.Image = Resources.QustionMark;
            pictureBox11.Image = Resources.QustionMark;
            pictureBox12.Image = Resources.QustionMark;
            pictureBox13.Image = Resources.QustionMark;
            pictureBox14.Image = Resources.QustionMark;
            pictureBox15.Image = Resources.QustionMark;
            pictureBox16.Image = Resources.QustionMark;
            pictureBox17.Image = Resources.QustionMark;
            pictureBox18.Image = Resources.QustionMark;
            pictureBox19.Image = Resources.QustionMark;
            pictureBox20.Image = Resources.QustionMark;


            DownloadPicturesAndPutItAtTag();

           

            ShufellImages(images);

            pictureBox1.Tag = images[0];
            pictureBox2.Tag = images[1];
            pictureBox3.Tag = images[2];
            pictureBox4.Tag = images[3];
            pictureBox5.Tag = images[4];
            pictureBox6.Tag = images[5];
            pictureBox7.Tag = images[6];
            pictureBox8.Tag = images[7];
            pictureBox9.Tag = images[8];
            pictureBox10.Tag = images[9];
            pictureBox11.Tag = images[10];
            pictureBox12.Tag = images[11];
            pictureBox13.Tag = images[12];
            pictureBox14.Tag = images[13];
            pictureBox15.Tag = images[14];
            pictureBox16.Tag = images[15];
            pictureBox17.Tag = images[16];
            pictureBox18.Tag = images[17];
            pictureBox19.Tag = images[18];
            pictureBox20.Tag = images[19];

            

        }
        private bool CheckTwoImages(PictureBox image1, PictureBox image2)
        {
            return image1.Tag == image2.Tag;
        }  
        private void ChangeImage(PictureBox Pic)
        {
            

            Pic.Image =Image.FromFile(@"D:\Work Space\Programming\Programming Advice\.NET Freamwork And C#\Memory Game\Pictures\"+Pic.Tag+".jpg");
            Refresh();
            Thread.Sleep(500);

        }
        private void ChangeTurn()
        {
            if (Mode == frmMain.ModeTheGame.TwoPlayer)
            {
                if (NowTurn == PlayerTurn.playerTwo)
                {
                    NowTurn = PlayerTurn.PlayerOne;
                    lbTurnRuselt.Text = "Player One";
                    lbTurn.BackColor = Color.Brown;
                    lbTurn.ForeColor = Color.WhiteSmoke;
                    lbTurnRuselt.ForeColor = Color.Crimson;
                }

                else
                {
                    NowTurn = PlayerTurn.playerTwo;
                    lbTurnRuselt.Text = "Player Two";
                    lbTurn.BackColor = Color.White;
                    lbTurn.ForeColor = Color.Black;
                    lbTurnRuselt.ForeColor = Color.Black;
                }
            }
            else
                return;

           
                
        }
        private void CulculateResult()
        {
            CountOfTheGame++;

            if (Mode == frmMain.ModeTheGame.TwoPlayer)
            {
                if (NowTurn == PlayerTurn.playerTwo)
                {
                    PlayerTwo++;
                    LBPlayerTwoResult.Text = PlayerTwo.ToString();
                }
                else
                {
                    playerOne++;
                    LBPlayerOneResult.Text = playerOne.ToString();
                }
            }
            else
            {
                playerOne++;
                LBPlayerOneResult.Text = playerOne.ToString();

            }
               
        }
        private void ShowResult()
        {
            PanalPictures.Enabled = false;
            if (playerOne > PlayerTwo)
            {
                MessageBox.Show("Player One Won The Game ....", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (PlayerTwo > playerOne)
            {
                MessageBox.Show("Player Two Won The Game ....", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                MessageBox.Show("Draw ....", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void EnablePictures()
        {
            PanalPictures.Enabled = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox16.Enabled = true;
            pictureBox17.Enabled = true;
            pictureBox18.Enabled = true;
            pictureBox19.Enabled = true;
            pictureBox20.Enabled = true;
            
        }
        private void RestartTheGame()
        {
            NowTurn = PlayerTurn.PlayerOne;
            CountOfTheGame = 0;
            playerOne = 0;
            PlayerTwo = 0;
            LBPlayerOneResult.Text = "0";
            LBPlayerTwoResult.Text = "0";
            lbTurnRuselt.Text = "Player One";
            lbTurn.BackColor = Color.Brown;
            lbTurn.ForeColor = Color.WhiteSmoke;
            lbTurnRuselt.ForeColor = Color.Crimson;
            prevPicture = null;
            EnablePictures();
            AllocationPicture();
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartTheGame();

        }

        private void DoGame(PictureBox Pic)
        {
            if(CountOfTheGame >= 10)
            {
                ShowResult();
            }

           
            
                ChangeImage(Pic);



            if (prevPicture == null)
            {
                prevPicture = Pic;
                prevPicture.Enabled = false;
                return;
            }
            else
            {

                if(CheckTwoImages(Pic,prevPicture))
                {
                    CulculateResult();
                    Pic.Enabled = false;
                    prevPicture = null;
                }
                else
                {
                    prevPicture.Image = Resources.QustionMark;
                    prevPicture.Enabled = true;
                    Pic.Image = Resources.QustionMark;
                    Pic.Enabled = true;
                    prevPicture = null;
                    ChangeTurn();
                }
                

            }

            if (CountOfTheGame >= 10)
            {
                ShowResult();
            }



        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DoGame((PictureBox)sender);
        }
    }
}
