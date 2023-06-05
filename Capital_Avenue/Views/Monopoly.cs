
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
    public partial class Monopoly : UserControl
    {

        private Game currentGame;
        private LeftPanel UCLeftPanel;
        private Dice d;
        private int Ldice = 0;
        private int NbDice = 2;
        public Monopoly(Game game)
        {
            InitializeComponent();
            this.currentGame = game;
            //this.Dock = DockStyle.Fill;
            this.addPlayerPanel();
            //this.addPawnPanel();
            currentPlayerName.Text = game.playerList[0].Name + ", lancer vos dés";
            this.InitializeDice();

            /*this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; */
            ucBoard1.InitPawns(game.playerList);
        

        }
        public void InitializeDice()
        {
            d = new Dice();
            d.addDice(Ldice, NbDice);
            pictureBox2.Enabled = false;
            pictureBox2.BackColor = Color.Red;
            pictureBox1.BackColor = Color.Green;
            for (int i = 0; i < d.DiceList.Count; i++)
            {
                if (i == 0)
                {
                    DiceShow.Text = "Dés : " + d.DiceList[i].ToString();
                }
                else
                {
                    DiceShow.Text += " + " + d.DiceList[i].ToString();
                }

            }
            DiceResultShow.Text = "Résultats  :" + d.ResultDice.ToString();
        }

        public void addPlayerPanel()
        {
            UCLeftPanel = new LeftPanel(currentGame.playerList);
            UCLeftPanel.Size = new Size(500, 840);
            this.Controls.Add(UCLeftPanel);

        }
        public void CalculeDice()
        {
            d.ResultDice = 0;

            for (int i = 0; i < d.DiceList.Count; i++)
            {
                if (i == 0)
                {
                    DiceShow.Text = " Dés  :  " + d.DiceList[i].ToString();
                }
                else
                {
                    DiceShow.Text += "  +  " + d.DiceList[i].ToString();
                }
                d.ResultDice += d.DiceList[i];
            }
            DiceResultShow.Text = "Résultats  " + d.ResultDice.ToString();
        }
        public void diceShow()
        {
            d.DiceThrower();
            this.CalculeDice();

        }

        /* public void onDice_Click(object sender, EventArgs e)
         {
             this.diceShow();
             onDice.Enabled = false;
             PasserTour.Enabled = true;

         }*/
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.diceShow();
            pictureBox1.Enabled = false;
            //pictureBox1.Enabled = false;
            pictureBox1.BackColor = Color.Red;
            pictureBox2.Enabled = true;
            pictureBox2.BackColor = Color.Green;
            int currentPlayerIndex = currentGame.currentPlayer;
            Player currentPlayer = currentGame.playerList[currentPlayerIndex];
            ucBoard1.MovePawn(currentPlayer, d.ResultDice) ; 

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int currentPlayerIndex = currentGame.currentPlayer;
            if (currentPlayerIndex > currentGame.playerList.Count)
            {
                currentPlayerIndex = 0;
            }
            currentGame.EndTurn();
            pictureBox1.Enabled = true;
            pictureBox1.BackColor = Color.Green;

            this.InitializeDice();
            currentPlayerName.Text = currentGame.playerList[currentPlayerIndex].Name + ", lancer vos dés";
        }
        /*
        public void PasserTour_Click(object sender, EventArgs e)
        {
            int currentPlayerIndex = currentGame.currentPlayer;
            if (currentPlayerIndex > currentGame.playerList.Count)
            {
                currentPlayerIndex = 0;
            }
            currentGame.EndTurn();
            pictureBox1.Enabled = true;
            pictureBox1.BackColor = Color.Green;

            this.InitializeDice();
            currentPlayerName.Text = currentGame.playerList[currentPlayerIndex].Name + ", lancer vos dés";

        }*/

        public void onBankrupt_Click()
        {
            currentGame.Bankruptcy();
            UCLeftPanel.UpdateValues();
        }
        private void UCMonopoly_Load(object sender, EventArgs e)
        {

        }


    }
}
