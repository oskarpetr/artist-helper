using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourHelperForm.Tools {
    public class Files {
        const string PAINTINGS = "Paintings/";

        public static List<string> GetPaintings() {
            List<string> images = new();

            string[] files = Directory.GetFiles(PAINTINGS);
            foreach (string file in files) {
                images.Add(file);
            }

            return images;
        }

        public static void CreatePainting() {
            // add painting to folder
        }
    }
}
