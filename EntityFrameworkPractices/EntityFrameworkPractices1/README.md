# Entity Framework Practice-1 

ASP.NET Core Web App (Model-View-Controller) // .Net Core 5.0 kullanılarak hazırlandı. Nuget package olarak ``Microsoft.EntityFramework 5.0.9`` kullanıp **bağımlı olduğu paketler** de eklendi. MSSQL Server ile çalışıldı.

Herhangi bir mimari yapı kullanılmadan sadece veritabanına erişim sağlamak ve migration dosyalarını gözlemlemek adına oluşturulmuş bir pratiktir. 

Proje oluşturulduktan sonraki aşamalar:

1. Nuget package'lar eklenir.
2. Program.cs içerisinde Student class yapısıyla yeni bir entity oluşturulur.
3. Student classının veritabanındaki karşılığa olacak tablonun sütunlarından hangisinin birincil anahtar olacağına karar verilir. Birincil anahtar özelliği taşıyan sütun, class yapısındaki property'nin üzerine ``[Key]`` Attribute 'ü ile belirtilir ve **bu attribute'a ulaşmak için ilgili abstract class program.cs'e eklenir.**
4. *Entity Framework paketlerinden* gelen ``DbContext``'den kalıtım alınarak Context class'ı oluşturulur. Veritabanı için gerekli bağlantı dizesi belirtilip  ``DbSet<T>`` işlemleri burada yapılır.
5. Yeni bir migration dosyası oluşturulur. Proje içierisindeki değişen modelleri kaydeden Migration students tablosunun oluşturulduğunu belirtir. 
6. Migration dosyasında kaydedilen değişimlerin veritabanına yansıması için ``update-database işlemi`` yapılır.

<img src="https://github.com/zeynepaslierhan/.NetCorePractices/blob/main/img/Entity%20Framework%20Practices.jpg" width="300" alt="Entity Framework Practices"/>

**Youtube videosu:** [Entity Framework Practices-1 / Software Developer Archive](https://www.youtube.com/watch?v=cPpfsINyRCs&t=2s&ab_channel=SoftwareDeveloperArchive)

Entity Framework için özet bilgiler için

**Instagram**: @softwaredeveloperarchive https://www.instagram.com/softwaredeveloperarchive/
