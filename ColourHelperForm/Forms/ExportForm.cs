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
    public partial class ExportForm : Form {
        private string _path;
        public ExportForm(string path) {
            InitializeComponent();

            _path = path;
        }

        private void _labelBack_Click(object sender, EventArgs e) {
            Switch.Screen(new PaintingForm(_path));
        }
    }
}
