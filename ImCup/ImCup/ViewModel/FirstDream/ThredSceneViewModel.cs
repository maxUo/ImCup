using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImCup.ViewModel.FirstDream
{
    public class ThredSceneViewModel:BaseViewModel
    {
        public ThredSceneViewModel()
        {
            BaseView.GetBlank();
            ImageFon = (new SecondSceneViewModel()).ImageFon;
            PlaySlideAnim();
        }
        protected override void OnCreate()
        {
            base.BaseView.GetBlank();

            Text = 
                "Чтобы начать путешествие, нужно выяснить,\n\r" +
                "в какую сторону двигаться.\n\r" +
                "Читателю придется помочь\n\r" +
                "нашему герою выбрать предмет,\n\r" +
                "с помощью которого он это определит\n\r";

            ImageFon = "ways.png";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "2";

            NavigationLeftButtonIsEnabled = "true";
            NavigationRightButtonIsEnabled = "false";


            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "nextNoACtive.png";
        }

        protected override void BackScene()
        {
            NextView(new SecondSceneViewModel());
        }
    }
}
