using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImCup.ViewModel.MenuPages
{
    public class RecognitionPageViewModel : BaseMenuPageViewModel
    {
       public RecognitionPageViewModel()
       {
           ImageSource = "BottleMap.png";
       }

        protected override void OnButtonShowCommand()
        {
            RecognitionPage?.Invoke();
        }
    }
}
