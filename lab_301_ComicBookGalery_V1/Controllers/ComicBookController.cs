﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_301_ComicBookGalery_V1.Controllers
{
    public class ComicBookController : Controller
    {
        public ContentResult Detail()
        {
            return new ContentResult()
            {
                Content = "hello from the comic book controls!"
            };
        }
    }
}