using Microsoft.AspNetCore.Mvc;
using NetCoreEducation.Model;
using System.Collections.Generic;

namespace NetCoreEducation.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>()
            {
                new Category(){CategoryId = 1,CategoryName = "Matematik"},
                new Category(){CategoryId = 2,CategoryName = "Fizik"}
            };

            return View(categories);
        }
    }
}
