using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mialbum3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alumnoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.albumDataSet);

        }

        private void alumnoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.albumDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'albumDataSet.alumno' table. You can move, or remove it, as needed.
            this.alumnoTableAdapter.Fill(this.albumDataSet.alumno);

        }

        private void imagenPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Title = "Open Picture";
            img.FileName = ".jpg";
            img.Filter = "All Files |*.*";
            img.ShowDialog();
            imagenPictureBox.Image = System.Drawing.Image.FromFile(img.FileName);
        }

        private void videoPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog video = new OpenFileDialog();
            video.Title = "Open Video";
            video.FileName = ".jpg";
            video.Filter = "All Files |*.*";
            video.ShowDialog();
            //videoPictureBox.Image = System.Drawing.Image.FromFile(video.FileName);
            videoPlayer.URL = video.FileName;
        }
    }
}
