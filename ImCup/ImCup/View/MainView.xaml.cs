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

namespace ImCup.View {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class MainView
    {
        public MainView(BaseViewModel model) {
            InitializeComponent ();
            this.BaseViewModel = model;
            this.BindingContext = model;
            model.NextView = GetNextProperty;
            model.PlayLeftAnimation = PlayLeftAnimation;
            model.GoBack = () => Navigation.PopModalAsync();
        }

        private  void PlayLeftAnimation()
        {
            AnimationLeftView.Play();
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
                viewModel.GoBack = () => Navigation.PopModalAsync();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}
