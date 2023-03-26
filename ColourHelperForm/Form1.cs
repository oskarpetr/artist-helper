using ColourHelperForm.Tools;
using ColourHelperForm.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using ColourHelperForm.Models;

namespace ColourHelperForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            LoadPaintings();
        }

        private void LoadPaintings() {
            List<string> images = Files.GetPaintings();

            int x = 50;
            int y = 120;
            for (int i = 0; i < images.Count; i++) {
                PictureBox picture = new();

                picture.Image = Image.FromFile(images[i]);
                picture.ImageLocation = images[i];
                picture.Width = 205;
                picture.Height = 250;
                picture.Location = new Point(x + (i % 3) * 255, y + (i / 3) * 300);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Click += Picture_Click;

                Label label = new();
                label.Text = Path.GetFileNameWithoutExtension(images[i]);
                label.Font = new Font("SF Pro Rounded", 10);
                label.ForeColor = SystemColors.ControlDarkDark;
                label.Width = 205;
                label.Location = new Point(x + (i % 3) * 255, y + (i / 3) * 300 + 255);

                Controls.Add(picture);
                Controls.Add(label);
            }
        }

        private void Picture_Click(object? sender, EventArgs e) {
            PictureBox picture = sender as PictureBox;
            PaintingForm form = new(picture.ImageLocation);
            Switch.Screen(form);
        }

        private void _buttonCreate_Click(object sender, EventArgs e) {
            Switch.Screen(new CreatePaintingForm());
        }
    }
}