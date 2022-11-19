using FilmDB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB.Controllers
{
    public class FilmController : Controller
    {
        FilmManager filmManager = new FilmManager();

        public IActionResult Index()
        {
            FilmModel film = new FilmModel();
            film.Title = "Rambo";
            film.Year = 1980;

            filmManager.AddFilm(film);
            filmManager.RemoveFilm(3);
            return View();
        }
    }
}
