using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewPractices.Controllers
{
    public class Create2 : Controller
    {
        public PartialViewResult PartialView_Index()
        {
            return PartialView();
        }
    }
}
