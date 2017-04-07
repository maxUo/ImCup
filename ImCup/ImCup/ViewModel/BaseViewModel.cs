using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DeviceMotion.Plugin;
using DeviceMotion.Plugin.Abstractions;
using ImCup.Annotations;
using ImCup.Model;
using Xamarin.Forms;

namespace ImCup.ViewModel {
    public class BaseViewModel: INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        public Action<BaseViewModel> NextView;
        public Action GoBack;
        public Action PlayLeftAnimation;

        public BaseViewModel()
        {
            BaseView = new BaseView();
            NextSceneCommand = new Command(NextScene);
            BackSceneCommand = new Command(BackScene);
            CrossDeviceMotion.Current.Start (MotionSensorType.Accelerometer);
            CrossDeviceMotion.Current.SensorValueChanged += Current_SensorValueChanged;
        }
        protected virtual void Current_SensorValueChanged( object sender, SensorValueChangedEventArgs e ) {
            
        }

        protected async void PlaySlideAnim()
        {
            BaseView.GetBlank();

            ImageFon = ImageFon;
            ImageFonGridColumnSpan = "4";
            ImageFonGridRowSpan = "2";

            Text = "Идет загрузка...";

            AnimationLeft = "loading_semicircle.json";
            AnimationLeftLoop = false;
            AnimationLeftAutoPlay = true;

            AnimationLeftColumnSpan = "4";
            AnimationLeftRowSpan = "2";

            NavigationImageLeft = "backActive.png";
            NavigationImageRight = "nextActive.png";

            await Task.Delay(1500);
            OnCreate();
        }

        protected virtual void OnCreate()
        {
            
        }
        public BaseView BaseView { get; set; }
        public ICommand NextSceneCommand { set; get; }
        public ICommand BackSceneCommand { set; get; }

