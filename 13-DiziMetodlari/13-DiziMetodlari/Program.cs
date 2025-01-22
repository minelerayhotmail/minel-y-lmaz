using System.Collections;

namespace _13_DiziMetodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetValue() metodu ile dizinin içindeki, değerini almak istediğimiz index verisi ile elemana erişmek için kullanırız.
            //bir tane aylar isminde string dizisi oluşturuyorum. içine de sayı belirlemeden aylardan birkaç tane yazıyorum.
            //şuanda elimde index numarasını bildiğim bir dizi var ve valuesine erişmek istiyorum.
            //normalde şimdiye kadar aylar[0] yazıp 0ıncı indexe ulaşabiliyorduk. yine bu erişme yerine metodlarla buna erişim 
            //sağlayabiliyoruz. elimizde bir aylar dizisi var. aylar.getvalue() diyorum, bunlar metod. içine benden bir tane index 
            //istiyor. getvalue metodu çalıştığında geriye object tipinde ve null da olabilir bir değer döndürür. ben bunu stringe 
            //almak istediğim için bunu doğrudan stringe convert etmemiz lazım. onun için de en sona tostring ekleyebiliriz.
            //yine başına convert.tostring de eklenebilir hepsi olabilir.
            //bu şekilde get value metodu ile dizinin içersindekiindex numarasıyla değerini alabiliyoruz. burda almak istediğimiz
            //index numarasını bilmemiz gerekiyor, yine yanlış bir numara yani olmayan bir index numarası girersen hata verir.
            //neden tostring ile convert işlemi yaptık? getvalue metodunun bana döndürdüğü tip object, null tipte bir object.
            //o yüzden bunu tostringe çevirmem gerekiyor çünkü sol tarafında değişkenin tipi string. eğer ben başındaki tipe object 
            //deseydim o zaman bir problem olmazdı. convert etmeme gerek olmazdı.
            //biz string tipinde değerler  atadık, aylar karakter olarak ama int tipte de bir şey koyabilirdik, dolayısıyla int
            //olduğunda sol tarafta intse mutlaka convert etmemiz gerekecek.

            string[] aylar = { "ocak", "şubat", "mart", "nisan", "mayıs" };
            string ay1 = aylar[0];
            string ay2 = aylar.GetValue(0).ToString();
            object ay3 = aylar.GetValue(1);




            //SetValue() elimizdeki bir indexe istinaden, dizinin elemanına değer ataması yapmak için kullanılır.
            //get ilgili indexin değerini getiriyordu set ise onun içine doğrudan bir değer set etmemize yarıyor.
            //aylar.setvalue() diyorum ve benden yine null object tipinde bir şey istiyor ya da buna string te girebiliriz.
            //rneğin üstteki dizim ocak subat mart nisan mayıstı en sondakını aralık yapmak ıstıyorum. bunun için önce
            //aylar.setvalue dedikten sonra parantez içine ne set etmek istiyorsam önce onu yazıyorum. yani değerini yazıyorum
            //aralık olarak ardından bir tane virgül ekleyerek elemanın index değerini yazıyorum. mayısı yazmak istiyorum mayıs 
            //değerimin indexi 4tü o yüzden buraya 4ü yazmam gerekiyor. 4ü yazdığımda artık bu yazdığım satır çalıştıktan sonra
            //benim aylar dizisi içersindeki mayıs yerine artık aralık oluyor olacak.
            aylar.SetValue("aralık", 4);


            //Array.İndexOff() metodunu dizinin içindeki bir elemanın index numarasını almak için kullanırız.
            //örneğin dizinin içindeki elemanı biliyoruz ama inndexini bilmiyoruz. yani örneğin benim elimde mart bilgisi var.
            //ama martın indexi kaç onu öğrenmek istiyorum. b unun için de indexoff metodunu kullanıyoruz. bunlarda ayların
            //yanına nokta koyarak çoluşturma yapmıyoruz üsttekiler gibi. öncelikle int indexno diye bir değişken oluşturuyoruz.
            //çünkü bana elemanın index numarasını dönecek yani sayısal bir değer döneceği için int kullanıyoruz.
            //ardından arrey dediğimiz bir sınıf var ben bu sınıftan bazı metodlara erişebiliyorum. bu metodlardan ilki de indexof metodu.
            //ardından bir parantez açıyorum. burda bana ilk olarak hangi dizinin içinde sen aramak istiyorsun bana onu soruyor.
            //çünkü şuan elimde herhangibir dizi yok. yukarda get ve sette aylar.getvalue ve aylar.setvalue yapıp işlem yapmıştık.
            //orda dizimin adını vermiştim. yani hangi diziyle çalışacağımız belliydi. o yüzden şuan hangi dizinin içinde çalışacağım
            //belli olmadığı için array sınıfını kullanarak bir metodun içinde olduğum için ilk olarak parantez içine dizimi yazıyorum.
            //ardından da bizim elimizde değer var demiştik, o değeri buraya yazıyoruz.
            //şuan  bu değerler elimizin altında fakat yarın öbürgün bunlar hep veri tabanından geliyor olacak, ve içindeki değerleri
            //biz yazılımcı olarak bilmiyor olacağız belkide. çünkü bu değerler ekranda giriliyor da olabilir içeriğini bilmiyor
            //olabiliriz. o yüzden böyle metodlara ihtiyacımız oluyor.
            //bu şekilde yaptığımızda burda verdiğim parametredeki dizinin içersinde, gidip arayıp ilgili elemanı bulup bize indexini
            //geriye dönüyor. yani index numarasını veriyor.
            int indexNo = Array.IndexOf(aylar, "mart");



            //dizinin içerisinde kaç tane eleman olduğunu bize döner.
            //elimizde bir dizi var, aylar dizisi bunun lenghtine baktığımda bu bana doğrudan içerisinde kaç tane olduğunu dönüyor.
            //lenght bir metod değil bir property. metodların sonunda mutlaka parantez açıp kapatılır, propertylerde değer alınır ya da
            //değer set edilir sadece. o yüzden bunun sonunda bir metod yok
            int elemanSayisi = aylar.Length;




            //Array.sort() metodu ile dizinin içindeki elemanları sıralayabiliriz.
            //eğer elemanlar sayısal bir değere sahipse küçükten büyüğe doğru sıralama yapar. eğer string bir değer  ise A dan Z ye
            //bir sıralama yapar. datetime ise yani tarihse büyükten küçüğe sıralama yapar. short metodu da array sınıfındandır.
            //array sınıfından olduğu için bana bir dizi lazım, yani ben hangi diziyi sıralamak istiyorum parantez içine o ilgili
            //değişkeni yazıyorum. şuan ben dedim ki aylar dizisini bana sırala getir. burda artık büyükten küçüğe sıralama yapıyor.
            //normalde bu metod olmasaydı napardık? dizinin içinde bir döngü oluştururduk.  tek tek sayılara bakardık. sayısal mı
            //string mi bi ayrım yapardık. tek tek bütün elemanlara bakıp döngü oluştururduk. bu döngü 30 40 satırı bulabilirdi.
            //o şekilde uğraşmamamız içiçn ardık bu hazır metodlar çıktı. bunları kullanabiliyoruz.
            //bizim aylar dizisindeki sıralamamız ocak subat mart nisan aralık seklındeydı. short işlemi yapıolmadan önce benim girdiğim
            //sıralama seklındeydı. sort metodunu calıstırdıktan sonra ise sıralamam artık harfe göre adan zye gidecek şekilde
            //sıralama işlemini yapar. aralık, mart, nisan, ocak, şubat şeklinde oldu ve bunların indexleri de artık değişti.
            //normalde aralığın indexi 4tü artık indexi değişti ve 0 oldu. short metodunu çalıştırdığımız anda elemanın içersindeki
            //verilere göre bir sıralama işlemi çalıştırıyor. ve bu sıralamanın ardından da indexlerini de değiştirmek şartıyla diziyi
            //tekrar oluşturuyor diyebiliriz. 
            //nasılkı burda strıng bir şeye short ettik aynı mantıkla yine array sınıfı üzerinden int dizisini de short edebiliriz.
            //int sayılar deyıp sayılar dızısı olusturabiliriz. örneğin 1 6 4 3 9 0 diye bir dizi yaptım. bunda da short metodunu calıstırdıgımda
            //kücükten nbuyuge olacak sekilde sıralıyor. yine bunların indexleri de değişti.
            //foreach ile ekrana yazdırma işlemi yapıyoruz. foreacte cok kod oldugunda suslu parantez kullanmalıyız ama tek satırlık
            //bir kod varsa direkt CW ile parantez içine sayı diyerek ekrana sayıları yazdırabiliriz, süslü parantez kullanmadan.
            //birden fazla satır da yazabiliriz fakat birden fazla kod oldugunda karısabiliyor.
            Console.WriteLine("normal hali");
            foreach (string ay in aylar)
            {
                Console.WriteLine(ay);
            }
            Array.Sort(aylar);
            Console.WriteLine("short metodu ile sıralanmış hali");
            foreach (string ay in aylar)
            {
                Console.WriteLine(ay);
            }

            int[] sayilar = {1, 6, 4, 3, 9, 0};
            Array.Sort(sayilar);
            foreach (int sayi in sayilar)
                Console.WriteLine(sayi);
            




            //array.reverse() metodu ile dizinin içindeki elemanları tersten sıralayabiliriz. büyükten küçüğe ya da zden aya.
            //reverse metodunda unutmamamız gereken en önemli konu reversei yapmak için mutlaka önce shortu yapmak zorundayız.
            //yani ben doğrudan array.reverse dediğimde sıralama yapmıyor mutlaka bundan önce shortun calıstırılması gerekıyor.
            //önce shortu calıstıracak adan zye sıralayacak ya da kucukten buyuge sonra reverseyi calıstırıp tekrar tersine calıstırmamız gerekiyor.
            //shortu hemen önunde kullanmak zorunda değilim. yukarda sayılara short işlemi yaptıysam tekrar yapmama gerek yok.
            Array.Reverse(sayilar);

            int[] sayilar2 = {1, 6, 4, 3, 9, 0};
            Array.Sort(sayilar2);
            Array.Reverse(sayilar2);






            //array.clear() metodu ile dizi içindeki elemanları silebiliriz.
            //örneğin dizinin içersindeki bütün elemanları silmek istiyoruz. bu metodu kullanabiliriz.
            //ÖNEMLİ NOT: silmekten kastımız eleman sayısını silmek değil. silme yaptığımızda eleman sayısı aynı kalır.sadece değerleri silinir.
            //örneğin 6 elemanlı bir sayılar dizim var burda array.clear(sayilar2) yapıyorum. clear metodu çalıştığında eleman
            //sayısı aynı şekilde 6 olarak duruyor fakat içine baktığımızda int tipte olduğu için hepsi 0 olarak değişir.
            //string olsaydı da null olarak ayarlayacaktı.
            //clear tamamını temizlemek için kullanılıyor ama deyelim ki bana tamamını silmek için lazım değil. örneğin ben sadece 
            //0 1 2 3 indexli elemandan itibaren bir tane ıkı tane 3 tane neyse onları silmek istiyorum. o zamanda


            //------------------------------------------------------------------------------------

            //dizlerde elemanın verisini değiştirirken örneğin 2.indexin değerini 1 yap deyebiliyorduk. arraylistte de bunu
            //yapabiliyoruz. kullanımı da aynı dizilerdeki gibi. köşeli parantez içine indexi veriyorum. ve ilgili indexe sahip elemana
            //ulaşıp değerini veriyorum. arraylistte int bir indexin değerine değiştirmek istediğimde string de atabiliyorum
            //tamamen dimanik bir yapı.

            ArrayList rakamlar = new ArrayList();
            rakamlar[2] = 1;
            rakamlar[1] = "ahmet";

            //diziler ve arraylist arasındaki farklar:
            //1-dizilerin boyutunu oluştururken belirtmek zorundayız. arraylist sınıfında belirtmeden oluşturup istediğimiz zaman ekleme çıkarma
            //yaparak boyutunu değiştirebiliriz.
            //2-dizilerin veri tipi baştan belirlenir ve sadece o tipte değerler alır. arraylist sınıfında istediğimiz tipte değer ataması yapabiliriz.
            //herhangibir tip belirlemek zorunda değiliz.

            //arraylistte sıralam işlemi yapma. önce rakamlar değişkenimin içine geldim short metodu ile sıralama yapabiliyorum.
            //burda da short ile içindeki elemanların hepsini ya küçükten büyüğe ya da adan zye sıralamasını yapıyor.
            //sıralama yapacağımız zaman iki farklı tipten değer girmememiz gerekiyor.örn. int ve string. cunku bunları sıralayamaz
            //hata verir.
            rakamlar.Sort();
            //tersten sıralama için:
            rakamlar.Reverse();
            //burda yine aynı kuralımız geçerli, önce short metodunu çalıştırmak durumundayız ardında reverse calıstırabiliriz.
            //içindeki herhangibir elemanı kaldırmak için: removenin içine yazdığımız elemanın değerini kaldırır, index numarası değil.
            //örneğin yukarda 7 var remove deyıp parantez içine 7 yazdıgımda burdaki değeri ve aynısı olanların hepsini kaldırır.
            //dizilerde bu farklıydı orda eleman sayısını silmez değerini null yapardı. bu oyle değil bu direkt elemanı yok ediyor.
            //artık dizini boyutu değişir 4 indexli idi 7yi kaldırdım index3e düştü.
            rakamlar.Remove(0);
            //yine bunun haricinde removeat metodu var. bu da index numarası ile çalışır.örneğin burdada parantez içine deyebilirim ki 0ıncı index.
            //yani 6 vardı 0da 6yı sil. değerle değil index numarasıyla eleman siler.

            rakamlar.Clear();//clear tamamen temizleme işlemi yapar. arraylist değişkeninin içersini tamamen temizliyor.
            //clear metodunu çalıştırdıktan sonra artık ekranda hiçbir şey yazmaz. yani artık içinde eleman yok. boş anlamında değil artık eleman sayısı 0.













        }
    }
}