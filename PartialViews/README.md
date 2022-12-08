<h1 align="center">
  <br>
  <a href="https://github.com/zeynepaslierhan/.NetCoreArchive"><img src="https://github.com/zeynepaslierhan/zeynepaslierhan/blob/main/img/Logo.png" alt="SoftwareDeveloperArchive" width="200"></a>
  <br>
  PartialView Practices
  <br>
</h1>

<img src="https://github.com/zeynepaslierhan/zeynepaslierhan/blob/main/img/gifs/BuKadarSakin%C3%87al%C4%B1%C5%9Fm%C4%B1yorum.gif" align="right">


.Net Core projelerinde kullanılan PartialView işlemleri için oluşturulmuş bir bölümdür.

## İçindekiler

1. [PartialView oluşturma](https://github.com/zeynepaslierhan/.NetCoreArchive/tree/main/PartialViews#-partialview-olu%C5%9Fturma)

2. PartialView kullanımı örnekleri (***Yakında...***)


<a href="https://www.youtube.com/watch?v=XGUQSzAj4DE&ab_channel=SoftwareDeveloperArchive"><img src="https://github.com/zeynepaslierhan/.NetCoreArchive/blob/main/img/PartialView%20Practices.jpg" align="left" height="95"> </a> 


## 💻 PartialView Oluşturma

İki şekilde partialView kullanabilirsiniz. İster Controller'a bağlı ister controller olmadan bir Razor View oluşturup partialView seçeneğini seçerek ilerleyebilirsiniz. İlgili sayfa içerisine istenilen partialView'ı çağırmak için de kod satırı eklemeniz yeterli. [youtube'da paylaştığım videoyu :clapper: ](https://www.youtube.com/watch?v=XGUQSzAj4DE&ab_channel=SoftwareDeveloperArchive) takip ederek PartialView oluşturabilirsiniz.

1. 📌 Controller kısmında gerekli olan kod, aslında bir action türüdür. PartialView() döndüren bir method yazmanız yeterlidir:
  
    ```c#
      public PartialViewResult PartialView_Index()
        {
            return PartialView();
        }
    ```
    
    > Action türleri hakkında daha detaylı bilgi edinmek için [instagram sayfamdan .Net Core Hikaye Arşivi](https://www.instagram.com/softwaredeveloperarchive/) serisini inceleyebilirsiniz.
    
2. 📌 Controller kullanarak veya kullanmadan eklediğiniz Razor View'ın partialView olduğunu belirten seçeneği işaretlemeniz gerekiyor.

3. 📌 PartialView'ı kullanmak istediğiniz View içerisine istediğiniz yere aşağıdaki kod satırını eklemelisiniz. Daha sonrasında partialView'ın gerekli dosya uzantısını kod içerisine yerleştiriniz:

    ```html
      @Html.Partial("~/Views/Shared/.....") 
    ```


  > :dizzy: Burada gösterilen uygulamaları kullandığım projeleri incelemek için: [.NetCorePractices](https://github.com/zeynepaslierhan/.NetCorePractices) projelerini inceleyebilirsiniz.


---

<img src="https://github.com/zeynepaslierhan/zeynepaslierhan/blob/main/img/gifs/Yorumlar%C4%B1Okuyorumdur.gif" align="left" height="150">


## İletişim :telephone_receiver:

:e-mail:  softwaredeveloperarchive@gmail.com

:iphone: [@softwaredeveloperarchive](https://www.instagram.com/softwaredeveloperarchive/)
