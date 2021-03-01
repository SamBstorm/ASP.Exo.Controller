using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Exo._01.Controllers
{
    public class MainController : Controller
    {
        [Route("Contact")]
        public string Contact()
        {
            return "Contacter le service du site web : samuel.legrain@bstorm.be";
        }
        [Route("NotFound")]
        public string NotFound()
        {
            return "L'élément recherché n'existe pas...";
        }
    }
}