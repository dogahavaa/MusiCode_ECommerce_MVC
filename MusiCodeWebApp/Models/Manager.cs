using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MusiCodeWebApp.Models
{
    public class Manager:Entity
    {
        public int ManagerRoleID { get; set; }
        [ForeignKey("ManagerRoleID")]
        public virtual ManagerRole ManagerRole { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [Display(Name = "Isim")]
        [StringLength(maximumLength:75, ErrorMessage = "Bu alan en fazla 75 karakter olabilir.")]
        public string Name { get; set; }

        [Display(Name = "Soyisim")]
        [StringLength(maximumLength: 75, ErrorMessage = "Bu alan en fazla 75 karakter olabilir.")]
        public string Surname { get; set; }
        
        [Display(Name = "E-Posta")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [StringLength(maximumLength: 100, MinimumLength = 5, ErrorMessage = "Bu alan 5 - 200 karakter arasında olabilir.")]
        public string Mail { get; set; }

        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [StringLength(maximumLength: 24, MinimumLength = 5, ErrorMessage = "Bu alan 5 - 24 karakter arasında olabilir.")]
        public string Password { get; set; }

        public bool IsActive { get; set; }

    }
}