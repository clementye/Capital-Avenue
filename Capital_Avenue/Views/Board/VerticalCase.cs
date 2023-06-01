using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue.Views.Board
{
    public partial class VerticalCase : Case
    {
        public VerticalCase() : base()
        {
            this.Size = new Size(122, 73);
            this.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
