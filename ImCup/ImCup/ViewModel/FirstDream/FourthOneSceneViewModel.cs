using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImCup.ViewModel.FirstDream
{
    public class FourthOneSceneViewModel:BaseViewModel
    {
        public FourthOneSceneViewModel()
        {
            base.BaseView.GetBlank();
            ImageFon = "arbre1.png";
            PlaySlideAnim();
        }

        protected override void OnCreate()
        {
            base.BaseView.GetBlank();
            Text = "Юный авантюрист Панда-По решил\n\r" +
                "решил отправиться на поиски сокровищ.\n\r" +
                "Он двинулся в путь, взяв в дорогу\n\r" +
                "немного провизии, карту,\n\r" +
                "компас и подзорную трубу.\n\r";

            ImageFon = "most.jpg";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "3";

            AnimationLeft = "pandaDiver1.json";
            AnimationLeftAutoPlay = true;
            AnimationLeftLoop = false;
            AnimationLeftColumnSpan = "4";
            AnimationLeftRowSpan = "2";
            AnimationLeftIsVisible = true;


            NavigationLeftButtonIsEnabled = "true";
            NavigationRightButtonIsEnabled = "true";

            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "nextActive.png";
        }
    }
}
