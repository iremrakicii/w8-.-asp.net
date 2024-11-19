var builder = WebApplication.CreateBuilder(args);

// 1. MVC Servislerinin Eklenmesi
builder.Services.AddControllersWithViews(); // Controller ve View deste�i sa�lar.

var app = builder.Build();

// 2. Statik Dosyalar�n Kullan�lmas�
app.UseStaticFiles(); // wwwroot klas�r�ndeki dosyalar�n sunulmas�n� sa�lar.

// 3. Routing Konfig�rasyonu
app.UseRouting();

// 4. Varsay�lan Routing Tan�m�
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Default routing: Home Controller, Index Action

// Uygulamay� �al��t�r
app.Run();

// Controllers: Controller s�n�flar�, kullan�c�dan gelen HTTP isteklerini i�ler ve bir i�lem sonucunda veri ya da view d�ner.
// Models: Uygulamada kullan�lan veri yap�lar�n� tan�mlar.
// Views: Kullan�c�ya sunulan aray�zleri temsil eder. Razor view dosyalar� burada yer al�r.
// wwwroot: Statik dosyalar (CSS, JavaScript, resim vb.) bu klas�rde bulunur.

// Razor: ASP.NET Core'da kullan�lan bir view engine'dir. Dinamik HTML i�eri�i �retmek i�in kullan�l�r.
// RazorView: Razor view dosyalar�n� i�lemenin bir yoludur (�rne�in .cshtml dosyalar�).

// builder.Build(): Web uygulamas�n� olu�turur ve gerekli t�m ba��ml�l�klar� yap�land�r�r.
// app.Run(): Uygulamay� ba�lat�r ve HTTP isteklerini dinlemeye ba�lar.

