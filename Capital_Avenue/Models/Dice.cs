using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Avenue.Models
{
    public class Dice
    {
        //réaliser un élément pour enregistrer une valeur aléatoire entre 1 et 6.
        //faire une fonction lançant deux dés aléatoire et, dans la partie test, voir si c'est bien aléatoire.
        Random rnd = new Random();

        public List<int> DiceList;
        public int DoubleDice { get; set; }
        public bool isDouble { get; set; }
        public int ResultDice { get; set; }
        
        public Dice()
        {
            this.DiceList = new List<int>();
            this.DoubleDice = 0;
            this.ResultDice = 0; //Value that dictate the movement.
            //Simply put, if player is a case 0 and RD is 9, the player will go to case 9. 
            //Similar, if at 36 and value of RD is 6, will go to 36+6=42, then minus 40 to find the real case, being 2 in this exemple
            this.isDouble = false;
        }

        public void addDice(int dice, int nbDice)
        {
            for (int i = 0; i < nbDice; i++)
            {
                DiceList.Add(dice);
            }
          
        }

        public void DiceThrower()
        {
            isDouble = false;
            for (int i = 0;i < DiceList.Count; i++)
            {
                DiceList[i] = rnd.Next(1, 7);
            }
            if (DiceList.Distinct().Count() == 1) 
            {
                isDouble = true;
            }
        }

        
    }

    //TODO:
    // - Gestion du double
    // - Gestion du cas où trois double se suivent
}
