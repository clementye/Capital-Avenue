using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Avenue.Services
{
    public static class ConfigService
    {
        public static List<String> GetPlayerColors()
        {
            return new List<string> {
                "#6AFF2D",
                "#401ad6",
                "#401ad6"
            };
        }
        public static Image[] GetPlayerImages()
        {
            Image[] images = new Image[]
            {
                Properties.Resources.face1,
                Properties.Resources.face2,
                Properties.Resources.Chapeau,
                Properties.Resources.Cloche
            };
            return images;
        }


    }
}
