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
        }   
        public BaseViewModel BaseViewModel { get; set; }
        private void GetNextProperty()
        {
          //  _model.NewView();
             BindingContext = BaseViewModel;
        }
    }
}
