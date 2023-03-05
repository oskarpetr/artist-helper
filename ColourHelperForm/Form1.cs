using ColourHelperForm.Tools;

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

                Controls.Add(picture);
            }
        }

        private void Picture_Click(object? sender, EventArgs e) {
            PictureBox picture = sender as PictureBox;
            if (picture != null) {
                MessageBox.Show(Path.GetFileName(picture.ImageLocation));
            }
        }

        private void _buttonAdd_Click(object sender, EventArgs e) {

        }
    }
}