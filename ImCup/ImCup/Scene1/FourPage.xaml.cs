using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceMotion.Plugin;
using DeviceMotion.Plugin.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImCup.Scene1 {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class FourPage : ContentPage {
        public FourPage() {
            InitializeComponent ();

            CrossDeviceMotion.Current.Start (MotionSensorType.Accelerometer);

            CrossDeviceMotion.Current.SensorValueChanged += Current_SensorValueChanged;
        }

        private void Current_SensorValueChanged( object sender, SensorValueChangedEventArgs e )
        {
            var t = e.SensorType;
            if (t == MotionSensorType.Accelerometer && ((MotionVector)e.Value).Z<0 || ((MotionVector)e.Value).Z>20)
            {
                this.AnimationView.Play ();
            }
        }
    }
}
