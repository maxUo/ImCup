using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImCup.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LucherTest : ContentPage
    {
        TodoItemManager manager;
        private List<Tuple<DateTime, string>> _timeTuples;
        private Action addColor;
        public LucherTest()
        {
            InitializeComponent();
            _timeTuples = new List<Tuple<DateTime, string>>();
            addColor = CheckDich;
            var k = new Tuple<DateTime,string>(DateTime.Now,"LucherTest");
            _timeTuples.Add(k);
        }
        private async void CheckDich()
        {
            if (_timeTuples.Count == 9)
            {
                /*Сложная логика*/
                try
                {
                    manager = TodoItemManager.DefaultManager;
                    string str = "";
                    str = "SuperKid";
                    foreach (var timeTuple in _timeTuples)
                    {
                        str += ";" + timeTuple.Item2;
                    }
                    var todo = new TodoItem {Name = str};
                    AddItem(todo);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
                /*Сложная логика*/
                await Navigation.PopModalAsync();
            }
        }
        private async void AddItem(TodoItem item)
        {
            await manager.SaveTaskAsync(item);
        }
        private void ButtonBlue(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null) button.IsEnabled = false;
            blue.IsVisible = false;
            var k = new Tuple<DateTime, string>(DateTime.Now, "blue");
            _timeTuples.Add(k);
            addColor?.Invoke();
        }
        private void ButtonBlack(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null) button.IsEnabled = false;
            black.IsVisible = false;
            var k = new Tuple<DateTime, string>(DateTime.Now, "black");
            _timeTuples.Add(k);
            addColor?.Invoke();
        }
        private void ButtonKorich(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null) button.IsEnabled = false;
            korichn.IsVisible = false;
            var k = new Tuple<DateTime, string>(DateTime.Now, "korich");
            _timeTuples.Add(k);
            addColor?.Invoke();
        }
        private void ButtonRed(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null) button.IsEnabled = false;
            red.IsVisible = false;
            var k = new Tuple<DateTime, string>(DateTime.Now, "red");
            _timeTuples.Add(k);
            addColor?.Invoke();
        }
        private void ButtonGreen(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null) button.IsEnabled = false;
            green.IsVisible = false;
            var k = new Tuple<DateTime, string>(DateTime.Now, "green");
            _timeTuples.Add(k);
            addColor?.Invoke();
        }
        private void ButtonYellow(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null) button.IsEnabled = false;
            yellow.IsVisible = false;
            var k = new Tuple<DateTime, string>(DateTime.Now, "yellow");
            _timeTuples.Add(k);
            addColor?.Invoke();
        }
        private void ButtonGrey(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null) button.IsEnabled = false;
            grye.IsVisible = false;
            var k = new Tuple<DateTime, string>(DateTime.Now, "grey");
            _timeTuples.Add(k);
            addColor?.Invoke();
        }
        private void ButtonFiolet(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null) button.IsEnabled = false;
            fiolet.IsVisible = false;
            var k = new Tuple<DateTime, string>(DateTime.Now, "fiolet");
            _timeTuples.Add(k);
            addColor?.Invoke();
        }
    }
}
