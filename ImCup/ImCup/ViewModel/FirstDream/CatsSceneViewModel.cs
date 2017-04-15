using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ProjectOxford.Emotion;
using Microsoft.ProjectOxford.Emotion.Contract;
using Microsoft.ProjectOxford.Face;
using Xamarin.Forms;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;

namespace ImCup.ViewModel.FirstDream
{
   public class CatsSceneViewModel : BaseViewModel
    {
        private bool dich;
        private TodoItemManager manager;
        private readonly IFaceServiceClient _faceServiceClient;
        private readonly EmotionServiceClient _emotionServiceClient;
        public CatsSceneViewModel()
        {
            dich = false;
            base.BaseView.GetBlank();
            this._faceServiceClient =
                new FaceServiceClient("712fbe18e65847ffb9000e6ecc110a54");
            // Обеспечивает доступ к Emotion API
            this._emotionServiceClient =
                new EmotionServiceClient("3b0e48569c754d3b9ed0154fbd9e94dc");
            ImageFon = "ways.png";
            PlaySlideAnim();
        }
        private async void TakePictureButton()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable ||
              !CrossMedia.Current.IsTakePhotoSupported)
            {
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(
                new StoreCameraMediaOptions
                {
                    SaveToAlbum = true,
                    Name = "test.jpg"
                });

            if (file == null)
                return;
            FaceEmotionDetection theData = await DetectFaceAndEmotionsAsync(file);
            try
            {
                manager = TodoItemManager.DefaultManager;
                string str = "";
                str = "SuperKid;EmotionApi;";
                str +=
                    theData.Emotion + ";" +
                    theData.Age + ";" +
                    theData.Smile;
                var todo = new TodoItem { Name = str };
                AddItem(todo);
            }
            catch (Exception d)
            {
                Debug.WriteLine("Tyt Trabli! " + d);
            }
        }
        private async Task<FaceEmotionDetection> DetectFaceAndEmotionsAsync(MediaFile inputFile)
        {
            try
            {
                // Получаем эмоции из указанного потока данных
                Emotion[] emotionResult = await _emotionServiceClient.
                    RecognizeAsync(inputFile.GetStream());

                // Предполагая, что на снимке только одно лицо, получаем
                // эмоции для первого элемента в возвращаемом массиве
                var faceEmotion = emotionResult[0]?.Scores.ToRankedList();

                // Создаем список атрибутов лица, которые
                // понадобится получать приложению
                var requiredFaceAttributes = new FaceAttributeType[]
                {
                    FaceAttributeType.Age,
                    FaceAttributeType.Gender,
                    FaceAttributeType.Smile,
                    FaceAttributeType.FacialHair,
                    FaceAttributeType.HeadPose,
                    FaceAttributeType.Glasses
                };
                // Получаем список лиц на снимке
                var faces = await _faceServiceClient.DetectAsync(
                    inputFile.GetStream(), false, false, requiredFaceAttributes);

                // Предполагая, что на снимке только одно лицо,
                // сохраняем его атрибуты
                var faceAttributes = faces[0]?.FaceAttributes;
                FaceEmotionDetection faceEmotionDetection =
                    new FaceEmotionDetection();
                faceEmotionDetection.Age = faceAttributes.Age;
                faceEmotionDetection.Emotion =
                    faceEmotion.FirstOrDefault().Key;
                faceEmotionDetection.Glasses =
                    faceAttributes.Glasses.ToString();
                faceEmotionDetection.Smile = faceAttributes.Smile;
                faceEmotionDetection.Gender = faceAttributes.Gender;
                faceEmotionDetection.Moustache =
                    faceAttributes.FacialHair.Moustache;
                faceEmotionDetection.Beard = faceAttributes.FacialHair.Beard;
                return faceEmotionDetection;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }
        private async Task TakePicture()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable ||
                !CrossMedia.Current.IsTakePhotoSupported)
            {
                Debug.WriteLine("Dich! Razberice");
                return;
            }
            var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);
            if (status == PermissionStatus.Granted)
            {
                //Permission was granted

                var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    SaveToAlbum = true,
                    PhotoSize = PhotoSize.Custom,
                    CustomPhotoSize = 80 //Resize to 90% of original
                });
                if (file == null)
                    return;

                //Image1.Source = ImageSource.FromStream(() =>file.GetStream());

                FaceEmotionDetection theData = await DetectFaceAndEmotionsAsync(file);
                try
                {
                    manager = TodoItemManager.DefaultManager;
                    string str = "";
                    str = "SuperKid;EmotionApi;";
                    str +=
                        theData.Emotion + ";" +
                        theData.Age + ";" +
                        theData.Smile;
                    var todo = new TodoItem {Name = str};
                    AddItem(todo);
                }
                catch (Exception d)
                {
                    Debug.WriteLine("Tyt Trabli! " + d);
                }
            }
        }
        private async void AddItem(TodoItem item)
        {
            await manager.SaveTaskAsync(item);
        }
       
        protected override void OnCreate()
        {
            base.BaseView.GetBlank();
            Text = "Let’s try to scare the pirates." +
                   "Show them the most horrible" +
                   "expression on your face!";

            ImageFon = "catsBG.png";
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "3";

            ImageLeft = "catGOOD.png";
            ImageLeftGridRowSpan = "2";
            ImageLeftGridColumnSpan = "4";

            NavigationLeftButtonIsEnabled = "true";
            NavigationRightButtonIsEnabled = "false";

            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "tap.png";

        }
        
        protected override void SecondChoiceCommmandButton()
        {
            NavigationImageRight = "emotion.png";
            ImageLeft = "catBAD.png";
            NavigationRightButtonIsEnabled = "true";
            
        }
        protected override async void NextScene()
        {
            if (!dich)
            {
                TakePictureButton();
                Text = "Cats got scared" +
                   "seeing such a formidable" +
                   "opponent. Pondo was not" +
                   "in danger and he could" +
                   "continue his journey.";
                NavigationImageRight = "nextActive.png";
                ImageLeft = "catSCARED.png";
                dich = !dich;
            }
            else
            {
                NextView(new ThredSceneViewModel());
            }
        }
    }
    public class FaceEmotionDetection
    {
        public string Emotion { get; set; }
        public double Smile { get; set; }
        public string Glasses { get; set; }
        public string Gender { get; set; }
        public double Age { get; set; }
        public double Beard { get; set; }
        public double Moustache { get; set; }
    }
}
