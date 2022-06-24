using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Restapitest.Models;

namespace Restapitest.Controllers
{
    public class BookController
    {
        public async static Task<List<Books>> getBooks()
        {
            List<Books> listalibros = new List<Books>();
            using (HttpClient client = new HttpClient()) 
            {
                var respuesta = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
                if (respuesta.IsSuccessStatusCode)
                {
                    var contenido = respuesta.Content.ReadAsStringAsync().Result;
                    listalibros = JsonConvert.DeserializeObject<List<Books>>(contenido);
                }
            }
            return listalibros;
        }

        public async static Task<List<Alumno>> getAlumnos()
        {
            List<Alumno> listaalumn = new List<Alumno>();
            Repuesta re = new Repuesta();
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.GetAsync("http://192.168.0.10:8887/pm02/listadoAlumnos.php");
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
    }
}
