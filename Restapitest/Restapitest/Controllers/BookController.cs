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
    }
}
