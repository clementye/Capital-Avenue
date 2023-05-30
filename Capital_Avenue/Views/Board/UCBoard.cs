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
    public partial class UCBoard : UserControl
    {
        public UCBoard()
        {
            InitializeComponent();
            AddBoard();
        }

        public void AddBoard()
        {
            // Configurer les propriétés de dimensionnement du UCBoard
            // AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            // Dock = DockStyle.Fill;

            StartCase startCase = new StartCase(); // Crée une instance de la case de départ
            startCase.Location = new Point(782, 774); // Définit la position de la case de départ

            // Crée et configure la case de prison
            PrisonCase prisonCase = new PrisonCase();
            prisonCase.Location = new Point(0, 774); // Définit la position de la case de prison

            FreeParkingCase freeParkingCase = new FreeParkingCase(); // Crée une instance de la case de parking gratuit
            freeParkingCase.Location = new Point(782, 0); // Définit la position de la case de parking gratuit

            GoToJailCase gotojailCase = new GoToJailCase(); // Crée une instance de la case "Allez en prison"
            gotojailCase.Location = new Point(0, 0); // Définit la position de la case "Allez en prison" 

            Controls.Add(startCase);
            Controls.Add(prisonCase);
            Controls.Add(freeParkingCase);
            Controls.Add(gotojailCase);


            int positionY = 124;
            for (int i = 0; i < 9; i++)
            {
                LeftRowCase leftRowCase = new LeftRowCase();
                leftRowCase.Location = new Point(0, positionY + (i * leftRowCase.Height));
                Controls.Add(leftRowCase);
            }

            int positionX = 124;
            for (int i = 0; i < 9; i++)
            {
                UpCase upCase = new UpCase();
                upCase.Location = new Point(positionX + (i * upCase.Width), 0);
                Controls.Add(upCase);
            }


            for (int i = 0; i < 9; i++)
            {
                RightRowCase rightRowCase = new RightRowCase();
                rightRowCase.Location = new Point(782, positionY + (i * rightRowCase.Height));
                Controls.Add(rightRowCase);
            }


            for (int i = 0; i < 9; i++)
            {
                DownCase downCase = new DownCase();
                downCase.Location = new Point(positionX + (i * downCase.Width), 774);
                Controls.Add(downCase);
            }
            // Ajouter d'autres instances de classes de case pour les autres cases du plateau
        }
    }
}