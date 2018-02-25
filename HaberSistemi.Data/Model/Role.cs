using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSistemi.Data.Model
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "RolAdi : ")]
        [MinLength(3, ErrorMessage ="Lütfen 3 karakterden fazla değer giriniz! "),MaxLength(150,ErrorMessage = "Lütfen 150 Karakterden fazla değer girmeyiniz ! ")]
        public string RolAdi { get; set; }
        public string Email { get; set; }
    }
}
