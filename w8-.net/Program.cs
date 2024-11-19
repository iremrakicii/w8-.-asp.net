var builder = WebApplication.CreateBuilder(args);

// 1. MVC Servislerinin Eklenmesi
builder.Services.AddControllersWithViews(); // Controller ve View desteði saðlar.

var app = builder.Build();

// 2. Statik Dosyalarýn Kullanýlmasý
app.UseStaticFiles(); // wwwroot klasöründeki dosyalarýn sunulmasýný saðlar.

// 3. Routing Konfigürasyonu
app.UseRouting();

// 4. Varsayýlan Routing Tanýmý
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Default routing: Home Controller, Index Action

// Uygulamayý çalýþtýr
app.Run();

// Controllers: Controller sýnýflarý, kullanýcýdan gelen HTTP isteklerini iþler ve bir iþlem sonucunda veri ya da view döner.
// Models: Uygulamada kullanýlan veri yapýlarýný tanýmlar.
// Views: Kullanýcýya sunulan arayüzleri temsil eder. Razor view dosyalarý burada yer alýr.
// wwwroot: Statik dosyalar (CSS, JavaScript, resim vb.) bu klasörde bulunur.

// Razor: ASP.NET Core'da kullanýlan bir view engine'dir. Dinamik HTML içeriði üretmek için kullanýlýr.
// RazorView: Razor view dosyalarýný iþlemenin bir yoludur (örneðin .cshtml dosyalarý).

// builder.Build(): Web uygulamasýný oluþturur ve gerekli tüm baðýmlýlýklarý yapýlandýrýr.
// app.Run(): Uygulamayý baþlatýr ve HTTP isteklerini dinlemeye baþlar.

