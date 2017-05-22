﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using module04_08.Models;

namespace module04_08.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetComments()
        {
            List<Comment> data = new List<Comment>
            {
                new Comment {Id=100,Subject="A" },
                new Comment {Id=200,Subject="B" },
                new Comment {Id=300,Subject="C" },
            };
            return View(data);
        }

        public ActionResult GetOtherComments()
        {
            List<Comment> data = new List<Comment>
            {
                new Comment {Id=500,Subject="E" },
                new Comment {Id=600,Subject="F" },
                new Comment {Id=700,Subject="G" },
            };
            return View(data);
        }
    }
}