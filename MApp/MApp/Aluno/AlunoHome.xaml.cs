using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MApp.Aluno
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlunoHome : ContentPage
	{
		public AlunoHome ()
		{
			InitializeComponent ();
		}

        //DISCIPLINAS
        private async void DisciplinasButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisciplinasPage());
        }

        //AVISOS
        private async void AvisosButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AvisosPage());
        }

        //ESTÁGIOS
        private async void EstagiosButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EstagiosPage());
        }

        //PERFIL
        private async void PerfilButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PerfilPage());
        }

        //LOGOUT
        private async void LogOutButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}