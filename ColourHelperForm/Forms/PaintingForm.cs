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
            Switch.Screen(new Form1());
        }

        private void _buttonRemove_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "Are you sure that you want to delete this painting?",
                "Delete painting?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes) {
                Files.RemovePainting(Path.GetFileName(_path));
                Switch.Screen(new Form1());
            }
        }

        private void _buttonExport_Click(object sender, EventArgs e) {
            Switch.Screen(new ExportForm(_path));
        }
    }
}