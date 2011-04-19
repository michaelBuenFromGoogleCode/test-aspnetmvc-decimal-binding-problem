using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestBindingProblem.Models;

namespace TestBindingProblem.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }   

        [HttpPost]
        public string Index(Person p)
        {
            return string.Format(
@"
<br>Lastname: {0}
<br>Firstname: {1}
<br>Birthday: {2}
<br>Grade: {3}", p.Lastname, p.Firstname, p.Birthday, p.Salary);
        }

    }
}
