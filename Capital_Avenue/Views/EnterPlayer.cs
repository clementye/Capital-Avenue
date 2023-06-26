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

            this.NumberPlayer.Anchor = AnchorStyles.None;
            int dropdownWidth = this.NumberPlayer.Width;
            int dropdownHeight = this.NumberPlayer.Height;
            int panelWidth = this.Width;
            int dropdownX = (panelWidth - dropdownWidth) / 2;
            int dropdownY = 10; 
            this.NumberPlayer.Location = new Point(dropdownX, dropdownY);

            for (int i = 2; i <= 4; i++)
            {
                this.NumberPlayer.Items.Add(i);
            }
            this.NumberPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            System.Windows.Forms.Button button1 = new System.Windows.Forms.Button(); 
            button1.Text = "Confirmer";
            button1.Size = new Size(100, 30);
            button1.Location = new Point(dropdownX, dropdownY + dropdownHeight + 10); 
            button1.Click += button1_Click;
            this.Controls.Add(button1);
            this.SizeChanged += EnterPlayer_SizeChanged;
        }

        private void EnterPlayer_SizeChanged(object sender, EventArgs e)
        {

            int dropdownWidth = this.NumberPlayer.Width;
            int panelWidth = this.Width;
            int dropdownX = (panelWidth - dropdownWidth) / 2;
            int dropdownY = 10; 
            this.NumberPlayer.Location = new Point(dropdownX, dropdownY);

            if (this.Controls.Count > 0 && this.Controls[this.Controls.Count - 1] is System.Windows.Forms.Button button1)
            {
                int buttonY = dropdownY + this.NumberPlayer.Height + 60; 
                button1.Location = new Point(dropdownX, buttonY);
            }
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
                    MessageBox.Show("Please fill in all fields.");
                    return false;
                }

                for (int g = 0; g < PlayerTextList.Count - 1; g++)
                {
                    for (int j = g + 1; j < PlayerTextList.Count; j++)
                    {
                        if ((PlayerTextList[g].comboBox.SelectedIndex.ToString()) ==
                            (PlayerTextList[j].comboBox.SelectedIndex.ToString()))
                        {
                            MessageBox.Show("The avatars are identical.");
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}