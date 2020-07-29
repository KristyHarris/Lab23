using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab23.Data;
using Lab23.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab23.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieListContext _dbContext;

        public MovieController(MovieListContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var movies = _dbContext.Movies.ToList();
            return View(movies);
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult SearchResultTitle(string title)
        {
            var movieList = _dbContext.Movies.Where(m=> m.Title.ToLower().Contains(title.ToLower())).ToList();
            
            ViewBag.MovieList = movieList;
            ViewBag.Title = title;

            return View();
        }
        
        public IActionResult SearchResultGenre(string genre)
        {
            var movieList = _dbContext.Movies.Where(m => m.Genre == genre).ToList();
            ViewBag.MovieList = movieList;
            ViewBag.Genre = genre;

            return View();

        }

        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie([Bind("Title", "Genre", "Runtime")] Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
  