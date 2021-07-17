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

namespace ImageSelector
{
    public partial class frm_PictureBox : Form
    {
        string filename;
        int rowindex;
        string selectedfolderpath;
        string notepath;


        public frm_PictureBox()
        {
            InitializeComponent();
        }

        public frm_PictureBox(int RowIndex, string FileName, string SelectedFolderPath)
        {
            InitializeComponent();

            rowindex = RowIndex;
            filename = FileName;
            selectedfolderpath = SelectedFolderPath;
            notepath = selectedfolderpath + "\\" + Path.GetFileNameWithoutExtension(filename) + ".txt";
        }

        private void frm_PictureBox_Load(object sender, EventArgs e)
        {
            Image img;
            using (var bmpTemp = new Bitmap(filename))
            {
                img = new Bitmap(bmpTemp);
            }

            frm1_PictureBox.Image = img;
            if (File.Exists(notepath))
            {
                txtNotes.Text = File.ReadAllText(notepath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNotes.Text))
            {
                using (StreamWriter sw = File.AppendText(notepath))
                {
                    //File.WriteAllText(notepath, String.Empty); // Clear file
                    sw.Write(txtNotes.Text); // Write text to .txt file
                    
               
                }
            }
        }

        private void frm_PictureBox_DoubleClick(object sender, EventArgs e)
        {

        }

        private void frm1_PictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
