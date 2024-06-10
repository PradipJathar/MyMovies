using MyMovies.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMovies.Controllers
{
    public class MovieController : Controller
    {
        MyMoviesDBEntities db = new MyMoviesDBEntities();


        // GET: Movie
        public ActionResult Index()
        {
            List<Movie> movies = new List<Movie>();
            movies = db.Movies.ToList();

            return View(movies);
        }
    }
}