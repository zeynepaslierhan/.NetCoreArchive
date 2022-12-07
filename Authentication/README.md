<h1 align="center">
  <br>
  <a href="https://github.com/zeynepaslierhan/.NetCoreArchive"><img src="https://github.com/zeynepaslierhan/.NetCoreArchive/blob/main/img/Readme/Logo.png" alt="SoftwareDeveloperArchive" width="200"></a>
  <br>
  Authentication İşlemleri
  <br>
</h1>

.Net Core Projelerinde kullanılan Authentication işlemleri için oluşturulmuş bir bölümdür.

## İçindekiler

1. [Controller Seviyesinde Login İşlemi](https://github.com/zeynepaslierhan/.NetCoreArchive/edit/main/Authentication/README.md#controller-seviyesinde-login-i%CC%87%C5%9Flemi)

2. Identity Kütüphanesi ile Login İşlemi (***Yakında...***)

<img src="https://github.com/zeynepaslierhan/.NetCoreArchive/blob/main/img/gifs/developer.gif" align="right">

## 💻Controller Seviyesinde Login İşlemi 

1. **Startup dosyasında gerekli olan kodlar:**
  
    ```c#
      public void ConfigureServices(IServiceCollection services)
    ```

    İlk olarak yukarıdaki Methodun içerisine aşağıdaki kod eklenir:

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

    İkinci olarak startup dosyasının içerisine aşağıdaki kod direkt eklenir.

    ```c#
    app.UseAuthentication();
    ```


1. **LoginController içerisinde gerekli kodlar**

   1. **Login/Signin işlemi**

    Login işlemi için ilgili method içerisine yazılır:

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
    Login işlemi için ilgili method içerisine yazılır:

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



## İletişim :telephone_receiver:

:e-mail:  softwaredeveloperarchive@gmail.com

:iphone: [@softwaredeveloperarchive](https://www.instagram.com/softwaredeveloperarchive/)
