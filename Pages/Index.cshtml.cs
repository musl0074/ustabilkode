﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace _3_semester_projekt.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger _logger;

        public IndexModel(ILogger<IndexModel> logger){
            _logger = logger;
        }
        
        public void OnGet()
        {
            string Message = $"Index page visited at {DateTime.UtcNow.ToLongTimeString()}";
            _logger.LogDebug("Message displayed: {Message}", Message);
        }
    }
}
