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

        public bool PlayMp3File(string fileName)
        {
            _mediaPlayer = MediaPlayer.Create (global::Android.App.Application.Context, Resource.Raw.BZZZZ);
            
            _mediaPlayer.Start ();
            return true;
        }

        public bool PlayWavFile(string fileName)
        {
            _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.Fon);
            _mediaPlayer.Start();

            return true;
        }
    }
}

