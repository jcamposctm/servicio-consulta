using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NewProject.Controllers
{
    [Route("Prueba")]
    public class PruebaController : Controller
    {
        // GET: Prueba
        [HttpGet]


        public IActionResult Prueba()
        {
            return View();
        }
        

        /*   public ContentResult Index()
        {
            return new ContentResult
            {
                ContentType = "text/html",
                Content = "<div><p><h3> Control piscinas </h3><h3> Día </h3 ><h3> Fecha </h3></p></div>"
            };
        }  
        */
    }
}