using Activity2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Bogus;

namespace Activity2.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            List<MovieModel> MovieList = new List<MovieModel>();

                if (MovieList.Count == 0)
            {
                MovieList.Add(new MovieModel { Id = 1, Title = "The Pursuit of Happiness", Review = "The movie was breathtaking. WIll Smith displayed his best performance.", Release = new DateTime(2006, 5, 20) });
                MovieList.Add(new MovieModel { Id = 2, Title = "Forrest Gump", Review = "The movie was amazing. Tom Hanks greatest role.", Release = new DateTime(1994, 8, 01) });
                MovieList.Add(new MovieModel { Id = 3, Title = "The Godfather", Review = "Al Pochino delivers.", Release = new DateTime(1972, 2, 17) });


                for (int i = 0; i < 200; i++)
                {
                    MovieList.Add(new Faker<MovieModel>()
                        .RuleFor(p => p.Id, i + 3)
                        .RuleFor(p => p.Title, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Review, f => f.Rant.Review())
                        .RuleFor(p => p.Release, f => f.Date.Soon())
                        );

                }



            }
            
            return View(MovieList);
        }
    }
}
