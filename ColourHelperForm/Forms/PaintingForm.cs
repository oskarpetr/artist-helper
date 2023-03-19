using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using ColourHelperForm.Tools;

namespace ColourHelperForm.Forms {
    public partial class PaintingForm : Form {
        private string _path;
        public PaintingForm(string path) {
            InitializeComponent();

            _path = path;
            LoadPainting();
        }

        private void LoadPainting() {
            _labelName.Text = Path.GetFileNameWithoutExtension(_path);
            _picturePainting.Image = Image.FromFile(_path);
        }

        private void _labelBack_Click(object sender, EventArgs e) {
            //Switch.Screen(new Form1());
        }

        private void _buttonRemove_Click(object sender, EventArgs e) {
            MessageBox.Show(
                "Are you sure that you want to delete this painting?",
                "Delete painting?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // handle options
        }

        private void _buttonExport_Click(object sender, EventArgs e) {
            //Switch.Screen(new ExportForm(_path));
        }

        private void button1_Click(object sender, EventArgs e) {
            Painting painting = new Painting(Image.FromFile(_path));

            var list = painting.GetColours();
            var mlList = painting.GetPaintCm(list, 100).ToList();

            for (int i = 0; i < list.Count; i++) {
                Debug.WriteLine($"{mlList[i].Key}: {mlList[i].Value}");
            }
        }
    }
}