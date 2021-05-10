using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Data;
using FizzBuzz.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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
        public IList<Liczba> Lista { get; set; }
        public async Task OnGetAsync()
        {
            Lista = await _wyniki.Liczba.OrderByDescending(s=>s.Date).Take(10).ToListAsync();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Liczba = await _wyniki.Liczba.FindAsync(id);

            if (Liczba != null)
            {
                _wyniki.Liczba.Remove(Liczba);
                await _wyniki.SaveChangesAsync();
            }

            return RedirectToPage("./Sesja");
        }
        //public IActionResult OnPostDelete(int id)
        //{
        //    var wynik = _wyniki.Liczba.Find(id);
        //    if(wynik!=null)
        //    {
        //        _wyniki.Remove(wynik);
        //        _wyniki.SaveChanges();
        //        return RedirectToPage("Sesja");
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}
    }
}
