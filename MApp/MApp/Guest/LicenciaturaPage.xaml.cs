using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MApp.Guest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LicenciaturaPage : ContentPage
	{
		public LicenciaturaPage ()
		{
			InitializeComponent ();
		}

        //PRIMEIRO ANO
        private async void PrimeiroButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrimeiroAnoPage());
        }

        //SEGUNDO ANO
        private async void SegundoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SegundoAnoPage());
        }

        //TERCEIRO ANO
        private async void TerceiroButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TerceiroAnoPage());
        }
    }
}