using Capital_Avenue.Views;

namespace Capital_Avenue
{
    public partial class CAWindow : Form
    {
        public CAWindow()
        {
            InitializeComponent();
            this.Controls.Add(new UCHomePage());
        }
        public void NextPage(UserControl uc)
        {
            this.Controls.Clear();
            this.Controls.Add(uc);
        }

        private void CAWindow_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        
    }
}