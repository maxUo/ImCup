using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImCup.Interfaces;
using Xamarin.Forms;

namespace ImCup.ViewModel.FirstDream
{
    public class FourthSceneViewModel : BaseViewModel
    {
        public FourthSceneViewModel()
        {
            BaseView.GetBlank();
            ImageFon = "ways.png";
            PlaySlideAnim();
        }

        protected override void OnCreate()
        {
            BaseView.GetBlank();

            Text =
                "Путь его лежал мимо большой яблони\n\r" +
                "Искатель сокровищ шел целый день и проголодался,\n\r" +
                "так что он решил набрать немного яблок.\n\r" +
                "Однако плоды росли слишком высоко!\n\r" +
                "Придется трясти дерево!\n\r";

            ImageFon = "arbre1.png";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "2";

            ImageLeft = "pandaVbok.png";
            ImageLeftGridColumnSpan = "2";
            ImageLeftGridRowSpan = "2";
            /*
            AnimationLeft = "bee.json";
            AnimationLeftAutoPlay = false;
            AnimationLeftLoop = false;
            */
            NavigationLeftButtonIsEnabled = "true";
            NavigationRightButtonIsEnabled = "false";

            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "acelerometre.png";
        }

        protected override async void AcelerometrMove()
        {
            NavigationImageRight = "nextActive.png";
            NavigationRightButtonIsEnabled = "true";
            AnimationRight = "bee.json";
            AnimationRightLoop = false;
            AnimationRightAutoPlay = true;
            AnimationRightGridColumnSpan = "2";
            AnimationRightGridRowSpan = "2";
            AnimationRightIsVisible = true;
            DependencyService.Get<IAudio>().PlayMp3File("");
            await Task.Delay(1500);

            BaseView.GetBlank();

        }

        protected override void NextScene()
        {
            //await CleanAnimationForm();
            NextView(new FourthOneSceneViewModel());
        }

        protected override void BackScene()
        {
            NextView(new ThredSceneViewModel());
        }
    }
}
