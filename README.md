# FundementalsProject

Patika.Dev Ödevi - C# Temel Uygulamalar
Bu proje, Patika.dev için yapılmış bir ödevdir. Bu projede, C# dilinde yazılmış üç farklı konsol uygulaması bulunmaktadır. Her biri, farklı türlerde metodlar kullanarak temel programlama yapılarının kullanımını göstermektedir.

# İçindekiler
# Projeye Genel Bakış
# Kullanılan Teknolojiler
# Program Açıklamaları
   #Rastgele Sayı Bulma Oyunu
  #Hesap Makinesi
  #Ders Notu Ortalaması Hesaplama

## Projeye Genel Bakış
Bu proje, üç farklı konsol uygulamasını içermektedir:

Rastgele Sayı Bulma Oyunu
Hesap Makinesi
Ders Notu Ortalaması Hesaplama
Her bir uygulama, farklı metod türlerinin kullanımını göstermek amacıyla tasarlanmıştır:

Parametre almayan ve değer döndürmeyen metodlar.
Parametre almayıp değer döndüren metodlar.
Parametre alıp değer döndüren metodlar.
## Kullanılan Teknolojiler
C#: Bu projede kullanılan ana programlama dilidir.
.NET Core Console Application: Konsol uygulamalarının çalıştırılabilmesi için .NET Core kullanılmıştır.
## Program Açıklamaları
1. Rastgele Sayı Bulma Oyunu
Bu program, kullanıcıdan 1 ile 100 arasında bir sayı tahmin etmesini isteyen bir oyun sunar. Kullanıcının 5 tahmin hakkı vardır. Doğru sayıyı tahmin edemezse, oyun sonunda doğru sayı gösterilir.

Kullanılan Metod:

FindRandomValue(): Bu metod, parametre almayan ve değer döndürmeyen bir metoddur. Rastgele bir sayı üretir ve kullanıcının tahminlerini değerlendirir.
2. Hesap Makinesi
Bu program, iki sayı ve bir işlem türü (toplama, çıkarma, çarpma, bölme) alarak basit bir hesaplama yapar. Bölme işlemi sırasında sıfıra bölme hatasını önlemek için kullanıcı uyarılır.

Kullanılan Metod:

Counter(int num1, int num2, char op): Bu metod, parametre alıp değer döndüren bir metoddur. İki sayı ve bir işlem türü alır ve bu işlem sonucunu döndürür.
3. Ders Notu Ortalaması Hesaplama
Bu program, kullanıcının üç ders notunu alır ve bu notların ortalamasını hesaplayarak bir harf notu döndürür.

Kullanılan Metod:

CountGrade(): Bu metod, parametre almayan ama bir string değer döndüren bir metoddur. Kullanıcının girdiği notların ortalamasına göre bir harf notu belirler.
## Kurulum ve Çalıştırma
Projeyi klonlayın veya indirin.
.NET Core yüklü bir ortamda projeyi çalıştırın.
Konsol üzerinden kullanıcıdan program seçimi yapması istenir. Gerekli bilgileri girerek istediğiniz programı çalıştırabilirsiniz.
