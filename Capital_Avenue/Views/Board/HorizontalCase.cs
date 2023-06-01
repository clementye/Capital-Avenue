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
    public partial class HorizontalCase : Case
    {
        public HorizontalCase() : base()
        {
            this.Size = new Size(73, 122);
            this.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
