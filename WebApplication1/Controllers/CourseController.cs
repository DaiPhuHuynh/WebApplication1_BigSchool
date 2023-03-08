using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public List<Category> Categories { get; private set; }

        public ActionResult Create()
        {
            var viewModel = new CoursesController
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }

    }
}