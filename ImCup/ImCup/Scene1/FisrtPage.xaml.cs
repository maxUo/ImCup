using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFImageLoading.Svg.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImCup.Scene1 {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class FisrtPage : ContentPage {
        public FisrtPage() {
            
            InitializeComponent ();
        }
        private bool isNewPage = false;
        private async void Button_OnClicked(object sender, EventArgs e)
        {
            
            await Navigation.PushModalAsync(new Scene1.SecondPage());
        }

        private async void ButtonBackClick(object sender, EventArgs e)
        {
            if(! isNewPage )
            await Navigation.PopModalAsync();
        }
    }
}
