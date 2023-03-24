using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class OrnekController : Controller
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public IActionResult Index()
        {

            var productList = new List<Product>()
            {
                new() { Id = 1, Name="Kalem"},
                new() { Id = 2, Name="Defter"}
            };

            ViewBag.name = "Asp.Net Core";

            ViewData["Age"] = 61;
            ViewData["Ages"] = new List<int> { 65,75};

            TempData["Name"] = "Avşar";

            return View(productList);
        }
        public IActionResult Index2()
        {
            return RedirectToAction("Index","Ornek");
        }
        public IActionResult Index3()
        {
            return View();
        }

        public IActionResult Content()
        {
            return Content("ContentResult");
        }

        public IActionResult JsonResult()
        {
            return Json(new {Id = 5, Name = "Kadir"});
        }

        public IActionResult ParametreView(int id)
        {
            return RedirectToAction("JsonResultParametre", "Ornek",new {id=id});
        }

        public IActionResult JsonResultParametre(int id)
        {
            return Json(new { Id = id });
        }

    }
}
