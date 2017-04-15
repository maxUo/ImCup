using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImCup.ViewModel.FirstDream
{
   public class Stray228ViewModel : BaseViewModel
    {
        public Stray228ViewModel()
        {
            base.BaseView.GetBlank();
            ImageFon = "ways.png";
            PlaySlideAnim();
        }

        protected override void OnCreate()
        {
            base.BaseView.GetBlank();
            Text = "After a while he came\n\r" +
                   "across the smallest\n\r" +
                   "pirate in the world:\n\r" +
                   "a mouse! Apparently it\n\r" +
                   "also have heard about\n\r" +
                   "the treasure and did\n\r" +
                   "not want to stand a\n\r" +
                   "competitor. It was\n\r" +
                   "necessary to do something.\n\r";

            ImageFon = "stray228.png";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "3";

            AnimationLeft = "rat.json";
            AnimationLeftAutoPlay = false;
            AnimationLeftLoop = false;
            AnimationLeftColumnSpan = "4";
            AnimationLeftRowSpan = "3";
            AnimationLeftIsVisible = true;

            NavigationLeftButtonIsEnabled = "true";
            NavigationRightButtonIsEnabled = "false";

            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "tap.png";
        }

        protected override async void  SecondChoiceCommmandButton()
        {
            AnimationLeftAutoPlay = true;
            await Task.Delay(1800);
            NavigationRightButtonIsEnabled = "true";
            NavigationImageRight = "nextActive.png";
        }

        protected override void NextScene()
        {
            NextView(new ThredSceneViewModel());
        }
        protected override void BackScene()
        {
            NextView(new ThredSceneViewModel());
        }
    }
}
