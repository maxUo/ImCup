﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImCup.Model {
    public class BaseView {
        public void GetBlank()
        {
            Text = "";

            ImageFon = "";
            ImageFonGridColumnSpan = "1";
            ImageFonGridRowSpan = "1";

            AnimationLeft = "progress_bar.json";
            AnimationLeftColumnSpan = "1";
            AnimationLeftRowSpan = "1";
            AnimationLeftAutoPlay = true;
            AnimationLeftLoop = false;
            AnimationLeftIsVisible = false;


            AnimationRight = "progress_bar.json";
            AnimationRightLoop = false;
            AnimationRightAutoPlay = true;
            AnimationRightGridColumnSpan = "1";
            AnimationRightGridRowSpan = "1";
            AnimationRightIsVisible = false;

            ImageLeft = "";
            ImageLeftGridColumnSpan = "1";
            ImageLeftGridRowSpan = "1";

            ImageRight = "";
            ImageRightGridRowSpan = "1";
            ImageRightGridColumnSpan = "1";

            NavigationImageLeft = "";
            NavigationImageRight = "";
            NavigationLeftButtonIsEnabled = "false";
            NavigationRightButtonIsEnabled = "false";

            FirstChoiceImage = "";
            SecondChoiceImage = "";
            ThirdChoiceImage = "";
        }
        //Сурсы к картинкам
        public string ImageFon { get; set; }
        public string ImageLeft { get; set; }
        public string ImageRight { get; set; }
        //Расположение картинок
        public string ImageFonGridRowSpan { get; set; }
        public string ImageFonGridColumnSpan { get; set; }

        public string ImageLeftGridRowSpan { get; set; }
        public string ImageLeftGridColumnSpan { get; set; }

        public string ImageRightGridRowSpan { get; set; }
        public string ImageRightGridColumnSpan { get; set; }
        //Смещение картинок

        //Сурсы к анимациям
        public string AnimationLeft { get; set; }
        public string AnimationRight { get; set; }
        //Расположение анимаций 
        public string AnimationLeftRowSpan { get; set; }
        public string AnimationLeftColumnSpan { get; set; }

        public bool AnimationLeftIsVisible { get; set; }
        public bool AnimationRightIsVisible { get; set; }
        public string AnimationRightGridRowSpan { get; set; }
        public string AnimationRightGridColumnSpan { get; set; }

        //Проигрывание Анимации
        public bool AnimationLeftAutoPlay { get; set; }
        public bool AnimationLeftLoop { get; set; }
        public bool AnimationRightAutoPlay { get; set; }
        public bool AnimationRightLoop { get; set; }
        //Смещение картинок

        //Текст на панели снизу
        public string Text { get; set; }

        //Сурсы к Навигационным клавишам
        public string NavigationImageLeft { get; set; }
        public string NavigationImageRight { get; set; }
        //Доступность кнопок навигации
        public string NavigationLeftButtonIsEnabled { get; set; }
        public string NavigationRightButtonIsEnabled { get; set; }
        //Навигация
        public string FirstChoiceImage { get; set; }
        public string SecondChoiceImage { get; set; }
        public string ThirdChoiceImage { get; set; }
    }
}
