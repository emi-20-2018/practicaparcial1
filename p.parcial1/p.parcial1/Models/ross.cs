using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace p.parcial1.Models
{
    public enum lista { univerdad,casa,farmacia,hospital,supermercado} 
    public class ross
    {[Key]
        public int rossID { set; get; }
        [Required] [Display(Name ="Nombre Completo")] [StringLength(24,MinimumLength =2)]
        public string Friendofross { set; get; }
        [Required]
        public lista place { set; get; }
        [EmailAddress(ErrorMessage ="ponga un correo valido")]
        public string Email { set; get; }
        [Display(Name ="Cumpleaños")]
        public DateTime Birthdate { set; get; }


    }
}