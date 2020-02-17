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
        public Person Person { get; set; } = new Person();
        public event PropertyChangedEventHandler PropertyChanged;     
        public ICommand Loginbtn { get { return new RelayCommand(LogIn); } }
        public ICommand Signupbtn { get { return new RelayCommand(SignUp); } }
        //Event to button LogIn//
        private async void LogIn() 
        {
            if (string.IsNullOrEmpty(Person.Name) || string.IsNullOrEmpty(Person.Pass))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Empty fields", "Ok");
            }
            else
            {                         
                await App.Current.MainPage.Navigation.PushAsync(new MainContentPage(Person));
            }
        }
        //Event to button SignUp//
        private async void SignUp()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }
    }
}
