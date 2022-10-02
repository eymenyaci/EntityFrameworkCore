using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Querying;

QueryingContext context = new QueryingContext();

#region En Temel Basit Bir Sorgulama Nasıl Yapılır?
#region Method Syntax
//var urunler = await context.Urunler.ToListAsync();
#endregion
#region Query Syntax
//var urunler2 = await (from urun in context.Urunler
//               select urun).ToListAsync();
#endregion
#endregion

#region Sorguyu Execute Etmek İçin Ne Yapmamız Gerekmektedir ?
#endregion

#region IQueryable ve IEnumarable Nedir ? 
#endregion

#region Çoğul Veri Getiren Sorgulama Fonksiyonları
#endregion

#region Tekil Veri Getiren Sorgulama Fonksiyonları
#endregion

#region Diğer Sorgulama Fonksiyonları
#endregion

#region Sorgu Sonucu Dönüşüm Fonksiyonları
#endregion

#region GroupBy Fonksiyonu
#endregion

#region Foreach Fonksiyonu
#endregion

namespace Querying
{
    
    public class QueryingContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Parca> Parcalar { get; set; }

        //OnConfiguring metotunun kullanımı için DbContext nesnesinden miras alınması gerekir.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JFVV9NF;Database=QueryingDB;User ID=sa;Password=eymen123");
        }

    }
    public class Urun
    {

        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public string Aciklama { get; set; }
        public ICollection<Parca> Parcalar { get; set; }
    }
    public class Parca
    {
        public int Id { get; set; }
        public string ParcaAdi { get; set; }
    }
}
