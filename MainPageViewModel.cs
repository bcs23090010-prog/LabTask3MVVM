using LabTask3MVVM.Models;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace LabTask3MVVM.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        private Dog? _currentDog;
        public Dog? CurrentDog
        {
            get => _currentDog;
            set => SetProperty(ref _currentDog, value);
        }

        private Owner? _currentOwner;
        public Owner? CurrentOwner
        {
            get => _currentOwner;
            set => SetProperty(ref _currentOwner, value);
        }

        public string StudentInfo => "Wong Sing Yaw | BCS23090010";

        public ICommand LikeCommand { get; }
        public ICommand AdoptCommand { get; }

        public MainPageViewModel()
        {
            CurrentDog = new Dog
            {
                Name = "Urh?",
                GenderImage = "symbolmale.png",
                Type = "Dog",
                Age = "1 year old",
                Location = "3B, Lorong 88, Taman Rantau Panjang, 96000 Sibu, Sarawak",
                ImageSource = "image7.png",
                Description = "Hi! Urh? ah? Your name’s Urh? Bro, that sounds like a loading screen noise"
            };

            CurrentOwner = new Owner
            {
                Name = "Ali bin Abubaka",
                Role = "Owner",
                ProfileImage = "image6.jpg",
                DatePosted = "1.11.2024"
            };

            LikeCommand = new Command(() => {
                Application.Current?.MainPage?.DisplayAlert("Action", "Liked!", "OK");
            });
            AdoptCommand = new Command(() => {
                Application.Current?.MainPage?.DisplayAlert("Action", "Adoption button clicked!", "OK");
            });
        }
    }
}