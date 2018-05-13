using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JustynaKozbaLab5Zad1.Models
{
    /// <summary>
    /// Klasa odpowiadająca za stworzenie formularza logowania, pozwalająca na 
    /// wpisanie Imienia z maksymalną liczbą znakó 20, Nazwiska z maksymalną liczbą znaków 40 oraz hasła o największej liczbie znaków 25 a najmniejszej 10
    /// </summary>
    public class ContactForm
    {
        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(40)]
        public string LastName { get; set; }
        [MaxLength(25, ErrorMessage ="Hasło nie może być dłuższe niż 25 znaków")][MinLength(10, ErrorMessage = "Hasło nie może być krótsze niż 10 znaków")]
        public string Password { get; set; }

    }
}