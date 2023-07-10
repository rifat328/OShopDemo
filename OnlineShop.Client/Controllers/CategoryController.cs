using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineShop.Client.Models;
using System.IO;

namespace OnlineShop.Client.Controllers
{
    public class CategoryController : Controller
    {
        HttpClient _client=new HttpClient();
        public async Task<IActionResult> Index()
        {
            List<Category> categories = new List<Category>();
            _client.BaseAddress = new Uri("http://localhost:5223");
          
            HttpResponseMessage response = await _client.GetAsync("/api/category/getall");
            if (response.IsSuccessStatusCode)
            {
                categories = JsonConvert.DeserializeObject<List<Category>>(await response.Content.ReadAsStringAsync());
            }
            return View(categories);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Category category)
        {
            string message = "";
            _client.BaseAddress = new Uri("http://localhost:5223");
            HttpResponseMessage response = await _client.PostAsJsonAsync("/api/category/add",category);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
               //message= await response.Content.ReadAsStringAsync();
            }
            //ViewBag.message = message;
            return View(category);
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
