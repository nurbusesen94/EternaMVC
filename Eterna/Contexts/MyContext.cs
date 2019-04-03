using Eterna.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eterna.Contexts
{
    public class MyContext:DbContext
    {
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Yorum> Yorum { get; set; }
        public DbSet<Sorular> Sorular { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Hizmetler> Hizmetler { get; set; }
        public DbSet<Sehir> Sehir { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Mahalle> Mahalle { get; set; }
        public DbSet<Admin> Admin { get; set; }
    }
}