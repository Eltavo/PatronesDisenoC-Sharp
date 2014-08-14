using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ElTavo.RepositoryPattern.Dominio;
using Newtonsoft.Json;

namespace ElTavo.RepositoryPattern.ApiRepository
{
    public class BaseRepository<T> where T : class 
    {
        public string UrlApi { get; set; }

        public T ObtenerPorId(string id)
        {
            var client = new HttpClient { BaseAddress = new Uri("http://localhost:38417/") };

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/DatosContacto/1").Result;

            if (response.IsSuccessStatusCode)
            {
                var datosContacto = response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(datosContacto.Result);
            }
            else
            {
                return null;
            }
        }
    }
}
