using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using apiTestApp.Models;
using System.Text.Json;

namespace apiTestApp.Controllers;

public class HomeController : Controller
{
   

    public async Task<IActionResult> Index()
    {
        var products = new List<ProductDTO>();

        using(var httpClient = new HttpClient())
        {
            using(var response = await httpClient.GetAsync("http://localhost:5005/api/Products"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                products = JsonSerializer.Deserialize<List<ProductDTO>>(apiResponse);
            }
        }
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

   
}
