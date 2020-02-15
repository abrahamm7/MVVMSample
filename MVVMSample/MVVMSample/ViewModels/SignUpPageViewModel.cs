using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace MVVMSample.ViewModels
{
    public class SignUpPageViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
        public string Password { get; set; }
        public string Repass { get; set; }
        public string Email { get; set; }

        public ICommand Signupbtn { get { return new RelayCommand(SignUp); } }

        private async void SignUp()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Repass) || string.IsNullOrEmpty(Email))
            {
                await App.Current.MainPage.DisplayAlert("Error","Empty Fields","ok");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Congrats", $"Welcome {Name}", "ok");
            }
        }
    }
}
