using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWeb.Models;

namespace VendasWeb.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronicos" });
            list.Add(new Department { Id = 1, Name = "Roupas" });
            list.Add(new Department { Id = 1, Name = "Móveis" });
            list.Add(new Department { Id = 1, Name = "Alimentos" });

            return View(list);
        }
    }
}
