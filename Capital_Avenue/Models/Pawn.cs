using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Avenue.Models
{
    public class Pawn
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public string Player { get; set; }

        public Pawn(string name, string player) 
        { 
            Name = name;
            Player = player;
            Index = 0;
        }
    }
}
