using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Capital_Avenue.Models
{
    public class Propriety : Case
    {
        //On va devoir se décider si on met dans Player ou dans CLPropriety la notion de possession.
        //Je pensais l'ajouter dans CLPropriety, et ajouter un élément InBank pour dire si c'est dans la banque ou non.
        public PGroupe PGroupe { get; set;}
        public enum PState //état propriete
        {
            free,
            purchase,
            mortgage,
        }
        public PGroupe StreetG { get; set; }
        public PState state { get; set; }
        public int PurchasePrice { get; }
        public float Rent { get; set; }
        public int MortgagedPrice { get; }
        public Player Owner { get; set; }

        public Propriety (int index, string name, PGroupe groupe, int price, int rent, int mortgaged) : base (index, name)
        {
            this.PGroupe = groupe;
            this.Name = name;
            this.Index = index;
            this.PurchasePrice = price;
            this.Rent = rent;
            MortgagedPrice = mortgaged;
            //state = PState.free;
            PurchasePrice = price;
        }
        public override string ToString()
        {
            return $"Propriety: {Name} (Index: {Index}), Group: {StreetG}, State: {state}, Purchase Price: {PurchasePrice}, Rent: {Rent}, Mortgaged Price: {MortgagedPrice}, Owner: {(Owner != null ? Owner.Name : "None")}";

        }

        /*
         * si le proprietaire est dans sa case passez 
         * si un joueur se met danss la case du owner faut payer
         * si le joueur se met dans uen case ou l'ensemble de la couleur  **/


        public void Action(Player currentPlayer)
        {
            if (this.state == PState.free)
            {
                //voir cette partie pour choix de l'affichage
                this.BuyProp(currentPlayer);
                Console.WriteLine("If you wanna buy it press yes");
            }
            else if (this.state == PState.purchase)
            {
                Payrent(currentPlayer); 

            }

            if (this.state == PState.mortgage)
            {
                //while()
            }
            if (this.Owner == Owner)
            {

            } 
        }
        // a specifié pour faire la matérialisation du plateau si c'est acheté et/ou hypothéqué
        public void BuyProp(Player currentPlayer)
        {
            int purchasePrice = this.PurchasePrice;

            currentPlayer.DeductMoney(purchasePrice);
            currentPlayer.AddProperty(this);

            this.state = PState.purchase;
            this.Owner = currentPlayer;
        }
        public void Payrent(Player currentPlayer)
        {
            Player owner = this.Owner;
            int rentAmount = (int)this.Rent;

            currentPlayer.DeductMoney(rentAmount);
            owner.AddMoney(rentAmount);

            
        }
        

    }
}

﻿