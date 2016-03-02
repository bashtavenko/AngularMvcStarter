using System.Web.Mvc;

namespace AngularMvcStarter.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}