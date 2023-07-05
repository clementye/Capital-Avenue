using Capital_Avenue.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue.Views.Auction
{
    public partial class Auction : Form
    {
        Label PlaCard1;
        Label PlaCard2;
        CheckedListBox P1Box;
        CheckedListBox P2Box;
        private Player P1;
        private Player P2;
        public Auction(Player Cplayer, Player Oplayer)
        {
            InitializeComponent();
            label2.Text = Cplayer.Name;
            label3.Text = Oplayer.Name;
            foreach (Property p in Cplayer.OwnedProperties)
            {
                if (p.IsInBank == false)
                {
                    checkedListBox1.Items.Add(p.Name, false);
                }
            }
            foreach (Property p2 in Oplayer.OwnedProperties)
            {
                if (p2.IsInBank == false)
                {
                    checkedListBox2.Items.Add(p2.Name, false);
                }
            }
            label6.Text = "Propriété de " + Cplayer.Name;
            label4.Text = "Argent :";
            label7.Text = "Propriété de " + Oplayer.Name;
            label5.Text = "Argent :";
            this.CardBoxAdder(Cplayer, Oplayer);
            CapitalP1.Text = "0";
            CapitalP2.Text = "0";
            P1 = Cplayer;
            P2 = Oplayer;

        }

        private void CardBoxAdder(Player pla1, Player pla2)
        {
            PlaCard1 = new Label();
            PlaCard2 = new Label();
            P1Box = new CheckedListBox();
            P2Box = new CheckedListBox();
            if (pla1.Cards.Count > 0 || pla2.Cards.Count > 0)
            {
                Label PlaCard = new Label();
                string Name = pla1.Cards.Count > 0 ? pla1.Name : pla2.Name;
                Player PlaTrue = pla1.Cards.Count > 0 ? pla1 : pla2;
                PlaCard.Text = Name;
                CheckedListBox SingleBox = new CheckedListBox();
                foreach (Property p in PlaTrue.OwnedProperties)
                {
                    if (p.IsInBank == false)
                    {
                        SingleBox.Items.Add(p.Name, false);
                    }
                }
                PlaCard.Location = new Point(191, 114);
                SingleBox.Location = new Point(191, 137);
                this.Controls.Add(PlaCard);
                this.Controls.Add(SingleBox);
            }

            if (pla1.Cards.Count > 0 && pla2.Cards.Count > 0)
            {
                foreach (Property p in pla1.OwnedProperties)
                {
                    if (p.IsInBank == false)
                    {
                        P1Box.Items.Add(p.Name, false);
                    }
                }
                foreach (Property p in pla2.OwnedProperties)
                {
                    if (p.IsInBank == false)
                    {
                        P2Box.Items.Add(p.Name, false);
                    }
                }
                PlaCard1.Location = new Point(191, 114);
                P1Box.Location = new Point(191, 137);
                PlaCard2.Location = new Point(191, 231);
                P2Box.Location = new Point(191, 252);
                this.Controls.Add(PlaCard1);
                this.Controls.Add(P1Box);
                this.Controls.Add(PlaCard2);
                this.Controls.Add(P2Box);
            }
        }
        private void AuctionConfirm_Click(object sender, EventArgs e)
        {
            this.AuctionTradeP(P1, P2, checkedListBox1);
            this.AuctionTradeP(P2, P1, checkedListBox2);
            /*if (P1.Cards.Count > 0 || P2.Cards.Count > 0)
            {
                this.AuctionTradeC(P1, P2, P1Box);
                this.AuctionTradeC(P2, P1, P2Box);
            }*/
            this.AuctionMoney(P1, P2, CapitalP1);
            this.AuctionMoney(P2, P1, CapitalP2);
            this.Close();
        }

        private void AuctionTradeP(Player Cpla, Player Opla, CheckedListBox box)
        {
            for (int i = 0; i < box.CheckedItems.Count; i++)
            {
                var FoundProperty = Cpla.OwnedProperties.Find(p2 => p2.Name == box.CheckedItems[i]);
                Opla.AddProperty(FoundProperty);
                FoundProperty.Owner = Opla;
            }
            Cpla.OwnedProperties.RemoveAll(p3 => p3.Owner != Cpla);
        }

        private void AuctionTradeC(Player Cpla, Player Opla, CheckedListBox box)
        {
            for (int i = 0; i < box.CheckedItems.Count; i++)
            {
                var FoundProperty = Cpla.Cards.Find(p2 => p2 == box.CheckedItems[i]);
                Opla.AddCard(FoundProperty);
                Cpla.Cards.Remove(FoundProperty);
            }
        }

        private void AuctionMoney(Player Cpla, Player Opla, TextBox Box)
        {
            string objTextBox = Box.Text;
            int i = int.Parse(objTextBox);
            Cpla.Capital -= i;
            Opla.Capital += i;
        }
        private void AuctionCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}