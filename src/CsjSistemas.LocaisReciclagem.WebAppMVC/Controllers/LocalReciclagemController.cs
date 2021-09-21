using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsjSistemas.LocaisReciclagem.WebAppMVC.Extension;
using CsjSistemas.LocaisReciclagem.WebAppMVC.Model;

namespace CsjSistemas.LocaisReciclagem.WebAppMVC.Controllers
{
    public class LocalReciclagemController : Controller
    {

        public LocalReciclagemController()
        {

        }

        [HttpGet]
        [Route("listar-todos")]
        public JsonResult ObterTodos()
        {
            HttpClientIntegration http = new HttpClientIntegration();
            var model = http.Get("https://localhost:5701/api/todos-locais");
            return Json(model);
        }

              
    }
}
