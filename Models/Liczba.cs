using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Models
{
    public class Liczba
    {
        [Required(ErrorMessage = "Pole FizzBuzz jest obowiązkowe"),Range(1,1000,ErrorMessage = "Wartość pola FizzBuzz musi znajdować się w przedziale od 1 do 1000.")]
        public int FizzBuzz { get; set; }
        public string Result { get; set; }
    }
}
