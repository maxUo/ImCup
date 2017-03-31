using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImCup.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImCup.Views {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        //private ObservableCollection<ViewDataObject> _lViewModel;
        public MenuPage() {
            InitializeComponent ();

            LViewModel = new ObservableCollection<ViewDataObject> ()
            {
                new ViewDataObject() {Text = "Сказки", ImageSource = "iconChessBorder.png"},
                new ViewDataObject() {Text = "", ImageSource = "iconV.png"},
                new ViewDataObject() {Text = "", ImageSource = "iconV.png"}
            };
            DependencyService.Get<IAudio>().PlayWavFile("a");
            BindingContext = this;
        }

        public ObservableCollection<ViewDataObject> LViewModel { get; set; }

        private async void Button_OnClicked( object sender, EventArgs e ) {
            await Navigation.PushModalAsync(new Scene1.FisrtPage());
        }
    }

    public class ViewDataObject
    {
        public string ImageSource { get; set; }
        public string Text { get; set; }
    }
}
