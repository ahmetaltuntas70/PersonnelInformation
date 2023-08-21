# PersonnelInformation

Bu proje HUMAN GROUP .NET 6 EĞİTİMİ 1. BİREYSEL PROJE ÖDEVİ (A) olarak geçmektedir.
Personnel Information projesinde Asp.Net Mvc (.Net Framework) ve Sql Server kullanılmıştır.
Projenin amacı personel listeleme, ekleme, silme ve güncelleme işlemlerinin gerçekleşmesidir. 
Katmanlı mimari olarak PersonnelInformationUI-PersonnelInformationEL-PersonnelInformationDL katmanları
kullanılmıştır. PersonnelInformationEL katmanında Entities klasörü içinde personnel sınıfı oluşturularak 
gerekli değerler ekledikten sonra Code First yaklaşımı kullanılmıştır. PersonnelInformationDL katmanında ise
Context klasörü içinde MyContext sınıfı oluşturularak veri tabanı için kodlar tutulmuştur.
PersonnelInformationUI katmanında yeni bir PersonnelController oluşturarak listeleme, ekleme,
silme ve güncelleme (crud) işlemlerini HttpGet ve HTTPPost (attributes) yapılarak controller tarafında kodlar 
tutulmuştur. Yeni bir _LayoutPersonnel (view) oluşturularak Space (template) temasının index
sayfasındaki kodlarını içine ekledik ve gerekli düzenlemeleri yaptıktan sonra _LayoutPersonnel'e bağlı olarak 
PersonnelController tarafında oluşturulan denetleyici olarak Index (personel listesi), AddPersonnel (personel ekleme)
ve FillPersonnel (personel güncelleme ) (views) sayfa görünümlerinden yararlanılarak gerekli kodlar tutulmuştur. 

Proje Ekran Görüntüleri: 

![1](https://github.com/ahmetaltuntas70/PersonnelInformation/assets/111458472/d1508a68-8613-4629-a8cb-4a69e6a3c63f)
![2](https://github.com/ahmetaltuntas70/PersonnelInformation/assets/111458472/cb837fe8-d866-47cf-aa96-9245041639ab)
![3](https://github.com/ahmetaltuntas70/PersonnelInformation/assets/111458472/118e9bf2-a0ff-4174-9f5a-0bfb61a465ad)
![4](https://github.com/ahmetaltuntas70/PersonnelInformation/assets/111458472/8c1ab226-0ec8-4b9e-a9d2-6fcfe70eacf5)
![5](https://github.com/ahmetaltuntas70/PersonnelInformation/assets/111458472/776b541a-68bf-42d9-8346-29dae104f86c)
![01](https://github.com/ahmetaltuntas70/PersonnelInformation/assets/111458472/f3814c35-2d11-4b1d-bc97-803e32878eeb)
![02](https://github.com/ahmetaltuntas70/PersonnelInformation/assets/111458472/5e363255-7a13-4f69-83b6-8b67a7b653f9)
![03](https://github.com/ahmetaltuntas70/PersonnelInformation/assets/111458472/6d288dce-c1bb-44e9-b282-53b2940bf10e)
![04](https://github.com/ahmetaltuntas70/PersonnelInformation/assets/111458472/8a06dbc5-70e6-4bc1-b24f-ca633963f207)


