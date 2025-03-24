using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projekat.Models
{
    public class korisnik
    {
        [Required(ErrorMessage = "Obavezno uneti Ime i prezime!")]
        public string ImeIPrezime { get; set; }
        [Required(ErrorMessage = "Obavezan Email!")]
        [EmailAddress(ErrorMessage = "Neispravna email adresa!")]
        public string Email { get; set; }
    }
    public class kupci : korisnik
    {
        [Key]
        public int ID { get; set; }

        public string Poruka { get; set; }
    }
}