# 🛒 FoodMart -MongoDB E-Ticaret Projesi


**FoodMart**, modern web teknolojileri kullanılarak geliştirilmiş, **MongoDB** tabanlı dinamik bir e-ticaret (Süpermarket) uygulamasıdır. **ASP.NET Core MVC** mimarisi üzerine inşa edilmiş olup, katmanlı mimari prensiplerine uygun olarak **Admin Paneli** ve **Vitrin (UI)** tarafını birbirinden ayırır.

Bu proje, statik bir HTML temasını dinamik, veritabanı destekli ve yönetilebilir bir web uygulamasına dönüştürme sürecini kapsar.

---

## 🚀 Temel Özellikler

### Müşteri Arayüzü (Vitrin)
* **Dinamik Ana Sayfa:** Slider, Kategoriler ve Ürünler veritabanından (MongoDB) anlık çekilir.
* **ViewComponent Mimarisi:** Sayfa parçaları (Trend Ürünler, En Çok Satanlar, Etiketler) bağımsız ve tekrar kullanılabilir bileşenler olarak tasarlanmıştır.
* **Gelişmiş Ürün Listeleme:** Kategorilere göre filtreleme veya tüm ürünleri listeleme.
* **Bülten Aboneliği:** Kullanıcı mail adresiyle abone olduğunda **SMTP (MailKit)** üzerinden otomatik %25 indirim kuponu gönderilir.

### Yönetim Paneli (Admin)
* **Güvenli Giriş Sistemi:** `AspNetCore.Identity.MongoDbCore` ile güvenli Admin Login/Register işlemleri.
* **CRUD İşlemleri:**
    * **Ürün Yönetimi:** Ürün ekle, sil, güncelle, listele.
    * **Kategori Yönetimi:** Kategori işlemleri.
    * **Slider & Özellikler:** Ana sayfa manşet ve "İnsanlar Bunları Arıyor" etiketlerinin yönetimi.
* **Modern Admin Teması:** **Spike Tailwind CSS Admin Template** entegrasyonu ile şık ve kullanıcı dostu panel.

---

## 🛠️ Mimari ve Kullanılan Teknolojiler

Projenin altyapısı, performans, ölçeklenebilirlik ve temiz kod prensipleri gözetilerek oluşturulmuştur. Aşağıda projede kullanılan temel teknolojiler ve kullanım amaçları detaylandırılmıştır:

### Backend (Sunucu Tarafı)
Projenin temelinde, Microsoft'un açık kaynaklı ve çapraz platform destekli **ASP.NET Core MVC (6.0/8.0)** framework'ü yer almaktadır. Kodun sürdürülebilirliğini sağlamak adına **N-Tier (Katmanlı Mimari)** yapısı benimsenmiş; Entity, Data Access, Business ve UI katmanları mantıksal olarak ayrılmıştır.

### Veritabanı (Database)
Klasik ilişkisel veritabanları yerine, büyük veri yönetimi ve esnek şema yapısı sunan NoSQL teknolojisi **MongoDB** tercih edilmiştir. Veritabanı ile iletişim, **MongoDB.Driver** kütüphanesi üzerinden sağlanmaktadır.

### Güvenlik ve Kimlik Doğrulama
Kullanıcı yönetimi ve admin paneli güvenliği için **AspNetCore.Identity.MongoDbCore** kütüphanesi entegre edilmiştir. Bu sayede, Identity mekanizmasının sağladığı güçlü güvenlik özellikleri (Login, Register, Role Management) MongoDB üzerinde sorunsuz çalışmaktadır.

### Frontend (Arayüz)
* **Müşteri Tarafı:** Kullanıcı dostu ve mobil uyumlu bir deneyim için **Bootstrap 5** grid sistemi, **HTML5** ve **CSS3** kullanılmıştır. Ürün kaydırma efektleri için **SwiperJS** kütüphanesinden yararlanılmıştır.
* **Admin Tarafı:** Yönetim panelinde modern ve şık bir görünüm elde etmek için **Tailwind CSS** tabanlı **Spike Admin Template** projeye entegre edilmiştir.

### Yardımcı Araçlar ve Kütüphaneler
* **AutoMapper:** Entity ve DTO (Data Transfer Object) nesneleri arasındaki veri transferini otomatikleştirmek için kullanılmıştır.
* **MailKit:** Bülten aboneliği gibi e-posta gönderim işlemleri için .NET'in en güçlü mail kütüphanesi olan MailKit (SMTP) tercih edilmiştir.

---

## 📸 Proje Arayüzü ve Özellikler

<p align="center">
 Uygulamanın müşteri tarafı vitrini, yönetici paneli ve mail entegrasyonu ile ilgili temel ekran görüntüleri aşağıda listelenmiştir.
</p>

