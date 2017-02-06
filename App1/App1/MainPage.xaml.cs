using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnPage3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }

        private async void BtnPage4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }

        private async void Button_Clicked_Page1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }


        private async void Button_Clicked_Page2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}
