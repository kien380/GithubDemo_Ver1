using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_Page4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
    }
}
