using Microsoft.AspNetCore.Mvc;

namespace NetCoreEducation.Controllers
{
    public class AboutController : Controller
    {
        public string Profile()
        {
            return "MIRAC OZTURK";
        }
    }
}