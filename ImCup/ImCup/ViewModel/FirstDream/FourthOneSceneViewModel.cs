﻿using System;
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
            Text = "Our hero wasn’t a fast\n\r" +
                   "runner but he was smart.\n\r" +
                   "Therefore he took shelter in\n\r " +
                   "a river and used a bamboo\n\r" +
                   "stick for breathing.\n\r";

            ImageFon = "most.jpg";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "3";

            AnimationLeft = "BEEriver.json";
            AnimationLeftAutoPlay = true;
            AnimationLeftLoop = false;
            AnimationLeftColumnSpan = "4";
            AnimationLeftRowSpan = "3";
            AnimationLeftIsVisible = true;

            NavigationLeftButtonIsEnabled = "true";
            NavigationRightButtonIsEnabled = "true";

            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "nextActive.png";

            /*await Task.Delay(7000);
            AnimationLeft = "pandaDiver1.json";
            AnimationLeftColumnSpan = "3";
            AnimationLeftRowSpan = "2";*/
        }

        private bool isLucher = false;

        protected override void NextScene()
        {
            if (!isLucher)
            {
                isLucher = !isLucher;
                GoLucher();
            }
            else
            {
                NextView(new AfterFourthSceneViewModel());
            }
        }
    }
}
