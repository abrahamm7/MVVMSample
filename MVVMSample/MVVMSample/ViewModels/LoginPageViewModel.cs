using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMSample.ViewModels
{
    public class LoginPageViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Username { get; set; }
        public string Password { get; set; }       
        public ICommand Loginbtn { get { return new RelayCommand(LogIn); } }
        //Event to button LogIn//
        private async void LogIn() 
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Message", "The field Username is empty", "Ok");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Message", $"Welcome {Username}", "Ok");
            }
        }
    }
}
