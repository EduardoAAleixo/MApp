using System;
using System.Collections.Generic;
using System.Text;
//EXTENÇÕES
using System.IO;
using Newtonsoft.Json;
using System.Net;
//API
using MApp.API;
//MODEL
using MApp.Models;

namespace MApp.Controllers
{
    class DisciplinaController
    {
        //LIGAÇÃO AO SERVIDOR
        private WS server;

        //LISTA DE OBJETOS DO MODEL(DISCIPLINA)
        public List<Disciplina> ListaDisciplinas;

        //CHAMAR DATA 
        public DisciplinaController()
        {
            server = new WS();
            //LINK SERVIDOR
            ListaDisciplinas = JsonConvert.DeserializeObject<List<Disciplina>>(server.PedidoServidor("http://multiapp.x10host.com/api/disciplinas").ReadLine());
        }

        //LISTAR NA LISTA
        public List<Disciplina> getAvisosById(int _id)
        {
            List<Disciplina> temp = new List<Disciplina>();

            foreach (Disciplina disciplina in ListaDisciplinas)
            {
                if (disciplina.id == _id)
                    temp.Add(disciplina);
            }

            return temp;
        }
    }
}
