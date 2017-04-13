using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

namespace ImCup.ViewModel.FirstDream
{
    public class ThredSceneViewModel:BaseViewModel
    {
        TodoItemManager manager;
        private bool _eng;
        public ThredSceneViewModel()
        {
            Eng = true;
            BaseView.GetBlank();
            ImageFon = "road1.png";
            PlaySlideAnim();

            //manager = TodoItemManager.DefaultManager;

            //var todo = new TodoItem { Name = "Ale"};
            //AddItem(todo);
            //var client = new MobileServiceClient("http://imaginationcup.azurewebsites.net");


        }

        public bool Eng
        {
            get { return _eng; }
            private set { _eng = value; }
        }
        private async void AddItem(TodoItem item)
        {
            await manager.SaveTaskAsync(item);
        }
        protected override void OnCreate()
        {
            base.BaseView.GetBlank();
            if (Eng)
            {
                Text =
                    "The reader will have to help our \n\r" +
                    "hero to begin the journey by choosing\n\r" +
                    "the object which will help\n\r" +
                    "him to determine the way to move.\n\r";
            }
            else
            {
                Text =
                "Чтобы начать путешествие, нужно выяснить,\n\r" +
                "в какую сторону двигаться.\n\r" +
                "Читателю придется помочь\n\r" +
                "нашему герою выбрать предмет,\n\r" +
                "с помощью которого он это определит.\n\r";
            }
            

            ImageFon = "ways.png";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "3";

            NavigationLeftButtonIsEnabled = "true";
            NavigationRightButtonIsEnabled = "false";


            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "nextNoACtive.png";

            FirstChoiceImage = "compas.png";
            SecondChoiceImage = "Tube.png";
            ThirdChoiceImage = "BottleMap.png";


        }

        protected override void BackScene()
        {
            NextView(new SecondSceneViewModel());
        }

        protected override void ThirdChoiceCommmandButton()
        {
            //base.ThirdChoiceCommmandButton();
            NextView(new FourthSceneViewModel());
        }
    }
}
