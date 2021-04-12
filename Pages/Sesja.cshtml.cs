using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Data;
using FizzBuzz.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FizzBuzz.Pages
{
    public class LiczbaModel : PageModel
    {
        private readonly Wyniki _wyniki;
        public LiczbaModel(Wyniki wyniki)
        {
            _wyniki = wyniki;
        }
        [BindProperty]
        public Liczba Liczba { get; set; }
        public IEnumerable<Liczba> Lista { get; set; }
        public void OnGet()
        {
            Lista = _wyniki.Liczba.ToList();
        }
        public IActionResult OnPostDelete(int id)
        {
            var wynik = _wyniki.Liczba.Find(id);
            if(wynik!=null)
            {
                _wyniki.Remove(wynik);
                _wyniki.SaveChanges();
                return RedirectToPage("Sesja");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
