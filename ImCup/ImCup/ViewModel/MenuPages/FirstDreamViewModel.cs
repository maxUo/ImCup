using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImCup.ViewModel.FirstDream;
using Xamarin.Forms;

namespace ImCup.ViewModel.MenuPages
{
    public class FirstDreamViewModel : BaseMenuPageViewModel
    {
        public FirstDreamViewModel()
        {
            ImageSource = "iconChessBorder.png";
        }

        protected override void OnButtonShowCommand()
        {
            NextDream(new FirstSceneViewModel());
        }
    }
}
