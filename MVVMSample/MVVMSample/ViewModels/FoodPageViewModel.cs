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
        public string cheesburguer { get; set; }
        public string mercado { get; set; }
        public string supermarket { get; set; }
        public string vegetales { get; set; }
        public string restaurante { get; set; }
        public string food { get; set; }
        
        public FoodPageViewModel()
        {
            TapFrame = new Command(Tap);
            cheesburguer = "cheeseburger.png";
            mercado = "mercado.png";
            supermarket = "Supermarketcar.png";
            vegetales = "corn.png";
            restaurante = "restaurant.png";
            food = "food.png";
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
