# 💈 Kuaför Otomasyon Sistemi

Bu proje, **tamamen internetsiz (offline) çalışan**, tüm kuaför salonlarına uygun şekilde geliştirilmiş **C# WinForms tabanlı masaüstü kuaför otomasyon sistemidir**.

Sistem; kuaför işletmelerinin **randevu, müşteri, çalışan (personel), envanter ve genel işletme yönetimini** tek bir platform üzerinden düzenli, hızlı ve güvenli biçimde yönetebilmesini amaçlamaktadır.

---

## 🎯 Projenin Amacı

Kuaför salonlarında yaşanan;

- Randevu karışıklığı  
- Müşteri takibinin düzensiz olması  
- Personel yönetiminin zorlaşması  
- Stok ve malzeme kontrolünün manuel yapılması  
- Günlük iş yükünün artması  

gibi problemleri ortadan kaldırmak amacıyla **kapsamlı bir otomasyon sistemi** geliştirilmiştir.

Bu sistem sayesinde tüm kuaför süreçleri **tek merkezden yönetilebilir hale gelmiştir.**

---

## ⚙️ Genel Özellikler

- ✅ Tamamen internetsiz (offline) çalışma
- ✅ C# WinForms masaüstü uygulaması
- ✅ Admin Paneli & Personel Paneli
- ✅ Çalışan (personel) yönetim sistemi
- ✅ Randevu planlama sistemi
- ✅ Müşteri takip sistemi
- ✅ Envanter & stok yönetimi
- ✅ Progress Bar ile stok görselleştirme
- ✅ Yerel Access veritabanı kullanımı
- ✅ Kullanıcı yetkilendirme sistemi

---

## 🧩 Sistem Modülleri

### 👤 Kullanıcı Yönetimi
- Yönetici ve personel için ayrı giriş sistemi
- Rol bazlı yetkilendirme
- Güvenli kullanıcı doğrulama

---

### 🧑‍💼 Çalışan (Personel) Yönetimi
- Personel kayıt işlemleri
- Personel bilgileri yönetimi
- Aktif / pasif personel durumu
- Çalışan bazlı randevu takibi
- Personel kullanıcı adı ve şifre tanımlama

---

### 📅 Randevu Sistemi
- Müşteri bazlı randevu oluşturma
- Personel bazlı randevu planlama
- Günlük ve haftalık randevu takibi
- Randevu çakışmalarının önlenmesi
- Randevu güncelleme ve silme işlemleri

---

### 👥 Müşteri Yönetimi
- Müşteri kayıt sistemi
- Müşteri iletişim bilgileri
- Geçmiş randevu takibi
- Hızlı müşteri arama ve filtreleme

---

### 📦 Envanter & Stok Yönetimi
- Kuaför malzemelerinin takibi
- Ürün ekleme, silme, güncelleme
- Stok giriş – çıkış işlemleri
- Azalan stok kontrolü
- Progress Bar ile stok durumu görüntüleme

---

### 🧑‍💻 Yönetici Paneli
- Tüm sistemin merkezi yönetimi
- Kullanıcı ve personel yönetimi
- Envanter kontrolü
- Randevu kontrolü
- Hesap yönetimi

---

### 🙋‍♂️ Personel Paneli
- Kendi randevularını görüntüleme
- Müşteri işlemleri
- Yetki sınırlandırılmış sistem erişimi

---

## 🖥️ Kullanılan Teknolojiler

- C# 
- Windows Forms (WinForms)
- Microsoft Access Database
- ADO.NET
- Katmanlı mimari yapı

---

## 🏗️ Mimari Yapı

- Presentation Layer (WinForms UI)
- Business Layer (İş kuralları)
- Data Access Layer (Veritabanı işlemleri)
- Entity / Model yapısı

Bu yapı sayesinde sistem:

- Modüler
- Genişletilebilir
- Bakımı kolay

bir mimariye sahiptir.

---

# 🔧 PROJE KURULUMU VE KULLANIM KILAVUZU

---

## 📁 Klasör Yapısı

- Proje ve tüm kaynak kodlar **Kuaför** klasörü içerisinde bulunmaktadır.

- Veritabanı dosyaları:
  **Kuaför → bin → Debug** klasörü içindedir.  
  Toplamda **5 adet Access veritabanı dosyası** bulunmaktadır.

- Setup dosyası:
  **Kuaför Otomasyonu → Debug** klasörü içerisindedir.

---

## 💿 Setup Dosyası Kurulumu

1. **Kuaför Otomasyonu** klasörünü açınız  
2. **Debug** klasörüne giriniz  
3. **Setup** dosyasını **yönetici olarak çalıştırınız**

---

### ⚠️ Kurulum Esnasında Dikkat Edilmesi Gerekenler

- Kurulum sırasında:
  **Yükleme klasörü seçimi ekranında “Herkes (Everyone)” seçilmelidir.**

- Proje yerel veritabanı kullandığı için:
  - Setup mutlaka yönetici olarak çalıştırılmalıdır
  - Uygulama yönetici olarak açılmalıdır

Bu işlem veritabanı hatalarının önüne geçmektedir.

---

## ⚠️ Yönetici Olarak Çalıştırma (ÇOK ÖNEMLİ)

- Proje ilk kez çalıştırılırken:
  - Visual Studio yönetici olarak açılmalıdır

- Kod çalıştırıldığında form ortamı kapanırsa:
  1. Projeyi kapatın  
  2. Kuaför klasöründen tekrar açın  
  3. Yönetici olarak yeniden çalıştırın  

Bu işlem uygulamanın tam yetkili çalışmasını sağlar.

---

## 🗄️ Veritabanı Bilgilendirmesi (ÇOK ÖNEMLİ)

- Kullanılan veritabanı: **Microsoft Access**
- Access sürümü: **12.0**
- Sağlayıcı: **Microsoft.ACE.OLEDB.12.0**

### Olası Hata
> Microsoft.ACE.OLEDB.12.0 sağlayıcısı yerel makineye kayıtlı değil

Bu hata Access 12.0 yüklü değilse görülür.

### Çözüm
- Proje klasörleri yanında bulunan  
  **AccessDatabaseEngine** dosyası çalıştırılarak  
  Access 12.0 kurulmalıdır.

Kurulum sonrası sistem sorunsuz çalışır.

---

## 🔐 Giriş Ekranları

### 👨‍💼 Yönetici Girişi
- Kullanıcı adı: **yönetici**
- Şifre: **2312**

Yönetici bu bilgileri panelden değiştirebilir.  
Şifre unutulursa **Şifremi Unuttum** alanı kullanılabilir.

---

### 👷 Personel Girişi

Personel kullanıcı adı ve şifreleri yönetici tarafından belirlenir.

Örnek personel:

- Ad: **Ali Aslan**
- Kullanıcı adı: **ali**
- Şifre: **250900**

---

## 📊 Progress Bar Kullanımı

- Yönetici Paneli → Envanter Yönetimi
- Ürüne çift tıklanır
- Stok durumu Progress Bar üzerinde görüntülenir

---

## 🔄 Veritabanı Güncelleme İşlemleri

- DataGridView üzerine çift tıklanır
- Ekle butonu otomatik olarak Güncelle olur
- Güncelleme işlemi bu buton ile yapılır

---

## 📌 Hedef Kitle

- Kuaför salonları
- Berberler
- Güzellik merkezleri
- Küçük ve orta ölçekli işletmeler

---


## 👨‍💻 Geliştirici

**Yunus Güçlü**  
Software Enginer

---

## 📄 Lisans

Bu proje kişisel olarak geliştirilmiştir.
Ticari kullanım için geliştirici izni gereklidir.
