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
	public partial class GuestHome : ContentPage
	{
		public GuestHome ()
		{
			InitializeComponent ();
		}

        //LICENCIATURA
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Guest.LicenciaturaPage());
        }

        //SAIDAS
        private async void SaidasButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SaidasPage());
        }

        //CONDIÇÕES
        private async void CondicoesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CondicoesPage());
        }
    }
}