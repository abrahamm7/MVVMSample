using GalaSoft.MvvmLight.Command;
using MVVMSample.Models;
using MVVMSample.Views;
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
        Person person;
        public event PropertyChangedEventHandler PropertyChanged;
        public string Username { get; set; }
        public string Password { get; set; }       
        public ICommand Loginbtn { get { return new RelayCommand(LogIn); } }
        public ICommand Signupbtn { get { return new RelayCommand(SignUp); } }
        //Event to button LogIn//
        private async void LogIn() 
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Empty fields", "Ok");
            }
            else
            {
                person = new Person();
                person.Name = Username;
                person.Pass = Password;                
                await App.Current.MainPage.Navigation.PushAsync(new MainContentPage(person));
            }
        }
        //Event to button SignUp//
        private async void SignUp()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }
    }
}
