using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SistemaWeb.Controllers
{
    public class GeraDocumentosController : Controller
    {
        public IActionResult GeraExcel()
        {
            return View();
        }

        public IActionResult GeraWord()
        {
            return View();
        }

    }
}