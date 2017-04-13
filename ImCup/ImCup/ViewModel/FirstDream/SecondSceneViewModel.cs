using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ImCup.Model;
using Xamarin.Forms;

namespace ImCup.ViewModel.FirstDream {
    public class SecondSceneViewModel : BaseViewModel
    {
        private bool _eng;
        public SecondSceneViewModel()
        {
            Eng = true;
            BaseView.GetBlank();
            ImageFon = "house.png";
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
                Text = "The young adventurer Pondo decided \n\r" +
                "to go on a treasure hunt.\n\r" +
                "He moved in a way taking only\n\r" +
                "some provisions, map,\n\r" +
                "compass and spyglass.\n\r";
            }
            else
            {
                Text = "Юный авантюрист Панда-По решил\n\r" +
                "решил отправиться на поиски сокровищ.\n\r" +
                "Он двинулся в путь, взяв в дорогу\n\r" +
                "немного провизии, карту,\n\r" +
                "компас и подзорную трубу.\n\r";
            }
            

            ImageFon = "road1.png";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "3";

            AnimationLeft = "walk.json";
            AnimationLeftAutoPlay = true;
            AnimationLeftLoop = false;
            AnimationLeftColumnSpan = "4";
            AnimationLeftRowSpan = "3";
            AnimationLeftIsVisible = true;

            NavigationLeftButtonIsEnabled = "true";
            NavigationRightButtonIsEnabled = "true";

            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "nextActive.png";
        }

        protected override void NextScene()
        {
            NextView(new ThredSceneViewModel());
        }

        protected override void BackScene()
        {
            NextView(new FirstSceneViewModel());
        }
    }
}
