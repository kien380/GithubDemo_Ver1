using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        public Page2(string strName)
        {
            InitializeComponent();

            lblName.Text = "Hello " + strName;
        }

        private async void BtnSignOut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
