using ImCup.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace ImCup {
    public partial class App : Application {
        public App() {
            InitializeComponent ();
            Current.MainPage = new MenuPage();
        }
    }
}
