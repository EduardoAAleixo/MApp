using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Linq;

namespace MApp.API
{
    public class WS
    {
        public StreamReader PedidoServidor(string uri)
        {
            //INSTALAR Package 'Microsoft.Net.Http' e 'JSON.net' do NuGet Installer
            //Necessário Importar a biblioteca ->System.Net, ->System.IO e ->Newtonsoft.Json
            //JSON

            HttpWebRequest ws = (HttpWebRequest)WebRequest.Create(new Uri(uri));
            ws.ContentType = "application/json";

            var pedido = ws.BeginGetResponse(new AsyncCallback(WebRequestCallback), ws);
            HttpWebResponse resposta = (pedido.AsyncState as HttpWebRequest).EndGetResponse(pedido) as HttpWebResponse;
            StreamReader stream = new StreamReader(resposta.GetResponseStream(), Encoding.UTF8);

            return stream;
        }

        private void WebRequestCallback(IAsyncResult result)
        {
            //é obrigatório estar aqui
        }
    }
}
