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
    class AvisoController
    {   
        //LIGAÇÃO AO SERVIDOR
        private WS server; 

        //LISTA DE OBJETOS DO MODEL(AVISOS)
        public List<Aviso> ListaAvisos;

        //CHAMAR DATA 
        public AvisoController()
        {
            server = new WS();
            //LINK SERVIDOR
            ListaAvisos = JsonConvert.DeserializeObject<List<Aviso>>(server.PedidoServidor("http://multiapp.x10host.com/api/avisos").ReadLine());
        }

        //CHAMAR AVISOS PARA A LISTA
        public List<Aviso> getAvisosById(int _id)
        {
            List<Aviso> temp = new List<Aviso>();

            foreach (Aviso aviso in ListaAvisos)
            {
                if (aviso.id == _id)
                    temp.Add(aviso);
            }

            return temp;
        }
    }
}
