using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Avenue.Models
{
    public abstract class Case
    {
        public int Index { get; set; }
        public string Name { get; set; }

        public Case(int index, string name)
        {
            Index = index;
            Name = name;
        }

        //public abstract OnAction(CLPlayer player);
    }
}
