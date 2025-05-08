using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace LearningApplication1
{
    class LearningController
    {
        List<Slide> slides;
        int currentSlideIndex;
        //bool isPictureVisible;
        //Конструктор, создает "презентацию" из слайдов на основании XML-файла xmlFilename
        public LearningController(string xmlFilename)
        {
            slides = new List<Slide>();
            XmlDocument xml = new XmlDocument();
            xml.Load(xmlFilename);
            foreach (XmlNode node in xml.SelectNodes("/slides/slide"))
            {
                slides.Add(Slide.parseXmlNode(node));
            }
            Restart();
        }
        //Возвращает текущий слайд
        public Slide CurrentSlide
        {
            get { return slides[currentSlideIndex]; }
        }
        //Начать со стартового слайда
        public void Restart()
        {
            currentSlideIndex = 0;
        }
        //Переместиться на следующий слайд, возвращает true, если он есть
        public bool Next()
        {
            if (currentSlideIndex + 1 < slides.Count)
            {
                currentSlideIndex++;
                return true;
            }
            else return false;
        }

        //Переместиться на предыдущий слайд, возвращает true, если он есть
        public bool Back()
        {
            if (currentSlideIndex > 0)
            {
                currentSlideIndex--;
                return true;
            }
            else return false;
        }
    }
}
