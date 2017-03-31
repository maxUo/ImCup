using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceMotion.Plugin;
using DeviceMotion.Plugin.Abstractions;
using ImCup.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImCup.Scene1 {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class FourPage : ContentPage {
        private bool _isUsed = false;
        public FourPage() {
            InitializeComponent ();

            CrossDeviceMotion.Current.Start (MotionSensorType.Accelerometer);
            CrossDeviceMotion.Current.SensorValueChanged += ( s, e ) =>
            {
                if ( !_isUsed && (((MotionVector)e.Value).Z < 0 || ((MotionVector)e.Value).Z > 20) ) {
                    this.AnimationView.Play ();
                    //this.imgHelpa.Opacity = 0;
                }
            };
        }

        private async void ButtonBackClick(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
