using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Capital_Avenue.Views
{
    public partial class UCEnterPlayer : UserControl
    {
        public UCEnterPlayer()
        {
            InitializeComponent();


        }

        private void UCEnterPlayer_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                comboBox1.Items.Add(i);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String Name = Joueur1.Text;
            Program.PageHome.NextPage(new UCMonopoly());

        }


    }
}
