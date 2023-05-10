using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Avenue.Models
{
    public class CLPropriety : CLCase
    {
        //On va devoir se décider si on met dans CLPlayer ou dans CLPropriety la notion de possession.
        //Je pensais l'ajouter dans CLPropriety, et ajouter un élément InBank pour dire si c'est dans la banque ou non.
        public PGroupe PGroupe { get; set;}
        public int Prix { get; set;}
        public int Loyer { get; set;}

        public CLPropriety (int index, string name, PGroupe groupe, int prix, int loyer) : base (index, name)
        {
            this.PGroupe = groupe;
            this.Name = name;
            this.Index = index;
            this.Prix = prix;
            this.Loyer = loyer;
        }

        internal static void payLoyer()
        {
            throw new NotImplementedException();
        }
    }
}
