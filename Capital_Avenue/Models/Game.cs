using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Avenue.Models
{
    public class Game
    {
        public List<CLPlayer> playerList { get; private set; }
        public List<CLPawn> pawnList { get; private set; }

        public Game(List<CLPlayer> pList, List<CLPawn> paList)
        {
            playerList = pList;
            pawnList = paList;
        }
    }
}