        #region Обвязка на поля базовой модели
        public bool AnimationLeftAutoPlay
        {
            get { return BaseView.AnimationLeftAutoPlay; }
            set
            {
                if (BaseView.AnimationLeftAutoPlay != value)
                {
                    BaseView.AnimationLeftAutoPlay = value;
                    OnPropertyChanged("AnimationLeftAutoPlay");
                }
            }
        }
        public bool AnimationLeftLoop
        {
            get { return BaseView.AnimationLeftLoop; }
            set
            {
                if (BaseView.AnimationLeftLoop != value)
                {
                    BaseView.AnimationLeftLoop = value;
                    OnPropertyChanged("AnimationLeftLoop");
                }
            }
        }
        public bool AnimationRightAutoPlay
        {
            get { return BaseView.AnimationRightAutoPlay; }
            set
            {
                if (BaseView.AnimationRightAutoPlay != value)
                {
                    BaseView.AnimationRightAutoPlay = value;
                    OnPropertyChanged("AnimationRightAutoPlay");
                }
            }
        }
        public bool AnimationRightLoop
        {
            get { return BaseView.AnimationRightLoop; }
            set
            {
                if (BaseView.AnimationRightLoop != value)
                {
                    BaseView.AnimationRightLoop = value;
                    OnPropertyChanged("AnimationRightLoop");
                }
            }
        }
        public string ImageFon
        {
            get { return BaseView.ImageFon; }
            set {
                if ( BaseView.ImageFon != value ) {
                    BaseView.ImageFon = value;
                    OnPropertyChanged ("ImageFon");
                }
            }
        }
        public string ImageLeft {
            get { return BaseView.ImageLeft; }
            set
            {
                if ( BaseView.ImageLeft != value ) {
                    BaseView.ImageLeft = value;
                    OnPropertyChanged ("ImageLeft");
                }
            }
        }
        public string ImageRight {
            get { return BaseView.ImageRight; }
            set
            {
                if ( BaseView.ImageRight != value ) {
                    BaseView.ImageRight = value;
                    OnPropertyChanged ("ImageRight");
                }
            }
        }
        public string ImageFonGridRowSpan {
            get { return BaseView.ImageFonGridRowSpan; }
            set
            {
                if ( BaseView.ImageFonGridRowSpan != value ) {
                    BaseView.ImageFonGridRowSpan = value;
                    OnPropertyChanged ("ImageFonGridRowSpan");
                }
            }
        }
        public string ImageFonGridColumnSpan {
            get { return BaseView.ImageFonGridColumnSpan; }
            set
            {
                if ( BaseView.ImageFonGridColumnSpan != value ) {
                    BaseView.ImageFonGridColumnSpan = value;
                    OnPropertyChanged ("ImageFonGridColumnSpan");
                }
            }
        }
        public string ImageLeftGridRowSpan {
            get { return BaseView.ImageLeftGridRowSpan; }
            set
            {
                if ( BaseView.ImageLeftGridRowSpan != value ) {
                    BaseView.ImageLeftGridRowSpan = value;
                    OnPropertyChanged ("ImageLeftGridRowSpan");
                }
            }
        }
        public string ImageLeftGridColumnSpan {
            get { return BaseView.ImageLeftGridColumnSpan; }
            set
            {
                if ( BaseView.ImageLeftGridColumnSpan != value ) {
                    BaseView.ImageLeftGridColumnSpan = value;
                    OnPropertyChanged ("ImageLeftGridColumnSpan");
                }
            }
        }
        public string ImageRightGridRowSpan {
            get { return BaseView.ImageRightGridRowSpan; }
            set
            {
                if ( BaseView.ImageRightGridRowSpan != value ) {
                    BaseView.ImageRightGridRowSpan = value;
                    OnPropertyChanged ("ImageRightGridRowSpan");
                }
            }
        }
        public string ImageRightGridColumnSpan {
            get { return BaseView.ImageRightGridColumnSpan; }
            set
            {
                if ( BaseView.ImageRightGridColumnSpan != value ) {
                    BaseView.ImageRightGridColumnSpan = value;
                    OnPropertyChanged ("ImageRightGridColumnSpan");
                }
            }
        }
        public string AnimationLeft {
            get { return BaseView.AnimationLeft; }
            set
            {
                if ( BaseView.AnimationLeft != value ) {
                    BaseView.AnimationLeft = value;
                    OnPropertyChanged ("AnimationLeft");
                }
            }
        }
        public string AnimationRight {
            get { return BaseView.AnimationRight; }
            set
            {
                if ( BaseView.AnimationRight != value ) {
                    BaseView.AnimationRight = value;
                    OnPropertyChanged ("AnimationRight");
                }
            }
        }
        public string AnimationLeftRowSpan {
            get { return BaseView.AnimationLeftRowSpan; }
            set
            {
                if ( BaseView.AnimationLeftRowSpan != value ) {
                    BaseView.AnimationLeftRowSpan = value;
                    OnPropertyChanged ("AnimationLeftRowSpan");
                }
            }
        }
        public string AnimationLeftColumnSpan {
            get { return BaseView.AnimationLeftColumnSpan; }
            set
            {
                if ( BaseView.AnimationLeftColumnSpan != value ) {
                    BaseView.AnimationLeftColumnSpan = value;
                    OnPropertyChanged ("AnimationLeftColumnSpan");
                }
            }
        }
        public string AnimationRightGridRowSpan {
            get { return BaseView.AnimationRightGridRowSpan; }
            set
            {
                if ( BaseView.AnimationRightGridRowSpan != value ) {
                    BaseView.AnimationRightGridRowSpan = value;
                    OnPropertyChanged ("AnimationRightGridRowSpan");
                }
            }
        }
        public string AnimationRightGridColumnSpan {
            get { return BaseView.AnimationRightGridColumnSpan; }
            set
            {
                if ( BaseView.AnimationRightGridColumnSpan != value ) {
                    BaseView.AnimationRightGridColumnSpan = value;
                    OnPropertyChanged ("AnimationRightGridColumnSpan");
                }
            }
        }
        public string Text {
            get { return BaseView.Text; }
            set
            {
                if ( BaseView.Text != value ) {
                    BaseView.Text = value;
                    OnPropertyChanged ("Text");
                }
            }
        }
        public string NavigationImageLeft {
            get { return BaseView.NavigationImageLeft; }
            set
            {
                if ( BaseView.NavigationImageLeft != value ) {
                    BaseView.NavigationImageLeft = value;
                    OnPropertyChanged ("NavigationImageLeft");
                }
            }
        }
        public string NavigationImageRight {
            get { return BaseView.NavigationImageRight; }
            set
            {
                if ( BaseView.NavigationImageRight != value ) {
                    BaseView.NavigationImageRight = value;
                    OnPropertyChanged ("NavigationImageRight");
                }
            }
        }
        public string NavigationLeftButtonIsEnabled {
            get { return BaseView.NavigationLeftButtonIsEnabled; }
            set
            {
                if ( BaseView.NavigationLeftButtonIsEnabled != value ) {
                    BaseView.NavigationLeftButtonIsEnabled = value;
                    OnPropertyChanged ("NavigationLeftButtonIsEnabled");
                }
            }
        }
        public string NavigationRightButtonIsEnabled {
            get { return BaseView.NavigationRightButtonIsEnabled; }
            set
            {
                if ( BaseView.NavigationRightButtonIsEnabled != value ) {
                    BaseView.NavigationRightButtonIsEnabled = value;
                    OnPropertyChanged ("NavigationRightButtonIsEnabled");
                }
            }
        }
        #endregion

        protected virtual void NextScene()
        {

        }
        protected virtual  void BackScene()
        {
            
        }
        protected void ExitMove()
        {
            GoBack?.Invoke();
        }

        protected virtual void AcelerometrMove()
        {
            
        }
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
