using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImCup.Scene1 {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class FisrtPage : ContentPage {
        public FisrtPage() {
            
            InitializeComponent ();
            
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            
            await Navigation.PushModalAsync(new Scene1.SecondPage());
        }
    }
}
