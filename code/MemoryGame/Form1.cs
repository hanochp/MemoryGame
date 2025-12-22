namespace MemoryGame
{
    public partial class MemoryGame : Form
    {
        string path = Application.StartupPath + @"\Images\";
        //create a list for all picture boxes
        List<PictureBox> lstallpictureboxes;
        //create a list of all images
        List<Image> lstimages;
        List<PictureBox> cardsturnedover = new();

        List<Image> cardimages;
        enum GameStageEnum { NotPlaying, Playing, NoCardsSelected, OneCardSelected, TwoCardsSelected }
        GameStageEnum gamestatus = MemoryGame.GameStageEnum.NotPlaying;
        GameStageEnum CardsSelected = GameStageEnum.NoCardsSelected;

        enum EnableDisableEnum { enable, disable }

        int setsfound;
        int turnstaken;



        public MemoryGame()
        {
            InitializeComponent();
            CenterOverlayPanel();
            // instantiate the list of picture boxes
            lstallpictureboxes = new() {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
                pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10,
                pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15,
                pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20,
                pictureBox21, pictureBox22, pictureBox23, pictureBox24
            };
            //put a question mark in each picture box
            lstallpictureboxes.ForEach(p => p.ImageLocation = path + "question-mark-icon.png");


            //instantiate list of images
            lstimages = new() {
                Properties.Resources.Image1, Properties.Resources.Image2, Properties.Resources.Image3,
                Properties.Resources.Image4, Properties.Resources.Image5, Properties.Resources.Image6,
                Properties.Resources.Image7, Properties.Resources.Image8, Properties.Resources.Image9,
                Properties.Resources.Image10, Properties.Resources.Image11, Properties.Resources.Image12
            };

            cardimages = new List<Image>(new Image[24]);

            //click event for cards
            lstallpictureboxes.ForEach(p => p.Click += Picture_Click);
            //disable all controls till the player clicks start
            EnableDisableAllControls(EnableDisableEnum.disable);

            btnStart.Click += BtnStart_Click;
            btnRestart.Click += BtnRestart_Click;
            this.Resize += MemoryGame_Resize;
            AssignPicturesToPictureBoxVariables();
            lblMessage.Text = "Click Start To Start Playing!";

        }

        private void MemoryGame_Resize(object? sender, EventArgs e)
        {
            CenterOverlayPanel();
        }

        private void CenterOverlayPanel()
        {
            pnlMessage.Left = (ClientSize.Width - pnlMessage.Width) / 2;
            pnlMessage.Top = (ClientSize.Height - pnlMessage.Height) / 2;
        }

      

        private void EnableDisableAllControls(EnableDisableEnum enable)
        {
            bool enabledisable = enable == EnableDisableEnum.enable;
            lstallpictureboxes.ForEach(pb => pb.Enabled = enabledisable);
            btnRestart.Enabled = enabledisable;
        }

        private void AssignPicturesToPictureBoxVariables()
        {
            Image im;
            Random rnd = new();
            List<Image> usedimages = new();
            for (int ind = 0; ind < cardimages.Count(); ind++)
            {

                im = lstimages.Where(i => usedimages.Count(x => x == i) < 2).ToList().OrderBy(_ => rnd.Next()).First();
                cardimages[ind] = im;
                usedimages.Add(im);


            }

        }

        private void UpdateScoreAndTurnsTaken()
        {
            lblTurnsTaken.Text = "Turns Taken: " + turnstaken.ToString();
            lblSetsFound.Text = "Sets Found: " + setsfound.ToString();
        }
        private void TakeTurn(PictureBox pb)
        {

            if (gamestatus == GameStageEnum.Playing && cardsturnedover.Contains(pb) == false && pb.Image != null)
            {

                if (CardsSelected == GameStageEnum.NoCardsSelected)
                {
                    TurnOverCard(pb);
                    cardsturnedover.Add(pb);
                    CardsSelected = GameStageEnum.OneCardSelected;
                }
                else if (CardsSelected == GameStageEnum.OneCardSelected)
                {
                    TurnOverCard(pb);
                    CardsSelected = GameStageEnum.TwoCardsSelected;
                    cardsturnedover.Add(pb);

                    CheckIfMatch(cardsturnedover);


                }

            }
        }

        private void TurnOverCard(PictureBox pb)
        {

            int index = lstallpictureboxes.IndexOf(pb);
            pb.Image = cardimages[index];
        }

        private PictureBox GetTickPictureBox()
        {
            PictureBox tick = new() { Image = Properties.Resources.Tick, SizeMode = PictureBoxSizeMode.Zoom, BackColor = Color.Transparent, Size = new Size(120, 120), };
            return tick;
        }

        private async void CheckIfMatch(List<PictureBox> lstcardsturnedover)
        {
            if (CardsSelected == GameStageEnum.TwoCardsSelected && lstcardsturnedover.Count == 2)
            {


                bool b = lstcardsturnedover[0].Image == lstcardsturnedover[1].Image;
                if (b == true)
                {


                    foreach (PictureBox i in lstcardsturnedover)
                    {
                        PictureBox tick = GetTickPictureBox();
                        tick.Parent = i;
                        tick.BringToFront();
                        tick.Location = new Point(i.Width - tick.Width - 5, 5);

                    }

                    await Task.Delay(2000);


                    lstcardsturnedover.ForEach(c =>
                    {
                        c.Image = null;
                        foreach (PictureBox tick in c.Controls.OfType<PictureBox>())
                        {
                            tick.Visible = false;
                        }


                    });

                    
                    setsfound++;


                }
                else if (b == false)
                {
                    await Task.Delay(1000);
                    lstcardsturnedover.ForEach(c => c.Image = Properties.Resources.question_mark_icon);
                }
                CardsSelected = GameStageEnum.NoCardsSelected;
                lstcardsturnedover.Clear();
                turnstaken++;
                UpdateScoreAndTurnsTaken();
                DetectLoose();
                DetectWin();
            }

        }

        private async void DetectLoose()
        {
            if (turnstaken - setsfound >= 15)
            {
                pnlMessage.Visible = true;
                lblMessage.Text = "Sorry.. you lost! you had too many missed Tries.. try again";
                EnableDisableAllControls(EnableDisableEnum.disable);
                await Task.Delay(2000);
                pnlMessage.Visible = false;
                EnableDisableAllControls(EnableDisableEnum.enable);
                RestartGame();
            }

            else
            {
                return;
            }
        }

        private async void DetectWin()
        {
            if(setsfound == 12)
            {
                pnlMessage.Visible = true;
                lblMessage.Text = "Great Job! you managed to match all sets, You Won!!";
                await Task.Delay(2000);
                pnlMessage.Visible = false;
                await Task.Delay(0005);
                RestartGame();
                
                
                
                

            }
        }

        private void RestartGame()
        {
            setsfound = 0;
            turnstaken = 0;
            UpdateScoreAndTurnsTaken();
            AssignPicturesToPictureBoxVariables();
            lstallpictureboxes.ForEach(p => p.ImageLocation = path + "question-mark-icon.png");
            gamestatus = GameStageEnum.NotPlaying;
            EnableDisableAllControls(EnableDisableEnum.disable);
            pnlMessage.Visible = true;
            lblMessage.Text = "Click Start To Start Playing!";


        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            if (gamestatus == GameStageEnum.NotPlaying)
            {
                gamestatus = GameStageEnum.Playing;
                pnlMessage.Visible = false;
                EnableDisableAllControls(EnableDisableEnum.enable);
            }
        }

        private void BtnRestart_Click(object? sender, EventArgs e)
        {
            if (gamestatus == GameStageEnum.Playing && turnstaken >= 1)
            {
                
                RestartGame();
            }

        }
        private void Picture_Click(object? sender, EventArgs e)
        {
            PictureBox pb = new();
            if (sender is PictureBox)
            {
                pb = (PictureBox)sender;
            }
            TakeTurn(pb);

        }
    }
}
