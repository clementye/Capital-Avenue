using Capital_Avenue.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue.Views
{
    public partial class UCMonopoly : UserControl
    {
        private string hexPlay1 = "#6aff2d";
<<<<<<< HEAD
        private Game currentGame;
        private LeftUCPanel UCLeftPanel;
        public UCMonopoly(Game game)
=======

        //Le système de lancer de dés est chiant à faire, faudra que je trouve une technique pour ça.
        //J'arrive pas à juste le faire s'afficher par dessus le reste en étant semi-transparent. Il doit y avoir une technique.
        public UCMonopoly() //Always here
>>>>>>> f38c7195e728e5200a61581d6e8c1ffd3477df8e
        {
            InitializeComponent();
            this.currentGame = game;

            this.Dock = DockStyle.Fill;
            //this.dicethrow();
            this.addPlayerPanel();

            /*this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; */
        }

        public void addPlayerPanel()
        {
<<<<<<< HEAD
            UCLeftPanel = new LeftUCPanel(currentGame.playerList);
            UCLeftPanel.Size = new Size(500, 840);
            this.Controls.Add(UCLeftPanel);
            
        }

        public void onDiceClick()
        {
            // je lance les dés, je réfresh l'affichage, je déplace l'icone du joueur, j'actualise le monde.

            UCLeftPanel.UpdateValues();
=======
            LeftUCPanel lucp = new LeftUCPanel();
            lucp.Size = new Size(800, 840);
            this.Controls.Add(lucp);
>>>>>>> f38c7195e728e5200a61581d6e8c1ffd3477df8e
        }

        /*public void dicethrow()
        {
            UCDiceThrower ucdt = new UCDiceThrower();
            ucdt.Size = new Size(1440, 840);
            ucdt.BringToFront();
            this.Controls.Add(ucdt);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }*/
        public void UserControl(string name)
        {

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCMonopoly_Load(object sender, EventArgs e)
        {

        }
    }
}
