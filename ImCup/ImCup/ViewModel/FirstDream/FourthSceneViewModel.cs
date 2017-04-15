using System.Threading.Tasks;
using ImCup.Interfaces;
using Xamarin.Forms;

namespace ImCup.ViewModel.FirstDream
{
    public class FourthSceneViewModel : BaseViewModel
    {
        private bool _eng;
        public FourthSceneViewModel()
        {
            Eng = true;
            BaseView.GetBlank();
            ImageFon = "ways.png";
            PlaySlideAnim();
        }

        public bool Eng
        {
            get { return _eng; }
            private set { _eng = value; }
        }

        protected override void OnCreate()
        {
            BaseView.GetBlank();
            if (Eng)
            {
                Text =
                "His path took him by a big apple tree.\n\r" +
                "The treasure hunter was walking all day\n\r" +
                "day long and was hungry so he decided\n\r" +
                "to pick up some apples.\n\r" +
                "Unfortunately the fruits grew too high and\n\r" +
                "Pondo had to shake the tree.\n\r";
            }
            else
            {
                Text =
                "Путь его лежал мимо большой яблони\n\r" +
                "Искатель сокровищ шел целый день и проголодался,\n\r" +
                "так что он решил набрать немного яблок.\n\r" +
                "Однако плоды росли слишком высоко!\n\r" +
                "Придется трясти дерево!\n\r";
            }

            ImageFon = "tree.png";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "3";
            /*
            AnimationLeft = "bee.json";
            AnimationLeftAutoPlay = false;
            AnimationLeftLoop = false;
            */
            NavigationLeftButtonIsEnabled = "true";
            NavigationRightButtonIsEnabled = "false";

            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "acelerometre.png";
        }

        protected override async void AcelerometrMove()
        {
            if (Eng)
            {
                Text =
                    "That was a mistake.\n\r" +
                    "Pondo disturbed the bees\n\r" +
                    "which lived in a hive on the tree!\n\r" +
                    "He had to run away\n\r" +
                    "before being stung!\n\r";
            }
            else
            {
                Text = "Это было ошибкой:\n\r" +
                       "Пондо растревожил пчел,\n\r" +
                       "живших в улье на яблоне!\n\r" +
                       "Надо было уносить ноги,\n\r" +
                       "пока не покусали!";
            }


            NavigationImageRight = "nextActive.png";
            NavigationRightButtonIsEnabled = "true";
            /*AnimationRight = "bee.json";
            AnimationRightLoop = false;
            AnimationRightAutoPlay = true;
            AnimationRightGridColumnSpan = "2";
            AnimationRightGridRowSpan = "3";
            AnimationRightIsVisible = true;*/

            AnimationLeft = "bee.json";
            AnimationLeftLoop = false;
            AnimationLeftAutoPlay = true;
            AnimationLeftColumnSpan = "4";
            AnimationLeftIsVisible = true;
            AnimationLeftRowSpan = "2";

            DependencyService.Get<IAudio>().PlayMp3File("BZZZZZ.mp3");
            await Task.Delay(1500);

            BaseView.GetBlank();

        }

        protected override void NextScene()
        {
            //await CleanAnimationForm();
            DependencyService.Get<IAudio>().StopPlay();
            NextView(new FourthOneSceneViewModel());
        }

        protected override void BackScene()
        {
            DependencyService.Get<IAudio>().StopPlay();
            NextView(new ThredSceneViewModel());
        }
    }
}
