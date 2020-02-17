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
    public partial class FoodPage : ContentPage
    {
        Frame frame = new Frame();
        public FoodPage()
        {
            InitializeComponent();           
        }

        private void TapFrame(object sender, EventArgs args)
        {
            frame.BackgroundColor = Color.White;

            var element = (Frame)sender;
            element.BackgroundColor = Color.LightYellow;

            frame = element;
        }
    }
}