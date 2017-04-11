using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ImCup.Annotations;
using ImCup.ViewModel.MenuPages;
using Xamarin.Forms;

namespace ImCup.ViewModel
{
    public class BaseMenuPageViewModel : INotifyPropertyChanged
    {
        public Action<BaseViewModel> ViewDream;
        //костыль на превью когнитивок, потом убрать
        public Action RecognitionPage;
        private string _imageSource;
        public event PropertyChangedEventHandler PropertyChanged;
        public BaseMenuPageViewModel()
        {
            ButtonShowCommand = new Command(OnButtonShowCommand);
        }

        protected virtual void OnButtonShowCommand()
        {
            
        }

        protected virtual void NextDream(BaseViewModel dreamViewModel)
        {
            ViewDream?.Invoke(dreamViewModel);
        }
        public string ImageSource
        {
            get { return _imageSource; }
            set
            {
                if (_imageSource != value)
                {
                    _imageSource = value;
                    OnPropertyChanged("ImageSource");
                }
            }
        }
        public ICommand ButtonShowCommand { get; set; }
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
