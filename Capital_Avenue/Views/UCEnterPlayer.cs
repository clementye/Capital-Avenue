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
    public partial class UCEnterPlayer : UserControl
    {
        private List<PlayerTextbox> PlayerTextList;
        public UCEnterPlayer(int NumberPlayer)
        {
            InitializeComponent();
            PlayerTextList = new List<PlayerTextbox>();
            for (int i = 1; i <= NumberPlayer; i++)
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
                if (PlayerTextList[i].Textbox.Text.Length == 0 )   
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
           
            //System.Diagnostics.Debug.WriteLine(System.Drawing.Image.FromFile(PlayerTextList[0].comboBox.Text));
            return true;

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            // j'appuie sur ENTER après avoir remplis les champs
            // je dois :
            // => valider les champs !
            // si NOK : affichage des erreurs (par une fonction dédié)
            // else : récupération des champs, et initialisation de la partie avec les valeurs fournis

            List<CLPlayer> playerList = new List<CLPlayer>();
            if (this.ValidateForm())
            {
<<<<<<< HEAD
                CLPlayer p = new CLPlayer(Player1.Text, "Voiture", 1);
                CLPawn pa = new CLPawn("Voiture", Player1.Text);
                CLPlayer p2 = new CLPlayer(Player2.Text, "Chaussure", 1);
                List<CLPlayer> playerList = new List<CLPlayer>();
                List<CLPawn> pawnList = new List<CLPawn>();
                playerList.Add(p);
                playerList.Add(p2);
                pawnList.Add(pa);
                Game newGame = new Game(playerList, pawnList);
=======
                for (int i = 0; i < PlayerTextList.Count; i++)
                {
                    if (PlayerTextList[i].Textbox.Text.Length != 0)
                        
                    {
                        CLPlayer p = new CLPlayer(PlayerTextList[i].Textbox.Text, int.Parse(PlayerTextList[i].comboBox.SelectedIndex.ToString()), 1);
                       playerList.Add(p);
                    }
                }
                Game newGame = new Game(playerList);
>>>>>>> feature/PlayerSetup
                Program.PageHome.NextPage(new UCMonopoly(newGame));

            }



            /*
           if (Player1.Text.Length > 0) // TODO add other test to validate view
           {

               CLPlayer p = new CLPlayer(Player1.Text, "Voiture", 1);
               CLPlayer p2 = new CLPlayer(Player2.Text, "Chaussure", 1);
               List<CLPlayer> playerList = new List<CLPlayer>();
               playerList.Add(p);
               playerList.Add(p2);
               Game newGame = new Game(playerList);
               Program.PageHome.NextPage(new UCMonopoly(newGame));
           }
           else
           {
               MessageBox.Show("Remplisez les champs vides");
           }  */
        }
    }
}
