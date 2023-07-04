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
                "#EEE8AA",
                "#FFB6C1",
                "#90EE90",
                "#ADD8E6",
                
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

        public static Image[] GetDice()
        {
            Image[] images = new Image[]
            {
                Properties.Resources.dice_0,
                Properties.Resources.dice_1,
                Properties.Resources.dice_2,
                Properties.Resources.dice_3,
                Properties.Resources.dice_4,
                Properties.Resources.dice_5,
                Properties.Resources.dice_6
            };
            return images;
        }
    }
}
