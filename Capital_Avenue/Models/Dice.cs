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
        public int DiceResult;

        public int DiceThrower()
        {
            DiceResult = 0;
            for (int i = 0; i < 2; i++) 
            {
                DiceResult += rnd.Next(1, 7);
            }
            return DiceResult;
        }
    }

    //TODO:
    // - Gestion du double
    // - Gestion du cas où trois double se suivent
}
