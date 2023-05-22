using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Avenue.Models
{
    public static class ComboBoxTools
    {
        private const int MarginWidth = 3;
        private const int MarginHeight = 3;
        public static void DisplayImages(this ComboBox comboBox, Image[] images)
        {
            foreach (Image image in images)
            {
                comboBox.Items.Add(image);
            }
            
            comboBox.MeasureItem += cboDrawImage_MeasureItem;
            comboBox.DrawItem += cboDrawImage_DrawItem;
        }
        private static void cboDrawImage_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0) return;
            ComboBox comboBox = sender as ComboBox;
            Image img = (Image)comboBox.Items[e.Index];
            e.ItemHeight = img.Height + MarginWidth;
            e.ItemWidth = img.Width + MarginHeight;
        }

        private static void cboDrawImage_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.DrawBackground();
            // Draw the image.
            ComboBox comboBox = sender as ComboBox;
            Image img = (Image)comboBox.Items[e.Index];
            float hgt = e.Bounds.Height - 2 ;
            float scale = hgt / img.Height;
            float wid = img.Width * scale;
            RectangleF rect = new RectangleF(
                e.Bounds.X ,
                e.Bounds.Y ,
                wid, hgt);
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.DrawImage(img, rect);

            // Draw the focus rectangle if appropriate.
            e.DrawFocusRectangle();
        }

    }
}
