using MVVMSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MVVMSample.ViewModels
{
    public class MainContentPageViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Title { get; set; }
        public string Username { get; set; }      
        //Constructor//
        public MainContentPageViewModel(Person people)
        {
            Title = $"Bienvenido {people.Name}";
        }

    }
}
