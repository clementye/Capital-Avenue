using System.Text;

namespace Capital_Avenue.Views
{
    using Models;
    using Capital_Avenue.Services;
    public class LeftPanel : UserControl
    {
        private List<Player> PlayerList;
        public LeftPanel(List<Player> playerList)
        {
            this.PlayerList = playerList;
            List<string> colors = ConfigService.GetPlayerColors();
            int basePosition = 120;
            int space = 25;
            for (int i = 0; i < playerList.Count; i++)
            {
                int pos = basePosition;
                if (i > 0)
                    pos = basePosition * (i + 1) + space * i;
                this.AddPlayerUC(playerList[i], colors[i], pos);
            }
        }

        public void AddPlayerUC(Player player, string color, int position)
        {
            UserControl uc1 = new UserControl();
            Panel p1 = new Panel();
            Label l1 = new Label();
            Label l2 = new Label();
            Label l3 = new Label();
            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.FlowDirection = FlowDirection.TopDown;
            flow.AutoSize = true;

            l1.Text = player.Name;
            p1.Controls.Add(l1);

            l2.Text = "Properties: " + player.OwnedProperties.Count.ToString();
            l2.Location = new Point(0, 30);
            p1.Controls.Add(l2);

            l3.Text = "Capital: " + player.Capital.ToString();
            l3.Location = new Point(0, 60);
            p1.Controls.Add(l3);

            Button propertiesButton = new Button();
            propertiesButton.Text = "Properties";
            propertiesButton.Size = new Size(90, 40);
            propertiesButton.Location = new Point(0, 85);
            propertiesButton.Click += (sender, e) => PropertiesButton_Click(player);
            p1.Controls.Add(propertiesButton);

            p1.BackColor = ColorTranslator.FromHtml(color);
            p1.Size = new Size(200, 130);
            p1.BorderStyle = BorderStyle.FixedSingle;

            uc1.Location = new Point(0, position);
            uc1.Size = new Size(200, 130);
            uc1.Controls.Add(p1);

            this.Controls.Add(uc1);
        }

        private void PropertiesButton_Click(Player player)
        {
            StringBuilder propertiesList = new StringBuilder();
            propertiesList.AppendLine($"Properties of {player.Name}:");
            foreach (var property in player.OwnedProperties)
            {
                if (property.IsInBank == false)
                {
                    propertiesList.AppendLine(property.Name);
                }
                else
                {
                    propertiesList.AppendLine(property.Name + "\U0001F3E6");
                }
            }

            MessageBox.Show(propertiesList.ToString(), "Player Properties");
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // LeftPanel
            // 
            BackgroundImageLayout = ImageLayout.Stretch;
            Name = "LeftPanel";
            ResumeLayout(false);
        }

        public void UpdatePlayerUC(Player player)
        {
            // Réinitialisation des boutons de tour
            foreach (UserControl uc in this.Controls)
            {
                if (uc.Controls[0] is Panel panel)
                {
                    // Recherche du bouton de tour existant et le supprimer
                    Control[] existingButtons = panel.Controls.Find("turnButton", true);
                    foreach (var button in existingButtons)
                    {
                        panel.Controls.Remove(button);
                        button.Dispose();
                    }

                    // Vérification du joueur en cours et ajout du bouton de tour si nécessaire
                    if (panel.Controls[0].Text == player.Name)
                    {
                        Button turnButton = new Button();
                        turnButton.Name = "turnButton";
                        turnButton.Text = "Tour";
                        turnButton.BackColor = Color.Red;
                        turnButton.ForeColor = Color.White;
                        turnButton.Size = new Size(80, 30);
                        int x = panel.Width - turnButton.Width - 10;
                        int y = panel.Height - turnButton.Height - 10;
                        turnButton.Location = new Point(x, y);
                        PictureBox jailCellPictureBox = panel.Controls.Find("jailCellPictureBox", true).FirstOrDefault() as PictureBox;
                        panel.Controls.Add(turnButton);
                    }

                    if (panel.Controls[0].Text == player.Name)
                    {
                        panel.Controls[1].Text = "Properties: " + player.OwnedProperties.Count.ToString();
                        panel.Controls[2].Text = "Capital: " + player.Capital.ToString();

                        PictureBox jailCellPictureBox = panel.Controls.Find("jailCellPictureBox", true).FirstOrDefault() as PictureBox;

                        if (player.isInJail)
                        {
                            if (jailCellPictureBox == null)
                            {
                                jailCellPictureBox = new PictureBox();
                                jailCellPictureBox.Name = "jailCellPictureBox";
                                jailCellPictureBox.Image = Properties.Resources.jail_cell;
                                jailCellPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                jailCellPictureBox.Size = new Size(50, 50);

                                int x = panel.Width - jailCellPictureBox.Width - 10;
                                int y = 10;
                                jailCellPictureBox.Location = new Point(x, y);

                                panel.Controls.Add(jailCellPictureBox);
                            }
                            jailCellPictureBox.Visible = true;
                        }
                        else
                        {
                            if (jailCellPictureBox != null)
                            {
                                panel.Controls.Remove(jailCellPictureBox);
                                jailCellPictureBox.Dispose();
                            }

                            int playerIndex = PlayerList.FindIndex(x => x.Name == player.Name);
                            List<string> colors = ConfigService.GetPlayerColors();
                            if (playerIndex >= 0 && playerIndex < colors.Count)
                            {
                                panel.BackColor = ColorTranslator.FromHtml(colors[playerIndex]);
                            }

                            panel.BorderStyle = BorderStyle.FixedSingle;
                        }
                    }


                    // Reste du code pour la mise à jour des autres informations des joueurs
                    // ...
                }

            }
        }
    }
}

