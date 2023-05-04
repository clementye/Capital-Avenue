using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue.Views
{
    public class LeftUCPanel : UserControl
    {
        private int toto;
        private string hexPlay1 = "#6AFF2D";
        private string hexPlay2 = "#401ad6";
        public LeftUCPanel()
        {
            UserControl uc1 = new UserControl();
            Panel p1 = new Panel();
            Label l1 = new Label();
            l1.Text = "Joueur 1";
            p1.Controls.Add(l1);
            p1.BackColor = ColorTranslator.FromHtml(hexPlay1);
            p1.Size = new Size(300, 120);
            uc1.Controls.Add(p1);
            uc1.Location = new Point(0, 100);
            uc1.Size = new Size(1570, 120);
            this.Controls.Add(uc1);




            UserControl uc2 = new UserControl();
            Panel p2 = new Panel();
            Label l2 = new Label();
            l2.Text = "Joueur 2";
            p2.Controls.Add(l2);
            p2.BackColor = ColorTranslator.FromHtml(hexPlay2);
            p2.Size = new Size(300, 120);
            uc2.Controls.Add(p2);
            uc2.Location = new Point(0, 245);
            uc2.Size = new Size(1570, 120);
            this.Controls.Add(uc2);

        }
        public int getToto()
        {
            return toto;
        }

        public void update()
        {

        }
    }
}
