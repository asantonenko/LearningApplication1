using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace LearningApplication1
{
    //Представляет собой один "слайд", содержит в себе текст и некоторое количество картнок
    public class Slide
    {
        string textFilename;
        List<SlidePicture> pictures;
        public Slide(string textFilename)
        {
            this.textFilename = textFilename;
            pictures = new List<SlidePicture>();
        }
        //Добавить картинку
        public void addPicture(SlidePicture p)
        {
            pictures.Add(p);
        }
        //Показать слайд - используется компоненты RichTextBox, PictureBox и Label
        //данный метод расчитан максимум на одно изображение на слайде
        public void Show(RichTextBox rtb, PictureBox pb, Label l)
        {
            if (textFilename.EndsWith(".txt")) rtb.LoadFile(textFilename,RichTextBoxStreamType.UnicodePlainText);
            else if (textFilename.EndsWith(".rtf")) rtb.LoadFile(textFilename, RichTextBoxStreamType.RichText);
            if (pictures.Count >= 1)
            {
                pb.Visible = true; l.Visible = true;
                pb.Image = pictures[0].GetImage();
                l.Text = "Рис. " + pictures[0].Number.ToString();
            }
            else
            {
                pb.Visible = false; l.Visible = false;
            }
        }
        //Распарсить XML тег <slide text="файл текста"><picture name="файл изображения" number="номер изображения"</slide>
        public static Slide parseXmlNode(XmlNode node)
        {
            string textFn = node.Attributes["text"].Value;
            Slide s = new Slide(textFn);
            foreach (XmlNode pic in node.ChildNodes)
            {
                if (pic.Name == "picture")
                    s.addPicture(new SlidePicture(Convert.ToInt32(pic.Attributes["number"].Value),pic.Attributes["name"].Value));
            }
            return s;
        }
    }
}
