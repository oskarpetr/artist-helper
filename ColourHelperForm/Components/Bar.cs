using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColourHelperForm.Models;

namespace ColourHelperForm.Components {
    public partial class Bar : UserControl {
        private Detail _detail;
        private Graphics _g;
        private int _x;
        private int _y;
        Dictionary<string, double> _colours = new();
        private double _total = 1;

        public Bar(Graphics g, Detail detail, int x, int y) {
            InitializeComponent();

            _detail = detail;
            _g = g;
            _x = x;
            _y = y;

            _colours = _detail.Colours;
            _colours = _colours.Where(c => c.Value != 0).ToDictionary(c => c.Key, c => c.Value);

            for (int i = 0; i < _detail.Colours.Count; i++) {
                _total += _detail.Colours.ElementAt(i).Value;
            }

            Create();
        }

        private void Create() {
            float previous = 0;
            for (int i = 0; i < _colours.Count; i++) {
                Brush colour = BrushColour(_colours.ElementAt(i).Key);

                float width = ((float)_colours.ElementAt(i).Value / (float)_total) * (float)Width * 0.95f;
                _g.FillRectangle(colour, previous + _x, 0 + _y, width, Height);

                previous += width;
            }
        }

        private Brush BrushColour(string colour) { 
            switch (colour.ToLower()) {
                case "blue":
                    return Brushes.Blue;
                case "blueviolet":
                    return Brushes.BlueViolet;
                case "magenta":
                    return Brushes.Magenta;
                case "purple":
                    return Brushes.Purple;
                case "red":
                    return Brushes.Red;
                case "tomato":
                    return Brushes.Tomato;
                case "orange":
                    return Brushes.Orange;
                case "yellow":
                    return Brushes.Yellow;
                case "yellowgreen":
                    return Brushes.YellowGreen;
                case "green":
                    return Brushes.Green;
                case "springgreen":
                    return Brushes.SpringGreen;
                case "cyan":
                    return Brushes.Cyan;
                case "ivory":
                    return Brushes.Ivory;
            }

            return null;
        }
    }
}
