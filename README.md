# ASP.NET Core MVC Projesi

Bu proje, ASP.NET Core Empty şablonundan başlatılarak, MVC (Model-View-Controller) mimarisine uygun olarak yapılandırılmıştır. Proje, dinamik web uygulamaları geliştirmek için temel bir başlangıç noktası sunar.

## Proje Yapısı

- **Controllers**: Controller sınıflarını içerir.
- **Models**: Veri modellerini içerir.
- **Views**: Razor view dosyalarını içerir.
- **wwwroot**: Statik dosyalar (CSS, JS, resimler vb.) burada saklanır.

## Yapılandırmalar

1. **MVC Servislerinin Eklenmesi**  
   `Program.cs` dosyasında aşağıdaki kod ile MVC servisleri etkinleştirilmiştir:  
   ```csharp
   builder.Services.AddControllersWithViews();
Statik Dosyaların Kullanılması
Statik dosyaların sunulması için wwwroot klasörü etkinleştirilmiştir:
 ```

 ```csharp
app.UseStaticFiles();
Routing Konfigürasyonu
Tarayıcıdan gelen isteklerin yönlendirilmesi için routing yapılandırması yapılmıştır:
 ```

 ```csharp
app.UseRouting();
Varsayılan Routing Tanımı
Varsayılan olarak HomeController'ın Index action'ına yönlendirme yapılmıştır:
 ```

 ```csharp
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
 ```
