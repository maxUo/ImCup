using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImCup.ViewModel.FirstDream
{
    public class InMountinViewModel : BaseViewModel
    {
        public InMountinViewModel()
        {
            base.BaseView.GetBlank();
            ImageFon = "mountain.png";
            PlaySlideAnim();
        }

        protected override void OnCreate()
        {
            base.BaseView.GetBlank();
            Text = "Our hero wasn’t a fast\n\r" +
                   "runner but he was smart.\n\r" +
                   "Therefore he took shelter in\n\r " +
                   "a river and used a bamboo\n\r" +
                   "stick for breathing.\n\r";

            ImageFon = "cave.png";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "3";

            NavigationLeftButtonIsEnabled = "true";
            NavigationRightButtonIsEnabled = "true";

            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "nextActive.png";
        }

        protected override void NextScene()
        {
            GoBack();
        }

        protected override void BackScene()
        {
            NextView(new AfterFourthSceneViewModel());
        }
    }
}
