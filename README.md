🌦️ Meteoroloji Genel Müdürlüğü (MGM) MVC Weather App

Bu proje, Meteoroloji Genel Müdürlüğü (MGM) tarafından sunulan herkese açık API uç noktalarını kullanarak geliştirilmiş bir ASP.NET MVC tabanlı hava durumu uygulamasıdır.

Uygulama; istasyon listeleme, detay görüntüleme, harita üzerinden konum gösterimi, saatlik/günlük tahminler ve son durum verilerinin görüntülenmesini sağlar.


---

🚀 Özellikler

📋 İstasyon Listeleme

Sayfalama (Pagination) desteği

İl / İlçe bazlı filtreleme


🔍 İstasyon Detay Ekranı

Seçilen istasyona ait temel bilgiler


🗺️ Harita Entegrasyonu

İstasyon konumunun harita üzerinde gösterimi


⏱️ Saatlik Hava Durumu

İstasyona ait saatlik tahmin verileri


📅 Günlük Hava Durumu (5 Günlük)

Günlük sıcaklık ve hava durumu tahminleri


📊 Son Durum Bilgileri

Anlık gözlem ve ölçüm değerleri




---

🏗️ Kullanılan Teknolojiler

ASP.NET MVC

C#

HttpClient

Bootstrap (UI)

JavaScript / jQuery

Leaflet / Google Maps (Harita gösterimi)



---

🌐 MGM API Bilgileri

🔑 Base URL

https://servis.mgm.gov.tr


---

📌 Header Bilgileri

Aşağıdaki header bilgileri tüm isteklerde zorunlu olarak kullanılmaktadır:

Key	Value

Host	servis.mgm.gov.tr
Connection	keep-alive
Accept	application/json, text/plain, /
User-Agent	Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.122 Safari/537.36
Origin	https://www.mgm.gov.tr



---

🔗 Kullanılan API Endpointleri

1️⃣ İller (81 İl)

GET /web/merkezler/iller

Örnek:

https://servis.mgm.gov.tr/web/merkezler/iller


---

2️⃣ İl İstasyon Bilgileri

GET /web/merkezler?il={ilAdi}

Örnek:

https://servis.mgm.gov.tr/web/merkezler?il=bolu


---

3️⃣ İl + İlçe İstasyon Bilgileri

GET /web/merkezler?il={ilAdi}&ilce={ilceAdi}

Örnek:

https://servis.mgm.gov.tr/web/merkezler?il=bolu&ilce=merkez


---

4️⃣ İl Tüm İstasyonlar (İl + İlçeler)

GET /web/merkezler/ililcesi?il={ilAdi}

Örnek:

https://servis.mgm.gov.tr/web/merkezler/ililcesi?il=bolu


---

5️⃣ Günlük Hava Durumu (5 Günlük Tahmin)

GET /web/tahminler/gunluk?istno={istasyonNo}

Örnek:

https://servis.mgm.gov.tr/web/tahminler/gunluk?istno=17020


---

6️⃣ Saatlik Hava Durumu

GET /web/tahminler/saatlik?istno={istasyonNo}

Örnek:

https://servis.mgm.gov.tr/web/tahminler/saatlik?istno=17020


---

7️⃣ Son Durum Bilgileri

GET /web/sondurumlar?merkezid={merkezId}

Örnek:

https://servis.mgm.gov.tr/web/sondurumlar?merkezid=17020


---

8️⃣ Tüm İstasyonlar

GET /web/istasyonlar

Örnek:

https://servis.mgm.gov.tr/web/istasyonlar


---

🖥️ Uygulama Ekranları

İstasyon Listeleme (Sayfalı)

İstasyon Detay

Harita Üzerinde Konum Gösterimi

Saatlik Tahminler

Günlük Tahminler

Son Durum Bilgileri



---

⚠️ Önemli Notlar

MGM API’leri resmi dokümantasyona sahip değildir.

API’ler herkese açık olmakla birlikte, yoğun kullanımda kısıtlamalar uygulanabilir.

Header bilgileri eksik gönderildiğinde 403 Forbidden hatası alınabilir.



---

📌 Geliştirme & Katkı

Oğuz Taşkın (oguz-taskin) 

---

📄 Lisans

Bu proje eğitim ve örnek amaçlı geliştirilmiştir. MGM servisleri üzerindeki tüm haklar Meteoroloji Genel Müdürlüğü’ne aittir.


---

⭐ Projeyi faydalı bulduysanız yıldızlamayı unutmayın!
