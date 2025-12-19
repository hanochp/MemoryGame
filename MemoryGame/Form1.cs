namespace MemoryGame
{
    public partial class MemoryGame : Form
    {
        string path = Application.StartupPath + @"\Images\";
        //create a list for all picture boxes
        List<PictureBox> lstallpictureboxes;
        enum gamestage { NotPlaying, Playing};
        gamestatus gamestatus = MemoryGame.gamestatus.NotPlaying;

        public MemoryGame()
        {
            InitializeComponent();
            // instantiate the list of picture boxes
            lstallpictureboxes = new() {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
                pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10,
                pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15
            };
            //put a question mark in each picture box
            lstallpictureboxes.ForEach(p => p.ImageLocation = path + "question-mark-icon.png");
        }




    }
}
