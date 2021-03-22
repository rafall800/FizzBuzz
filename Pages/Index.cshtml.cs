using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Liczba Liczba { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
            if (Liczba.FizzBuzz % 3 == 0)
            {
                Liczba.Result += "fizz";
            }
            if (Liczba.FizzBuzz % 5 == 0)
            {
                Liczba.Result += "buzz";
            }
            if (Liczba.Result == null)
                    Liczba.Result = String.Format("Liczba {0} nie spełnia kryteriów Fizz/Buzz.",Liczba.FizzBuzz);
                HttpContext.Session.SetString("SessionLiczba",
               JsonConvert.SerializeObject(Liczba));  
            }
        }
    }
}
