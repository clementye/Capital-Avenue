using Capital_Avenue.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue.Views
{
    public partial class UCPawn : UserControl
       
    {
        private CLPawn Pawn;

        public UCPawn(CLPawn pawn)
        {
            //throw new NotImplementedException();
            PictureBox pb = new PictureBox();
            pb.ImageLocation = "F:\\Users\\Pc\\Documents\\Devoir\\Intech\\S03\\Projet\\capital-avenue\\Capital_Avenue\\Content\\" + pawn.Name + ".png";
            pb.Size = new Size(40,40);
        }
    }
}
