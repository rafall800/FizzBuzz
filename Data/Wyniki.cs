using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Models;
using Microsoft.EntityFrameworkCore;

namespace FizzBuzz.Data
{
    public class Wyniki : DbContext
    {
        public Wyniki(DbContextOptions options): base(options) { }
        public DbSet<Liczba> Liczba { get; set; }
        
    }
}
