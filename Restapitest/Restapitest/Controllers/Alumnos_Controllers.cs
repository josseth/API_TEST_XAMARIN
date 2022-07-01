using System;
using System.Collections.Generic;
using System.Text;
using Restapitest.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Restapitest.Controllers
{
    public class Alumnos_Controllers
    {
        //add commentario
        public async static Task<List<Alumno>> getAlumnos()
        {
            List<Alumno> listaalumn = new List<Alumno>();
            Repuesta re = new Repuesta();
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.GetAsync(Configs.apiGetList);
                if (respuesta.IsSuccessStatusCode)
                {
                    var contenido = respuesta.Content.ReadAsStringAsync().Result;//OBTENGO EL CONTENIDO
                    //PASAR A RESUESTA DONDE ES EL ROOT DE LA LISTA EL JSON 
                    re = JsonConvert.DeserializeObject<Repuesta>(contenido);
                    //OBTENER DEL ROOT DEL OBJETO "RESPUESTA" EL ELEMENTO LISTADO que es una lista de alumnos
                    listaalumn = re.LISTAD0;
                }
            }
            return listaalumn;
        }
        public async static Task CrearAlumno(Alumno emple)
        {
            String json = JsonConvert.SerializeObject(emple);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            using (HttpClient cliente = new HttpClient())
            {
                response = await cliente.PostAsync(Configs.apiSetAlumno, content);
            }
            if (response.IsSuccessStatusCode)
            {
                Debug.WriteLine(@"\tTodoItem successfully saved.");
            }

        }
    }
}
