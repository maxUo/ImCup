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
        public ThredSceneViewModel()
        {
            BaseView.GetBlank();
            ImageFon = "road1.png";
            PlaySlideAnim();

            manager = TodoItemManager.DefaultManager;

            var todo = new TodoItem { Name = "Ale"};
            AddItem(todo);
            //var client = new MobileServiceClient("http://imaginationcup.azurewebsites.net");


        }
        private async void AddItem(TodoItem item)
        {
            await manager.SaveTaskAsync(item);
        }
        protected override void OnCreate()
        {
            base.BaseView.GetBlank();

            Text = 
                "Чтобы начать путешествие, нужно выяснить,\n\r" +
                "в какую сторону двигаться.\n\r" +
                "Читателю придется помочь\n\r" +
                "нашему герою выбрать предмет,\n\r" +
                "с помощью которого он это определит\n\r";

            ImageFon = "ways.png";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "2";

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
