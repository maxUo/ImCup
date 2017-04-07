using System;
using System.Collections.Generic;
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
        }

        private  void PlayLeftAnimation()
        {
            AnimationLeftView.Play();
        }

        public BaseViewModel BaseViewModel { get; set; }
        private void GetNextProperty(BaseViewModel viewModel)
        {
            //  _model.NewView();
            BaseViewModel = viewModel;
            BindingContext = viewModel;
        }
    }
}
