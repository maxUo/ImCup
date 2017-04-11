using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImCup.Interfaces;
using ImCup.Model;
using ImCup.View;
using ImCup.ViewModel;
using ImCup.ViewModel.FirstDream;
using ImCup.ViewModel.MenuPages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImCup.Views {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        //private ObservableCollection<ViewDataObject> _lViewModel;
        private ObservableCollection<BaseMenuPageViewModel> _viewModels;
        public MenuPage() {
            InitializeComponent ();
            ViewModels = new ObservableCollection<BaseMenuPageViewModel>();

            ViewModels.Add(new FirstDreamViewModel());
            ViewModels[0].ViewDream = ShowDream;
            ViewModels.Add(new RecognitionPageViewModel());
            ViewModels[1].RecognitionPage = ShowRecognition;

           // DependencyService.Get<IAudio>().PlayWavFile("a");
            BindingContext = this;
        }

        public ObservableCollection<BaseMenuPageViewModel> ViewModels
        {
            get { return _viewModels; }
            set
            {
                if (value != null && _viewModels != value)
                {
                    _viewModels = value;
                }
            }
        }

        private async void ShowRecognition()
        {
            await Navigation.PushModalAsync(new RecognitionPage());
        }
        private async void ShowDream(BaseViewModel viewModel)
        {
            await Navigation.PushModalAsync(new MainView (viewModel));
        }
    }
}
