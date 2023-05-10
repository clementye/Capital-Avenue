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
            // j'appuie sur ENTER après avoir remplis les champs
            // je dois :
            // => valider les champs !
            // si NOK : affichage des erreurs (par une fonction dédié)
            // else : récupération des champs, et initialisation de la partie avec les valeurs fournis

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
                // TODO display errors in view
            }
        }


    }
}
