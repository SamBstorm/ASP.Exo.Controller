using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Exo._01.Controllers
{
    public class FilmsController : Controller
    {
        // GET: Films
        [Route("")]
        public string Index()
        {
            return "1 : Matrix<br>2 : Jurassic Park<br>3 : Predator<br>4 : Le père noël est une ordure<br>5 : Roger rabit";
        }

        [Route("Films/{id}/Details")]
        public ActionResult Details(int? id)
        {
            try
            {
                if (id == null || id > 5 || id < 1)
                    {
                        throw new Exception();
                    }
                string details = default;
                switch (id)
                {
                    case 1:
                        details = "Matrix (1999) - Keanu Reevse";
                        break;
                    case 2:
                        details = "Jurassic Park (1999) - Keanu Reevse";
                        break;
                    case 3:
                        details = "Predator (1999) - Keanu Reevse";
                        break;
                    case 4:
                        details = "Le père noël est une ordure (1999) - Keanu Reevse";
                        break;
                    case 5:
                        details = "Roger rabit (1999) - Keanu Reevse";
                        break;
                }
                ContentResult result = new ContentResult();
                result.Content = details;
                return result;
            }
            catch (Exception)
            { 
                return RedirectToAction("NotFound", new { controller ="Main" });
            }
            
        }
    }
}