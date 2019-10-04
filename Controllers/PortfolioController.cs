using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("index");
        }

        [HttpGet]
        [Route("projects")]
        public ViewResult Projects()
        {
            return View("projects");
        }

        [HttpGet]
        [Route("contact")]
        public ViewResult Contact()
        {
            return View("contact");
        }
    }
}