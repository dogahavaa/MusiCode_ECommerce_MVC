using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusiCodeWebApp.Models
{
    public class ManagerRole:Entity
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [Display(Name = "Rol Adı")]
        public string Name { get; set; }

        public virtual ICollection<Manager> managers { get; set; }
    }
}