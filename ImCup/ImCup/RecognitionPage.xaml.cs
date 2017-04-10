using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using Microsoft.ProjectOxford.Emotion;
using Microsoft.ProjectOxford.Emotion.Contract;
using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;
using Plugin.Connectivity;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System.Threading.Tasks;
using FFImageLoading.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImCup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecognitionPage : ContentPage
    {
        private readonly IFaceServiceClient _faceServiceClient;
        private readonly EmotionServiceClient _emotionServiceClient;

        public RecognitionPage()
        {
            InitializeComponent();

            // Обеспечивает доступ к Face API
            this._faceServiceClient =
                new FaceServiceClient("712fbe18e65847ffb9000e6ecc110a54");
            // Обеспечивает доступ к Emotion API
            this._emotionServiceClient =
                new EmotionServiceClient("3b0e48569c754d3b9ed0154fbd9e94dc");
        }

        private async void UploadPictureButton_Clicked(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("No upload",
                    "Picking a photo is not supported.", "OK");
                return;
            }

            var file = await CrossMedia.Current.PickPhotoAsync();
            if (file == null)
                return;

            this.Indicator1.IsVisible = true;
            this.Indicator1.IsRunning = true;

            Image1.Source = ImageSource.FromStream(() =>
                file.GetStream());

            FaceEmotionDetection theData =
                await DetectFaceAndEmotionsAsync(file);
            this.BindingContext = theData;

            this.Indicator1.IsRunning = false;
            this.Indicator1.IsVisible = false;
        }

        private async void TakePictureButton_Clicked(
            object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable ||
                !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera",
                    "No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                DefaultCamera = CameraDevice.Front,
                SaveToAlbum = true,
                Directory = "Sample",
                Name = "test.jpg"
            });


            if (file == null)
                return;

            this.Indicator1.IsVisible = true;
            this.Indicator1.IsRunning = true;

            Image1.Source = ImageSource.FromStream(() =>
                file.GetStream());

            FaceEmotionDetection theData = await DetectFaceAndEmotionsAsync(file);
            this.BindingContext = theData;

            this.Indicator1.IsRunning = false;
            this.Indicator1.IsVisible = false;

        }

        private async Task<FaceEmotionDetection>DetectFaceAndEmotionsAsync(MediaFile inputFile)
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

                await DisplayAlert("Error", ex.Message, "OK");
                return null;
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
