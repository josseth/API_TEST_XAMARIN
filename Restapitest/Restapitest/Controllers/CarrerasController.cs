using Newtonsoft.Json;
using Restapitest.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Restapitest.Controllers
{
    public class CarrerasController
    {
        public async static Task<List<Carrera>> getCarreras()
        {
            List<Carrera> listacar = new List<Carrera>();
            RespuestaCarrera re = new RespuestaCarrera();
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.GetAsync(Configs.apigetCarreras);
                if (respuesta.IsSuccessStatusCode)
                {
                    var contenido = respuesta.Content.ReadAsStringAsync().Result;//OBTENGO EL CONTENIDO
                    //PASAR A RESUESTA DONDE ES EL ROOT DE LA LISTA EL JSON 
                    re = JsonConvert.DeserializeObject<RespuestaCarrera>(contenido);
                    //OBTENER DEL ROOT DEL OBJETO "RESPUESTA" EL ELEMENTO LISTADO que es una lista de carreras
                    listacar = re.LISTAD0;
                }
            }
            return listacar;
        }
    }
}
