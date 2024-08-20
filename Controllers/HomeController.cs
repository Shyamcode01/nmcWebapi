using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using nmvUiproject.Models;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace nmvUiproject.Controllers
{
    public class HomeController : Controller
    {

        private string url = "https://localhost:7201/api/Home";
        private HttpClient _client= new HttpClient();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(studentregister obj)
        {
            string data= Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            StringContent content = new StringContent(data,Encoding.UTF8,"application/json");
            HttpResponseMessage response=_client.PostAsync(url, content).Result;
            if(response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
        //[HttpGet]
        //public async Task< IActionResult> Index()
        //{
        //    try
        //    {
        //        List<studentregister> studentregisters = new List<studentregister>();
        //        HttpResponseMessage response =await _client.GetAsync(url);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string result = await response.Content.ReadAsStringAsync();
        //            var data = JsonConvert.DeserializeObject<List<studentregister>>(result);
        //            if (data != null)
        //            {
        //                studentregisters = data;
        //            }
        //        }
        //        return View(studentregisters);
        //    }catch(Exception ex)
        //    {
        //        return View(ex.Message);
        //    }
        //}
    }
}
