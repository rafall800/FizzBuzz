using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FizzBuzz.Pages
{
    public class LiczbaModel : PageModel
    {
        public Liczba Liczba { get; set; }

        public void OnGet()
        {
            var SessionLiczba = HttpContext.Session.GetString("SessionLiczba");
            if (SessionLiczba != null)
                Liczba =
                JsonConvert.DeserializeObject<Liczba>(SessionLiczba);
        }
    }
}
