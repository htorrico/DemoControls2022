using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoControls
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dtpFecha.Date = DateTime.Today;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Titulo", "Mensaje", "Ok");
        }
    }
}
