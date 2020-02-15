using MVVMSample.Models;
using MVVMSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainContentPage : ContentPage
    {
        
        public MainContentPage(Person person)
        {
            InitializeComponent();
            this.BindingContext = new MainContentPageViewModel(person);
        }
    }
}