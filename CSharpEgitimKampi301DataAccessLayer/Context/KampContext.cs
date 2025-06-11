using CSharpEgitimKampi301.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Veri tabanı bağlantı adresleri ve veri tabanına yansıyacak olan tabloları tuttuğumuz classımızdır.
//References ile DataAccessLayer katmanına, EntityLayer katmanına ve EntityFramework kütüphanesine referans verdik.

namespace CSharpEgitimKampi301DataAccessLayer.Context
{
    public class KampContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}

//Migration ile beraber bu classlarımızı veri tabanına iletiyoruz.
//Migration için View > Other Windows > Package Manager Console kısmına geliyoruz.
//Burada Package Manager Console kısmında Default Project kısmından DataAccessLayer projesini seçiyoruz.
//Ardından Enable-Migrations komutunu veriyoruz.
//Enable-Migrations komutunu verdikten sonra DataAccessLayer klasörünün altında Migrations adında bir klasör oluşuyor.
//Bu Migration klasörünün altında Configuration.cs adında bir class oluşuyor.
//Bu class içinde AutomaticMigrationsEnabled değerini true yapıyoruz.
//Sonrasında update-database komutunu verip migration işlemini tamamlıyoruz.
//Sonrasında yeniden migration işlemi yapmak istersek Add-Migration MigrationAdı komutunu veriyoruz ve onay istedikten sonra onayı verip tekrardan update-database komutunu veriyoruz.
