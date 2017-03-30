using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceMotion.Plugin;
using DeviceMotion.Plugin.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImCup.Scene1 {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage {
        public SecondPage()
        {
            InitializeComponent();
            CrossDeviceMotion.Current.Start(MotionSensorType.Accelerometer);

            CrossDeviceMotion.Current.SensorValueChanged += (s, a) =>
            {
                lbGyro.Text =
                    $"A: {((MotionVector) a.Value).X},{((MotionVector) a.Value).Y},{((MotionVector) a.Value).Z}";
            };

        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Scene1.ThredPage());
        }

        private void Button_On(object sender, EventArgs e)
        {
            
            //this.AnimationView.Play();
        }
    }
}
