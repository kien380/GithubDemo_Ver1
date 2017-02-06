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
        private bool _IsButton3Green = false;
        private bool _IsButton4Blue = false;

        public Page4()
        {
            InitializeComponent();
            _button1.Clicked += (s, e) => Button_Clicked_Function3(s, e);
            _button2.Clicked += (s, e) => Button_Clicked_Function4(s, e);
        }

        private void Button_Clicked_Function1(object sender, EventArgs e)
        {
            // If _button3 is now Green
            if (_IsButton3Green)
            {
                // Change to Gray
                _button3.TextColor = Color.White;
                _button3.BackgroundColor = Color.Gray;
            }
            else
            {
                // Change to Green
                _button3.TextColor = Color.White;
                _button3.BackgroundColor = Color.Green;
            }

            _IsButton3Green = !_IsButton3Green;
        }

        private void Button_Clicked_Function3(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_Function2(object sender, EventArgs e)
        {
            // If _button4 is now Blue
            if (_IsButton4Blue)
            {
                // Change to Gray
                _button4.TextColor = Color.White;
                _button4.BackgroundColor = Color.Gray;
            }
            else
            {
                // Change to Blue
                _button4.TextColor = Color.White;
                _button4.BackgroundColor = Color.Blue;
            }

            _IsButton4Blue = !_IsButton4Blue;
        }

        private void Button_Clicked_Function4(object sender, EventArgs e)
        {

        }
    }
}
