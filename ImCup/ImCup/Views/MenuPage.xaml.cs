using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImCup.Models;
using ImCup.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImCup.Views {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        //private ObservableCollection<ViewDataObject> _lViewModel;
        public MenuPage() {
            InitializeComponent ();

            LViewModel = new ObservableCollection<ViewDataObject>()
            {
                new ViewDataObject() {Text = "Сказки", ImageSource = "chestIcon.png"},
                new ViewDataObject() {Text = "", ImageSource = "iconV.png"},
                new ViewDataObject() {Text = "", ImageSource = "iconV.png"}
            };

            BindingContext = this;
        }

        /*private ObservableCollection<ViewDataObject> GetContent()
        {
            var k = new ObservableCollection<ViewDataObject>()
            {
                new ViewDataObject() {Text = "Сказки", ImageSource = "chestIcon.png"},
                new ViewDataObject() {Text = "Справка", ImageSource = "iconV.png"}
            };
            return k;
        }         */

        public ObservableCollection<ViewDataObject> LViewModel { get; set; }

        private async void Button_OnClicked( object sender, EventArgs e ) {
            await Navigation.PushModalAsync(new Scene1.FisrtPage());
        }
    }
}
