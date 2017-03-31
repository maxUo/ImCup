using Android.Media;
using ImCup.Interfaces;
using Xamarin.Forms;
using ImCup.Droid;

[assembly: Xamarin.Forms.Dependency (typeof (PlaySound))]
namespace ImCup.Droid {
    public class PlayImplementation : Java.Lang.Object, PlaySound, MediaPlayer.IOnInfoListener {

        MediaPlayer _player;
        private string _source;

        public PlayImplementation()
        {
        }

        public void Play(string source)
        {
            var ctx = Forms.Context;
            _source = source;
            
            if (_source != null)
            {
                _player = MediaPlayer.Create (ctx, Resource.Raw.BZZZZ);
                _player.Start ();
            }
        }

        public bool OnInfo(MediaPlayer mp, MediaInfo what, int extra)
        {
            return true;
        }
    }
}