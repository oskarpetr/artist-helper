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
using ColourHelperForm.Tools;

namespace ColourHelperForm.Forms {
    public partial class ExportForm : Form {
        private string _path;
        private Detail _detail;
        private string _destination;

        public ExportForm(string path) {
            InitializeComponent();

            _path = path;
            _detail = Files.GetDetail(Path.GetFileNameWithoutExtension(_path));
        }

        private void _labelBack_Click(object sender, EventArgs e) {
            Switch.Screen(new PaintingForm(_path));
        }

        private void _buttonSelect_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK) {
                _destination = $"{dialog.SelectedPath}\\{Path.GetFileNameWithoutExtension(_path)}";
                _labelPath.Text = dialog.SelectedPath;
            }
        }

        private void _buttonExport_Click(object sender, EventArgs e) {
            if(_comboBox.SelectedValue == null && _destination == null) {
                MessageBox.Show(
                "You have to select the type of export and the folder destination.",
                "Incomplete form",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_comboBox.SelectedIndex == 0) {
                Files.Export(Exporter.ToJson(_detail.Colours), $"{_destination}.json");
            } else if(_comboBox.SelectedIndex == 1) {
                Files.Export(Exporter.ToText(_detail.Colours), $"{_destination}.txt");
            }

            Switch.Screen(new PaintingForm(_path));
        }
    }
}
