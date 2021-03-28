using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api_aspnet_core.Models;

namespace api_aspnet_core.Controllers
{
    public class SchoolController : Controller
    {

        public IActionResult Index() 
        {
            var school = new School();
            school.SchoolId = Guid.NewGuid().ToString();
            school.FoundationYear = 2005;
            school.Name = "Escuela Montevideo";
            return View(school);
        }

    }
}
