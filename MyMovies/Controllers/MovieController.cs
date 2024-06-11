using MyMovies.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            movies = db.Movie.ToList();

            return View(movies);
        }


        [HttpGet]
        public ActionResult Create()
        {
            Movie movie = new Movie();

            return View(movie);
        }


        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            db.Movie.Add(movie);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Movie movie = db.Movie.Find(id);

            return View(movie);
        }


        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            db.Entry(movie).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            Movie movie = db.Movie.Find(id);

            db.Movie.Remove(movie);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}