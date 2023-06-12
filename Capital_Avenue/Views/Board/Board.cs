using Capital_Avenue.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue.Views.Board
{
    public partial class Board : UserControl
    {
        List<Case> Cases;
        Dictionary<Player, int> PlayerPositions;
        private Dictionary<int, Propriety> Proprie = new Dictionary<int, Propriety>();

        public Board()
        {
            InitializeComponent();
            Cases = new List<Case>();
            PlayerPositions = new();
            CreateBoard();
        }

        public void InitPawns(List<Player> players)
        {
            foreach (Player player in players)
            {
                Cases[0].AddPawn(player);
                PlayerPositions[player] = 0;
            }
        }

        public void InitPawnOnePlayer(Player player, int newmove)
        {

            PlayerPositions[player] = newmove;
            Cases[newmove].AddPawn(player);


        }

        public void MovePawn(Player p, int move)
        {
            int currentPosition = PlayerPositions[p];
            int newCase = PlayerPositions[p] + move;
            //Case.RemovePawn(p);
            if (newCase > 39)
            {
                newCase -= 40;
                p.Capital += 200;
                MessageBox.Show($"vous  Avez réçu 200 euros {p.Name}");
            };
            Cases[PlayerPositions[p]].RemovePawn(p);
            this.InitPawnOnePlayer(p, newCase);
            this.ProprietyEvent(p, newCase);


        }
        public void ProprietyEvent(Player player, int move)
        {

            if (Proprie.ContainsKey(move))
            {
                Propriety p = Proprie[move];
                //p.GetOwnerOfProperty(Proprie[move]);
                if (p.VerificationProperty(Proprie[move]) == true)
                {
                    p.TaxProperty(player, Proprie[move]);
                }
                else
                {
                    string message =
                     $"{player.Name} Voulez vous payer la Propiéte : {p.Name}  \n" +
                     $" qui cout {p.Prix} Euros \n";
                    DialogResult result = MessageBox.Show(message, " Information Propiété ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        p.ValiderProperty(player, Proprie[move]);


                    }
                }

            }

        }



        /* public void MovePawn(Player p, int move)

             int currentPosition = PlayerPositions[p];
             int targetCase = currentPosition + move;

             while (currentPosition != targetCase)
             {
                 currentPosition = (currentPosition + 1) % 40; 
                 Cases[PlayerPositions[p]].RemovePawn(p);
                 PlayerPositions[p] = currentPosition;
                 this.InitPawnOnePlayer(p, currentPosition);
                 Thread.Sleep(200); 
             }
         }
        */



        public void CreateBoard()
        {
            // Configurer les propriétés de dimensionnement du UCBoard
            // AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            // Dock = DockStyle.Fill;
            /*TableLayoutPanel Table = new TableLayoutPanel();
            Table.ColumnCount = 3;
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            Table.RowCount = 2;
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            this.Controls.Add(Table);*/
            //Le code du dessus est une idée pour ajouter sans problème les pions, ainsi que si une propriété est acheté et le nombre de maison dessus si besoin

            Case StartCase = new SquareCase(); // Crée une instance de la case de départ
            StartCase.Location = new Point(782, 776); // Définit la position de la case de départ
            StartCase.BackgroundImage = Properties.Resources.Casedepart;

            Controls.Add(StartCase);


            // Crée et configure la case de prison
            Case PrisonCase = new SquareCase();
            PrisonCase.Location = new Point(0, 776); // Définit la position de la case de prison
            PrisonCase.BackgroundImage = Properties.Resources.case10;
            Controls.Add(PrisonCase);


            Case FreeParkingCase = new SquareCase(); // Crée une instance de la case de parking gratuit
            FreeParkingCase.Location = new Point(782, 0); // Définit la position de la case de parking gratuit
            FreeParkingCase.BackgroundImage = Properties.Resources.case30;
            Controls.Add(FreeParkingCase);

            Case GotojailCase = new SquareCase(); // Crée une instance de la case "Allez en prison"
            GotojailCase.Location = new Point(0, 0); // Définit la position de la case "Allez en prison" 
            GotojailCase.BackgroundImage = Properties.Resources.case20;
            Controls.Add(GotojailCase);

            // LeftRowCase
            Case VerticalLeftCase1 = new VerticalCase();
            VerticalLeftCase1.Location = new Point(0, 124);
            VerticalLeftCase1.BackgroundImage = Properties.Resources.case19;
            Controls.Add(VerticalLeftCase1);

            Case VerticalLeftCase2 = new VerticalCase();
            VerticalLeftCase2.Location = new Point(0, 197);
            VerticalLeftCase2.BackgroundImage = Properties.Resources.case18;
            Controls.Add(VerticalLeftCase2);

            Case VerticalLeftCase3 = new VerticalCase();
            VerticalLeftCase3.Location = new Point(0, 270);
            VerticalLeftCase3.BackgroundImage = Properties.Resources.case17;
            Controls.Add(VerticalLeftCase3);

            Case VerticalLeftCase4 = new VerticalCase();
            VerticalLeftCase4.Location = new Point(0, 343);
            VerticalLeftCase4.BackgroundImage = Properties.Resources.case16;
            Controls.Add(VerticalLeftCase4);

            Case VerticalLeftCase5 = new VerticalCase();
            VerticalLeftCase5.Location = new Point(0, 416);
            VerticalLeftCase5.BackgroundImage = Properties.Resources.case15;
            Controls.Add(VerticalLeftCase5);

            Case VerticalLeftCase6 = new VerticalCase();
            VerticalLeftCase6.Location = new Point(0, 489);
            VerticalLeftCase6.BackgroundImage = Properties.Resources.case14;
            Controls.Add(VerticalLeftCase6);

            Case VerticalLeftCase7 = new VerticalCase();
            VerticalLeftCase7.Location = new Point(0, 562);
            VerticalLeftCase7.BackgroundImage = Properties.Resources.case13;
            Controls.Add(VerticalLeftCase7);

            Case VerticalLeftCase8 = new VerticalCase();
            VerticalLeftCase8.Location = new Point(0, 635);
            VerticalLeftCase8.BackgroundImage = Properties.Resources.case12;
            Controls.Add(VerticalLeftCase8);

            Case VerticalLeftCase9 = new VerticalCase();
            VerticalLeftCase9.Location = new Point(0, 708);
            VerticalLeftCase9.BackgroundImage = Properties.Resources.case11;
            Controls.Add(VerticalLeftCase9);

            // UpCase
            Case HorizontalupCase1 = new HorizontalCase();
            HorizontalupCase1.Location = new Point(124, 0);
            HorizontalupCase1.BackgroundImage = Properties.Resources.case21;
            Controls.Add(HorizontalupCase1);

            Case HorizontalupCase2 = new HorizontalCase();
            HorizontalupCase2.Location = new Point(197, 0);
            HorizontalupCase2.BackgroundImage = Properties.Resources.Case22;
            Controls.Add(HorizontalupCase2);

            Case HorizontalupCase3 = new HorizontalCase();
            HorizontalupCase3.Location = new Point(270, 0);
            HorizontalupCase3.BackgroundImage = Properties.Resources.case23;
            Controls.Add(HorizontalupCase3);

            Case HorizontalupCase4 = new HorizontalCase();
            HorizontalupCase4.Location = new Point(343, 0);
            HorizontalupCase4.BackgroundImage = Properties.Resources.case24;
            Controls.Add(HorizontalupCase4);

            Case HorizontalupCase5 = new HorizontalCase();
            HorizontalupCase5.Location = new Point(416, 0);
            HorizontalupCase5.BackgroundImage = Properties.Resources.case25;
            Controls.Add(HorizontalupCase5);

            Case HorizontalupCase6 = new HorizontalCase();
            HorizontalupCase6.Location = new Point(489, 0);
            HorizontalupCase6.BackgroundImage = Properties.Resources.case26;
            Controls.Add(HorizontalupCase6);

            Case HorizontalupCase7 = new HorizontalCase();
            HorizontalupCase7.Location = new Point(562, 0);
            HorizontalupCase7.BackgroundImage = Properties.Resources.case27;
            Controls.Add(HorizontalupCase7);

            Case HorizontalupCase8 = new HorizontalCase();
            HorizontalupCase8.Location = new Point(635, 0);
            HorizontalupCase8.BackgroundImage = Properties.Resources.case28;
            Controls.Add(HorizontalupCase8);

            Case HorizontalupCase9 = new HorizontalCase();
            HorizontalupCase9.Location = new Point(708, 0);
            HorizontalupCase9.BackgroundImage = Properties.Resources.case29;
            Controls.Add(HorizontalupCase9);

            // RightRowCase
            Case VerticalRightCase1 = new VerticalCase();
            VerticalRightCase1.Location = new Point(782, 124);
            VerticalRightCase1.BackgroundImage = Properties.Resources.case31;
            Controls.Add(VerticalRightCase1);

            Case VerticalRightCase2 = new VerticalCase();
            VerticalRightCase2.Location = new Point(782, 197);
            VerticalRightCase2.BackgroundImage = Properties.Resources.case32;
            Controls.Add(VerticalRightCase2);

            Case VerticalRightCase3 = new VerticalCase();
            VerticalRightCase3.Location = new Point(782, 270);
            VerticalRightCase3.BackgroundImage = Properties.Resources.case33;
            Controls.Add(VerticalRightCase3);

            Case VerticalRightCase4 = new VerticalCase();
            VerticalRightCase4.Location = new Point(782, 343);
            VerticalRightCase4.BackgroundImage = Properties.Resources.case34;
            Controls.Add(VerticalRightCase4);

            Case VerticalRightCase5 = new VerticalCase();
            VerticalRightCase5.Location = new Point(782, 416);
            VerticalRightCase5.BackgroundImage = Properties.Resources.case35;
            Controls.Add(VerticalRightCase5);

            Case VerticalRightCase6 = new VerticalCase();
            VerticalRightCase6.Location = new Point(782, 489);
            VerticalRightCase6.BackgroundImage = Properties.Resources.case36;
            Controls.Add(VerticalRightCase6);

            Case VerticalRightCase7 = new VerticalCase();
            VerticalRightCase7.Location = new Point(782, 562);
            VerticalRightCase7.BackgroundImage = Properties.Resources.case37;
            Controls.Add(VerticalRightCase7);

            Case VerticalRightCase8 = new VerticalCase();
            VerticalRightCase8.Location = new Point(782, 635);
            VerticalRightCase8.BackgroundImage = Properties.Resources.case38;
            Controls.Add(VerticalRightCase8);

            Case VerticalRightCase9 = new VerticalCase();
            VerticalRightCase9.Location = new Point(782, 708);
            VerticalRightCase9.BackgroundImage = Properties.Resources.case39;
            Controls.Add(VerticalRightCase9);

            // DownCase
            Case HorizontaldownCase1 = new HorizontalCase();
            HorizontaldownCase1.Location = new Point(124, 776);
            HorizontaldownCase1.BackgroundImage = Properties.Resources.case9;
            Controls.Add(HorizontaldownCase1);

            Case HorizontaldownCase2 = new HorizontalCase();
            HorizontaldownCase2.Location = new Point(197, 776);
            HorizontaldownCase2.BackgroundImage = Properties.Resources.case8;
            Controls.Add(HorizontaldownCase2);

            Case HorizontaldownCase3 = new HorizontalCase();
            HorizontaldownCase3.Location = new Point(270, 776);
            HorizontaldownCase3.BackgroundImage = Properties.Resources.case7;
            Controls.Add(HorizontaldownCase3);

            Case HorizontaldownCase4 = new HorizontalCase();
            HorizontaldownCase4.Location = new Point(343, 776);
            HorizontaldownCase4.BackgroundImage = Properties.Resources.case6;
            Controls.Add(HorizontaldownCase4);

            Case HorizontaldownCase5 = new HorizontalCase();
            HorizontaldownCase5.Location = new Point(416, 776);
            HorizontaldownCase5.BackgroundImage = Properties.Resources.case5;
            Controls.Add(HorizontaldownCase5);

            Case HorizontaldownCase6 = new HorizontalCase();
            HorizontaldownCase6.Location = new Point(489, 776);
            HorizontaldownCase6.BackgroundImage = Properties.Resources.case4;
            Controls.Add(HorizontaldownCase6);

            Case HorizontaldownCase7 = new HorizontalCase();
            HorizontaldownCase7.Location = new Point(562, 776);
            HorizontaldownCase7.BackgroundImage = Properties.Resources.case3;
            Controls.Add(HorizontaldownCase7);

            Case HorizontaldownCase8 = new HorizontalCase();
            HorizontaldownCase8.Location = new Point(635, 776);
            HorizontaldownCase8.BackgroundImage = Properties.Resources.case2;
            Controls.Add(HorizontaldownCase8);

            Case HorizontaldownCase9 = new HorizontalCase();
            HorizontaldownCase9.Location = new Point(708, 776);
            HorizontaldownCase9.BackgroundImage = Properties.Resources.case1;
            Controls.Add(HorizontaldownCase9);


            //Ajouter les case dans la liste des cases
            Cases.Add(StartCase);
            Cases.Add(HorizontaldownCase9);
            Proprie[1] = new Propriety(1, "GHANA", PGroupe.Marron, 60, 120);
            Cases.Add(HorizontaldownCase8);
            Cases.Add(HorizontaldownCase7);
            Proprie[3] = new Propriety(3, "UGUANDA", PGroupe.Marron, 60, 120);
            Cases.Add(HorizontaldownCase6);
            Cases.Add(HorizontaldownCase5);
            Proprie[5] = new Propriety(5, "READING RAILROAD", PGroupe.Aucun, 200, 400);
            Cases.Add(HorizontaldownCase4);
            Proprie[6] = new Propriety(6, "KENYA", PGroupe.BleauC, 100, 200);
            Cases.Add(HorizontaldownCase3);
            Cases.Add(HorizontaldownCase2);
            Proprie[8] = new Propriety(8, "MADAGASCAR", PGroupe.BleauC, 100, 200);
            Cases.Add(HorizontaldownCase1);
            Proprie[9] = new Propriety(9, "MYANNAR", PGroupe.BleauC, 120, 240);
            Cases.Add(PrisonCase); //10
            Cases.Add(VerticalLeftCase9);//11
            Proprie[11] = new Propriety(11, "NIGERIA", PGroupe.Rose, 140, 280);
            Cases.Add(VerticalLeftCase8);//12
            Proprie[12] = new Propriety(12, "DISTRIBUTION COMPANY", PGroupe.Aucun, 150, 300);
            Cases.Add(VerticalLeftCase7);//13
            Proprie[13] = new Propriety(13, "BANGLADESH", PGroupe.Rose, 140, 280);
            Cases.Add(VerticalLeftCase6);
            Proprie[14] = new Propriety(14, "PHILIPPINES", PGroupe.Rose, 160, 320);
            Cases.Add(VerticalLeftCase5);
            Proprie[15] = new Propriety(15, "PENNSYVALIA ARWAYS", PGroupe.Aucun, 200, 400);
            Cases.Add(VerticalLeftCase4);//16
            Proprie[16] = new Propriety(16, "VET MAN", PGroupe.Orange, 180, 360);
            Cases.Add(VerticalLeftCase3);
            Cases.Add(VerticalLeftCase2);//18
            Proprie[18] = new Propriety(18, "RUSIA", PGroupe.Orange, 180, 360);
            Cases.Add(VerticalLeftCase1);//19
            Proprie[19] = new Propriety(19, "MALAYSIA", PGroupe.Orange, 200, 400);
            Cases.Add(GotojailCase);//20
            Cases.Add(HorizontalupCase1);
            Proprie[21] = new Propriety(21, "INDONESIA", PGroupe.RougeOrange, 220, 440);
            Cases.Add(HorizontalupCase2);//22
            Cases.Add(HorizontalupCase3);
            Proprie[23] = new Propriety(23, "FRANCE", PGroupe.RougeOrange, 220, 440);
            Cases.Add(HorizontalupCase4);//24
            Proprie[24] = new Propriety(24, "COLOMBIA", PGroupe.RougeOrange, 240, 480);
            Cases.Add(HorizontalupCase5);
            Proprie[25] = new Propriety(25, "B & O CARGO", PGroupe.Aucun, 240, 480);
            Cases.Add(HorizontalupCase6);//26
            Proprie[26] = new Propriety(26, "GERMANY", PGroupe.Jaune, 260, 520);
            Cases.Add(HorizontalupCase7);
            Proprie[27] = new Propriety(27, "THAILAND", PGroupe.Jaune, 260, 520);
            Cases.Add(HorizontalupCase8);//28
            Proprie[28] = new Propriety(28, "STORAGE WORKS", PGroupe.Aucun, 150, 300);
            Cases.Add(HorizontalupCase9);
            Proprie[29] = new Propriety(29, "MEXICO", PGroupe.Aucun, 280, 560);
            Cases.Add(FreeParkingCase);//30
            Cases.Add(VerticalRightCase1);
            Proprie[31] = new Propriety(31, "ARGENTINA", PGroupe.Vert, 300, 600);
            Cases.Add(VerticalRightCase2);//32
            Proprie[32] = new Propriety(32, "INDIA", PGroupe.Vert, 300, 600);
            Cases.Add(VerticalRightCase3);
            Cases.Add(VerticalRightCase4);
            Proprie[34] = new Propriety(34, "BRAZIL", PGroupe.Vert, 320, 640);
            Cases.Add(VerticalRightCase5);//35
            Proprie[35] = new Propriety(35, "SHORT TRUCIS", PGroupe.Aucun, 200, 400);
            Cases.Add(VerticalRightCase6);
            Cases.Add(VerticalRightCase7);//37
            Proprie[37] = new Propriety(37, "USA", PGroupe.Bleu, 350, 700);
            Cases.Add(VerticalRightCase8);
            Proprie[38] = new Propriety(38, "SALES TAXE", PGroupe.Aucun, 75, 150);
            Cases.Add(VerticalRightCase9);
            Proprie[39] = new Propriety(39, "CHINA", PGroupe.Bleu, 400, 800);

            // TODO 39 autres dans l'ordre !!!
        }
    }
}