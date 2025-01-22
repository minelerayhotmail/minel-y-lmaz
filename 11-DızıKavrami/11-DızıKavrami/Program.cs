namespace _11_DızıKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DİZİLER: biz şimdiye kadar bir veri tipi ile değişkenin içine bir değer ataması yapyorduk, sadece bir değer.
            //diziler artık değişkenin içine birden fazla değer atayabildiğimiz durumlara deniyor. içerisinde artık bir liste barındırdığımız değişken var anlamına geliyor.
            //diziler nasıl tanımlanıyor? dizileri belirlemek için köşeli parantez işaretini kullanıyoruz.
            //önce dizini tipini belirliyorum, dizinin içinde hangi değerleri tutacaksam, string mi bool mu int mi gibi. ardından bir köşeli
            //parantez yaparak bunun bir dizi olduğunu belirliyorum. sonra değişkenin ismini tanımlıyoruz.örneğin rakamlar, benim dizimin adı
            //rakamlar.sonra bu oluşturma şekilleri var. ilk olarak tanımlama yöntemi ben bir int dizisi tanımladığım için yine sağına newleyerek
            //yine int tipinde soldaki intse yine int olmak zorunda ornrgın burda strıng yapamayız.sonra köşeli parantez açıp içine bir boyut belirlemem gerekiyor.
            //örneğin 5, burda belirlediğim boyut bu rakamların içerisine 5 tane eleman aldığını belirtiyor. yani ben bunun içine 5 tane int değer atabilirim.
            //


            //Dizinin eleman sayısını belirterek içi boş olacak şekilde oluşturmak için kullanılır.
            int[] rakamlar = new int[5];
            string[] isimler = new string[6];


            //dizinin bir elemanına değer yazma.
            rakamlar[0] = 5;
            rakamlar[3] = 10;

            //dizinin x indexine sahip elemanın değerini verir.
            Console.WriteLine(rakamlar[0]);
            Console.WriteLine(rakamlar[3]);
            //rakamlar değişkenimin içinde 5 tane eleman var ve bu elemanların her birinin indexleri var. içinde 5 eleman varsa 1. elemanın indexi 0
            //yani ben 1. elemana değer yazmak istediğim zaman köşeli parantezin içine 0 yazmam gerekiyor. buda sen git rakamlar değişkeninin 1. 
            //elemanına 5 değeri yaz demek oluyor. yine aynı şekilde rakamlar dizisinin indexi 3 olan elemanına 10 değeri yaz. yani buda 4 numaraya karşılık geliyor.
            //bu şekilde değer ataması yapabilirim. rakamlarım ınt tipinde değerler oldugu için ben burda int tipinde bir değer verdim yani sayı girdi.
            //gidipte strıng bir değer atamazdım. ekrana yazdırmak için de console wrıteline(rakamlar[0]) yaparak ekrana değeri alabiliyorum.
            //eğer burda ekrana yazdırırken değer tanımlamadığım bir index girersem ekrana 0 yazdırır çünkü intte boş bırakıldığında varsayılan değeri 0 kabul ediyordu.
            isimler[0] = "minel";
            isimler[1] = "ayşe";


            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);




            //burdada içerisi strıng bir değer olduğu için içine sayısal bır değer yazamıyorum.
            //eğer burda ekrana yazdırırken değer tanımlamadığım bir index girersem içi boş olarak ekrana yazdırır. stringte boş bırakıldığında değeri null olduğu için boş getirir.







            //dizinin hem eleman sayısını, hem de elemanlarına değer ataması yaparak dizi oluşturma. süslü parantezin içinde değer ataması yapabiliyorum.
            //eğer dizime 3 index atadıysam, değer ataması yaparken de 3 değer ataması yapmam gerekiyor 2 tane yapamam hata verir.
            //ekrana da yazdırırken CW ile yazdırmak istediğim sayıyı giriyorum. ekrana o sayıdaki atadığım değeri veriyor.
            string[] arabalar = new string[3] {"volvo", "bmw", "ford" };
            Console.WriteLine(arabalar[1]);


            //diğer yöntemi ise: yine aynı şekilde veri tipimi yazıyorum dizimin adını giyorum ama içine kaç indexli olacağını girmiyorum
            //o zaman bu dizinin indexi süslü parantez içinde atadığım değer sayısı kadar olur. maşağıda beyaz ve kırmızı iki değer atadım. bu dizimin indexi 2.
            //dizinin eleman sayısını belitmeden değer ataması yaparak eleman sayısını oluşturma.
            string[] renkler = new string[] { "beyaz", "kırmızı" };
            //yine bunun aynnısını bu sefer new stringi yazmadan direkt süslü parantez içinde değer ataması yaparak oluşturabiliriz.






            //olmayan bir indexe değer ataması yapamam. örneğin benim dizimde 2 eleman varsa ben 4.elemana değer ataması yapmak istiyorum deyemem. hata verir.


            //bir dizinin içindekileri for döngüsüyle ekrana yazdırmak istiyorum. for dizisinde benim elemanın içindeki sayı kadar dönmem lazım.
            //bunun için bana arabaların içindeki 3 sayısı lazım ki ben bu araba sayısı kadar bir döngü oluşturabileyim. çünkü içinde dönmek için eleman sayısına ihtiyacım var.
            //dolayısıyıla bunu almak için arabalar yani yukardaki dizinin ismi.length yaptığımda bana arabalar dizisini boyutunu veriyor.
            //sonra CW ile arabalar[i] yapıyorum arabalar dizisini i'ninci elemanı çünkü inin içerisinde dönüyorum 3 olana kadar.


            //dizinin boyutu kadar bir döngü oluşturuyorum.içerisinde dönüp, dizinin döngünün içindeki değişken kadar dönüyor. i = 0
            //çünkü indexler 0dan başlıyor. bu döngüde de 0 dan başlıyor 0,1,2 olarak dönüp duruyor. çunku degerim 3tü.
             for(int i = 0; i < arabalar.Length; i++)
            {
                Console.WriteLine(arabalar[i]);
            }





        }


        //WATCH PENCERESİ: biz kodumuzu yazarken mutlaka debug modunda çalışıyoruz. debug modda olmadığımız sürece o pencere gelmez.
        //bakmaya başlamak istediğim satıra en sağ köşeye kırmızı daireyi ekliyorum ve örneğin yukarda rakamlar dizisinin durumunu 
        //görmek istiyorum. rakamların üzerinde sağ tıklayıp quick watch diyorum yani hızlı izleme byurda bana rakamlar dizisinin türünü,
        //adını,içinde kaç tane değer olduğunu, değerlerin içeriklerini hızlı bir şekilde açıyor ve kontrol edebiliyorum.
        //isimler dizisinde de aynı içeriğini görüntüleyebiliyorum. içinde kaç değer ataması olduğunu, bunların isimlerini, değerlerini görebiliyorum.
        // watch pencerem benim aşağıda kodu çalıştırdıktan sonraki çıkan pencereme deniyor. bakmak istediğim satırları hızlı izleme yapıp
        // hangisini istiyorsam izleme ekle dediğimde o en altta çıkan watch penceresine ekleniyor ve benim sürekli o koda gidip hızlı izleme
        //yapmama gerek kalmadan onu aşağıda süreklii görebiliyorum.f10 ile kodda ilerleme yapıyorum ilerki kodlarda o seçtığım diziye değer
        //atamıssam watch penceresinde bu değişiyor, kod ilerledikçe değer ataması değişiyor. dizimin içindeki bir indexe kod yazarken değer
        //ataması yapmamışsam watch penceresinden o indexe hızlı bir şekilde değer ataması yapabilirim. ama tabi burda yazdığımız değer 
        //uygulama çalışana kadar işler. uygulama durduğunda o değerler değişkenin değerleri gidiyor olacak. sadece dreneme amaçlı kullanabiliriz.
        //bunu quıck watchda da değiştirebiliriz. quıck watchde de değişkenin değerinde değişiklik yapabiliriz. bunu birde ilgili kodun uzerine 
        //gelip ıntelısesnten de direkt değiştirme yapabilirim.
        //!!!bu değer atamaları uygulamanın ömrü boyunca uygulamayı durdurduğum an hepsi gider ilk yaptığım halini alır.
        //örneğin uygulamayı çalıştırdım 1 indexteki ahmet değerini mehmet yaptım uygulama calısıyor hala kodlara baktım uygulamayı durdurduktan
        //sonra o mehmet yine ahmete döner yani orjınal halıne.  burda amac bazı denemeleri görmek istiyorum ve değerini böyle yapsam nasıl olacak kod diye
        //görmek istiyorum bunu baştan sona sürekli kodu değiştirmektense burda deneme yapıp bakabilirim.













    }
}