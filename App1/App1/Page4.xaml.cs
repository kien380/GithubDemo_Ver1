using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_Function3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private void Button_Clicked_Function4(object sender, EventArgs e)
        {
            _button3.BackgroundColor = Color.Black;
            _button3.TextColor = Color.White;
        }
    }
}
