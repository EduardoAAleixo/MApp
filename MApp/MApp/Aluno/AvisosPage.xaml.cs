using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//EXTENÇÕES
using System.IO;
using System.Net;
using Newtonsoft.Json;

//CHAMAR CONTROLLERS
using MApp.Controllers;

namespace MApp.Aluno
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AvisosPage : ContentPage
	{
        //CHAMAR CONTROLLER (AVISOS)
        AvisoController avisos;

        public AvisosPage()
        {
            InitializeComponent();

            avisos = new AvisoController();
            
            //ADICIONA OS OBJECTOS A LISTVIEW
            lavisos.ItemsSource = avisos.ListaAvisos;

            //LISTA NÃO PODE SER SELECIONADA
            lavisos.ItemSelected += (sender, e) => {
                ((ListView)sender).SelectedItem = null; 
            };
        }
    }
}