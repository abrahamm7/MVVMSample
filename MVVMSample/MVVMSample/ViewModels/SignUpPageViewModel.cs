using GalaSoft.MvvmLight.Command;
using MVVMSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMSample.ViewModels
{
    public class SignUpPageViewModel: INotifyPropertyChanged
    {
        public Person Person { get; set; } = new Person();
        public ItemMenu ItemMenu { get; set; } = new ItemMenu();
        public event PropertyChangedEventHandler PropertyChanged;  

        public ICommand Signupbtn { get; set; }

        public SignUpPageViewModel()
        {
            Signupbtn = new Command(SignUp);
            ItemMenu.Image = "camera.png";
        }
        //Event to Sign Up button//
        private async void SignUp()
        {
            if (string.IsNullOrEmpty(Person.Name) || string.IsNullOrEmpty(Person.Pass) || string.IsNullOrEmpty(Person.Repass) || string.IsNullOrEmpty(Person.Email))
            {
                await App.Current.MainPage.DisplayAlert("Error","Empty fields","ok");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Congrats", $"Welcome {Person.Name}", "ok");
            }
        }
    }
}
