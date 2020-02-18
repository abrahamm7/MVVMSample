using GalaSoft.MvvmLight.Command;
using MVVMSample.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMSample.ViewModels
{
    public class FoodPageViewModel: INotifyPropertyChanged
    {
        Frame frame = new Frame();
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand TapFrame { get; set; } 

        public FoodPageViewModel()
        {
            TapFrame = new Command(Tap);  
        }

        private void Tap(object sender)
        {
            frame.BackgroundColor = Color.White;

            var element = sender as Frame;
            element.BackgroundColor = Color.LightYellow;

            frame = element;
        }


    }
}
