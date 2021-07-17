using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DarkUI.Forms;

namespace ImageSelector
{
    public partial class frmImageSelector : DarkForm
    {

        string[] images;

        int CurrentIndex = 0;

        string NotesPath;

        int ZoomInedx = 0;

        public string SelectedFolderPath
        {
            get
            {
                if (!string.IsNullOrEmpty(txtAddress.Text))
                    return txtAddress.Text + @"\selected";
                return null;
            }
        }

        public frmImageSelector()
        {
            InitializeComponent();
            dgSelectedImages.AutoGenerateColumns = false;
        }

        private void frmImageSelector_Load(object sender, EventArgs e)
        {
            //dgSelectedImages.Columns["Flags"].DefaultCellStyle.NullValue = null;
            //dgSelectedImages.Rows[index].Cells["CellName"].Value = isFlag ? Properties.Resources.FlagImage : new Bitmap(1, 1);

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtAddress.Text = fbd.SelectedPath;
                    Helper.FillSelectedImages(SelectedFolderPath, dgSelectedImages);
                    images = Helper.GetImages(txtAddress.Text);
                    CurrentIndex = 0;
                    ShowImage();
                }
            }
           
        }

        private void dgSelectedImages_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void dgSelectedImages_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgSelectedImages.Rows)
            {
                FileInfo file = row.DataBoundItem as FileInfo;
                if (file != null)
                {

                    row.Cells[0].Value = Helper.CreateThumbnailImage(file.FullName);
                }

            }
        }

        private void ShowImage()
        {

            Image img;
            using (var bmpTemp = new Bitmap(images[CurrentIndex]))
            {
                img = new Bitmap(bmpTemp);
            }

            pbCurrentImage.Image = img;
            lblFileName.Text = Path.GetFileName(images[CurrentIndex]);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentIndex < images.Length-1)
            {
                CurrentIndex++;
                ShowImage();
            }
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 0)
            {
                CurrentIndex--;
                ShowImage();
            }
        }

        private void dgSelectedImages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.colImage.DefaultCellStyle.NullValue = null;
        }

        private void btnNext10_Click(object sender, EventArgs e)
        {
            if (CurrentIndex < images.Length - 10)
            {
                CurrentIndex = CurrentIndex + 10;
                ShowImage();
            }
        }

        private void btnPrv10_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 9)
            {
                CurrentIndex = CurrentIndex - 10;
                ShowImage();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(SelectedFolderPath))
            {
                Directory.CreateDirectory(SelectedFolderPath);
            }

            string currentImagePath = images[CurrentIndex];

            DirectoryInfo source = new DirectoryInfo(txtAddress.Text);
            DirectoryInfo dest = new DirectoryInfo(SelectedFolderPath);

            Helper.CopyFiles(source, dest, true, Path.GetFileNameWithoutExtension(currentImagePath) + ".*");

            Helper.FillSelectedImages(SelectedFolderPath, dgSelectedImages);

            NotesPath = SelectedFolderPath + @"\" + Path.GetFileNameWithoutExtension(currentImagePath) + ".txt";

            File.Create(NotesPath).Close(); // Create file

            using (StreamWriter sw = File.AppendText(NotesPath))
            {
                sw.Write(txtNotes.Text); // Write text to .txt file
            }

            txtNotes.Clear();

            //lblFileName.Text + ".txt"

        }

        private void frmImageSelector_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                if (CurrentIndex > 0)
                {
                    CurrentIndex--;
                    ShowImage();
                }
            }

            //capture right arrow key
            if (keyData == Keys.Right)
            {
                if (CurrentIndex < images.Length)
                {
                    CurrentIndex++;
                    ShowImage();
                }
            }

            //capture up arrow key
            if (keyData == Keys.Up)
            {
                if (CurrentIndex < images.Length - 10)
                {
                    CurrentIndex = CurrentIndex + 10;
                    ShowImage();
                }
            }

            //capture down arrow key
            if (keyData == Keys.Down)
            {
                if (CurrentIndex > 9)
                {
                    CurrentIndex = CurrentIndex - 10;
                    ShowImage();
                }
            }

            //capture down arrow key
            if (keyData == Keys.Enter)
            {
                if (!Directory.Exists(SelectedFolderPath))
                {
                    Directory.CreateDirectory(SelectedFolderPath);
                }

                string currentImagePath = images[CurrentIndex];

                DirectoryInfo source = new DirectoryInfo(txtAddress.Text);
                DirectoryInfo dest = new DirectoryInfo(SelectedFolderPath);

                Helper.CopyFiles(source, dest, true, Path.GetFileNameWithoutExtension(currentImagePath) + ".*");

                Helper.FillSelectedImages(SelectedFolderPath, dgSelectedImages);

                NotesPath = SelectedFolderPath + @"\" + Path.GetFileNameWithoutExtension(currentImagePath) + ".txt";

                File.Create(NotesPath).Close(); // Create file

                using (StreamWriter sw = File.AppendText(NotesPath))
                {
                    sw.Write(txtNotes.Text); // Write text to .txt file
                }

                txtNotes.Clear();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dgSelectedImages_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 1)
            {
                int rowIndex = dgSelectedImages.CurrentCell.RowIndex;

                string FileName = ((FileInfo[])dgSelectedImages.DataSource)[rowIndex].FullName;

                DirectoryInfo dir = new DirectoryInfo(SelectedFolderPath);

                Helper.DeleteFiles(dir, Path.GetFileNameWithoutExtension(FileName) + ".*");

                Helper.FillSelectedImages(SelectedFolderPath, dgSelectedImages);
            }
            //(dgSelectedImages.Rows.Remove);


           


        }

        private void frmImageSelector_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgSelectedImages_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgSelectedImages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                int rowIndex = dgSelectedImages.CurrentCell.RowIndex;

                string FileName = ((FileInfo[])dgSelectedImages.DataSource)[rowIndex].FullName;

                frm_PictureBox Picturebox_Form = new frm_PictureBox(rowIndex, FileName, SelectedFolderPath);
                Picturebox_Form.Show();

            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            ZoomInedx = -1;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            ZoomInedx = +1;
        }

        private void dgSelectedImages_DataSourceChanged(object sender, EventArgs e)
        {
            lblNull.Visible = false;
        }

        Image ZoomPicture(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width),
                Convert.ToInt32(img.Height * size.Height));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            pbCurrentImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbCurrentImage.Refresh();
        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            pbCurrentImage.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pbCurrentImage.Refresh();
        }

        private void pbCurrentImage_Click(object sender, EventArgs e)
        {

        }
    }
}