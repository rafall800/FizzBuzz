using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Data;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Models
{
    public class Liczba
    {
        [Required(ErrorMessage = "Pole FizzBuzz jest obowiązkowe"),Range(1,1000,ErrorMessage = "Wartość pola FizzBuzz musi znajdować się w przedziale od 1 do 1000.")]
        public int FizzBuzz { get; set; }
        [Key]
        public int Id { get; set; }
        public string Result { get; set; }
        public DateTime Date { get; set; }

        public string Check(int FizzBuzz)
        {
            if (FizzBuzz % 3 == 0)
            {
                Result += "fizz";
            }
            if (FizzBuzz % 5 == 0)
            {
                Result += "buzz";
            }
            if (Result == null)
                Result = String.Format("Liczba {0} nie spełnia kryteriów Fizz/Buzz.", FizzBuzz);
            return Result;
        }
    }
}
