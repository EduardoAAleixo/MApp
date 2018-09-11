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
	public partial class DisciplinasPage : ContentPage
	{
        //CHAMAR CONTROLLER (DISCIPLINAS)
        DisciplinaController disciplinas;

        public DisciplinasPage()
        {
            InitializeComponent();

            disciplinas = new DisciplinaController();

            //ADICIONA OS OBJECTOS A LISTVIEW
            ldisciplinas.ItemsSource = disciplinas.ListaDisciplinas;

            //LISTA NÃO PODE SER SELECIONADA
            ldisciplinas.ItemSelected += (sender, e) => {
                ((ListView)sender).SelectedItem = null;
            };
        }
    }
}