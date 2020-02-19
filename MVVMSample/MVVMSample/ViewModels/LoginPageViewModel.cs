using GalaSoft.MvvmLight.Command;
using MVVMSample.Models;
using MVVMSample.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMSample.ViewModels
{
    public class LoginPageViewModel: INotifyPropertyChanged
    {
        public ItemMenu itemMenu { get; set; } = new ItemMenu();
        public ItemMenu facebook { get; set; } = new ItemMenu();
        public ItemMenu github { get; set; } = new ItemMenu();
        public ItemMenu twitter { get; set; } = new ItemMenu();
        public ItemMenu google { get; set; } = new ItemMenu();
        public Person Person { get; set; } = new Person();
        public event PropertyChangedEventHandler PropertyChanged;     
        public ICommand Loginbtn { get; set; }
        
        public ICommand Signupbtn { get; set; }
        

        public LoginPageViewModel()
        {

            Loginbtn = new Command(login);
            Signupbtn = new Command(SignUp);
            itemMenu.Image = "usermale.png";
            facebook.Image = "facebook.png";
            google.Image = "google.png";
            twitter.Image = "twitter.png";
            github.Image = "github.png";
            
        }
        //Event to button LogIn//
        private async void login()
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
