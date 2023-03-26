using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourHelperForm.Tools {
    public class Painting {
        private Image _image;

        public Painting(Image image) {
            _image = image;
        }

        public Dictionary<string, int> GetColours() {
            // get major colours and how many pixels have it

            Bitmap bitmap = new Bitmap(_image);
            List<Color> colours = Colour.GetColours();

            Dictionary<string, int> list = new();

            foreach (Color colour in colours) {
                list.Add(colour.Name, 0);
            }
            
            for (int i = 0; i < bitmap.Width; i++) {
                for (int j = 0; j < bitmap.Height; j++) {
                    Color pixel = bitmap.GetPixel(i, j);
                    Color color = new Colour().CloseColour(pixel);

                    list[color.Name] += 1;
                }
            }

            return list;
        }

        public Dictionary<string, double> GetPaintDpi(Dictionary<string, int> list) {
            double mlPerInch = 0.00064515999;
            double mlPerPixel = mlPerInch / _image.VerticalResolution / _image.HorizontalResolution;

            Dictionary<string, double> mlList = new();

            foreach (var colour in list) {
                mlList.Add(colour.Key, colour.Value * mlPerPixel);
            }

            return mlList;
        }

        public Dictionary<string, double> GetPaintCm(Dictionary<string, int> list, double width) {
            double mlPerCm = 0.01;
            double horizontalResolution = _image.Width / width;
            double mlPerPixel = mlPerCm / Math.Pow(horizontalResolution, 2);

            Dictionary<string, double> mlList = new();

            foreach (var colour in list) {
                mlList.Add(colour.Key, colour.Value * mlPerPixel);
            }

            return mlList;
        }
    }
}
