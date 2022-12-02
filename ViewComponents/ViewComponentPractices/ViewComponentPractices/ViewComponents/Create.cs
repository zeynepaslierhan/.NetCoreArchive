using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponentPractices.ViewComponents
{
    public class Create : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
