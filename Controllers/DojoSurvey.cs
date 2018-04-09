using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurveyController
{
    public class DojoSurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("result")]
        
        public IActionResult Result(string name, string location, string lang, string message)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Lang = lang;
            ViewBag.Message = message;
            return View("result");
        }
        
    }
}