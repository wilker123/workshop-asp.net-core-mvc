using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {

            List<Departament> list = new List<Departament>();

            list.Add(new Departament { Id = 1, Nome = "Eletronics" });
            list.Add(new Departament { Id = 2, Nome = "Fashion" });

            return View(list);
        }
    }
}
