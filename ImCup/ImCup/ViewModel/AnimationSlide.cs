using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImCup.ViewModel
{
    public class AnimationSlide : BaseViewModel
    {
        public AnimationSlide(string imageFone)
        {
            base.BaseView.GetBlank();

            ImageFon = imageFone;
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "2";

            Text = "Идет загрузка...";

            AnimationLeft = "progress_bar.json";
            AnimationLeftLoop = false;
            AnimationLeftAutoPlay = true;


            AnimationLeftColumnSpan = "4";
            AnimationLeftRowSpan = "2";

            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "nextActive.png";
        }
    }
}
