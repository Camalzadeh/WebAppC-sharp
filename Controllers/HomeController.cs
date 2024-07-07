using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBD.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            /*ViewResult viewResult = new ViewResult();
            viewResult.ViewName = "Index";*/
            /*return Json(new
            {
                name="Ays"
            });*/

           /* return NoContent();*/

            return View();
        }
    }
}
