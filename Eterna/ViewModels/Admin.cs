using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eterna.ViewModels
{
    [Table("Admin")]
    public class Admin
    {
        [Key,StringLength(30), Column(TypeName = "varchar"), Display(Name ="Kullanıcı Adı Soyadı"), Required(ErrorMessage ="Ad Boş Geçilemez")]
        public string KullaniciAdi { get; set; }

        [StringLength(30), Column(TypeName = "varchar"), Display(Name = "Yetkili Adı Soyadı"), Required(ErrorMessage = "Ad Boş Geçilemez")]
        public string AdSoyad { get; set; }

        [StringLength(30), Column(TypeName = "varchar"), Display(Name = "Şifre"), Required(ErrorMessage = "Şifre Boş Geçilemez")]
        public string Sifre { get; set; }
       
        [NotMapped, Compare("Şifre", ErrorMessage="Şifreler Uyuşmuyor")]
        public string Sifre2 { get; set; }

        public DateTime SonGirisTarih { get; set; }

        [StringLength(30), Column(TypeName = "varchar"), Display(Name = "Son Giriş IP Adresi")]
        public string SonGirisIP { get; set; }

        [StringLength(10), Column(TypeName = "Varchar"), Display(Name = "Rolü")]
        public string Rol { get; set; }
    }
}