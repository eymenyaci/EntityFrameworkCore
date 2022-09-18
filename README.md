
# EntityFramework Yaklaşımlar

EF CORE Database First

İndirilmesi gereken paketler :

* Microsoft.EntityFrameworkCore.Tools
* Microsoft.EntityFrameworkCore.[Provider] -> SqlServer

-Model Yaratma-

* Scaffold-DbContext 'Server=DESKTOP-JFVV9NF;Database=Northwind;User Id=sa;Password=eymen123' Microsoft.EntityFrameworkCore.SqlServer
Bu komut Entity sınıflarını proje içinde otomatik olarak oluşturuyor.

Belirli tabloların gelmesini istiyorsak;

* Scaffold-DbContext 'Connection String' 
Microsoft.EntityFrameworkCore.[Provider] -Tables table1,table2,table3

-Path ve Namespace Belirleme-

* Scaffold-DbContext 'Server=DESKTOP-JFVV9NF;Database=Northwind;User Id=sa;Password=eymen123' Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models

ContectDir -> Context hangi path üzerinde oluşacağını seçiyor.
OutputDir  -> Modellerin hangi path üzerinde oluşacağını seçiyor.

-Model Güncelleme-

* Scaffold-DbContext 'Server=DESKTOP-JFVV9NF;Database=Northwind;User Id=sa;Password=eymen123' Microsoft.EntityFrameworkCore.SqlServer -Force

-Model Özelleştirme-

Force komutunu kullanırken modellerimizin etkilenmesini istemiyorsak farklı klasör altında aynı propları tanımlayabiliriz. Namespacelerini aynı yaparak class tipini partial yaparsak Force komutundan yalnızca hedef class etkilenir.
