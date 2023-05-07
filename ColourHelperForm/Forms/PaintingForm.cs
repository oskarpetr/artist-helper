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
using ColourHelperForm.Models;

namespace ColourHelperForm.Forms {
    public partial class PaintingForm : Form {
        private string _path;
        private Detail _detail;
        public PaintingForm(string path) {
            InitializeComponent();

            _path = path;
            _detail = Files.GetDetail(Path.GetFileNameWithoutExtension(_path));

            LoadPainting();
        }

        private void LoadPainting() {
            // set painting name
            _labelName.Text = Path.GetFileNameWithoutExtension(_path);


            // set painting image and size
            float width = ((float)_detail.Width / _detail.Height) * _picturePainting.Height;
            _picturePainting.Size = new((int)width, 300);
            _picturePainting.Image = Image.FromFile(_path);

            // set location for texts and buttons
            _labelColours.Location = new(100 + (int)width, _labelColours.Location.Y);
            Size location = new(100 + (int)width, 186);

            // set size text
            _labelSize.Text = $"{_detail.Width}x{_detail.Height}cm";

            // set colours with "ml" texts
            int counter = 0;
            int rounds = 0;
            for (int i = 0; i < _detail.Colours.Count; i++) {
                var entry = _detail.Colours.ElementAt(i);

                if(Math.Round(entry.Value, 2) == 0) {
                    counter--;
                    continue;
                }

                Label label = new();

                if (counter > 5) { counter = 0; rounds++; }
                label.Location = new Point(location.Width + (rounds * 200), location.Height + (counter * 25));

                label.Text = $"{entry.Key} — {Math.Round(entry.Value, 2)}ml";
                label.Font = new("SF Pro Rounded", 11);
                label.ForeColor = SystemColors.ControlDarkDark;

                label.Size = new(200, 25);

                Controls.Add(label);
                counter++;
            }

            // set location for button
            _buttonVisual.Location = new(100 + (int)width, _buttonVisual.Location.Y);
        }

        private void _labelBack_Click(object sender, EventArgs e) {
            Switch.Screen(new Form1());
        }

        private void _buttonRemove_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "Are you sure that you want to delete this painting?",
                "Delete painting?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes) {
                Files.RemoveDetail(Path.GetFileNameWithoutExtension(_path));
                Switch.Screen(new Form1(false));
            }
        }

        private void _buttonExport_Click(object sender, EventArgs e) {
            Switch.Screen(new ExportForm(_path));
        }

        private void _buttonVisual_Click(object sender, EventArgs e) {
            Switch.Screen(new VisualForm(_detail));
        }
    }
}