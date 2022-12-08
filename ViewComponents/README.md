<h1 align="center">
  <br>
  <a href="https://github.com/zeynepaslierhan/.NetCoreArchive"><img src="https://github.com/zeynepaslierhan/zeynepaslierhan/blob/main/img/Logo.png" alt="SoftwareDeveloperArchive" width="200"></a>
  <br>
  ViewComponent Practices
  <br>
</h1>

<img src="https://github.com/zeynepaslierhan/zeynepaslierhan/blob/main/img/gifs/%C4%B0%C5%9FimBittiSanm%C4%B1%C5%9F%C4%B1md%C4%B1r.gif" align="right">

.Net Core projelerinde kullanılan ViewComponent işlemleri için oluşturulmuş bir bölümdür.

## İçindekiler

1. [ViewComponent oluşturma](https://github.com/zeynepaslierhan/.NetCoreArchive/blob/main/ViewComponents/README.md#-viewcomponent-olu%C5%9Fturma)

2. ViewComponent kullanımı örnekleri (***Yakında...***)

<a href="https://www.youtube.com/watch?v=t5fEB9ulkEw"><img src="https://github.com/zeynepaslierhan/.NetCoreArchive/blob/main/img/ViewComponent%20Practices.jpg" align="left" height="95"> </a> 

## 💻 ViewComponent Oluşturma

📌 **<ViewComponent.ismi>**.cs dosyası oluşturularak `ViewComponent`'den miras alınmalıdır.

📌 Daha sonrasında IViewComponentResult ile method tanımlanmalıdır.
  ```c#
    public IViewComponentResult Invoke()
    {
      return View();
    }
  ```
    
  > ViewComponent bir action türüdür. Action türleri hakkında daha detaylı bilgi edinmek için [instagram sayfamdan .Net Core Hikaye Arşivi](https://www.instagram.com/softwaredeveloperarchive/) serisini inceleyebilirsiniz.
     
📌 ~/Views/Shared içerisine isteğe bağlı Components klasörü ekleyip Component'ler için oluşturulan Razor View'ları burada tutabilirsiniz. Bu klasörlemedeki amaç oluşturulan ViewComponent'lerin yerlerinin herkes tarafından anlaşılabilir olmasıdır. 

📌 ~/Views/Shared/Component içerisine **<ViewComponent.ismi>**.cs dosyasıyla aynı isimli **<ViewComponent.ismi>** klasörü oluşturulmalıdır. bu klasörün içine de "default.cshtml" Razor View'ı eklenmelidir. Bu Razor View, partialView olarak seçeneklerden belirtilmelidir.

📌 ViewComponent'in kullanılması istenilen view içerisine viewComponent nerede kullanılmak isteniyorsa oraya aşağıdaki kod satırı eklenmelidir.
  
  ```html
      @await Component.InvokeAsync("<ViewComponent.ismi>")
  ```
  
> :dizzy: Burada gösterilen uygulamaları kullandığım projeleri incelemek için: [.NetCorePractices](https://github.com/zeynepaslierhan/.NetCorePractices) projelerini inceleyebilirsiniz.

---

<img src="https://github.com/zeynepaslierhan/zeynepaslierhan/blob/main/img/gifs/Yorumlar%C4%B1Okuyorumdur.gif" align="left" height="150">

## İletişim :telephone_receiver:

:e-mail:  softwaredeveloperarchive@gmail.com

:iphone: [@softwaredeveloperarchive](https://www.instagram.com/softwaredeveloperarchive/)
