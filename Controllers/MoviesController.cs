﻿using AttributeRouting.Models;
using AttributeRouting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeRouting.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie
            {
                Name = "Shrek"
            };

            var customers = new List<Customer>()
            {
                new Customer() {Name ="Customer1" },
            new Customer() { Name = "Customer2" }

            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
    }
}