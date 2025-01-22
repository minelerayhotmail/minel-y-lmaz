namespace _17_MethMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mathmetotları matematiksel metotlar. math classı üzerinden erişiyoruz. datetıme için datetıme sınıfından eriştiğimiz gibi.
            //dizilerde array sınıfı üzerinden eriştiğimiz gibi aynı mantık. math matematiğin kısaltımı.
            //örneğin biz en büyüğünü bulmak istediğimizde max metodunu kullanmamız gerekiyor. parantezini açtığımda benden ne istediğini görebiliyorum.
            //burda diyor ki max metodunu byteleri karşılaştırmak için kullanabilirsin yani büyüğünü küçüğünü algılamak için.
            //dolayısıyla byte tipiyle çalışırsan dönüşün de byte olur diyor çünkü hangisinin büyük olduğuna bakacak ve büyük olanı ban ödönecek.
            //o yüzden bu paremetreler byte ise geriye dönüş tipi de byte olacak.onu soyluyor üstüne geldiğimde. yine decimal için
            //de aynı şekilde decimal olarak kullanabilirsin, double,int vs. bu şekilde sırayla tüm sayısal tiplerin içinde bunları
            //kullanabileceğimiz şekilde bize dönüyor.
            //ben sol tarafta int tipini verdiğim için int tipinde çalışan versiyonunu kullanıyor olacağım. o yüzden içine 2 tane değer
            //girmem gerekiyor. bu yüzden içine iki tane değer girmem gerekiyor. bu ikisinden hangisini büyük olduğunu kendisi kıyaslayıp
            //bana buyuk olanı dönüyor olacak. 5 ve 10 değerini girdim. 5 birinci sayım 10 ikinci sayım. bu iki sayı arasından büyük olanı
            //kendisi bulup bana dönüyor olacak. yine CW diyorum ekrana yazdıralım. daha önceki derslerde iflerle bu sayı bundan buyukse bunu dön
            //gibi iflerle büyüğü küçüğü buluyorduk. şimdi burda artık math metotlarıyla bunu hiç if kullanmadan tabi elimizde iki sayı varsa.
            //CWyi çalıştırdım buyuksayi dedim ve bana 10u verdi.
            //ben 3 sayı arasında en buyugunu bulmak ıstıyorsam,dolayısıyla bana 3 parametreli çalışan versiyonu bulunmadı.
            //dolayısıyla napmam gerekiyor hemen aynısını alta kopyaladım enbuyuk2 dedım. üstte zaten max metodu bu ıkısınden buyugunu
            //buluyor ve gerıye ınt bır deger donduruyor. dolayısıyla ben bunu da bı math.max içinde kullanırsam, parantez açtım yine
            //8 yazdım virgül koydum ve benim biraz önce çalıştırdığım math metodu. yani bu sağ tarfta ne var artık 5le 10 hangisi buyukse
            //yanı 10 burdan cıktı olarak 10 var dolayısıyla soldakı ekledıgım max metodu napıyor 8le 10u kıyaslıyor.önce ilk oluşturdugum maxi
            //kıyaslıyor sonra ordan cıkan sonucla sonradan olusturdugum max içindeki degerı kıyaslıyor ve sonuc verıyor. dolayısıyla iç içe 
            //girdiği için bunları karıştırmamak gerekiyor. iç içe iki tane üç tane beş tane ekleyerek böyle bir sayının ıkı sayının
            //3 5 8 gibi farklı farklı kıyaslamalar hızlıca yapabiliriz. yine CW ile buyuksayı2 deyıp ekrana yazdıralım. bize yine 10u
            //veriyor olacak. bu şekilde bu üçünün arasında en buyugu buluyor olduk.


            //math.max() en büyük değeri bulmak için kullanılır.
            int enBuyuk = Math.Max(5, 10);
            int enBuyuk2 = Math.Max(18, Math.Max(5, 10));
            Console.WriteLine("büyük sayı: " + enBuyuk);
            Console.WriteLine("büyük sayı:" + enBuyuk2);



            //math.min() en küçük değeri bulmak için kullanılır.
            int enKucuk = Math.Min(5, 10);
            int enKucuk2 = Math.Min(18, Math.Min(5, 10));
            Console.WriteLine("küçük sayı: " + enKucuk);
            Console.WriteLine("küçük sayı:" + enKucuk2);

            //yine yukardaki mantıkla int ya da decamel farketmez örneğin int enkucuk sayıyı bulmak istiyorum.
            //ardından math.min diyorum ve içine 5 ve 10 değerini giriyorum. burda da iki sayı arasında kıyaslama yapıyor ve bana
            //en küçüğünü dönüyor. burda da yukardakı gibi aynı yöntemle 3 sayı ve daha fazlasını kıyaslayabiliriz.



            //math.sqrt(x) paremetre olarak verilen x sayısının karekökünü hesaplayarak geriye döner.
            double karekok = Math.Sqrt(64);
            Console.WriteLine("64'ün karakökü:" + karekok);

            //karekökünü hesaplama ihtiyacımız olduğunda kullanabiliriz. içine bir parametre istiyor. sadece double tipte çalışır.
            //double karekök diyorum eşittir math.sqrt içine double tipte bir değer alıyor ve geriye double tipte dönüyor yani ondalıklı bir sayı dönüyor.
            //örneğin içine 64 verdim. dolayısıyla 64ün karekökünü hesaplayarak geriye dönüyor olacak.




            //math.abs(x) parametre olarak verilen x değerinin mutlak (pozitif) karşılığını geriye dönüyor.
            int mutlakDeger = Math.Abs(-14);
            double mutlakDeger2 = Math.Abs(-14.5);
            Console.WriteLine("-14'ün mutlak değeri:" + mutlakDeger);
            Console.WriteLine("-14.5'in mutlak değeri: " +mutlakDeger2);


            //bunu birden fazla tipte kullanabiliyoruz. örneğin int mutlakdeger diyorum eşittir math.abs içine de herhangibir negatif değer giriyorum.
            //örn. -14. mutlak değerini aldığımızda bize geriye -14 yerine +14 veriyor olacak.
            //örneğin bir de double tipte kullanıyorum. -14.5 burda geriye +14.5 dönüyor olacak.
            //üstüne geldiğimde 8 varyasyonu olduğunu gösteriyor. hepsini ayrı ayrı kullanabiliyorum.




            //özellikle muhahese plrogramlarında vs. virgüllü sayılar çok önemlidir ondan dolayı kullanılır.
            //örneğin 0.0001 lik bir virgüllü sayı bile çok önemli olabilir. o yüzden bu yuvarlama işlemleri çok önemli.
            //bunlar için kullandığımız birkaç metot var.


            //math.round(x) kendisine en yakın tam sayıya yuvarlar.
            double yuvarla1 = Math.Round(7.99);
            double yuvarla2 = Math.Round(7.19);


            double yuvarla3 = Math.Round(4.1245, 2);
            double yuvarla4 = Math.Round(4.1245, 1);
            double yuvarla5 = Math.Round(4.1245, 0);

            //bu metot içilne parametre alır. tek parametre alan haliyle kullanalım. double tipi kullanıyorum. yuvarla1 dilyorum ve math.round
            //parantezi açıyorum ve diyorum ki 7.99 bunu bana yuvarla. burda tek sayı verdiğimiz durumda aslında burdaki x sayısını
            //kendisine en yakın tam sayıya yuvarlar. yani 8. burda 7.5 ve üstüyse bir üstündeki sayıya yuvarlar ama 7.5in altıysa
            //o zaman da 7ye yuvarlar duruma geliyor olacak. burda önemli olan kendisine yakın tam sayıya yuvarlaması.

            //bunu bir versiyonu da yine aynı şekilde yazıyorum ve bunun bır versıyonu daha var yine double
            //aldım ama digıts olarak kac istiyorsun yani ondalıklı sayısının virgülden sonra kaç basamak olacak
            //şekilde yuvarlamasını ıstıyorum. bize onu söyluyor. örneğin parantez içine 4.1245,2 değerini girdim.
            //dolayısıyla bıraz öncekinde tam sayıya yuvarlama yapmıştı şimdi burda yuvarla3 e baktıgımda artık tam sayı değıl
            //burdakını vırgulden sonra ıkı hane olacak sekılde en yakın degere yuvarlıyor. virgulden sonra en yakın olan sayıya yuvarlıyor
            //yanı değerın 4.1251 olsaydı o zaman sonuc 4.13 olacaktı. o mantıkla vırgulden sonra ıkı dıgıts olacak sekılde 
            //yuvarlama ıslemını yaparak gerıye  double tıpte deger dondurmus oldu. eğer vırgulden sonra ıkı dıgıts olarak 
            //döndürmesini istiyorsam 2 yazıyorum
            //aynı mantıkla eger bunun vırgulden sonra tek sayı olmasını ıstıyorsam buraya artık 1i eklıyorum. burda bana
            //4.1 olarak döner ama yukardakı 1in yanındakı sayım 2 degılde 5 ve ustu olsaydı bana 4.2 olarak donerdi.
            //0 girdiğimde de artık herhangıbır vırgullu sayı degıl tam sayı olarak 4 u bana verıyor.



            //math.floor(x) parametre olarak verilen sayıyı bir alt tam sayıya yuvarlar.
            double asagıYuvarla = Math.Floor(7.99);

            //hemen tanımlamasını yapıyorum ve parantez içine 7.99 değerini veriyorum.yukardakınde yanı round'da en yakın tam sayıya yuvarlama 
            //yapmıştık virgülden sonrakı en yakın sayıya yuvarlıyordu. bunda ise vırgulden sonrakı sayı ne olursa olsun,
            //neye yakın olursa olsun bır alta mutlaka cevırıyor. noktadan önceki değere çeviriyor deyebiliriz. vırgulden sonrakı sayı
            //ne olursa olsun isterse 999 olsun önemli değil mutlaka vırgulden önceki sayıya yuvarlama yapıyor. aşağı yuvarlama dediğimiz aslında bu.




            //math.ceiling(x) parametre olarak verilen sayıyı bir üst tam sayıya yuvarlar.
            double yukariYuvarla = Math.Ceiling(7.99);
            //yine bunun aynısının üst sayıya yuvarlama metodu var. ceiling metodu. burda da aynı örnekten gidersek 8e yuvarlar.

            //pi sayısına erişmek için kullanılan metot. bu metotla direkt pi sayısını alabiliyoruz.
            double piSayisi = Math.PI;
            Console.WriteLine("pi sayısı: " + piSayisi);


            //-BİLGİ-
            //deyelim ki herhangibir sebkeple projenin ismini değiştirmek istiyoruz. bilgisayarımın dosyalarımdan manuel olarak değiştiriyorum.
            //tekrar vısual studıodan projeyı actıgımda bana bir hata veriyor olacak. proje yüklenemedi diye bir hata veriyor.
            //solutıona geldiğimde de zaten projenin yüklenmediğini görüyorum. projenın ustune tıklıyorum ve remove diyorum.
            //solutıonun ustune gelıp en üstte sağ tıklıyorum add diyorum ve existing project tıklıyorum yani var olan bir projeyı
            //bu solutıonun içine dahil etmek istiyorum dıyorum. daha sonra bilgisayarım kısmından ilgili projenin üstüne geldim.
            //tıklayıp içine giriyorum bunun içindeki csproj dosyasını secerek aç diyorum ve buraya gelmiş oldu artık.
            //şimdi klosörün adını değiştirdim ama projenin ismini daha değiştirmedim. projenin ismini değiştirmek için de
            //üzerine sağ tıklayıp rename deyerek projenin ismini değiştirebilirim. şuanda projenin ismi değişmiş oldu.









        }
    }
}