using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Avenue.Views.Board
{
    public class FlowPanel
    {
        List<int> VerticalDown = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<int> VerticalUp = new List<int> { 21, 22, 23, 24, 25, 26, 27, 28, 29 };
        List<int> HorizontalDown = new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        List<int> HorizontalUp = new List<int> { 31, 32, 33, 34, 35, 36, 37, 38, 39 };
        public void SquarePanel()
        {
            TableLayoutPanel Table = new TableLayoutPanel();
            Table.ColumnCount = 2;
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            Table.RowCount = 2;
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            Table.Size = new Size(122, 122);
        }

        public void PrisonPanel()
        {
            TableLayoutPanel Table = new TableLayoutPanel();
            Table.ColumnCount = 3;
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            Table.RowCount = 3;
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 33)); 
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
            Table.Size = new Size(122, 122);
        }

        public void HorizontalPanel()
        {
            TableLayoutPanel Table = new TableLayoutPanel();
            Table.ColumnCount = 3;
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            Table.RowCount = 2;
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            Table.Size = new Size(0, 0);
        }

        public void VerticalPanel()
        {
            TableLayoutPanel Table = new TableLayoutPanel();
            Table.ColumnCount = 3;
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            Table.RowCount = 2;
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            Table.Size = new Size(0, 0);
        }

        public void PropertyVertical(int position, PictureBox element)
        {
            if (VerticalDown.Contains(position))
            {
                TableLayoutPanel Table = new TableLayoutPanel();
                Table.ColumnCount = 3;
                Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
                Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
                Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
                Table.RowCount = 2;
                Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                Table.Controls.Add(element, 0, 0);
                Table.Size = new Size(0, 0);
            } 
        }

        public void PropertyHorizontal()
        {
            TableLayoutPanel Table = new TableLayoutPanel();
            Table.ColumnCount = 3;
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            Table.RowCount = 2;
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            Table.Size = new Size(0, 0);
        }
        //Le code du dessus est une idée pour ajouter sans problème les pions, ainsi que si une propriété est acheté et le nombre de maison dessus si besoin



    }
}
