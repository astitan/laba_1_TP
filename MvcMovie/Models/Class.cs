using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Class
    {
        [Required(ErrorMessage = "Введите первое число")]
        public ulong first_oper { get; set; }
        [Required(ErrorMessage = "Введите второе число")]
        [Range(0,100, ErrorMessage = "Число должно быть не меньше 0 и не больше 100")]
        public ulong second_oper { get; set; }
        public char act { get; set; }
        public double result { get; set; }
        
    }
}
