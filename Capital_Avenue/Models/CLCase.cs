using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Avenue.Models
{
    public abstract class CLCase
    {
        public int Index { get; set; }
        public string Name { get; set; }

        public CLCase(int index, string name)
        {
            Index = index;
            Name = name;
        }

        //public abstract OnAction(CLPlayer player);
    }
}
