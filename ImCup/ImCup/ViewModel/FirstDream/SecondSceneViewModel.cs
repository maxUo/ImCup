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
    public class SecondSceneViewModel : BaseViewModel {
        public SecondSceneViewModel()
        {
            base.PlaySlideAnim();
        }

        protected override void OnCreate()
        {
            base.BaseView.GetBlank();

            Text = "Юный авантюрист Панда-По решил\n\r"+
                "решил отправиться на поиски сокровищ.\n\r"+
                "Он двинулся в путь, взяв в дорогу\n\r"+
                "немного провизии, карту,\n\r" +
                 "компас и подзорную трубу.\n\r";

            ImageFon = "road1.png";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "2";

            AnimationLeft = "walk.json";
            AnimationLeftAutoPlay = true;
            AnimationLeftLoop = false;
            AnimationLeftColumnSpan = "4";
            AnimationLeftRowSpan = "2";

            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "nextActive.png";
        }

        protected override void BackScene()
        {
            NextView(new FirstSceneViewModel());
        }
    }
}
