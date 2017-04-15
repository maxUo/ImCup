using Xamarin.Forms;
using Android.Media;
using ImCup.Interfaces;
using ImCup.Droid.Services;

[assembly: Dependency (typeof (AudioService))]

namespace ImCup.Droid.Services
{
    public class AudioService : IAudio
    {
        public AudioService()
        {
        }

        private MediaPlayer _mediaPlayer;

        public void PlayMp3File(string fileName)
        {
            int result;
            switch (fileName)
            {
                case "BZZZZZ.mp3": _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.BZZZZ);
                    break;
                case "Grandfather1.mp3": _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.Grandfather1);
                    break;
                case "Fon.mp3":
                    _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.Fon);
                    break;
            }
        
            //_mediaPlayer = MediaPlayer.Create (global::Android.App.Application.Context, Resource.Raw.BZZZZ);
            _mediaPlayer.Start ();
        }

        public void StopPlay()
        {
            _mediaPlayer?.Stop();
        }
    }
}

