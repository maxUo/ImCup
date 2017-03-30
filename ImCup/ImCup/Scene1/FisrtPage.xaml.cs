using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImCup.Scene1 {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class FisrtPage : ContentPage
    {
        private List<DataSource> dataSource;
        public FisrtPage() {
            
            InitializeComponent ();
            dataSource = new List<DataSource>()
            {
                new DataSource() { ViewForPresent = new FirstView()}
            };
            lw.ItemsSource = dataSource;

        }

        private void StartAnimation_OnClicked(object sender, EventArgs e)
        {

        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            
            //await Navigation.PushModalAsync(new Scene1.SecondPage());
        }
    }

    public class DataSource
    {
        public View ViewForPresent { get; set; }
    }
}
