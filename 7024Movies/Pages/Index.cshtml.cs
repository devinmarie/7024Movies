﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using QuickType;

namespace _7024Movies.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            using (var webClient = new WebClient())
            {

                string CriticJson = webClient.DownloadString("https://www.devinlally.com/uploads/6/0/5/4/60548821/critics.json");
                CriticsReviews.CriticsReview[] Reviews = CriticsReviews.CriticsReview.FromJson(CriticJson);
                ViewData["Reviews"] = Reviews;
            }
        }
    }
}
