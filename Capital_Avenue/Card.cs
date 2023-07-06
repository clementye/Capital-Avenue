namespace Capital_Avenue
{
    public partial class Card : Form
    {
        public Card(Image image, string M, string TypeCard)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            label1.Text = M;
            label2.Text = TypeCard;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
