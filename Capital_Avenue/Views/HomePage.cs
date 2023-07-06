namespace Capital_Avenue.Views
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
            //pictureBox1.Dock = DockStyle.Right;

            this.BackgroundImage = Properties.Resources.font1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Dock = DockStyle.Fill;
            //button1.Location = new Point(800, 800);

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            btn_Start.Image = Properties.Resources.start_hover;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_hover;
        }
        private void btn_Start_Click_Mouveleave(object sender, EventArgs e)
        {
            btn_Start.Image = Properties.Resources.start_normal;
        }
        private void btn_exit_Click_Mouveleave(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_normal;
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Program.PageHome.NextPage(new EnterPlayer());
        }
        private void option_Click(object sender, EventArgs e)
        {

            // menu.Hide();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
