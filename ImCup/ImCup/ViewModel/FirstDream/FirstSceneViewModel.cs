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
    public class FirstSceneViewModel: BaseViewModel {
        public FirstSceneViewModel()
        {
            BaseView.GetBlank();
          /* BaseView.GetBlank();
           ImageFon = "house.png";
           PlaySlideAnim();*/
           PlaySlideAnim();
        }

        protected override void OnCreate()
        {
            base.BaseView.GetBlank();

            Text = "В Солнечном Краю жил-был Панда-По.\n\r" +
                   "Однажды он услышал от своего деда легенду о сокровищах,\n\r" +
                   "сокрытых в пещере на вершине горы\n\r" +
                   "Когнито где-то на севере.\n\r" +
                   "";
            ImageFon = "house.png";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "2";

            ImageLeft = "pandaAndDed.png";
            ImageLeftGridColumnSpan = "4";
            ImageLeftGridRowSpan = "2";

            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "nextActive.png";

            NavigationLeftButtonIsEnabled = "true";
            NavigationRightButtonIsEnabled = "true";

        }

        protected override void NextScene()
        {
            NextView(new SecondSceneViewModel());
        }

        protected override void BackScene()
        {
            GoBack?.Invoke();
        }
    }
}
