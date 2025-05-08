using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace LearningApplication1
{
    public class SlidePicture
    {
        int number;
        string filename;
        public SlidePicture(int number, string filename)
        {
            this.number = number;
            this.filename = filename;
        }
        public Image GetImage()
        {
            return Image.FromFile(filename);
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
