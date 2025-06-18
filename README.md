# CSharp Eğitim Kampı 301

Bu proje, C# diliyle çok katmanlı (N-tier) mimariyi temel alan bir eğitim amaçlı uygulamadır. Katmanlı yapı sayesinde kodlar **Entity**, **Data Access**, **Business** ve **Presentation** olarak katmanlara ayrılmıştır. Amaç, gerçek dünya yazılım mimarisini örnekleyerek kurumsal uygulama geliştirme pratiği sunmaktır.

## 📁 Proje Yapısı

```
CSharpEgitimKampi301/
├── CSharpEgitimKampi301.PresentationLayer  # Kullanıcı arayüzü veya test katmanı
├── CSharpEgitimKampi301BusinessLayer       # İş mantığı – servisler, kurallar
├── CSharpEgitimKampi301DataAccessLayer     # Veritabanı erişimi – Repository yapısı
├── CSharpEgitimKampi301.EntityLayer        # Entity sınıfları (Model tanımları)
├── CSharpEgitimKampi301.EFProject          # Entity Framework yapılandırması ve form uygulama örnekleri
```

## 🧰 Kullanılan Teknolojiler

- C# ve .NET Framework
- Entity Framework (ORM)
- Katmanlı Mimari (N-tier Architecture)
- Repository Pattern



## 🧱 Katman Açıklamaları

- **Entity Layer**: Uygulamanın temel veri modelleri burada yer alır. Concrete dosyası içine modeller eklenmiştir.
- **Data Access Layer**: Entity Framework kullanılarak veritabanı işlemleri gerçekleştirilir. Modeller için ortak ve özel interface yapıları burada oluşturulur.
- **Business Layer**: Uygulama iş kuralları ve servis yapısı burada tanımlıdır.
- **Presentation Layer**: Kullanıcıya sunulan arayüz veya test senaryoları bu katmanda yer alır.
- **EFProject**: Entity Framework pratiği yapılırken oluşturulan form uygulamaları burada bulunmaktadır. 3 ayrı form uygulaması vardır. Birincisinde (Form1.cs) sisteme tur rehberleri için CRUD işlemleri yapılıyor. İkinci form içinde (FrmLocation) sisteme yapılacak turlar hakkında bilgiler girilmektedir. Son from içinde (FrmStatistics.cs) veri tabanına kaydedilmiş olan turlar hakkında bazı istatistiksel bilgiler rapor edilmiştir.
  
![image](https://github.com/user-attachments/assets/af92ead6-2ac2-4ca5-907a-280288d82fc4)

- 
