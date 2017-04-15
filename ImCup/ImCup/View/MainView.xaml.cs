using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ImCup.Model;
using ImCup.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics.Contracts;
using Microsoft.ProjectOxford.Emotion;
using Microsoft.ProjectOxford.Emotion.Contract;
using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;
using Plugin.Connectivity;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace ImCup.View {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        public MainView(BaseViewModel model) {
            InitializeComponent();
            this.BaseViewModel = model;
            this.BindingContext = model;
            model.NextView = GetNextProperty;
            model.PlayLeftAnimation = PlayLeftAnimation;
            model.GoLucher = GoLucher;
            model.GoBack = () => Navigation.PopModalAsync();
        }

        private async void GoLucher()
        {
            await Navigation.PushModalAsync(new LucherTest());
        }

        private  void PlayLeftAnimation()
        {
        }

        public BaseViewModel BaseViewModel { get; set; }
        private void GetNextProperty(BaseViewModel viewModel)
        {
            //  _model.NewView();
            try
            {
                this.BaseViewModel = viewModel;
                this.BindingContext = viewModel;
                viewModel.NextView = GetNextProperty;
                viewModel.PlayLeftAnimation = PlayLeftAnimation;
                viewModel.GoLucher = GoLucher;
                viewModel.GoBack = () => Navigation.PopModalAsync();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}
