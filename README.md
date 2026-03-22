# UrunYonetimSistemi

Bu proje ASP.NET Core MVC (.NET 9) kullanılarak geliştirilmiş basit bir Ürün Yönetim Sistemi uygulamasıdır.
Sistem kullanıcı girişi içerir ve giriş yaptıktan sonra kullanıcılar ürünleri listeleyebilir, ekleyebilir, düzenleyebilir ve silebilir.

Bu proje Entity Framework Core (Code First + Migration) ve PostgreSQL veritabanı kullanılarak geliştirilmiştir.

Kullanılan Teknolojiler
Backend: ASP.NET Core MVC (.NET 9)
ORM: Entity Framework Core
Veritabanı: PostgreSQL
Frontend: Razor View
Dil: C#
Versiyon kontrol: Git & GitHub

Kullanıcı Girişi
Kullanıcı adı ve şifre ile giriş yapılabilir
Yanlış girişlerde hata mesajı gösterilir

Ürün Yönetimi
Sisteme giriş yaptıktan sonra kullanıcılar:
Ürünleri listeleyebilir
Yeni ürün ekleyebilir
Ürün bilgilerini düzenleyebilir
Ürünleri silebilir

Ürün Bilgileri
Ürün Adı
Açıklama
Fiyat
Stok

KURULUM
projeyi klonlayın
git clone https://github.com/yagmurraydar/UrunYonetimSistemi.git

klasöre git
cd UrunYonetimSistemi

Install Dependencies
Restore .NET packages:
dotnet restore

PostgreSQL içerisinde yeni bir database
CREATE DATABASE urun_db;
Gerekirse appsettings.json dosyasındaki bağlantı dizesini güncelleyin.


Migrationu çalıştır
dotnet ef migrations add InitialCreate
dotnet ef database update

dotnet build
dotnet run

http://localhost:5124/Account/Login

seed kullanıcı
Username: yagmur Password: 1234
http://localhost:5124/Product/Create
http://localhost:5124/Product/Index

Screenshots
Login Page
Product List
Add screen
