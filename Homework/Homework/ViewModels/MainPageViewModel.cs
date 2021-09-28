using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Homework.Views;
using Xamarin.Forms;

namespace Homework.ViewModels
{
    public class MainPageViewModel : NavigationPage
    {

        public MainPageViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
            ForwardButton = new Command(OnForwardAsync);
        }

        public ICommand ForwardButton { get; }
        public ICommand IncreaseCount { get; }


        int count = 0;
        string countDisplay = "Click me!";
        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay)
                    return;

                countDisplay = value;
                OnPropertyChanged();

            }
        }

        void OnIncrease()
        {
            count++;
            CountDisplay = $"You clicked {count} time(s)";
        }

        private async void OnForwardAsync()
        {
            await Navigation.PushAsync(new SecondPage());
        }



    }
}
