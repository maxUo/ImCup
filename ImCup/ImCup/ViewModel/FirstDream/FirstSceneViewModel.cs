using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ImCup.Interfaces;
using ImCup.Model;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

namespace ImCup.ViewModel.FirstDream {
    public class FirstSceneViewModel: BaseViewModel
    {
        private bool _eng;
        
        public FirstSceneViewModel()
        {
            Eng = true;
            BaseView.GetBlank();
          /* BaseView.GetBlank();
           ImageFon = "house.png";
           PlaySlideAnim();*/
           PlaySlideAnim();
        }

        public bool Eng
        {
            get { return _eng; }
            private set { _eng = value; }
        }
        protected override void OnCreate()
        {
            base.BaseView.GetBlank();
            if (Eng)
            {
                Text = "Once upon a time there was a brave \n\r" +
                   "panda called Pondo in the Sunny Land. \n\r" +
                   "One day he heard from his grandfather a story \n\r" +
                   "about treasures hidden in the top\n\r"+
                   "of Cognito mountain somewhere in the North.\n\r";
            }
            else
            {
                Text = "В Солнечном Краю жил-был Панда-По.\n\r" +
                   "Однажды он услышал от своего деда легенду о сокровищах,\n\r" +
                   "сокрытых в пещере на вершине горы\n\r" +
                   "Когнито где-то на севере.\n\r";
            }
            
            ImageFon = "house.png";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "3";

            ImageLeft = "pandaAndDed.png";
            ImageLeftGridColumnSpan = "4";
            ImageLeftGridRowSpan = "2";

            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "nextActive.png";

            NavigationLeftButtonIsEnabled = "true";
            NavigationRightButtonIsEnabled = "true";
            musicId = DependencyService.Get<IAudio>().PlayMp3File("Grandfather1.mp3");

        }

        protected override void NextScene()
        {
            NextView(new SecondSceneViewModel());
        }

        protected override void BackScene()
        {
            DependencyService.Get<IAudio>().StopPlay(musicId);
            GoBack?.Invoke();
        }
    }
}
