# :gem:ASP.NET Core 6.0 ile Admin Panelli Portföy Sitesi
Bu repository, Murat Yücedağ'ın Udemy'de bulunan Asp.Net Core ile Portfolyo Uygulamanızı Geliştirin Part-1 & Part-2 kursunu içermektedir. Bu eğitimde bana yol gösteren Murat Yücedağ'a çok teşekkür ederim.

ASP.NET Core Web Application (.NET Core Framework) kullanarak dinamik bir Portföy sitesi oluşturdum. Bu projede tek katman üzerinde çalıştım. Klasör tasarımını bozmadan katmanlı mimari düzenini tek katmanda kurmaya çalıştım. SOLID prensiplerine ve dosya organizasyonuna uygun şekilde geliştirme yaparak kod tekrarını en aza indirmeye çalıştım. Entity Framework Core - Code First yaklaşımını kullanarak veritabanı bağlantılarını oluşturdum.

Genel anlamda tek katman üzerinde projeyi oluşturmama rağmen klasör tasarımı ile DataAccessLayer ve UI Layer olarak iki katman kullandım. Data Access Layer (Veri Erişim Katmanı), veritabanı ile etkileşimi sağlar. Burada veri tabanındaki verileri gereken şekilde kullandım. Entity Layer (Varlık Katmanı), verileri saklayan katmandır. Burası Code-First yaklaşımının başlangıcıdır. Veri tabanındaki tablolar ve sütunlar yerine bu katmanda sınıflar ve property'ler kullandım. UI Layer (Sunum Katmanı) ise kullanıcının görüntülediği bölümdür. Burada arayüz tasarımlarını oluşturdum. 

Bu projede değiştirilmesi gereken bazı noktalar olabilir fakat burada asıl amaç Back-end Development anlamında .Net Core ile admin panelli bir sistem kurmaktır. Front-end anlamında düzeltmeler yapılabilir.

Projede genel anlamda 3 farklı bölüm bulunmaktadır;

1- Admin Paneli: Adminler'in hakkımda, yetenekler, deneyimler, referanslar, mesajlar gibi alanlar ile ilgili CRUD (Create, Read, Update, Delete) işlemlerinin yaptığı bölümdür.  
2- Ana Sayfa: Burada da Melih Çolak ve hayatı ile ilgili bilgiler yer alıyor.

## :arrow_forward: Projeden Ekran Görüntüleri

### :triangular_flag_on_post: Ana Sayfa DEVAMMM....
Öne Çıkan bölümünde ismim, pozisyonum ve sosyal medya hesaplarım yer almaktadır. Bu sayfa, kullanıcıyı karşılayan giriş sayfası olarak düşünülebilir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/showCaseFeature.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Hakkımda Bölümü
Hakkımda bölümünde kendim ile daha detaylı bir bilgi, fotoğrafım ve kişisel bilgilerim yer almaktadır. Telefon numaram, mail üzerinden iletişime geçildiğinde uygun görülürse verilecektir.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/showCaseAbout.jpg" alt="image alt">
</div>

### :triangular_flag_on_post: Hizmetler Bölümü
Hizmetler bölümünde bu projeyi yaparken kullandığım teknolojilerden bazılarını gösterdim.
<div align="center">
  <img src="https://github.com/melihcolak0/NETCore_Portfolio/blob/c9017bd684dc5e65ee5a89186e79b84a93318a17/ss/showCaseService.jpg" alt="image alt">
</div>
