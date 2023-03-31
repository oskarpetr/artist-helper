using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ColourHelperForm.Tools;

namespace ColourHelperForm.Forms {
    public partial class CreatePaintingForm : Form {
        private string _path;
        private bool _selected;

        public CreatePaintingForm() {
            InitializeComponent();
        }

        private void _labelBack_Click(object sender, EventArgs e) {
            Switch.Screen(new Form1());
        }

        private void _buttonUpload_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK) {
                _picturePainting.Image = Image.FromFile(dialog.FileName);
                _path = dialog.FileName;
                _selected = true;

                Invalidate();

                CalculateHeight();

                _labelWidthTitle.Visible = true;
                _numericWidth.Visible = true;
                _labelCm.Visible = true;
                _labelHeightTitle.Visible = true;
                _labelHeight.Visible = true;
                _buttonCreate.Visible = true;
            }
        }

        private void _numericWidth_ValueChanged(object sender, EventArgs e) {
            CalculateHeight();
        }

        private void CalculateHeight() {
            Image image = Image.FromFile(_path);
            float height = (float)(_numericWidth.Value * image.Height) / image.Width;
            _labelHeight.Text = $"{Math.Round(height, 2)} cm";
        }

        private void _buttonCreate_Click(object sender, EventArgs e) { 
            Painting painting = new(Image.FromFile(_path));
            Dictionary<string, int> colours = painting.GetColours();
            Dictionary<string, double> ml = painting.GetPaintCm(colours, (double)_numericWidth.Value);

            Files.CreatePainting(_path, (int)_numericWidth.Value, ml);
            Switch.Screen(new Form1());
        }

        private void _panelHistogram_Paint(object sender, PaintEventArgs e) {
            
        }

        private float HISTOGRAM_HEIGHT = 140;
        private Size HISTOGRAM_LOC = new(55, 220);
        private void CreatePaintingForm_Paint(object sender, PaintEventArgs e) {
            if (_selected) {
                Graphics g = e.Graphics;
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

                    r_points.Add(new PointF(current + HISTOGRAM_LOC.Width, Math.Abs(r_point - HISTOGRAM_HEIGHT) + HISTOGRAM_LOC.Height));
                    g_points.Add(new PointF(current + HISTOGRAM_LOC.Width, Math.Abs(g_point - HISTOGRAM_HEIGHT) + HISTOGRAM_LOC.Height));
                    b_points.Add(new PointF(current + HISTOGRAM_LOC.Width, Math.Abs(b_point - HISTOGRAM_HEIGHT) + HISTOGRAM_LOC.Height));

                    current += 1.25f;
                }

                g.DrawCurve(Pens.Red, r_points.ToArray());
                g.DrawCurve(Pens.Green, g_points.ToArray());
                g.DrawCurve(Pens.Blue, b_points.ToArray());
            }
        }
    }
}
