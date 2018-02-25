using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSistemi.Data.Model
{
    [Table("Kullanici")]
    public class Kullanici
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(150,ErrorMessage = "Lütfen 150 den fazla karakter girmeyiniz!")]
        [Display(Name = "Ad Soyad")]
        public string AdSoyad { get; set; }

        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [Required]
        [MaxLength(16, ErrorMessage = "Lütfen 16 karakterden fazla girmeyiniz!")]
        public string Sifre { get; set; }

        [Display(Name = "KayitTarihi")]
        public DateTime KayitTarihi { get; set; }

        [Display(Name = "Aktif")]
        public  bool Aktif { get; set; }

        public virtual Role Rol { get; set; }
    }
}
