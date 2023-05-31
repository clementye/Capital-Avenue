using Capital_Avenue.Views;

namespace Capital_Avenue
{
    public partial class CAWindow : Form
    {
        public CAWindow()
        {
            InitializeComponent();
            this.Controls.Add(new HomePage());
        }
        public void NextPage(UserControl uc)
        {
            this.Controls.Clear();
            this.Controls.Add(uc);
        }

        private void CAWindow_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            int x = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.SetDesktopLocation(x, y);
        }

        
    }
}