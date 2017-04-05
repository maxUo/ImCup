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
            base.BaseView = new BaseView()
            {
                Text = "В Солнечном Краю жил-был Панда-По.\n\r" +
                       "Однажды он услышал от своего деда легенду о сокровищах,\n\r" +
                       "сокрытых в пещере на вершине горы\n\r" +
                       "Когнито где-то на севере.",

                ImageFon = "house.png",
                ImageFonGridColumnSpan = "4",
                ImageFonGridRowSpan = "2",

                ImageLeft = "pandaAndDed.png",
                ImageLeftGridColumnSpan = "4",
                ImageLeftGridRowSpan = "2",

                NavigationImageLeft = "backActive.png",
                NavigationImageRight = "nextActive.png",

                NavigationLeftButtonIsEnabled = "true",
                NavigationRightButtonIsEnabled = "true",

                AnimationLeft = "",
                AnimationLeftColumnSpan = "1",
                AnimationLeftRowSpan = "1",
                AnimationRight = "",
                AnimationRightGridColumnSpan = "1",
                AnimationRightGridRowSpan = "1",

                ImageRight = "",
                ImageRightGridColumnSpan = "1",
                ImageRightGridRowSpan = "1"
            };
        }
        
        protected override void NextScene()
        {
            Text = "road1.png";

            ImageFon = "road1.png";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "2";

            NavigationLeftButtonIsEnabled = "true";
            NavigationRightButtonIsEnabled = "true";

            base.NextScene();
        }

        protected override void BackScene()
        {
            base.BackScene();
        }
    }
}
