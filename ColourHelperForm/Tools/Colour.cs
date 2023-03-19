using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourHelperForm.Tools {
    public class Colour {
        public static List<Color> GetColours() {
            return new List<Color>() {
                Color.Blue,        Color.BlueViolet, Color.Magenta,     Color.Purple,
                Color.Red,         Color.Tomato,     Color.Orange,      Color.Yellow,
                Color.YellowGreen, Color.Green,      Color.SpringGreen, Color.Cyan,
                Color.Ivory
            };
        }

        public Color CloseColour(Color color) {
            return GetColours().OrderBy(c => Math.Abs(color.GetHue() - c.GetHue())).First();
        }
    }
}
