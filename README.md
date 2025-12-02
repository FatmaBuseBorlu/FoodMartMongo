# 🛒 FoodMart - ASP.NET Core & MongoDB E-Ticaret Projesi

![FoodMart Banner](https://via.placeholder.com/1000x300?text=FoodMart+Project+Banner)

**FoodMart**, modern web teknolojileri kullanılarak geliştirilmiş, **MongoDB** tabanlı dinamik bir e-ticaret (Süpermarket) uygulamasıdır. **ASP.NET Core MVC** mimarisi üzerine inşa edilmiş olup, katmanlı mimari prensiplerine uygun olarak **Admin Paneli** ve **Vitrin (UI)** tarafını birbirinden ayırır.

Bu proje, statik bir HTML temasını dinamik, veritabanı destekli ve yönetilebilir bir web uygulamasına dönüştürme sürecini kapsar.

---

## 🚀 Temel Özellikler

### 🔹 Müşteri Arayüzü (Vitrin)
* **Dinamik Ana Sayfa:** Slider, Kategoriler ve Ürünler veritabanından (MongoDB) anlık çekilir.
* **ViewComponent Mimarisi:** Sayfa parçaları (Trend Ürünler, En Çok Satanlar, Etiketler) bağımsız ve tekrar kullanılabilir bileşenler olarak tasarlanmıştır.
* **Gelişmiş Ürün Listeleme:** Kategorilere göre filtreleme veya tüm ürünleri listeleme.
* **Bülten Aboneliği:** Kullanıcı mail adresiyle abone olduğunda **SMTP (MailKit)** üzerinden otomatik %25 indirim kuponu gönderilir.

### 🔹 Yönetim Paneli (Admin)
* **Güvenli Giriş Sistemi:** `AspNetCore.Identity.MongoDbCore` ile güvenli Admin Login/Register işlemleri.
* **CRUD İşlemleri:**
    * **Ürün Yönetimi:** Ürün ekle, sil, güncelle, listele.
    * **Kategori Yönetimi:** Kategori işlemleri.
    * **Slider & Özellikler:** Ana sayfa manşet ve "İnsanlar Bunları Arıyor" etiketlerinin yönetimi.
* **Modern Admin Teması:** **Spike Tailwind CSS Admin Template** entegrasyonu ile şık ve kullanıcı dostu panel.

---

## 🛠️ Kullanılan Teknolojiler

| Kategori | Teknoloji |
|----------|-----------|
| **Backend** | ASP.NET Core 6.0 / 8.0 (MVC) |
| **Veritabanı** | MongoDB (NoSQL) |
| **ORM / Sürücü** | MongoDB.Driver |
| **Kimlik Doğrulama** | AspNetCore.Identity.MongoDbCore |
| **Nesne Eşleme** | AutoMapper |
| **Mail Gönderimi** | MailKit (SMTP) |
| **Frontend (Vitrin)** | Bootstrap 5, SwiperJS, HTML5, CSS3 |
| **Frontend (Admin)** | Spike Tailwind CSS Admin Template |
| **Mimari** | N-Tier Architecture (Entity, DTO, Service, Controller Layers) |

---

## 📸 Proje Arayüzü ve Özellikler

Uygulamanın modern ve kullanıcı dostu arayüzünden kareler:

<div align="center">

  <h3>🛒 Vitrin (Müşteri Arayüzü)</h3>
  <p>Kullanıcıların ürünleri incelediği, dinamik slider ve kategori alanlarına sahip ana sayfa.</p>
  <img src="Görseller/HomePage.png" width="800" alt="Ana Sayfa Görünümü">
  <br><br>

  <h3>🛍️ Ürün Detay & Sepet</h3>
  <p>Hızlı sepete ekleme, detaylı ürün inceleme ve dinamik sepet yönetimi.</p>
  <table align="center">
    <tr>
      <td><img src="Görseller/ProductList.png" width="400" alt="Ürün Listesi"></td>
      <td><img src="Görseller/Cart.png" width="400" alt="Sepet Görünümü"></td>
    </tr>
  </table>

  <br><hr><br>

  <h3>🔐 Yönetici Paneli (Admin Dashboard)</h3>
  <p>Spike Tailwind teması ile güçlendirilmiş, modern ve responsive yönetim paneli.</p>
  <img src="Görseller/AdminDashboard.png" width="800" alt="Admin Paneli">
  <br><br>

  <h3>📦 Ürün & Kategori Yönetimi</h3>
  <p>Admin panelinden kolayca ürün ekleme, güncelleme ve stok takibi işlemleri.</p>
  <table align="center">
    <tr>
      <td><img src="Görseller/ProductAdd.png" width="400" alt="Ürün Ekleme"></td>
      <td><img src="Görseller/CategoryList.png" width="400" alt="Kategori Listesi"></td>
    </tr>
  </table>

  <br><hr><br>

  <h3>🔑 Güvenlik & Giriş</h3>
  <p>MongoDB Identity altyapısı ile güvenli Admin giriş ve kayıt ekranları.</p>
  <table align="center">
    <tr>
      <td><img src="Görseller/Login.png" width="400" alt="Giriş Ekranı"></td>
      <td><img src="Görseller/Register.png" width="400" alt="Kayıt Ekranı"></td>
    </tr>
  </table>

  <br><hr><br>

  <h3>✉️ Bülten & İletişim</h3>
  <p>Kullanıcıların mail bültenine abone olması ve otomatik indirim kodu gönderimi.</p>
  <img src="Görseller/Newsletter.png" width="800" alt="Bülten Alanı">

</div>

---

## ⚙️ Kurulum ve Çalıştırma

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

### 1. Projeyi Klonlayın
```bash
git clone [https://github.com/kullaniciadiniz/foodmart-mongo.git](https://github.com/kullaniciadiniz/foodmart-mongo.git)
