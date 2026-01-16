using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace azure_app_course.Pages
{
    public class DevelpmentSlots : PageModel
    {
        private readonly ILogger<DevelpmentSlots> _logger;

        public DevelpmentSlots(ILogger<DevelpmentSlots> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}