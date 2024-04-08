using Microsoft.AspNetCore.Mvc;
using Personel_Kayit.Models;
using System.Diagnostics;
using System.IO;

namespace Personel_Kayit.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

     
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Personel model)
        {
            StreamWriter writer = new StreamWriter("d://personel/personel.txt",true);
            writer.WriteLine("Id : {0} ", model.Id);
            writer.WriteLine("Ad : {0} ", model.Ad);
            writer.WriteLine("Soyad : {0} ", model.Soyad);
            writer.WriteLine("Memleket : {0} ", model.Memleket);

            writer.WriteLine("-------------------------------------------");


            writer.Close();

            return View();

        }

        
    }
}