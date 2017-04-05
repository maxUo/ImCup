using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImCup.Scene1 {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class ThredPage : ContentPage {
        public ThredPage() {
            InitializeComponent ();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FourPage());
        }
        private bool isNewPage = false;
        private async void ButtonBackClick(object sender, EventArgs e)
        {
            if(!isNewPage)
            await Navigation.PopModalAsync();
        }
    }
}
