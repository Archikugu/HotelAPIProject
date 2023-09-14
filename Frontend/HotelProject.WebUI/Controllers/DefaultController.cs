using HotelProject.WebUI.Dtos.SubscribeDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult _DefaultSubscribeComponentPartial()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> _DefaultSubscribeComponentPartial(CreateSubscribeDto createSubscribeDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSubscribeDto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("https://localhost:7020/api/Subscribe", content);
            return RedirectToAction("Index", "Default");

        }
    }
}
