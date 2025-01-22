namespace DoWhıleDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DOWHİLE: Whıle'den farkı, whıle önce şart sağlanıyor mu diye bakıyordu sonra bloğun ıcındekı kodları calıstırıyordu.
            //do'daki fark burda ortaya cıkıyor. önce  do yani bir işlem yap.çalıştırılması gereken kodları buraya (do) ya yazıyoruz.
            //yani en üstte do'nun parantezine yapması gereken işlemi yazıyoruz. dolayısıyla burdaki kod her türlü bir seferde calısacak.
            //şartımız sağlansada sağlanmasa da. o yuzden ılk yazdıgımız kod burda calısacak. sonrasında sart saglanmıyorsa whıleden cıkacak.
            //ama sağlanıyorsa devamını getırecek yanı donmeye devam edecek. arttırma işlemi ise aynı whıledekı gıbbı manuel yapılır.
            //yıne altta whıledakı ıslem karsılandıgı surece sonsuz donguye gırebılır.


            //do
            //{
            //çalıştırılması gereken kodlar bu bloğa yazılır.
            //arttırma işlemi manuel yapılır.
            //}
            //while (true);


            //ilk önce yine bir değişken atıyoruz.
            //şimdi ben ekrana yazdırmak istiyorum, 0'ı yazmasını istiyor muyum? istiyorsam console.wrıtelıne(i) yazdırabilirim.
            //ardından bir arttırıyorum. i 0 dan buyuk mu sartı koydum. büyük olduğu için calısacak. bu durumda i her zaman 0 dan büyük oluyor.
            //sürekli sonsuz bir döngü şeklinde yazar çünkü şart her seferinde sağlanıyor.
            //burda değişkenimin değeri 0 once onu yazıyor sonra 1 arttırınca değerim 1 oluyor ve 0 dan buyuk oldugu için şart sağlanıyor ve bır arttırarak devam ediyor.böylece i her zaman 0 dan buyuk olur.
            //ben dersemki i<= 10 dersem ona kadar yazdırır.

            //int i = 0;

            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i > 0);



            //dowhıle: şimdi geldi i ne bir değişken değeri verdi. şarta hiç bakmadan direkt ekrana yazdırdı. arttırma işlemini de yaptı ardından şarta baktı.
            //şuan i 2 oldu birden küçük mü değil. dolayısıyla şarttan çıktı.



            //int i = 1;

            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i < 1);




            //şimi ise whıle dogusu ıle bakıyorum aynı değerler önce ekrana yazdırmadı
            //önce şarta baktı 1 1den küçük mü değil dolayısıyla ekrana bir cıktı vermedi.


            //i = 1;

            //while (i < 1)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}



            //bunu nerde kullanabiliriz?
            //kullanıcıdan bir sayı istiyorum ve bunu console.readlıne ile alıyorum.
            //amacım kişi pozitif bir sayı girmediyse tekrar tekrar uyarı vereceğim. pozitif bir sayı girene kadar uygulama hiç kapanmayacak.
            //burda tek bir fark var, kişi int bir değer girmez de harf vs. girerse diye console.readlıne'yi try catch'nin içine alıyorum.
            //çünkü herhangibir hata olduğunda uygulamanın durmadan devam etmesi için işlemin devam etmesini istiyorsam uygulamanın try catch ile catch kısmına 
            //catch {; } bu şekilde bırakıyorduk ve uygulama hata versede devam ediyordu.
            //bu kodun gidişatı şöyle olacak: pozitif bir sayı isteyecek ardından bir değişken oluşacak. do hemen calısacak şarta bakmayacak
            //bakıcak ekrandan bir değer girdişm deyelim kii 5 yani pozıtıf bır sayı 5i sayının içine atacak. şart sağlanıyor mu saglanmıyor.burdan cıkacak.
            //tekrar başa döndüm değeri girdim. diyelimki -5 girdim. şart sağlanmıyor. şart sağlanması için >= büyük eşit olması lazım yanı 
            //sayi >= 0 sayı 0 dan buyuk ve esıt ıse burdakı sart saglanır.
            //şimdi bır harf girdiğini düşünüyorum. yine console.readlıneyı calıstırdı. do'yu calıştırdı. readlıne ile ekrandakını
            //hemen aldı. ben buraya harf girdiğim için convert edemedi. cunku readlıne harf değerler aldıgı ıçın içine sayı alabılmesı 
            //için onu ınte convert etmiştim. ve convert edemediği için hata verdi.convert edemediği için onu sayı değişkenimdeki 0 olarak kabul etti.
            //benim değerim 0, 0 0a buyukveya esıt mı esıt oldugu için devam eder.
            //ama ben devam etmesini degıl bana pozıtıf sayı gırene kadar pozıtıf sayı gırınız dıye uyarı vermesini istiyorum.
            //o halde benim en alttakı sartımın sayi < 0 olması lazım.


            //en üstteki CWile pozıtıf sayı gırın dediğim kısmı do'nun altına alıyorum kı her seferinde döngünün içine girsin ve pozitif sayı girin diye uyarsın.
            //uygulamayı calıstırdım do ya gırdı CW ile pozitif bir sayı girin dedi, f girdim, catch'nin içine düştü hata verdi ama işlem ediyor, uygulamanın durmamasını sagladım cunku catch'yı koyarak.
            //en alttaki şartımın <= 0 yapmam lazım kı 0 ve 0 dan kucuk oldugu muddetce bu calışsın demek oluyor. -1 gırsem devam etmesi lazım pozıtıf sayı gırın dıye cunku.
            //dolayısıyla sarta uymayan bır değer gırdıgımde ekösi yada harf bana tekrar soruyor pozıtıf bır sayı gırın dıye, dönguden cıkmıyor.
            //ben ne zaman buyuk bır deger gırdım örn. 45 yanı pozıtıf sayı o zaman sarttan cıkar. uygulamayı bıtırdı.
            //do whılenın kullanımı dıgerlerıne gore bıraz daha ters görunebiliyor. unutmamamız gereken burdakı sart saglandıgı muddetce donuyoruz.
            //ben ne zamankı sayıya 0ın ustunde bır deger verdim şart saglanmadı o yuzden burdan cıktı. ne zamankı dogru bır deger vermedim,
            //sart saglandı, deger ataması yapamadı hıcbır sayıya o yuzden sureklı doner.

            
            int sayi = 0;
            do
            {
                Console.WriteLine("pozitif bir sayı giriniz..");
                try
                {
                    sayi = Convert.ToInt32(Console.ReadLine());
                }
                catch {; }

            } while (sayi <= 0);



            //biz şimdiye kadar hep ekrandan iki sayı girdirip bu iki sayının toplamını alsın ekrana geri yazdırsın diyorduk.
            //ve bunların hepsinde kullanıcı eğer sayı değil de bir karakter girerse uygulama patlıyordu. bu zamana kadar bunu engelleyemiyorduk
            //dowhılede ise kullanıcıdan bir değer aldık ve bu değeri burda kontrol ettik. girdiği değer 0dan buyuk mu diye baktık.
            ////0dan büyükse şartın içine girmesin yani döngünün içinden çıksın. aşağıda artık çarpma,bölme,toplama neyse yapsın.
            //çünkü ben sayıyı artık pozitif bir sayı ile doldurduğumdan eminim. çünkü buraya kadar artık onun kontrolunu yapıyorum.
            //girilen döngü 0 veya altındaysa sürekli bu döngü çalışacak. girilen sayı 0da küçük ya da eşitse tekrar başa döner.
            //kullanıcı -5 girdi başa döner a girdi başa döner.
            //öncelikle bir değer tanımlamak zorundayım çünkü aşağıda bir şart koymak zorundayım 0 dan kük ve eşitse burda dön gibi.
            //kkodu çalıştırdım dowhılenın içine geldi, önce ekrana pozitif bir sayı girin dedi. kullanıcı a girdi yani karakter.
            //devam etti try cashnın içine girdi. readlıne ıle ekranın ıcıne almak ıcın converte baktı ama convert edemedi. cunku
            //karakter girdim. edemeyince değerim aynı kaldı değişmedi yanı hala 0. şart sağlanmadığı için başa döndü. 
            //yani kullanıcıyı doğru bir değer girene kadar zorluyorum.















            //HESAP MAKİNASI ÖRNEĞİ



            //hesap makinesi uygulaması
            //-------------------------
            //menü
            //1- toplama işlemi yap
            //2- çıkarma işlemi yap
            //3- çarpma işlemi yap
            //4- bölme işlemi yap
            //0- uygulamayı kapat
            //hangi işlemi yapmak istiyorsunuz?
            //uygulama çalıştığında bu menünün açılması gerekiyor. hangi işlemi yapmak istiyorsunuz diye sorup seçimleri yapıp
            //bize sonucu vermesi gerekiyor.
            //öncelikle bize uygulamanın şart sağlanan kadar hiç durmamasını sağlayan bir döngü lazım.bunun için de do whıleyı kullanıyoruz.
            //bunu kullanmada amacımız hatalı bir değer girildiğinde sürekli bu menüye girmek. do whıle şarta bakmadan öönce ekrana 
            //menüyü yazdığı için önce içine console.wrıteline ile menümü yazdırıyorum. sonra şartımı koyuyorum ki şart sağlanmassa tekrar bu menüyü açsın.
            //o yuzden console.clear koduyla ekranı ılk once temizledim. dolayısıyla ben hatalı bir değer girdiğimde entera bastığımda ekran temizlensin.
            //en başta yukarda seçim diye bir değişken oluşturuyorum değerine de -1 verdim ki aşağıda da bu seçimin do whılenın içinde
            //0 mı değil mi diye kontrolunu sağlıyorum.  kullanıcı 0 ı seçtıyse uygulamayı kapat çalışsın ve bıtırsın. şartıma da !=0 (0 değilse değerini) ki 0ı  girmediği sürece uygulama çalışsın
            //dolayısıyla ilk geldiğimde benim bir değer girmemi istiyor ve ben bir harf girdim. burda da int.parse kodu var burda da hata alıyor
            //ve seçimin değerini değiştirememiş oldu. yani -1di yine -1 oldu. çunku burda try catch var şartı kontrol etti ve hala -1 olduğu için devam etti.
            // en başa geldi  clear koduyla ekranı temizledi yani gilen yanlış değerleri temizledi. kodları çaloıştırdı. satır satır
            //ekranı tekrar yazdı. ardından tekrar içeriye geldi.
            //şimdi normal bir değer giriyorum. yani ekranda olan değerlerden birisine örneğin 1 toplama işlemi yapmak istiyorum.
            //doğru seçtiğimde artık hata almayacağı için artık swıtchnın içine girebilir. seçimi kontrol edebilir anlamına geliyor.
            //swıchten seçimimi kontrol ediyor eğer ben bu değerlerden 1 i girdiysem burdaki kodu çalıştır şeklinde. burda ifte kullanılabilirdi.
            //seçimi yaptıktan sonra casenin içinde clearı tekrar koyuyorum kı burdakı menülerin hepsı gıtsin artık. üst tarafa toplama işlemi yazsın
            //ardına ıkı boşluk bıraksın ve sayıları benden istesin.1. sayıyı girin 2.sayıyı girin diye. sayıları giriyorum sonucu bana yazıyor.
            //en sona da readkey kodu koyuyorum. kod devam etmiyor, herhangibir tuşa basmamızı istiyor. entera bastığımızda whıle geldi seçim 0 mı
            //değil o zaman dönmeye devam etti.çünkü seçimim bırdı şuan o yuzden tekrar başa geldi. sürekli böyle devam ediyor. ne zamankı ben 
            //0ı seçtım entera bastım o zaman en başa geri dönüyor en baştan yine bakıyor yukardakı caselerin hiçbirine uymuyor o yuzden devam ettı işlemine
            //sonra en baktı 0 mı değil mi seçim artık 0 yuzden kodu bırakıp uygulamayı kapatıyor olacak.
            //burda eksik olan bırıncı sayıyı dogru gırdım ama ıkıncıyı yanlış girdiğimde bu kodda uygulama en başa dönuyor ama en başa dönme değil
            //bana ıkıncı sayıyı hatalı girdiniz diye uyarı vermesı gerekır. bu şekilde hata vermiyor ama düzgün de çalışmıyor.
            //ven seçimlerden tolama cıkarma capma vs. sectıkten sonra uygulama bırıncı sayıyı ısteyınce yanlıs gırdğımde yanı harf gırdığımde 
            //bana 1. sayıyı yanlış girdiniz diye uyarı vermesi gerekir.
            //burda seçim kısmında 


            //bize şart sağlandığı müddetçe uygulamanın hiç durmadan devam etmesi için kullanabileceğimiz bir döngü gerekli.
            // oyüzden dowhıle döngüsünü kullananıyoruz ki ekranda sürekli işlemler bittiğinde ya da hatalı bir değer girdiğinde 
            //sürekli bu menüye tekrar döndürmek. o yüzden dowhılenın içine 










        }
    }
}