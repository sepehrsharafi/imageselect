using DarkUI.Docking;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSelector
{
    class Helper
    {
        public void FillImageList(string path, FlowLayoutPanel panel)
        {
        }

        public static void FillSelectedImages(string path, DataGridView dg)
        {
            if (Directory.Exists(path))
            {
                dg.DataSource = new DirectoryInfo(path).GetFiles().Where(s => s.FullName.ToLower().EndsWith(".jpeg") || s.FullName.ToLower().EndsWith(".jpg") || s.FullName.ToLower().EndsWith(".png")).ToArray();
                dg.Update();
            }
        }

        public static void DeleteSelectedImages(string path, DataGridView dg)
        {

        }

        public static Image CreateThumbnailImage(string imageFileName)
        {
            const int thumbnailSize = 100;

            using (var image = Image.FromFile(imageFileName))
            {
                var imageHeight = image.Height;
                var imageWidth = image.Width;
                if (imageHeight > imageWidth)
                {
                    imageWidth = (int)(((float)imageWidth / (float)imageHeight) * thumbnailSize);
                    imageHeight = thumbnailSize;
                }
                else
                {
                    imageHeight = (int)(((float)imageHeight / (float)imageWidth) * thumbnailSize);
                    imageWidth = thumbnailSize;
                }

                return image.GetThumbnailImage(imageWidth, imageHeight, () => false, IntPtr.Zero);
            }
        }

        public static string[] GetImages(string path)
        {

            return Directory.GetFiles(path).Where(s => s.ToLower().EndsWith(".jpeg") || s.ToLower().EndsWith(".jpg") || s.ToLower().EndsWith(".png")).ToArray();

        }

        public static void CopyFiles(DirectoryInfo source,
                      DirectoryInfo destination,
                      bool overwrite,
                      string searchPattern)
        {
            FileInfo[] files = source.GetFiles(searchPattern);

            string DestPath;

            //this section is what's really important for your application.
            foreach (FileInfo file in files)
            {
                DestPath = destination.FullName + "\\" + file.Name;
                if (!File.Exists(DestPath))
                {
                    file.CopyTo(DestPath, overwrite);
                }
            }
        }

        public static void DeleteFiles(DirectoryInfo directory, string searchPattern)
        {
            FileInfo[] files = directory.GetFiles(searchPattern);

            //this section is what's really important for your application.
            foreach (FileInfo file in files)
            {
                file.Delete();
            }
        }
    }
}
