using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_OK(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2(_etUsername.Text));
        }
    }
}
