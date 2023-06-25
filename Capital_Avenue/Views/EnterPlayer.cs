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
using Capital_Avenue.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using TextBox = System.Windows.Forms.TextBox;

namespace Capital_Avenue.Views
{
    public partial class EnterPlayer : UserControl
    {
        private List<PlayerTextbox> PlayerTextList;
        public EnterPlayer()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            PlayerTextList = new List<PlayerTextbox>();
            for (int i = 2; i <= 4; i++)
            {
                this.NumberPlayer.Items.Add(i);
            }
            this.NumberPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void OnMyPawnPrinterChanged(object sender, EventArgs e)
        {     
            leftPlayerPanel.Controls.Clear();
            PlayerTextList.Clear();
            int selectedNumber = (int)NumberPlayer.SelectedItem;
            for (int i = 1; i <= selectedNumber; i++)
            {
                this.addPlayerTex(i);
            }
        }
        public void addPlayerTex(int position)
        {
            PlayerTextbox playerTextbox = new PlayerTextbox(position);
            PlayerTextList.Add(playerTextbox);
            leftPlayerPanel.Size = new Size(500, 850);
            leftPlayerPanel.Controls.Add(playerTextbox);

        }

        private bool ValidateForm()
        {
            for (int i = 0; i < PlayerTextList.Count; i++)
            {
                if (PlayerTextList[i].Textbox.Text.Length == 0)
                {
                    MessageBox.Show("Rempliser les champs vides");
                    return false;

                }

                for (int g = 0; g < PlayerTextList.Count - 1; g++)
                {
                    for (int j = g + 1; j < PlayerTextList.Count; j++)
                    {
                        if ((PlayerTextList[g].comboBox.SelectedIndex.ToString()) ==
                            (PlayerTextList[j].comboBox.SelectedIndex.ToString()))
                        {
                            MessageBox.Show("les avatars son identiques");
                            return false;
                        }
                    }
                }

            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Player> playerList = new List<Player>();
            if (this.ValidateForm())
            {
                for (int i = 0; i < PlayerTextList.Count; i++)
                {
                    if (PlayerTextList[i].Textbox.Text.Length != 0)

                    {
                        Player p = new Player(PlayerTextList[i].Textbox.Text, int.Parse(PlayerTextList[i].comboBox.SelectedIndex.ToString()), 1200);
                        playerList.Add(p);
                    }
                }
                Game newGame = new Game(playerList);
                Program.PageHome.NextPage(new Monopoly(newGame));
            }
        }
    }
}
