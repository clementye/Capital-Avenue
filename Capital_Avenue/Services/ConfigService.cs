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
                //Properties.Resources.Transparant,
                Properties.Resources.Chapeau1,
                Properties.Resources.Diamant,
                Properties.Resources.Chariot,
                Properties.Resources.Voiture1

            };
            return images;
        }


    }
}
