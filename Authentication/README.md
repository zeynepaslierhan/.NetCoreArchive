<h1 align="center">
  <br>
  <a href="https://github.com/zeynepaslierhan/.NetCoreArchive"><img src="https://github.com/zeynepaslierhan/zeynepaslierhan/blob/main/img/Logo.png" alt="SoftwareDeveloperArchive" width="200"></a>
  <br>
  Authentication İşlemleri
  <br>
</h1>

.Net Core Projelerinde kullanılan Authentication işlemleri için oluşturulmuş bir bölümdür.

<img src="https://github.com/zeynepaslierhan/zeynepaslierhan/blob/main/img/gifs/developer.gif" align="right">

## İçindekiler

1. [Controller Seviyesinde Login İşlemi](https://github.com/zeynepaslierhan/.NetCoreArchive/tree/main/Authentication#controller-seviyesinde-login-i%CC%87%C5%9Flemi)

2. Identity Kütüphanesi ile Login İşlemi (***Yakında...***)

<a href="https://www.youtube.com/watch?v=S1p0lEaLXnU&list=PLjMBQHLzNCzZ7nADOe8ZYej602FbID13M&index=4&pp=sAQB"><img src="https://github.com/zeynepaslierhan/.NetCoreArchive/blob/main/img/Authentication%20Practices.jpg" align="left" height="95"> </a> 


## 💻Controller Seviyesinde Login İşlemi 

İlk olarak startup dosyasının içersine gerekli kod blokları eklenip sonrasında Login/Logout işlemlerini yapan methodların içerisine ilgili kodlar yerleştirilir. Login işlemleri için yeni bir controller oluşturulmasının sebebi daha düzenli durması içindir. Buradaki amaç gerekli işlemleri yapan methodların nerede yazıldığını bilmektir. Aşağıdaki aşamaları takip ederek veya [youtube'da paylaştığım videoyu :clapper: ](https://www.youtube.com/watch?v=S1p0lEaLXnU&list=PLjMBQHLzNCzZ7nADOe8ZYej602FbID13M&index=4&pp=sAQB) takip ederek *Controller Seviyesinde Login* işlemlerini sağlayabilirsiniz.

1. **Startup dosyasında gerekli olan kodlar:**
  
    ```c#
      public void ConfigureServices(IServiceCollection services)
    ```

    📌 İlk olarak yukarıdaki Methodun içerisine aşağıdaki kod eklenir:

    ```c#
    services.AddMvc(config =>
    {
      var policy = new AuthorizationPolicyBuilder()
                      .RequireAuthenticatedUser()
                      .Build();
      config.Filters.Add(new AuthorizeFilter(policy));
    });

    services.AddMvc();
    services.AddAuthentication(
            CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
            {
              x.LoginPath = "/Login/Index";
            });
    ```

    📌 İkinci olarak startup dosyasının içerisine aşağıdaki kod direkt eklenir.

    ```c#
    app.UseAuthentication();
    ```


1. **LoginController içerisinde gerekli kodlar**

   1. **Login/Signin işlemi**

    📌 Login işlemi için ilgili method içerisine yazılır:

    ```c#
    Context c = new Context();

    var dataValue = c.users.FirstOrDefault(x => x.UserMail == user.UserMail && x.UserPassword == user.UserPassword);

    if(dataValue!=null)
    {
      var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserMail)
                };
      var userIdentity = new ClaimsIdentity(claims, "a");
      ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
      await HttpContext.SignInAsync(principal);
      eturn RedirectToAction("Index","Home");
    }
    else
    {
      return View();
    }
    ```

   2. **LogOut/SignOut işlemi**
    
    📌 LogOut işlemi için ilgili method içerisine yazılır:

    ```c#
    public async Task<IActionResult> LogOut()
    {
      await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
      return RedirectToAction("Index", "Login");
    }
    ```
  
   3. **Giriş Yapan Kişinin bilgilerinin yansıtılması**
  
    ```c#
    var userMail = User.Identity.Name;
    ```


  
  
  > :dizzy: Burada gösterilen uygulamaları kullandığım projeleri incelemek için: [.NetCorePractices](https://github.com/zeynepaslierhan/.NetCorePractices) projelerini inceleyebilirsiniz.

---

<img src="https://github.com/zeynepaslierhan/zeynepaslierhan/blob/main/img/gifs/Yorumlar%C4%B1Okuyorumdur.gif" align="left" height="150">


## İletişim :telephone_receiver:

:e-mail:  softwaredeveloperarchive@gmail.com

:iphone: [@softwaredeveloperarchive](https://www.instagram.com/softwaredeveloperarchive/)
