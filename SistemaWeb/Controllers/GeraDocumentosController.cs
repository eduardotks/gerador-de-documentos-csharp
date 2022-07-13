using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaWeb.Models;

namespace SistemaWeb.Controllers
{
    public class GeraDocumentosController : Controller
    {
        public IActionResult TelaGeraExcel()
        {
            return View();
        }

        public IActionResult TelaGeraWord()
        {
            return View();
        }

        [HttpPost]
        public IActionResult criaDocumentoWord(GeraDocumentos gdocs)
        {
            
            return View();
        }

    }
}