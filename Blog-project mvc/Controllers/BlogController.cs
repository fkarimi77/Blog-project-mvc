using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_project_mvc.Controllers
{
    public class BlogController : Controller
    {
        userdbEntities nd = new userdbEntities();
        // GET: Blog
        public ActionResult Index()
        {
            var blogdetails = nd.blogs.ToList().OrderByDescending(x => x.Bid);

            return View(blogdetails);
        }
        
        public ActionResult Uploadblog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Uploadblog(blog bg)
        {
            
            nd.blogs.Add(bg);
            nd.SaveChanges();
            ViewBag.message = "Blog Details Are Saved Successfully...!";

            return View();
        }

        public ActionResult Food()
        {
            var foodarticle = nd.blogs.Where(x => x.BCategory == "Food");
            return View(foodarticle);
        }

        public ActionResult Sports()
        {
            var sportsarticle = nd.blogs.Where(x => x.BCategory == "Sports");
            return View(sportsarticle);
        }

        public ActionResult Movies()
        {
            var moviesarticle = nd.blogs.Where(x => x.BCategory == "Movies");
            return View(moviesarticle);
        }

        public ActionResult RecipewordId()
        {
            return View();
        }


    }
}