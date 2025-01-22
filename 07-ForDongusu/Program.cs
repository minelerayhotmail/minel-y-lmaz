namespace _07_ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //FORDONGUSU: for belli bir sayıda dönmek için kullandığımız komuttur.
            //burda amacım belli bir sayı grubunu ard arda ekrana yazdırmak. int tipinde bir i değişkenim var ve 
            //ve değerini 5 giriyorum sonra şartımı yazıyorum i değişkeni 15'ten küçük olan sayıları 1 arttırarak ekrana yazdır.
            //15e eşit
            //ve 15'ten büyük oluncaya kadar. yani burda 5 ve 15 arasındakı sayıları bır dongu seklınde bır arttırarak yazdırıyorum.
            //ve for kısmını yazdıktan sonra yine diğerlerindeki gibi alta bir süslü parantez açıyorum ve console.wrıteline ile 
            //ekrana i değişkenini yazdırıyorum. burda 5' 14' kadar olan sayıları tek tek çıktı verir. 15 ve sonrasını vermez.

            //for (int i = 5; i < 15; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //burda dikkat etmemiz gereken bazı noktalar var. örneğin for (int i = 5; i > 0; i++) gibi bir kullanım yaptıgımızda ben 
            //burda int ntipindeki i değeri 5 olan i değişkeni 0 dan büyükse bir arttırarak devam et demiş oldum. ve bu sekılde
            //sonsuz bır
            //donguye gırer. cunku 5 0 dan buyuktur ve duracagı bır nokta yok. burda bana ınt değerinin alabildigi kadar olan tum
            //sayıları ekrana yazdırır.

            ////sonsuz döngü oluşur.
            //for (int i = 5; i > 0; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //birde for (int i = 0; i < 20; i+=2) gibi bir işlem yapıp ikişer ikişer arttırma yapabilirim. burda değeri 0 olan
            //i değişkeni
            //20den küçükse iki arttırarak devam et demiş oldum. +=2 bu işaret iki arttır demek oluyor. ++ bir arttır demekti.
            //for (int i = 0; i < 20; i += 2)
            //{
            //    Console.WriteLine(i);
            //}


            //birde bunun tam tersi geriye doğru bir sıralama yapmak istiyorsam. for (int i = 20; i > 0; i--) yani 20 0'dan büyükse
            //bir eksilterek dön demiş oldum. toplamada nasıl bir arttırması için  ++ yapıyorsam bir eksiltmesi için de -- yapmam
            //gerekiyor.
            //şart kısmında ise >= yaparsam 20 0' büyükse ve eşitse demiş olurum.
            //for (int i = 20; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //for ile char değer ataması da yapabiliriz. bildiğimiz gibi char tipi tek bır harf değeri alır.
            //char  değerler tek tırnak içinde yazılır.
            //bunun için for ( char i = 'a'; i < 'z'; i++) yaparak a dan z ye kadar harfleri ekrana yazdırabilirim. 
            //burda a küçükse z'den bir arttırarak dön demiş oldum.

            //for (char i = 'a'; i < 'z'; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //1 ile 50 arasındaki çift sayıları ekrana yazdıran kod bloğu
            
            //for (int i = 0; i < 52; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadKey();

            //1 ile 50 arasındaki çift sayıları ekrana yazdıran kod bloğu. ve kullanıcıdan baslangıc ve bıtıs sayılarını iste.
            //iki tane değer almamız gerekiyor. baslangıc ve bıtıs olarak bunları cw ile istiyorum  ınt baslangıc = yaparak
            //readline ile kullanıcının gırdıgı degerı alıyorum
            //burda kullanıcının degerını alırken redlıne dan once convert işlemi yapmam gerekiyor cunku ben strıng olarak bır
            //baslangıc değeri girin dedim
            //ama kullanıcı bır sayı gırecek yanı ınt tıpınde o yuzden bunu ınt tıpıne cevırmem gerekiyor. bunun aynısını
            //bıtıs ıçın de yapıyorum
            //sonra for kısmında bu istediğim değerlere göre revize edebilirim. yanı i = baslangıctan ıtıbaren baslasın,
            //kullanıcı ne deger gırdıyse ondan ıtıbaren.
            //bıtısı de aldım bıtıs degeri kadar devam etsin. sonunu +=2 yapmıyorum cunku kullanıcı 1 girerse artı ıkı ekrana
            //3 verir ama ben cıft sayılar ıstıyorum.
            //o yuzden bunu ++ yapıyorum. amacımız cıft sayıları bulmak oldugu için bunu bır ıfın içine eklıyorum cunku sart
            //yapmam gerekiyor.
            //diğerlerinde yaptıgım gibi direkt ekrana degerim olan i yi girmiyorum cunku oyle yaptıgımda hepsını
            //ekrana yazdırıyordu. ıf sartını koyduktan sonra ekrana dırekt i degerimi yazdırıyorum.
            //if'te i % 2 = 0 içinde bulundugum dongu esıt esıt 0 sa yanı cıft sayıysa sen gıt bunu ekrana yazdır.
            //değilse hıcbır sey yapmana gerek yok.
            //dolayısıyla 1 gırdıysem cıft sayı olmadıgı için yazdırmaz. 2 yapcak cıft sayı yazıcak. 3ü yazmayacak. 4 yazıcak.
            //şeklinde gider


            Console.WriteLine("lütfen baslangıc değeri giriniz");
            int baslangıc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen bitis değeri giriniz");
            int bıtıs = Convert.ToInt32(Console.ReadLine());



            for (int i = baslangıc; i < = bıtıs; i ++)
            {
                if (i % 2 == 0)
                  Console.WriteLine(i);
            }

            Console.ReadKey();



            //bunu birden fazla yontemle yapabiliriz. burda +=2 yapmak istiyorsam yanı ıkıser ıkıser artsın diyorsam şöyle bır
            //kontrol yapabılırım:
            //burda ifle bir sart koyuyorum bu sart (baslangıc = %2 != 0) baslangıc == ++; yanı baslangıc cıft sayıya esıt değil ise
            //sen bunu 1 arttır. zaten cıftse hıcbırsey yapmaz.
            //sonra for dongumu yazıyorum int i = baslangıc; i <= bıtıs; i+=2; şeklinde burda da baslangıcım bıtısten kucuk ve eşit
            //ise ıkı arttır demiş oluyorum.
            //




            Console.WriteLine("lütfen baslangıc değeri giriniz");
            int baslangıc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen bitis değeri giriniz");
            int bıtıs = Convert.ToInt32(Console.ReadLine());

            if (baslangıc = != % 2 = 0)
                baslangıc++;

            for (int i = baslangıc; i <= bıtıs; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey()








        }
    }
}