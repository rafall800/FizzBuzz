using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Data;
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
        private readonly Wyniki _wyniki;
        [BindProperty]
        public Liczba Liczba { get; set; }
        public IndexModel(ILogger<IndexModel> logger, Wyniki wyniki)
        {
            _logger = logger;
            _wyniki = wyniki;
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Liczba.Check(Liczba.FizzBuzz);
                Liczba.Date = DateTime.Now;
                _wyniki.Liczba.Add(Liczba);
                if(_wyniki.Liczba.Count()>9)
                {
                    _wyniki.Remove(_wyniki.Liczba.First());
                }
                _wyniki.SaveChanges();
                HttpContext.Session.SetString("SessionLiczba",
               JsonConvert.SerializeObject(Liczba));  
            }
        }
    }
}
