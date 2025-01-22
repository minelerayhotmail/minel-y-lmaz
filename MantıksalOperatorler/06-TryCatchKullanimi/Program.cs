namespace _06_TryCatchKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try tarafında yazıcagım sey hata alınma ihtimalı olan kod bloklarını buraya yazıyoruz. yani kullanıcıdan bir değer 
            //alıyoruz örneğın iki sayıyı toplayacagız bırıncı sayıyı ıkıncı sayıı gır dıye degerler alıyoruz. ve aldıgımız degerı
            //de convert ediyoruz.ama bız ınt bır tıpte strıng deger gönderdiğimizde sistem hata veriyordu ve hataları dönduruyorduk
            //bu bir hata yontemi dolayısıyla oyle bir hata alma durumunda, hata alma ihtimali olan kodları bu bloğun içine yazabiliyoruz.
            //hata alındıgında calısmasını ıstedığımız kodlar varsa onları catch'nin içine yazıyorum.
            //yani bir hata aldık netıcesinde bunu loglamak ısteyebiliriz, veri tabanında tablolara yazmak ısteyebiliriz, mail 
            //attırmak ısteyebiliriz, kişiye uyarı verdirebiliriz tekrar gir değeri diyebiliriz gibi bircok sey yapılabilir.
            //bir projenin içine dahil olundugunda boyle bir durumda ya mail attırılır onemlı bır kayıtsa ya da veri tabanında
            //bir yerlere yazılır kı yarın oburgun hata alınan yerlere baktıgımızda ilgili log kayıtlarından bulabiliriz.
            //bir hata alındıgında try catch yoksa kod patlar devam etmez, biz burda kodun devam etmesini sağlıyoruz.
            //daha sonra da fınally butonunun oldugu blok calısıyor. burda hata alınsada alınmasada calısmasını istediğimiz kodları
            //bu bloga yazabiliriz.
            //kodu calıstırdım once try içine gırdi hata yoksa catch içine hiç girmiyor sonra fınally calıstırıyor devam ediyor varsa 
            //altında kodlar ilgili kodlara devam ediyor. catch'ye sadece hata varsa girer.
            //ama try içine girdi ve hata aldıysa ornegın 100 tane satır var 10uncu satırda hata aldıysa 10uncu satırdan sonrakı
            //hicbir satır calışmaz, direkt catch bloğu calısır catch ıcınde yazdıgın kodlar calısır ardından fınallly calısarak devam eder.



            try
            {
                //hata alınma ihtimalı olan kodları bu bloga yazabiliriz.
                //ÖNEMLİ NOT: 100 tane satır varsa, 10. satırda hata alındı ise 10. satır ve sonrasındakı hiçbir satır çalıştırılmaz.
            }
            catch (Exception hata)
            {
                //hata alındığında çalışmasını istediğin kodları bu bloğa yazabiliriz.
            }
            finally
            {
                //hata alınsada alınmasada çalısmasını istediğimiz kodları bu bloğa yazabiliriz.
            }



            //burda işte hata alma ihtimalım var. kullanıcı sayısal veya strıng bır deger girebilir. o yuzden try catch kullanmalıyım.
            //burda kod boloklarımı secıp kod parcacıgından cerceveleyıp regıon yerine try seciyorum ve bana direkt try oluşumunu yapıyor.
            //bu asagıdakı kod bloğunda try catch yapmadıgım zaman, kullanıcıdan bır sayı istiyoruum o da sayı yerıne harf gırerse 
            //uygulama orda patlar alttakı kodların hıcbırı calısmaz. ama try catchde hata alındıgında uygulama patlamıyor,
            //hata aldıgı satırdan sonra catch bloguna giriyor ordan altta kodlar varsa devam ediyor. catchde bana hata alındıgı bılgısı
            //veriliyor ama uygulama patlamadan sınra asagıda kodlar varsa o kodları calıstırmaya devam ediyor.yanı uygulama durmuyor.
            //try catch olmadıgında ve hatya aldıgında alttakı hıcbır kkod calısmaz, try catch oldugunda ıse hata alınan koda kadar 
            //olanlar calısır hata alındıktan sonra try kısmındakı dıger kodlar calısmaz catch kısmına gırer ordan devam eder calısmaya.
            //ama try catch olmadan hata alınan kısımdan sonra hıcbır sey calısmaz.
            //sımdı catch kısmındayım amacım bu hatayı ekrana yazdırmak. bunu da console wrıtelıne ıle hata alındı dıye yazdırıyorum 
            //yıne altına bır tane daha cw eklıyorum exceptıon ıcınde hata ısmınde exceptıon tıpınde parametre var. exceptıon bır class
            //bunun içinde bazı ozellikler var. catchnin içinde ıkıncı bır console wrıtelıne yazdırıyorum ve içine hata.message yazıyorum
            //bıze hatanın içeriğini en son soyleyen hali. bunu harıcınde bır tane ınnerexceptıon dıye bır hata gosterme seklı var ve bırde
            //stacktrace dediğimiz hata modu var.
            //uygulamayı calıstırdım bır sayı ıstıyorum ama kullanıcı harf gırdı. uygulama calısır hata alınan yerden sonra catch blogunun içine girer.
            //orda cw ile hata alındı yazdırmıstım hata alındı dıye uyarı verır.sonra hatayı hata.message ıle yazdırmıstım burdada
            //bana alınan hatanın acıklamasını yazıyor. gırılen degerın dogru formatta olmadıgını soyleyen bır acıklama yapıyor.
            //burda ınnerexceptıon ıle ılgılı bır durum yok o yuzden onu yazmadı.
            //bırde bızı ılgılendıren aslında yazılımcıları ılgılendıren stacktrace paremetresi var bura benim hatayı aldıgım satırıı
            //dahil olmak uzere bana tek tek hatanın sebebini acıklıyor. yazılımcının anlayacagı dılden acıklama yapıyor. message de kullanıcının anlayacagı dılde acıklam yapıyor.
            //stacktracede yazılımcıya detaylı bır sekılde, kacıncı satırda hata aldıgını soyluyor ve burda bır convert işlemi vardı
            //o convert işleminin içinde hata aldı dıye yazıyor. mesela 26. satırda ama hangı dosyada? uzantısını sana burda veriyor.
            //hangı dosyaysa onu yazıyor.
            try
            {
                Console.WriteLine("birinci sayı giriniz");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ikinci sayıyı giriyiz");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception hata)
            {
                Console.WriteLine("hata alındı");
                Console.WriteLine("message=" + hata.Message);
                Console.WriteLine("ınnerexceptıon=" + hata.InnerException);
                Console.WriteLine("stacktrace=" + hata.StackTrace);

            }


            //herhangıbır hata aldıgında hıcbır sey yapmasını ıstemiyorsam onun için de catch {; } bu sekılde kullanabılıyoruz, bunu catch yanına yazıyoruz tabıkı cunku hata kısmı catch oldugu için
            //uygulama hata aldıgında sen durma devam et, ama tabı try dakı hata alındıktan  sonrakı satırlar calısmaz catch ıcıne gecer catch ıcınde kod yok.
            //varsa fınnaly calıstırır yoksa asagıdakı satırlara devam eder. yanı hata alındıgına dair bır uyarı verdirmedim.


            try
            {
                Console.WriteLine("birinci sayı giriniz");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ikinci sayıyı giriyiz");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

            }
            catch {; }

            Console.ReadKey();







            //burda ise uygulamayı calıstırdım. dogru bır deger girdim yanı harf değil sayı gırdım. sonra hatalı gırıs yapmadıgım ıcın
            //diğer kodlar da calısıyor ve ıkıncı bır sayı ıstıyor onu da dogru gırıyorum. hata olmadıgı için catch içine hiç girmez 
            //fınally ıcıne gırer ve işlem tamam der.
            //ama uygulamayı calıstırdım ve istediği birinci sayıyı hatalı gırdım try kısmındakı dıger kodları calıstırmadı hatalı gırış
            //yaptıgım için. sonra catch içine girdi hata alındı dedi ve fınally içine girdi işlem tamam dedi. cunku her kosulda fınally içine
            //girer. hata olsa da olmasa da fınally içine girer. fınally kodunu her zaman yazmak zorunda değiliz. eger fınally koodu varsa her zaman içine girer yani.
            //tamamen ihtiyaca göre fınally'yi ekleyebilirim.
            try
            {
                Console.WriteLine("birinci sayı giriniz");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ikinci sayıyı giriyiz");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception hata)
            {
                Console.WriteLine("hata alındı");

            }
            finally
            {
                Console.WriteLine("işlem tamamlandı");
            }


            //try tek basına kullanamıyorsun illakı catch veya fınally olması gerekıyor.



        }
    }
}