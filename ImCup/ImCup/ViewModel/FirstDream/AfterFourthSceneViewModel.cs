using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImCup.ViewModel.FirstDream
{
    public class AfterFourthSceneViewModel : BaseViewModel
    {
        public AfterFourthSceneViewModel()
        {
            BaseView.GetBlank();
            ImageFon = "most.jpg";
            PlaySlideAnim();
        }

        protected override void OnCreate()
        {
            BaseView.GetBlank();
            Text = "Pondo crossed a small\n\r" +
                   "grove and he saw a mountain.\n\r" +
                   "Finally a long journey\n\r" +
                   "came to the end, treasures\n\r" +
                   "were waiting ahead!\n\r" +
                   "All he had to do\n\r" +
                   "was climb up and find\n\r" +
                   "them in the cave.\n\r";

            ImageFon = "mountain.png";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "3";

            NavigationLeftButtonIsEnabled = "true";
            NavigationRightButtonIsEnabled = "true";

            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "nextActive.png";
        }

        protected override void NextScene()
        {
            NextView(new InMountinViewModel());
        }

        protected override void BackScene()
        {
            NextView(new FourthOneSceneViewModel());
        }
    }
}
