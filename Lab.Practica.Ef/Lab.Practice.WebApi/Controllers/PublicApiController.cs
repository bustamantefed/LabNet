using Lab.Practice.WebApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Lab.Practice.WebApi.Controllers
{
    public class PublicApiController : Controller
    {
        public async Task<List<FuturamaAPI>> GetAll()
        {
            string apiUrl = "http://futuramaapi.herokuapp.com/api/quotes";
            HttpClient httpClient = new HttpClient();

            try
            {
                string responseJson = await httpClient.GetStringAsync(apiUrl);

                List<FuturamaAPI> Futurama = JsonConvert.
                DeserializeObject<List<FuturamaAPI>>(responseJson);

                return Futurama;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
            public async Task<ActionResult> FuturamaAPI()
            {
                List<FuturamaAPI> Futurama = await GetAll();

                List<FuturamaAPI> FutusView = Futurama.Select(p => new FuturamaAPI
                {
                    character = p.character,
                    quote = p.quote ,
                    image = p.image 
                }).ToList();
            return View(FutusView);
            }
    }
}
