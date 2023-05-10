using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Avenue.Models
{
    internal class CLPawn
    {
        public string Name { get; set; }
        public int Index { get; set; }
        internal int modifiedPosition = 0;

        public CLPawn(string name) 
        { 
            Name = name;
            Index = 0;
        }

        public int locationUpdate(int newPosition) //Magic Number provisoire, c'est pas du tout près.
        {
            modifiedPosition += newPosition;
            if (modifiedPosition < 0) //Cas impossible où tous les joueurs doivent reculer de x cases et l'un d'eux est sur la case départ.
            {
                modifiedPosition = modifiedPosition+40;
            }
            if (modifiedPosition > 40) 
            {
                modifiedPosition = modifiedPosition - 40;
            }
            return Index = modifiedPosition;
        }
    }
}
