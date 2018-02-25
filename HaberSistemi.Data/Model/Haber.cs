using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSistemi.Data.Model
{
    public class Haber
    {
        [Key]
        public int ID { get; set; }
        [Display("Haber Başlık")]
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string KisaAciklama { get; set; }
        public bool AktifMi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public string Resim { get; set; }

        public virtual ICollection<Resim> Resims { get; set; }
    }
}
