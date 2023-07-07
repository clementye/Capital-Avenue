using Capital_Avenue.Views;
using System.Media;

namespace Capital_Avenue
{
    public partial class CAWindow : Form
    {

        public SoundPlayer simpleSound;
        

        public CAWindow()
        {
            InitializeComponent();
            this.Controls.Add(new HomePage());
            
            simpleSound = new SoundPlayer(Properties.Resources.button_sound);
            simpleSound.Play();

        }
        public void NextPage(UserControl uc)
        {
            this.Controls.Clear();
            this.Controls.Add(uc);
        }

        private void CAWindow_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None; // Activate only during presentation
            this.WindowState = FormWindowState.Maximized;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.SetDesktopLocation(x, y);
        }


    }
}