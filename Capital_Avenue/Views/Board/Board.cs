using Capital_Avenue.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        private List<Case> Cases;
        private CardChance CardChance;
        private CardCommunity CardCommunity;
        Dictionary<Player, int> PlayerPositions;
        private Dictionary<int, Property> Property = new Dictionary<int, Property>();


        public Board()
        {
            InitializeComponent();
            Cases = new List<Case>();
            CreateBoard();
            CardChance = new CardChance(this);
            CardCommunity = new CardCommunity(this);
        }

        public void Init(Game game)
        {
            game.GameBoard = this;
            foreach (Player player in game.PlayerList)
            {
                Cases[0].AddPawn(player);
            }
        }



        public void MovePawn(Player p, int diceValue, bool isGoingToJail = false)
        {
            int NewPosition = p.Position + diceValue;
            if (NewPosition > 39)
            {
                NewPosition -= 40;
                if (!isGoingToJail)
                {
                    string Message = $"Vous avez reçu \n 200 euros,\n {p.Name}!";
                    Card c = new Card(Properties.Resources.Emojy_Depart, Message,"Bonus");
                    c.ShowDialog();
                    p.Capital += 200;

                }
                
            }
            
            Cases[p.Position].RemovePawn(p);
            p.Position = NewPosition;
            Cases[p.Position].AddPawn(p);
            CheckStatusProperty(p, NewPosition);
        }


        public void CheckStatusProperty(Player player, int indexCase)
        {
            if (Property.ContainsKey(indexCase))
            {
                Property pro = Property[indexCase];
                if (pro.CheckPropietorship(Property[indexCase]) == true)
                {
                    pro.TaxProperty(player, pro);
                }
                else
                {   
                    PropertyCard c = new PropertyCard(pro,player);
                    c.ShowDialog();

                }
            }
            else if (indexCase == 7 || indexCase == 22 || indexCase == 36)
            {
               CardChance.ExecuteChanceCardAction(player);
            }
            else if (indexCase == 2 || indexCase == 17 || indexCase == 33)
            {
                CardCommunity.ExecuteCommunityCardAction(player);
            }
            else if (indexCase == 30)
            {
                MovePlayerToJail(player);
            }
        }

       public void MovePlayerToJail(Player player)
        {
            int move = player.Position > 10 ? 50 - player.Position : 10 - player.Position;
            MovePawn(player, move, true);
            player.isInJail = true;
            MessageBox.Show($"Vous allez en prison, {player.Name} !");
        }
      
        public void MovePawnToPosition(Player player, int newPosition)
        {
            int move = newPosition > player.Position ? newPosition - player.Position : 40 - newPosition - player.Position;
            MovePawn(player, move);
        }

        public void CreateBoard()
        {
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Case StartCase = new SquareCase(); // Crée une instance de la case de départ
            StartCase.Location = new Point(782, 776); // Définit la position de la case de départ
            StartCase.BackgroundImage = Properties.Resources.Casedepart;

            Controls.Add(StartCase);

            
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

            Property[1] = new Property(1, "GHANA", ColorProperty.Marron,Color.Peru, 60, 2,10,30,90,160,250);
            Cases.Add(HorizontaldownCase8);

            Cases.Add(HorizontaldownCase7);
            Property[3] = new Property(3, "UGANDA", ColorProperty.Marron,Color.Peru,60,4,20,60,180,320,450);
            Cases.Add(HorizontaldownCase6);
            Cases.Add(HorizontaldownCase5);
            Property[5] = new Property(5, "READING RAILROAD", ColorProperty.Station, Color.White, 200 , 25, 50 , 100, 150 , 200,400);
            Cases.Add(HorizontaldownCase4);
            Property[6] = new Property(6, "KENYA", ColorProperty.BleauC,Color.LightCyan,100,6, 30,90,270,400,550);
            Cases.Add(HorizontaldownCase3);
            Cases.Add(HorizontaldownCase2);
            Property[8] = new Property(8, "MADAGASCAR", ColorProperty.BleauC,Color.LightCyan, 100,6,30,90,270,400,550);
            Cases.Add(HorizontaldownCase1);
            Property[9] = new Property(9, "MYANNAR", ColorProperty.BleauC,Color.LightCyan, 120,8,40,100,300,450,600);
            Cases.Add(PrisonCase); //10
            Cases.Add(VerticalLeftCase9);//11
            Property[11] = new Property(11, "NIGERIA", ColorProperty.Rose,Color.DeepPink, 140,10,50,150,450,625,750);
            Cases.Add(VerticalLeftCase8);//12
            Property[12] = new Property(12, "DISTRIBUTION COMPANY", ColorProperty.Aucun,Color.White, 150,75, 20, 40, 60, 80, 110);
            Cases.Add(VerticalLeftCase7);//13
            Property[13] = new Property(13, "BANGLADESH", ColorProperty.Rose,Color.DeepPink, 140,10, 50, 150, 450, 625, 750);
            Cases.Add(VerticalLeftCase6);
            Property[14] = new Property(14, "PHILIPPINES", ColorProperty.Rose,Color.DeepPink, 160,12, 60, 180, 500, 700, 900);
            Cases.Add(VerticalLeftCase5);
            Property[15] = new Property(15, "PENNSYVALIA ARWAYS", ColorProperty.Station,Color.White, 200, 25, 50, 100, 150, 200, 400);
            Cases.Add(VerticalLeftCase4);//16
            Property[16] = new Property(16, "VIETNAM", ColorProperty.Orange, Color.DarkOrange, 180, 14, 70, 200, 550, 700 , 900);
            Cases.Add(VerticalLeftCase3);
            Cases.Add(VerticalLeftCase2);//18
            Property[18] = new Property(18, "RUSSIA", ColorProperty.Orange,Color.DarkOrange, 180,14, 70, 200, 550, 700, 900);
            Cases.Add(VerticalLeftCase1);//19
            Property[19] = new Property(19, "MALAYSIA", ColorProperty.Orange,Color.DarkOrange, 200,16, 80, 220, 600, 800 , 1000);
            Cases.Add(GotojailCase);//20
            Cases.Add(HorizontalupCase1);
            Property[21] = new Property(21, "INDONESIA", ColorProperty.RougeOrange,Color.OrangeRed,220,18, 90, 250, 700, 875, 1050);
            Cases.Add(HorizontalupCase2);//22
            Cases.Add(HorizontalupCase3);
            Property[23] = new Property(23, "FRANCE", ColorProperty.RougeOrange,Color.OrangeRed, 220,18, 90, 250, 700, 875 , 1050);
            Cases.Add(HorizontalupCase4);//24
            Property[24] = new Property(24, "COLOMBIA", ColorProperty.RougeOrange,Color.OrangeRed, 240, 20, 100, 300, 750, 925, 1100);
            Cases.Add(HorizontalupCase5);
            Property[25] = new Property(25, "B & O CARGO", ColorProperty.Station,Color.White,200, 25, 50, 100, 150, 200, 400);
            Cases.Add(HorizontalupCase6);//26
            Property[26] = new Property(26, "GERMANY", ColorProperty.Jaune,Color.Yellow,260,22, 110, 330, 800, 975 , 1150);
            Cases.Add(HorizontalupCase7);
            Property[27] = new Property(27, "THAILAND", ColorProperty.Jaune,Color.Yellow, 260,22, 110, 330, 800, 975, 1150);
            Cases.Add(HorizontalupCase8);//28
            Property[28] = new Property(28, "STORAGE WORKS", ColorProperty.Aucun,Color.White, 150,75, 20, 40, 60, 80,160);
            Cases.Add(HorizontalupCase9);
            Property[29] = new Property(29, "MEXICO", ColorProperty.Aucun,Color.Yellow,280,24, 120, 360, 850, 1025, 1200);
            Cases.Add(FreeParkingCase);//30
            Cases.Add(VerticalRightCase1);
            Property[31] = new Property(31, "ARGENTINA", ColorProperty.Vert,Color.Green,300,26, 130, 390, 900, 1100 , 1275);
            Cases.Add(VerticalRightCase2);//32
            Property[32] = new Property(32, "INDIA", ColorProperty.Vert,Color.Green,300,26, 130, 390, 900, 1100, 1275);
            Cases.Add(VerticalRightCase3);
            Cases.Add(VerticalRightCase4);
            Property[34] = new Property(34, "BRAZIL", ColorProperty.Vert,Color.Green,320,28, 150, 450, 1000, 1200, 1400);
            Cases.Add(VerticalRightCase5);//35
            Property[35] = new Property(35, "SHORT TRUCIS", ColorProperty.Station,Color.White, 200, 25, 50, 100, 150, 200, 400);
            Cases.Add(VerticalRightCase6);
            Cases.Add(VerticalRightCase7);//37
            Property[37] = new Property(37, "USA", ColorProperty.Bleu,Color.DeepSkyBlue,350, 35 , 175, 500, 1100, 1300  , 1500);
            Cases.Add(VerticalRightCase8);
            Property[38] = new Property(38, "SALES TAXE", ColorProperty.Aucun, Color.White,75, 150, 20, 40, 60, 80, 100);
            Cases.Add(VerticalRightCase9);
            Property[39] = new Property(39, "CHINA", ColorProperty.Bleu,Color.DeepSkyBlue,400, 50, 200, 600, 1400, 1700, 2000);

            
        }
       
    }
}