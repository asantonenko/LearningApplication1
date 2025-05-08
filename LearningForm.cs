using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LearningApplication1
{
    public partial class LearningForm : Form
    {
        LearningController ctr;
        public LearningForm()
        {
            InitializeComponent();
        }

        private void LearningForm_Load(object sender, EventArgs e)
        {
            ctr = new LearningController("test.xml");
            showCurrentSlide();
        }

        public void showCurrentSlide()
        {
            ctr.CurrentSlide.Show(richTextBox1, pictureBox1, lPictureName);
        }

        private void bRestart_Click(object sender, EventArgs e)
        {
            ctr.Restart();
            showCurrentSlide();
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            ctr.Next();
            showCurrentSlide();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            ctr.Back();
            showCurrentSlide();
        }

        private void cbShowPictures_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = cbShowPictures.Checked;
            lPictureName.Visible = cbShowPictures.Checked;
        }
    }
}
