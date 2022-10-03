using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
#region ToListAsync
//var urunler = await context.Urunler.ToListAsync();
#endregion

int urunId = 5;
var urunler = from urun in context.Urunler
              where urun.Id>5
              select urun;
urunId = 200;
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.UrunAdi);
}
#endregion

#region Foreach
//foreach (Urun urun in urunler)
//{
//    Console.WriteLine(urun.UrunAdi);
//}
#endregion
#region Deferred Execution(Ertelenmiş Çalışma)
// IQueryable çalışmalarında ilgili kod yazıldığı noktada çalıştırılmaz.
// Nerede eder ? Çalıştırıldığı yani execute edildiği noktada tetiklenir. Bu duruma
// ertelenmiş çalışma denir.
#endregion

#region IQueryable ve IEnumarable Nedir ? 

//var urunler = await (from urun in context.Urunler
//                     select urun).ToListAsync();
#region IQuaryable
//Sorguya karşılık gelir.
//EFCore üzerinden yapılmış olan sorgunun execute edilmemiş halini ifade eder.
#endregion
#region IEnumarable 
//Sorgunun execute edilip verilerin in memorye yüklenmiş halini ifade eder.
#endregion
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