<p align="center">
  <img src="ımages/Home.png"
       alt="Ana Sayfa Görünümü"
       style="max-width: 800px; width: 100%; aspect-ratio: 16/9; object-fit: cover; border-radius: 8px;">
</p>

---

### 🧺 Ürün Detay ve Sepet Yönetimi

<p align="center">
  Hızlı sepete ekleme, detaylı ürün inceleme ve dinamik sepet yönetimi ekranları.
</p>

<p align="center">
  <table width="100%">
    <tr>
      <td width="50%" align="center" valign="top">
        <img src="ımages/AllProduct.png"
             alt="Ürün Listeleme"
             style="width: 100%; aspect-ratio: 16/9; object-fit: cover; border-radius: 8px;"><br>
        <i>Ürün Listeleme</i>
      </td>
      <td width="50%" align="center" valign="top">
        <img src="ımages/MostPopulerProduct.png"
             alt="Popüler Ürünler Vitrini"
             style="width: 100%; aspect-ratio: 16/9; object-fit: cover; border-radius: 8px;"><br>
        <i>Popüler Ürünler Vitrini</i>
      </td>
    </tr>
  </table>
</p>

---

### 🔐 Yönetici Paneli Admin Dashboard

<p align="center">
  Spike Tailwind teması ile geliştirilmiş, modern ve responsive yönetim paneli.
</p>

<p align="center">
  <img src="ımages/AdminPanel.png"
       alt="Admin Paneli"
       style="max-width: 800px; width: 100%; aspect-ratio: 16/9; object-fit: cover; border-radius: 8px;">
</p>

---

### 📦 Ürün ve Kategori Yönetimi

<p align="center">
  Admin paneli üzerinden ürün ve kategori ekleme, güncelleme ve listeleme ekranları.
</p>

<p align="center">
  <table width="100%">
    <tr>
      <td width="50%" align="center" valign="top">
        <img src="ımages/ProductList.png"
             alt="Ürün Yönetim Tablosu"
             style="width: 100%; aspect-ratio: 16/9; object-fit: cover; border-radius: 8px;"><br>
        <i>Ürün Yönetim Tablosu</i>
      </td>
      <td width="50%" align="center" valign="top">
        <img src="ımages/CategoryList.png"
             alt="Kategori Yönetimi"
             style="width: 100%; aspect-ratio: 16/9; object-fit: cover; border-radius: 8px;"><br>
        <i>Kategori Yönetimi</i>
      </td>
    </tr>
  </table>
</p>

<p align="center">
  <table width="100%">
    <tr>
      <td width="50%" align="center" valign="top">
        <img src="ımages/CreateProduct.png"
             alt="Ürün Ekleme Formu"
             style="width: 100%; aspect-ratio: 16/9; object-fit: cover; border-radius: 8px;"><br>
        <i>Ürün Ekleme Formu</i>
      </td>
      <td width="50%" align="center" valign="top">
        <img src="ımages/CreateCategory.png"
             alt="Kategori Ekleme Formu"
             style="width: 100%; aspect-ratio: 16/9; object-fit: cover; border-radius: 8px;"><br>
        <i>Kategori Ekleme Formu</i>
      </td>
    </tr>
  </table>
</p>

---

### 🔑 Güvenli Giriş ve Kayıt Ekranları

<p align="center">
  MongoDB Identity altyapısı ile güvenli admin giriş ve kayıt akışı.
</p>

<p align="center">
  <table width="100%">
    <tr>
      <td width="50%" align="center" valign="top">
        <img src="ımages/Login1.png"
             alt="Giriş Ekranı"
             style="width: 100%; aspect-ratio: 16/9; object-fit: cover; border-radius: 8px;"><br>
        <i>Giriş Ekranı</i>
      </td>
      <td width="50%" align="center" valign="top">
        <img src="ımages/Register1.png"
             alt="Kayıt Ekranı"
             style="width: 100%; aspect-ratio: 16/9; object-fit: cover; border-radius: 8px;"><br>
        <i>Kayıt Ekranı</i>
      </td>
    </tr>
  </table>
</p>

---

### ✉️ Bülten Aboneliği ve Mail Gönderimi

<p align="center">
  Kullanıcıların mail bültenine abone olması ve otomatik indirim kodu içeren mail örneği.
</p>

<p align="center">
  <img src="ımages/Mail.png"
       alt="Bülten Alanı"
       style="max-width: 800px; width: 100%; aspect-ratio: 16/9; object-fit: cover; border-radius: 8px;">
</p>

<p align="center">
  <img src="ımages/MailMessage.png"
       alt="Gönderilen Mail Örneği"
       style="max-width: 800px; width: 100%; aspect-ratio: 16/9; object-fit: cover; border-radius: 8px;">
</p>
