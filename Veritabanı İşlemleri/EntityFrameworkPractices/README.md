<h1 align="center">
  <br>
  <a href="https://github.com/zeynepaslierhan/.NetCoreArchive"><img src="https://github.com/zeynepaslierhan/zeynepaslierhan/blob/main/img/Logo.png" alt="SoftwareDeveloperArchive" width="200"></a>
  <br>
  Entity Framework Practices
  <br>
</h1>

<img src="https://github.com/zeynepaslierhan/zeynepaslierhan/blob/main/img/gifs/BuKadarSakin%C3%87al%C4%B1%C5%9Fm%C4%B1yorum.gif" align="right">

.Net Core projelerinde kullanılan Entity Framework işlemleri için oluşturulmuş bir bölümdür.

<img src="https://github.com/zeynepaslierhan/.NetCoreArchive/blob/main/img/Entity%20Framework/EntityFramework.png" align="left" height="200">

:round_pushpin: **Entity Framework (EF)**, ORM (Object Relational Mapping) araçlarından biridir. .NET geliştiricilerinin .NET nesneleri kullanarak bir veritabanıyla çalışmasına olanak sağlar. 

.Net Core Archive serisinin bu bölümünde entity framework, *code first* projelerinde kullanılmıştır. Yani veritabanın mimarisi .Net core projelerindeki kodlarla belirlenmiştir... [*(:bookmark_tabs: daha detaylı bilgi için...)*](https://www.instagram.com/softwaredeveloperarchive/guide/entity-framework/18186750643234331/)

</br>

## İçindekiler

1. [Veritabanına bağlanma ve Migration işlemleri](https://github.com/zeynepaslierhan/.NetCoreArchive/tree/main/Veritaban%C4%B1%20%C4%B0%C5%9Flemleri/EntityFrameworkPractices#-veritaban%C4%B1na-ba%C4%9Flanma-ve-migration-i%C5%9Flemleri)

2. Linq kullanımı örnekleri (***Yakında...***)

<a href="https://www.youtube.com/watch?v=S1p0lEaLXnU&list=PLjMBQHLzNCzZ7nADOe8ZYej602FbID13M&index=4&pp=sAQB"><img src="https://github.com/zeynepaslierhan/.NetCoreArchive/blob/main/img/Authentication%20Practices.jpg" align="left" height="95"> </a> 

## 💻 Veritabanına bağlanma ve Migration işlemleri 

MSSQL veritabanı işlemleri yapılmak için aşağıdaki aşamalar takip edilmiştir. Bu bir Code First projesidir. Dolayısıyla aşağıdaki aşamalardan göreceğiniz üzere veritabanı mimarisi .Net Core porjesinin içerisindeki kodlarla sağlanmaktadır.

İsterseniz aşağıdaki aşamaları takip ederek ya da [kanalımdaki videosunu izleyerek 🎬](https://www.youtube.com/watch?v=S1p0lEaLXnU&list=PLjMBQHLzNCzZ7nADOe8ZYej602FbID13M&index=5&ab_channel=SoftwareDeveloperArchive) veritabanına bağlanma ve Migration işlemlerini yapabilirsiniz.

:pushpin: İlk olarak Entity Framework için gerekli nuget paketler indirilmelidir. 

(.Net Core 5.0 versiyonu kullandığım için nuget paketleri 5.0.9 versiyonunda indirdim.)

* Microsoft.EntityFrameworkCore 
* Microsoft.EntityFrameworkCore.Design
* Microsoft.EntityFrameworkCore.SqlServer
* Microsoft.EntityFrameworkCore.Tools

> Nuget paketler nadiren bağımsız bir şekilde çalışırlar. Genellikle bağımlı oldukları başka paketlerde vardır. Bu yüzden Microsoft.EntityFrameworkCore,paketinin yanında diğer 3 paketler daha indirilmelidir.

:pushpin: Context isminde bir class oluşturulup DbContext'den miras alınır. 

> Kodun okunurluğunu arttırmak için Context.cs dosyası olarak ayrı bir sınıf(class) oluşturulması daha dogrudur. Kodun daha düzgün çalışmasını sağlamaz sadece prensiplere uyması ve temiz kod oluşması açısından önemlidir.

:pushpin: Context sınıfı içerisinde OnConfiguring methodu override edilir. Bu method sayesinde Mssql server için gerekli bağlantı dizisi *(string)* eklenir.

```C#

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer("server=.; database=EntityFrameworkPractices1;integrated security=true");
  }

```

> override anahtar sözcüğü, temel sınıftaki methodu geçersiz kılıp bu sınıfa göre hareket ettirtir. [ :bookmark_tabs: *Override ve nesneye yönelik programlamanın diğer konuları için instagramdaki NYP notlarımı takip edebilirsiniz...*](https://www.instagram.com/softwaredeveloperarchive/guide/nesneye-y-nelik-programlama-ve-net-core/17999316274518932/)

:pushpin: Projede istenilen modelin *(varlık, entity)*, veritabanında tablosunu oluşturmak için Context sınıfı içerisinde `DbSet<T>` kullanılır.

```C#

public DbSet<*Model.ismi*> *Tablo.ismi* { get; set; }

```

:pushpin: Migration eklemek için package console manager açılıp `ad-migration *Migration.ismi*` yazılır. Yapılan migration işleminin veritabanına yansıması için tekrar package console manager'a `update-database` yazılır.

</br>

---

<img src="https://github.com/zeynepaslierhan/zeynepaslierhan/blob/main/img/gifs/Yorumlar%C4%B1Okuyorumdur.gif" align="left" height="150">

## İletişim :telephone_receiver:

:e-mail:  softwaredeveloperarchive@gmail.com

:iphone: [@softwaredeveloperarchive](https://www.instagram.com/softwaredeveloperarchive/)
