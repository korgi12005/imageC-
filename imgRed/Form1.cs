using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgRed
{
    public partial class Form1 : Form
    {
        Bitmap image,oldImage,newImage;
        public Form1()
        {
            InitializeComponent();
        }

      

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1 != null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(dialog.FileName);
                }
            }
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = InverseFilter.ExecuteG(image);
            image = resultImage;

            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void averageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = InverseFilter.ExecuteAv(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void autoConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = InverseFilter.ExecuteAutoCon(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = InverseFilter.ExecuteBinLevel(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

     

        private void ниблэкToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Bitmap resultImage = InverseFilter.ExecuteNiblack(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void глобальнаяГистограммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = InverseFilter.ExecuteGlGist(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void белыйШумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = InverseFilter.ExecuteSalt(image);
            image = resultImage;
            oldImage = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void шумГаусаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = InverseFilter.ExecuteGause(image);
            image = resultImage;
            oldImage=resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void усреднениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = InverseFilter.ExecuteMedian(image);
            image = resultImage;
            newImage = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void sSIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float resultImage = InverseFilter.ExecutePSNR(oldImage, newImage);
            PSNRlab.Text = resultImage.ToString();
        }

        private void фильтрГауссаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = InverseFilter.ExecuteGausFilter(image);
            image = resultImage;
            newImage = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void pSNRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float resultImage = InverseFilter.ExecuteSSIM(oldImage,newImage);
            SSIMlab.Text=resultImage.ToString();
            
        }
    }
}
