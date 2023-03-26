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

        public CreatePaintingForm() {
            InitializeComponent();
        }

        private void _labelBack_Click(object sender, EventArgs e) {
            Switch.Screen(new Form1());
        }

        private void _buttonUpload_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "images (*.png)|*.png|(*.jpg)|*.jpg|(*.jpeg)|*.jpeg";

            if (dialog.ShowDialog() == DialogResult.OK) {
                _picturePainting.Image = Image.FromFile(dialog.FileName);
                _path = dialog.FileName;

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
    }
}
