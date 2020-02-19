using GalaSoft.MvvmLight.Command;
using MVVMSample.Models;
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
        public ItemMenu itemMenu { get; set; } = new ItemMenu();
        public ItemMenu itemMenu1 { get; set; } = new ItemMenu();
        public ItemMenu itemMenu2 { get; set; } = new ItemMenu();
        public ItemMenu itemMenu3 { get; set; } = new ItemMenu();
        public ItemMenu itemMenu4 { get; set; } = new ItemMenu();
        public ItemMenu itemMenu5 { get; set; } = new ItemMenu();

        public ICommand TapFrame { get; set; } 
        
        
        public FoodPageViewModel()
        {
            TapFrame = new Command(Tap);
            

            itemMenu.Image = "cheeseburger.png";
            itemMenu.Title = "Comida Rapida";
            itemMenu1.Image = "mercado.png";
            itemMenu1.Title = "Mercado";
            itemMenu2.Image = "Supermartketcar.png";
            itemMenu2.Title = "Supermercado";
            itemMenu3.Image = "corn.png";
            itemMenu3.Title = "Vegetales";
            itemMenu4.Image = "restaurant.png";
            itemMenu4.Title = "Restaurantes";
            itemMenu5.Image = "food.png";
            itemMenu5.Title = "Bebidas";
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
