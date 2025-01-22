namespace _12_foreachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] takimlar = { "beşiktaş", "fenerbahçe", "galatasaray", "trabzonspor" };
            //foreach (var item in takimlar)
            //{
            //    Console.WriteLine(item);
            //}





            //dizimi oluşturdum ve bunların ıcınde dönüp ekrana yazdırmak istiyorum. bunu forla yazarken mutlaka dizinin boyutuna ihtiyacım var
            //cunku burda o kadar dönmem lazım. for döngüsünün çalışma mantığı budur. ama diyelimki ben bunu bilmiyorum ve bulma şansım yok, uygulamnın içeriğine göre değişir.
            //farklı bir değer olabilir, belki kullanıcıdan alınan bir değer olabilir. o yüzden bizim kullandığımız bir foreach döngüsü var.
            //foreach döngusu direkt otomatik cıkıyor. yukarda göruldugu gibi önce bir tip atadı var tipi. bu tip içine her şey alabiliyor.
            //döngunun içindeki her bir elemana karsılık gelen item. tipimin string oldugunu bildiğim için stringe cevirebilirim.
            //ben artık burda CW ile ekrana yazdırdıgımda (item) dediğim anda bana zaten strıng bır deger dönuyor. ilgili takımın içersinde döndugum
            //elemanın kendısını dırekt verıyor. yani 0ıncı 1inci 2inci kac tane varsa o elemanın degerini bana veriyor. 
            //forda ise dizilerde dönmek daha zor cunku once takımların lenghtini bulmam gerekiyor o kadar dönmem lazım cunku.
            //CW ile ekrana yazdırdığımda da benim 4 elemanım varken ben 5 yazarsam uygulama 4ten sonra hata verir. o yuzden for dongusunde bu tarz hatalarla karsılaşma ihtimalımız yuksek.




            //ÖRNEK:
            //Meyveler dizimiz olsun, eleman sayısını kullanıcı belirlesin. sayıyı belirlediktenn sonra her bir elemanın değerlerini
            //tek tek doldursun. son olarak elemanın tüm değerlerini ekrana alt alta yazdıran kod bloğu.

            //Console.WriteLine("kaç tane meyve girmek istiyorsunuz? ");


            //string[] meyveler = new string[Convert.ToInt32(Console.ReadLine())];

            //for (int i = 0; i < meyveler.Length; i++)
            //{
            //    Console.WriteLine($" {i + 1}. meyveyi giriniz: ");
            //    meyveler[i] = Console.ReadLine();
            //}

            //Console.Clear();
            //Console.WriteLine("girdiğiniz meyveler");

            //int index = 1;

            //foreach (var meyve in meyveler)
            //{
            //    Console.WriteLine($" {index}. meyve = {meyve}");
            //    index++;
            //}


            //öncelikle kullanıcıdan kaç tane meyve istediğini soruyorum. dizimin eleman sayısını belirlemek için.
            //ardından dizimi oluşturuyorum. karakter değer girileceği için string kullanıyorum, dizi oluşturmanın standartları zaten belli, bu şekilde oluşturuyorum.
            //ardından readline ile kullanıcının gireceği sayıyı readline ile alıyorum. readlıne sadece strıng değerler aldıgı için onu convert ediyorum.
            //ardından bu dizinin içine tek tek meyveleri girmesini sağlayacaktık. bunun için de for döngüsünü kullanıyorum.
            //bu for döngusunde meyveler dizisinin lennghti kadar dönmem gerekiyor yani kullanıcı kaç girdiyse o sayıya kadar dönmem gerekiyor.
            //her döndüğümde de ekrana xinci meyveyi girin diye kullanıcıya değer girmesi için yazı çıkarmam gerekiyor.
            // o yüzden CWyi ekledim ve xinci meyveyi girin yazıyorum.burdaki xi ded dinamik olarak yazdırmalıyız yani 1234 . meyve diye.
            //bunu dinamik olarak yazdırmak için de  dolar işareti kullanıyoruz yanına süslü parantez ile i+ 1 diyorum burda direkt i demiyorum çünkü ozaman 0ıncı meyve der ben onun yerine iyi 1 arttırarak 1. 2. 3. meyve yazmasını istiyorum.
            //dolar işaretini ve süslü parantezi kullanıyorum yoksa kullanıcının girdiği değeri alamam.
            //ardından da ilgili yazdığı meyveyi dizinin ilgili elemanına yazdırmamız gerekiyor.
            //dizin içine zaten biz nasıl değer ataması yapıyorduk? meyveler dizisinin xinci elemanı[] buraya int bir değer girmemiz gerekiyor.
            //ki zaten biz forun içinde dönüyorduk o yüzden direkt ininci elemamına değer ataması yapabiliyorum. ve C.readline ile kullanıcının buraya yazdığı değeri alıyorum.
            //ardından bi console.clear diyerek ekranı temizliyorum. daha sonra CW ile girdiğiniz meyveler diyerek onları alt alta yazdıralım.
            //yazdırmak için de foreach döngüsünü kullanıyoruz. meyvelerin içinde dönüyorum ve her birini de meyve değişkenine atıyorum.
            //ardında CW ile x. meyve = elma- armut neyse bunları yazdırmak istiyorum = den sonrasını kullanıcının gireceği değeri alacağım için süslü parantez içine meyve yazıyorum bu şekilde dinamik hale getiriyorum.
            //örneğin elmayı yazdırmak için zaten ben meyvelerin içersinde dönüyordum ve döndüğüm her bir meyvenin değerini de meyve değişkeninde alıyorum. o yuzden suslu parantezin içine meyve değişkenini yazıyorum.
            //burda bir değişkene ihtiyacım var cunku burda bı i yok. o yüzden buraya bir değişken oluşturuyorum. int index = 1;
            //1den başlasın 1. meyve bu 2. meyve bu gibi arka arkaya bunalrı tekrar tekrar eklesin. dolayısıyla her ekrana yazdırdığında da indexi++ 1 arttırmam gerekiyor.
            //foreachnin keni arttırma gibi bir becerisi yok çünkü.



            //ÖRNEK:
            //arabalar dizimiz olsun, eleman sayısını kullanıcı belirlesin. sayıyı belirlediktenn sonra her bir elemanın değerlerini
            //tek tek doldursun. son olarak elemanın tüm değerlerini ekrana alt alta yazdıran kod bloğu.


            //Console.WriteLine("kaç adat araba girmek istiyorsunuz ?");
            //string[] arabalar = new string[Convert.ToInt32(Console.ReadLine())];

            //for (int i = 0; i < arabalar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. arabayı giriniz ");
            //    arabalar[i] = Console.ReadLine();
            //}

            //Console.Clear();
            //Console.WriteLine("girdiğiniz arabalar");

            //int index = 1;
            //foreach (var araba in arabalar)
            //{
            //    Console.WriteLine($"{index}. araba = {araba} ");
            //    index++;
            //}





            //ÖRNEK:sayılar dizimiz olsun.eleman sayısını kullanıcı belirlesin.hatalı bir değer girdiğinde uygulama hata vermesin.
            //tekrar değer girmesini istesin.
            //girdiği sayıları toplayarak sonuucu ekrana yazdırsın.


            //öncelikle CW ile ekrana yazdırıyoruz, dizinin eleman sayısını girin diye.
            //ardından kullanıcıdan aldıgımız değerin gercekten bir int mi değil mi bunu kontrol ediyoruz.burda trypars ile kontrolumu yapıyorum
            //bunu da whıle dongusu içinde yapıyorum.int eleman sayısı diye bir değişken atıyorum tryparse içine C.readlıne ile kullanıcının verdiği değeri alıyorum.
            //yani consoldan aldıgım degere sen bı bak bu deger int mi. dolayısıyla ben suan bunun int olup olmadıgına bakıyorum ve geriye bana true  folse deger donduruyor.
            //burda !=true yapıyorum yanı girilen değer true değilse yani int değilse sen burda dönmeye devam et.
            //donerkende eger hatalı deger giriyorsa tekrar tekrar hatalı bır değer girddiniz diye uyarı verdırtıyoruz bunu da CW ileekrana yazdırıyoruz.
            //altına da dizinin eleman sayısını tekrar giriniz yazdiriyorum.
            //bunların en basında da cleaar ile ekranı bır temızlıyorum süreklı aynı yazılar cıkmasın dıye.
            //döngünün sartına || elemansayısı < 1 diye bır şartta ekleyebilirm ki 0 veya - bir değer girerse yine hata versin çünku 0 ve altı gırmemesi gerekiyor.
            //buraya kadar artık dizimizin eleman sayısını biliyoruz dolayısıyla artık bu eleman sayısıyla dizimi oluşturabilirim.
            //şimdi dizimi olusturuyorum. dizimde int deger almam gerekiyordu. toplama işlemi yapacagım için int tıpınde bir dizi oluşturuyorum.
            //ardından for dongusu olusturuyorum eleman sayısı kadar burda donmem gerekiyor.CWile ekrana yazdırıyorum xıncı sayıyı gırın dıye.burda benim amacım kullanıcıdan ilgili sayıları almak. 1.sayıyı gırın 2. sayıyı gırın dıye.
            //console readlıne ıle sayıları alıyorum. yine aynı yukardakı ornekte oldugu gıbı hatalı deger gırmesine karsılık uygulama patlamaması için kontrol yapabiliriz.
            //bunun için whıle doongusunu kullanıyorum.ve tryparse.out metodu sana bunu nereye atmak ıstıyorsun dıye sorar  aslında. ayrıyetten bır değişken olusturmama gerek yok bır değişkenim vardı zaten.burdakı değişkene convert edbildiği degerı atar.
            //biz bunu bsayılar dızısının ininci elemanına atmak ıstıyoruz kı bu sayılar dızısının ınıncı elemanını convert edebiliyorsa buraya atsın ıstıyorum.
            //yıne yukardakı ornekteki gibi girilen degerrin eksi deger olup olmadıgını kontrol edebiliriz.degerı sayılar dizisini ininci elemanına attık
            //dolayısıyla ben burda sayılardizisi[i]< 1 diye kontrol edebilirim. cunku 0ın ustu bır deger gırmesini istiyorum.
            //ardında yıne yukardakı ornekteki gibi hatalı deger uyarılarını yazıyorum.
            //dolayısıyla artık ben şuanda sayılar dizisinin butun elemanlarını tek tek doldurmus oldum ve hakikaten de pozitif sayılarla doldurmuş oldum.
            //kullanıcı hatalı bır deger girdiğinde uygulamanın hata vermemesini, sayıyı tekrar gırmesini sagladım.
            //yine 0dan kucuk olma 1 veya altında bır sayı olması durumunda yine kullanıcıyı uyararak doğru bır deger gırmesini sagladım.
            //en sondada sonucu olusturabilecegım bır degışken olusturmam gerekiyor. sonra foreach dongusu olusturuyorum kı nsayıların ıcnde dolaşmam lazım.
            //ve sonuc değişkeninin içersine de+= diyerek ilgili elemanın += += yaparak her birini birbiri üzerine toplayarak sonucu alıyoruz.
            //en sonda da değerleri girdiğime göre Cw ile girilen sayıların toplamı= deyip sayıların toplamını alıyorum.



            Console.WriteLine("dizinin eleman sayısını giriniz..");

            int elemansayisi = 0;

            while (!int.TryParse(Console.ReadLine(), out elemansayisi) || elemansayisi < 1)
            {
                Console.Clear();
                Console.WriteLine("hatalı bir değer girdiniz..");
                Console.WriteLine("dizinin eleman sayısını tekrar girin.");
            }

            int[] sayilar = new int[elemansayisi];

            for (int i = 0; i < elemansayisi; i++)
            {
                Console.WriteLine($"{i + 1}. sayıyı girin..");
                while (!int.TryParse(Console.ReadLine(), out sayilar[i]) || sayilar[i] < 1)
                {
                    Console.Clear() ;
                    Console.WriteLine("hatalı bir değer girdiniz..");
                    Console.WriteLine($"{i + 1}. sayıyı tekrar giriniz..");
                }
            }






        }













    }



}