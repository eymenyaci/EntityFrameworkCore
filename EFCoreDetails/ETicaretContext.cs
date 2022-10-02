using Microsoft.EntityFrameworkCore;
using System;

namespace EFCoreDetails
{


    #region Veri nasıl eklenir ?
    ETicaretContext context = new();
    Urun urun = new()
    {
        Id = 1,
        UrunAdi = "Deneme ürün adı",
        Fiyat = 350,
        Aciklama = "Deneme ürün açıklaması"
    };


    #endregion

    #region context.AddAsync fonksiyonu

    #endregion



    public class ETicaretContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }

        //OnConfiguring metotunun kullanımı için DbContext nesnesinden miras alınması gerekir.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JFVV9NF;Database=EFCore;User ID=sa;Password=eymen123");
        }

    }
    public class Urun
    {

        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public string Aciklama { get; set; }
    }

    #region OnConfiguring İle Konfigürasyon Ayarlarını Gerçekleştirmek  
    //EF Core tool'unu yapılandırmak için kullandığımız bir metottur.
    //Context nesnesinde override edilerek kullanılmaktadır.
    #endregion
}
