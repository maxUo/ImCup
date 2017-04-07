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
            base.BaseView.GetBlank();

            Text = "В Солнечном Краю жил-был Панда-По.\n\r" +
                   "Однажды он услышал от своего деда легенду о сокровищах,\n\r" +
                   "сокрытых в пещере на вершине горы\n\r" +
                   "Когнито где-то на севере.";

            ImageFon = "road1.png";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "2";

        }

        protected override void BackScene()
        {
            base.BackScene();
        }
    }
}
