using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourHelperForm.Models {
    [Serializable]
    public class Detail {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Dictionary<string, double> Colours { get; set; }
    }
}
