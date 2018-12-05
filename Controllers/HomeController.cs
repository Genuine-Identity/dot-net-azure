using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

/*
 * Storing the local connection string
 * Server=(localdb)\\mssqllocaldb;Database=MyDatabaseContext-91316f4b-b40a-416d-b064-737120c19fd3;Trusted_Connection=True;MultipleActiveResultSets=true
 */

namespace DotNetCoreSqlDb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
