using CRUDDemoForDI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDDemoForDI.Controllers
{
    public class CategoryController : Controller
    {
       
        // GET: Category
        public ActionResult Index()
        {

            CategoryBAL bal = new CategoryBAL();
            var categories= bal.GetCategories();    
            return View(categories);
        }
    }
}