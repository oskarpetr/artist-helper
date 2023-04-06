using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColourHelperForm.Components {
    public partial class Histogram : UserControl {
        private float HISTOGRAM_HEIGHT = 140;
        private Graphics _g;
        private string _path;
        private float _x;
        private float _y;

        public Histogram(Graphics g, string path, float x, float y) {
            InitializeComponent();
            _g = g;
            _path = path;
            _x = x;
            _y = y;

            Create();
        }

        private void Create() {
            Bitmap bitmap = new(Image.FromFile(_path));

            Dictionary<int, int> red = new();
            Dictionary<int, int> green = new();
            Dictionary<int, int> blue = new();

            for (int i = 0; i < 256; i++) {
                red.Add(i, 0); green.Add(i, 0); blue.Add(i, 0);
            }

            for (int i = 0; i < bitmap.Width; i++) {
                for (int j = 0; j < bitmap.Height; j++) {
                    red[bitmap.GetPixel(i, j).R] += 1;
                    green[bitmap.GetPixel(i, j).G] += 1;
                    blue[bitmap.GetPixel(i, j).B] += 1;
                }
            }

            List<PointF> r_points = new();
            List<PointF> g_points = new();
            List<PointF> b_points = new();

            int r_max = red.Values.Max();
            int g_max = green.Values.Max();
            int b_max = blue.Values.Max();

            float current = 1.25f;
            for (int i = 0; i < 256; i++) {
                float r_point = ((float)red[i] / r_max) * HISTOGRAM_HEIGHT;
                float g_point = ((float)green[i] / g_max) * HISTOGRAM_HEIGHT;
                float b_point = ((float)blue[i] / b_max) * HISTOGRAM_HEIGHT;

                r_points.Add(new PointF(current + _x, Math.Abs(r_point - HISTOGRAM_HEIGHT) + _y));
                g_points.Add(new PointF(current + _x, Math.Abs(g_point - HISTOGRAM_HEIGHT) + _y));
                b_points.Add(new PointF(current + _x, Math.Abs(b_point - HISTOGRAM_HEIGHT) + _y));

                current += 1.25f;
            }

            _g.DrawCurve(Pens.Red, r_points.ToArray());
            _g.DrawCurve(Pens.Green, g_points.ToArray());
            _g.DrawCurve(Pens.Blue, b_points.ToArray());
        }
    }
}
