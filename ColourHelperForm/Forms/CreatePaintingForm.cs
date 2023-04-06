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
using ColourHelperForm.Components;

namespace ColourHelperForm.Forms {
    public partial class CreatePaintingForm : Form {
        private string _path;
        private bool _selected;

        public CreatePaintingForm() {
            InitializeComponent();

            Inputs();
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

                width.SetVisibility(true);
                height.SetVisibility(true);
                _labelWidthTitle.Visible = true;
                _labelHeightTitle.Visible = true;
                _buttonCreate.Visible = true;
            }
        }

        private void _numericWidth_ValueChanged(object sender, EventArgs e) {
            CalculateHeight();
        }

        private void _buttonCreate_Click(object sender, EventArgs e) { 
            Painting painting = new(Image.FromFile(_path));
            Dictionary<string, int> colours = painting.GetColours();
            Dictionary<string, double> ml = painting.GetPaintCm(colours, (double)width.GetValue());

            Files.CreatePainting(_path, (int)width.GetValue(), ml);
            Switch.Screen(new Form1());
        }

        private void CreatePaintingForm_Paint(object sender, PaintEventArgs e) {
            if (_selected) {
                Graphics g = e.Graphics;

                Histogram histogram = new(g, _path, 55, 220);
                Controls.Add(histogram);
            }
        }

        private void Inputs() {
            width.Location = new Point(55, 149);
            width.OnValueChanged += Width_OnValueChanged;

            height.Location = new Point(233, 152);
            height.OnValueChanged += Height_OnValueChanged;

            Controls.Add(width);
            Controls.Add(height);
        }

        Input width = new();
        Input height = new();

        private void Width_OnValueChanged() {
            CalculateHeight();
        }

        private void Height_OnValueChanged() {
            CalculateWidth();
        }

        private void CalculateHeight() {
            Image image = Image.FromFile(_path);
            float h = (float)(width.GetValue() * image.Height) / image.Width;

            height.SetValue((int)h);
            width.SetValue(width.GetValue());
        }

        private void CalculateWidth() {
            Image image = Image.FromFile(_path);
            float w = (float)(height.GetValue() * image.Width) / image.Height;

            width.SetValue((int)w);
            height.SetValue(height.GetValue());
        }
    }
}
