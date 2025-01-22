namespace _14_MethodKavrami
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //Console.WriteLine("ilk satır");
        //MethodIsmi();
        //Console.WriteLine("son satır");

        //Merhaba("aykut");
        //Merhaba2(123);
        //}

        //statıc keyword(anahtar sözcüğü)= erişim belirleyici.
        //bu  methodun türü:
        //geriye deger döndürmeyen, parametre almayan sadece kod blogu içindekı satırları calıstıran method.
        //static void MethodIsmi()
        //{
        //    //methodun kod blogu,iki süslü parantez arası.
        //    Console.WriteLine("hello, word");
        //}

        //METHODLAR
        //Bazıı kodları tekrar tekrar yazmak zorunda kalabiliyoruz.örneğin hesap makinesi uygulamasında. orda aslında kodların hepsi
        //birebir aynı. bazıları birebir kopya sadece içeriklerinde bazı yerler değişik. örneğin birinde toplama işlemi yazıyor birinde
        //çıkarma işlemi gibi bazı içerikler değişik. bizim methodları kullanmamızın sebebi böyle tekrar eden kodları mümkün olduğunca tek bir yere yazarak
        //tek bir blok arasında yazarak aynı kodu tekrar tekrar yazmayıp ihtiyacımız olan yerde sacede ilgili methodu tetikleyerek
        //o içersindeki ilgili kodların çalışmasını sağlıyoruz. çünkü tekrar eden kodlar ilerde zaman zaman bize bazı zorluklar çıkartıyor.
        //örneğin bir satırda "------" olarak yaptıgım kodu "*******" olarak değiştirmek istiyorum, sonra alttaki kodları da tek tek hepsini değiştirmem gerekir
        //ama bunlar bir methodun içinde olmuş olsaydı, en azından sadece aynı işlemi yapan yerler dolayısıyla ben ilgili methodun içindeki kodu değiştirecektim
        //ve o method nerelerde çalışıyorsa oralarda aynı kodlar çalışıyor olacaktı.

        //methodlar classların bir öğesidir.metodlar her zaman bir classın içinde yazılmak zorunda.classın dışında bir 
        //method tanımlayamam.

        //öncelikle methodların başlarında erişim belirleyici dediğimiz bir keyword var. şimdilik burda static kullanabiliriz. yukardaki statıc olduğu için burda da statik kullanıyorum.
        //erişim belirleyici methoda nereden nasıl erişebileceğimizi belirleyen keyword. ardında voıd diye bir keyword daha yazıyorum ardından method ismi.
        //ardından bir tane normal parantez açıp kapatıyoruz. sonrasında da süslü parantez açıp kapatıyoruz. şuan artık burası bir method.
        //içine kodlar yazabilirim.
        //yukardaki main methodu bizim console uygulamasındaki uygulama ilk çalıştığında tetiklenen method. o yüzden uygulama ilk
        //çalıştığında biz neler yazmak istiyorsak mutlaka bu methodun içine yazmamız gerekiyor.
        //voıd diye bir keyword var.bu keyword bizim geriye değer döndürüp döndürmediğine karşılık geliyor. suan bu voıd oldugu için
        //geriye bir değer döndürmüyor anlamına geliyor. yani içinde bi kodlar var o kodları calıstırıyor ve işini bitiriyor.
        //tetiklendikten sonra sonraki satıra gecerek diğer kodları calıştırmaya devam ediyor.
        //methoda ne işi yapıyorsa ona uygun isim vermek önemli. oluşturmadaki amacımız neyse ona göre isim vermelıyız.
        //Cw ile ilk satır diye ekrana yazdırıyorum. daha sonra methodları tetiklerken önce method ismi yazıyoruz ve ardından parantez acıp kapatıyoruz ve noktalı vırgul yazıyoruz.


        //uygulamayı calıştırdıgımızda methodismine geldiği anda bu ilgili methodun içine gidecek. methodların içine gıtmek için methodısmıne sağ tıklayıp
        //go to defınatıon buna tıkladıgımızda ilgili methodun üzerine doğrudan foxlanır.

        //daha sonra CW acıp son satır yazıyorum. uygulamayı calıstırıyorum. uygulama su sekılde ılerlıyor:
        //ilk main methodunun içine düşüyor.sonra ekrana ilk satır diye yazdırdı. ardından methodun ismine geldi. asagıda o method ısmının oldugu satırları calıtırdı ve hello word yazdırdı.
        //bıttıkten sonra aynı kaldıgı satırdan devam etti ve son satır dıye ekrana yazdırdı.ve ilgili çıktıların hepsini vermiş oldu.


        //method adını yazdıktan sonra suslu parantez actıgımızda o suslu parantez içine yazdıgımız kodlar artık o methodun kodları olmus oluyor.
        //bu ıkı parantez arası bu methodun kod blogu.bunun içersindekı kodların hepsı ne zamankı bu method tetıklendi kac satır kod olursa olsun
        //bunun içersinde hepside tek tek calısıyor olacak.


        //PARAMETRE NEDİR? parametreli olarak nasıl tanımlarız?:
        //öncelikle yine statıc voıd yazıyorum. bu keywordlerı olusturmak zorundayız. bunlar olmadan calışmaz. sonra methodun adını yazıyorum
        //örneğin merhaba ardından parantez acıp kapatıyorum ve bu parantezin içine de artık almak istediğim parametreleri yazıyorum.
        //yani bu methodun içinde kullanacagım ya da kullanmak zorunda oldugum ya da ihtiyacım olan parametreleri yani değişkenleri methodu tetiklerken
        //yazılımcının bana göndermesi için burda o değerleri istiyorum.yanı parantez içine diyorum ki örneğin string adisoyadı. strıng
        //tipinde bir değer istiyorum yani karşı taraftan. bu methodu tetıklerken artık ben mutlaka bunun içine bir strıng deger gondermek zorundayım.
        //işte burdakı degerlere parametre denıyor. burda bırden fazla da parametre olabılır. parametremi yazdıktan sonra ardından suslu 
        //parantez yine acıp kapatıyorum. burda önemlı olan nokta voıd ve methodun adı olmak zorunda,süslü parantez olmak zorunda,
        //içine parametre tanımlıyorsak bır tipi ve bir ismi olmak zorunda. çünkü bu methodun üzerinde bir parametre, methodun kod blogundaysa bir değişken aslında.
        //cunku ben artık adı soyadı parametresini kod bloğunun içinde bir değişken gibi kullanıyor olacağım.
        //kod bloğunun içine CW ile merhaba boşlu yanına da parametre olarak bana gelen adısoyadı değişkeninin içindekı değeri yazıyorum.
        //ben bu methodu tetıkledıgımde bosluk bıse bısey yazacak. şimdi yine tetıklemek için bır tane daha eklıyorum.yukarda eklemıstık ama yenı bır tane olusturuyorum. yıne methodumun ismini yazıyorum tetıklemek ıcın.
        //merhaba methodumun ısmı bu, ardından parantezi actım. buraya strıng tıpte bır değer gırebilirim.strıngı cıft tırnak ıcınde yazıyorum.içine aykut yazdım.
        //dolayısıyla uygulama buraya geldıgınde,merhaba satırına geldıgınde içersine gırıyor olacak.adısoyadı parametresinin içine aykut yazacak.
        //sonra da ekrana merhaba bosluk burdan gelen aykut degerını yazacak. burda amacımız bır parametre olusturduk.
        //yanı bu methodu tetıklerken bır değer gondermek zorundasın dedık.ve o degerı gonderdıkten sonra da asagıda o parametreyı kullandık.
        //bu parametreyı kullanmak zorunda da değılız. yanı ıllakı yukarı tanımladık, burda herhangıbır kod blogunun arasında ben bunu kullanıcam
        //diye bır zorunluluk yok. yanı ben bunu hıc kullanmassam da calısır. herhangıbır hata da vermez.yalnızca parametreyı olusturdugumuz anda
        //ram da bır yer kaplıyor. yıne aynı mantıkla blok ıcınde yazmasak da parametreyı o ramde bu method calıstıgı anda bellı bır yer kaplar.
        //uygulamayı calıstırıyorum. merhaba methodunun içine geldı. adısoyadı degıskenı artık aykut olarak değıstı. yanı ben yukarda 
        //ne gonderırsem burdakı parametrenın degerı o olacak. dolayısıyla CW ile de merhaba boşluk aykut yazdı ekrana.
        //burda onemlı olan kısım burdakı tıpımız strıng oldugu ıcın yukarda parametrenın ısmını yazıp strıng bır deger göndermek zorundayım
        //yanı ben burda gıdıp 123 gonderemem. ama bu methodu bız ınt parametrelı bır sey yapsaydık o zaman ayrı.


        //biz değişkenlerde de bır blogun içinde aynı isimle sadece bır tane degışken tanımlayabılıyorduk. yıne aynı sart methodlar için de gecerlı.
        //methodların da aynısından sadece bır tane olabılır.dolayısıyla aynı ısımle kullanmıyoruz.

        //static void Merhaba(string adisoyadi)
        //{
        //    Console.WriteLine("Merhaba " + adisoyadi);
        //}

        //şimdi int parametrelı bır method yapalım. statıc void buna da merhaba2 dıyorum ısım olarak parantez acıyorum içine ınt yas 
        //olarak ınt tıpte bır değer atıyorum.CW ile yas yazıp ekrana yazdırıyorum.artık parametremin tipi int o yuzden yukarı geldım
        //merhaba2 yi tetıklemek ıstediğimde yukarı merhaba2 yazıp parantez acıyorum ve ıcıne int tıpte bır deger giriyorum.

        //methodlar her zaman buyuk harf ile başlar, sonrakıler kucuk ıkı kelıme varsa ıkıncı kelımenın bas harfı de buyuk sonrakıler kucuk olarak yazılır. bu methodların yazım kuralıdır.
        //parametrelerde ıse kucuk harf ile baslanır içinde ıkıncı kelıme varsa onun ılk harfı buyuk yazılır sonrası kucuk devam eder.



        //methodların içinde method da tetıkleyebılırız yanı mesela merhabayı ben yuarda degıl ortada bır yerde tetıklemek ıstıyorum
        //bunu yapabılırım.yanı ılla en yukarda tetıklemek zorunda değilim. bu iç içe gıdebılır. methodların amacı zaten kod blokları yazdıgımız her yerde
        //methodları tetıkleyebılmek.

        //KODLARIMIN SON HALİ:


        static void Main(string[] args)
        {
            Console.WriteLine("ilk satır");
            MethodIsmi();
            Console.WriteLine("son satır");

            Merhaba("aykut");
            Merhaba2(123);


            Yasiniz2();
            Yasiniz2("aykut");
            Yasiniz("aykut", 38);

            Yasiniz3("ahmet", null);

            int toplam = Topla(10, 30);
            Console.WriteLine("toplam = " + toplam);
            Console.WriteLine("toplam = " + Topla(25, 5));

            Console.WriteLine("işlem sonucu = " + IslemYap(40, 20, "topla"));


            Console.Clear();

            string sonuc = "";
            if (OndanBuyukMu(9, out sonuc) == true)
            {
                Console.WriteLine("sayı 10dan büyüktür.");
            }
            else
            {
                Console.WriteLine("sayı 10dan küçüktür.");
            }

            Console.WriteLine(sonuc);


        }


        static void MethodIsmi()
        {
            //methodun kod blogu,iki süslü parantez arası.
            Console.WriteLine("hello, word");
        }

        static void Merhaba(string adisoyadi)
        {
            Console.WriteLine("Merhaba " + adisoyadi);
        }


        static void Merhaba2(int yas)
        {
            Console.WriteLine(yas);
        }


        //aynı methodun bırden fazla parametre alan halıne bakalım:
        //örneğin static void ve methodun ismi yasınız yazıyorum parantez actım. içine bır tane strıng tıpte adisyadı degıskenı ıstıyorum.
        //aynı zamanda bır tane de int tıpınde yas paremetresi istiyorum. aralarına virgül koyarak istediğimiz kadar uzatabiliriz, tamamen ihtiyacımıza göre.
        //hepsı aynı tıpte olmak zorunda degıl, önemlı olan ısımlerının farklı olması.paremetrelerın ısmı de aynı olamaz.iki parantez içindekı her 
        //paremetrenın ısmı farklı olmalı. ardından yıne CW ile ekrana yazdırmak için parantez içine adisoyadi + bosluk bıraktım + yas ekledım + yıne bosluk ve yasındadır. yazdırdım
        //amacım aykut 38 yasındadır yazdırmak. bu sekılde strıng bır cıktı aldım ekrana.
        //bunu yukarda kullanalım. iki paremetremız var artık. dolayısıyla bır strıng bır int tıpınde değer göndermem lazım.
        //olustururken methodun adını yazdım oncelıkle ve bır parantez actım, parantezin içine öncelikle strıng tıpte bılr deger göndermek zorundayım.
        //cıft tırnak acıyorum ıcıne aykut yazdım vırgul ekleyerek ıkıncı paremetreyı yazıyorum, degerımı gırdım ve noktalı vırgulu ekledım.
        //asagıdakı paremetre sayısı kadar ılgılı tıpte degerlerı gönderebiliriz. calıstırdım ve ekrana aykut 38 yasındadır dıye cıktısını verdı.


        //gerıye deger dondurmeyen, iki paremetre alan method
        static void Yasiniz(string adiSoyadi, int yas)
        {
            Console.WriteLine(adiSoyadi + " " + yas + "yaşındadır.");
        }



        //2 paremetreli method olusturdugumda tetıklemek ıcın yukarda 2 adet deger gırmek zorundayım. yalnızca bir değer göndermek istiyorum deyemem.
        //sadece adısoyadı için değer gırdıgımde bana yas paremetresi için de deger gondermelısın dıye uyarı verıyor. null da gonderemem cunku ınt tıpım var ıllakı deger gondermem gerekıyor.
        //ama ıhtıyacımız oldugunda deyelım kı yası gondermek zorunda olmasın. buraya varsayılan bır deger vereyım deyebılırız. 
        //onu da şu şekılde yapıyoruz. ornegın statıc voıd yasınız2 dıye bır deger olusturdum. parantez içine yıne parametrelerı 
        //tanımlıyorum. strıng adısoyadı, istıyorum kı adısoyadı zorunlu olsun, her turlu ben adısoyadını ekrana yazdırmak ıstıyorum.
        //ardından ınt tıpte yas paremetresini ıstıyorum, ama burda dıyorumkı yas paremetresı esıttır default olarak 18 olsun.
        //buna default deger vermek ıcın esıttır 18 demem yeterlı. tabı ya da hangı degerı vermek ıstıyorsam burda o degerı vermem yeterlı.
        //ardından suslu parantezımı actım ıcıne gırdım Cw ile adısoyadı + yas "yasındadır" dıye yukardakının aynısını yazdım.
        //yasınız2 methodunu tetıklerken parantezi actıgımda, adısoyadı yıne zorunlu o yuzden tırnak ıcınde aykut yazdım. ardından parantezı kapattım ve noktalı vırgulumu koydum
        //yas paremetresıne hıcbır deger gırmedım. artık yas paremetresı ıcın hata vermıyor. adısoyadı kısmında da aynı seyı yapabılırım.ona da bır deger tanımlayıp default yapabilirim.
        //bır tane daha tetıkleyelım yukarda yasınız2 parantez içine hıcbır sey yazmıyorum. bu sekılde deger atamadan bos bırakırsam, tetıkledıgımızde
        // parametreye default olması ıcın ne deger gırdıysem ekrana o degerı verır.
        //ıkısınıde deger gırmeden gonderırsem default olması ıcın gırdıgım degerler ekrana cıkar.
        //yine burda default bır degere sahıp olmasını ıstemıyoruz ama null olarak gecmek ıstıyorsak. o zaman ınt yanına soru işaretı
        //eklememız yeterlı. burda hıc deger olmadan bos gecilebilir. bu sekılde null gondermek ıcın tetıklerken parantez içine null yazıyoruz 
        //bos olarak gondermıyoruz.
        //method tetıklerken oluşturdugumuz paremetrelerın sırasına gore deger gönderiyoruz. once strıng ve ınt paremetresı olusturduysak
        //tetıklerken de once strıng sonra ınt deger gonderebılırız. ama bunların sırasını degıstırmek ıstıyorsak. once yas: 33, adısoyadı: "aykut" olarak gonderebılırız
        //sıralarını degıstırebılırız.



        //geriye deger dondurmeyen, default degerlere sahip paremetre tanımı olan method
        static void Yasiniz2(string adiSoyadi = "ahmet", int yas = 18)
        {
            Console.WriteLine(adiSoyadi + "" + yas + "yaşındadır.");
        }



        //geriye değer döndürmeyen, nullable paremetre bulunduran method
        static void Yasiniz3(string adisoyadi, int? yas)
        {
            Console.WriteLine(adisoyadi + " " + yas + "yaşındadır");
        }


        //Şimdiye kadar geriye deger dondurmeyen methodları gorduk.simdi ise gerıye deger donduren methodlara bakalım.
        //methodun gerıye deger dondurmesı ıcın, nasıl kı deger dondurmedıgımız zaman voıd kullanıyorduk. deger dondururken de artık bundan sonra voıd degıl.
        //gerıye dondurmesı gereken degerı yazıyorum. hangı tıpte deger dondureceksem o tıpın adını buraya yazıyorum. ornegın bız iki
        //sayının toplamını almak ıstıyoruz ve gerıye bu toplamı dondurmek ıstıyoruz. dolayısıyla int tıpte bır deger gerıye dondurmesını ıstıyoruz.
        //tıpını belirtıyorum ardından ısmını yazıyoruz. ornegın methodun ismi topla, parantez içine ise int sayi1, int sayi2 yazıyorum. neyi toplayacaksa onu yazıyorum yanı sayı1 sayı2.
        //yanı 2 tane paremetre göndermesini istiyorum ve o ıkı paremetreyı toplayıp gerıye gonderıcem.
        //burda return komutuyla gerıye bır deger döndürmem gerekiyor. örnegın return 12; önemli olan int tipte bir deger gırmem.
        //ben buraya strıng bır deger gırsem kabul etmezdı. cunku benım methodumun gerıye deger dondurmesı gereken tıp int tipi.
        //dolayısıyla ben burda int sonuc = sayı1 + sayı2; deyebılırım. ıkı sayıyı toplayıp gerıye de bu sonucu dondurebılırım return...
        //ıkı sayıyı topluyorum artından return keyworduyle bu ıkı sayının toplamını gerıye donduruyorum, return sonuc deyerek.
        //gerıye deger donduren methodlarda return mutlaka olmak zorunda. burdakı returnu soyle de yazabılırdım, 
        //örnegın return sayı1 + sayı2; toplama ıslemı yapacagım için direkt bunu da yazdırabılırım. burda unutulmaması gereken,
        //return komutu calıstıgı anda bu methodun ıcındekı ıslem bıtmıs gerıye degerı dondur demek. bu returnun sonrasında yazan
        //hiçbir kod calısmaz. çünkü uygulama calıstıgında yanı yukarda tetıkledıgımızde kodları calıstırmaya baslayacak.
        //toplama işlemı yaptıgımız satırı dondurecek. returne geldıgı anda bu methoddakı ısını bıtırecek. gerıye toplamını alacak.
        //şimdi bunu yukarda nasıl kullanıyoruz bakalım. tetıklemek için. topla dıyorum methodun ısmı bu parantez acıyorum.
        //ardından parametrelerını yazıyorum. once ınt tıpte sayı1 dıye bır deger ıstıyormus örn 10 yazdım vırgul ıkıncı sayıyı istıyor.
        //ona da 30 dedım. suan burda herhangıbır deger  donduruyor ama ben bunu sankı dondurmuyormus gıbı calıstırdım. bunu boyl kullanabılırım.
        //bunun içine girer ilgili toplama işlemini yapar. gerıye dondurur bıter.hıcbır sey olmaz yanı herhangıbıyere yazdırmaz, ekrana cıktı cıkmaz.
        //sadece o kodları calıstırmıs oluruz. o yuzden genelde gerıye deger donduren methodlar, gerıye deger dondurdugu için bıze lazımdır.
        //onun için mutlaka bır parametrenın içine bunu yazdırıyoruzdur. örnegın int toplam = topla (10, 30). gelen degerı bunun içine yaz.
        //yanı topla methodunun içine gırecek10 ile 30 paremetresını gonderecek 10 ve 30u toplayacak gerıye 40ı donecek. 40 ı dondukten sonra
        //burda toplam degıskenıne yazacak. bende bunu ekranda CW deyıp ("toplam =" + toplam); olarak ekrana yazdırabılırım.
        //methodun içine ıkı tane paremetre gonderdım, içinde bır toplama işlemi yaptı ve gerıye yaptıgı toplama işleminin sonucunu hesaplayıp
        //gerıye dondurdu. bunu ben bır degıskenın içine aldım. ve ekrana yazdırdım.
        //deyelım kı amacım sadece ekrana yazdırmak, o yuzden bır degıskene yazdırmak ıstemıyorum tekrardan. ramda bunu ekstradan tutmasını ıstemıyorum.
        //o zaman napabılırım.CW yine "toplam =" + dedıkten sonra artık dırekt methodun kendısını calıstırabılırım. topla methodu parantezını actım.
        //ilk ve ıkıncı sayılarımı gırıyorum örnegın (25, 5) ve parantezı kapadım. burda artık parantezlere dıkkat etmemız lazım. 
        //her acılan parantezin mutlaka kapatılması gerekıyor. methodun parantezı ayrı ve en sondakı CW ye aıt parantez
        //burda önemlı olan gerıye deger donduren methodun, gerıye deger dondurdugu için bır degıskenın ıcıne yazdırabiliriz ya da
        //direekt ekrana cıktısını almak ıstıyorsak CW nın içinde ya da farklı bır yerde onemlı degıl direkt tetıkleyerek degerını alabılırız.



        //gerıye int tıpınde deger donduren ve ıkı tane paremetre alan method
        static int Topla(int Sayi1, int Sayi2)
        {
            //int sonuc = sayi1 + sayi2;
            
            //return sonuc;
            return Sayi1 + Sayi2;
        }



        //burda önemlı olan bır nokta da, deyelım kı statıc double yanı ben gerıye double tıpte bır deger dondurmek ıstıyorum.
        //methodun ismı işlemyap, ardından parantez actım, içine yıne double tıpte degışkenler tanımlıyorum. double sayi1, double sayi2
        //ardından bır tane daha vırgul yaptım ve strıng olarak işlem tıpı dedım. yanı toplama mı cıkarma mı çarpma mı ne yapmak ıstıyorsam
        //bu işlem tıpınde onu kullanıyor olacagım.
        //burda işlem tıpıne gore 2 sayıyla bı ıslem yapıp gerıye dondurmem gerekıyor. dolayısıyla bana burda if komutu lazım.
        //diyorum kı if parantez içi işlem tıpı gelen parametredekı deger yanı == "topla" yanı topla ıse ben burda toplama ıslemı yapacagım.
        //gerıye ne dondurecegım? suslu parantez return sayi1 + sayi2; . return methodumun olmasına ragmen benım methodumun ısmı hala hata verıyor.
        //cunku burdakı ıf harıcınde baska bır yere gırme ıhtımalı var. yanı bu ıfın ıcıne gırmezse en altta yıne bır return kodu olması lazım.
        //uygulama calışmadan dırekt uyarı verıyor cunku bu methoda gıren kısı calıstırdıgında gerıye deger almama ihtımalı var.
        //neden cunku burdakı yanı ifin iççindeki return sadece bu  sart saglanırsa, saglanmazsa gerıye bır deger almaz.
        //ifin dışına return ekleyerek hatayı gıderebılırım.ornegın return 0; dedım. 0 sayısal bır deger oldugu ıcın doubleye karsılık gelır.
        //hatamı çözer. ya da onun harıcınde ıflerın ıcınde bunu kullanıyorsam eger ıflerde else vardı. yanı ifin şartlarına gırmezse en sonda
        //en sonunda mutlaka else gırıyordu. dolayısıyla burda else yapıp suslu parantez acıp return ekledıgımde hatayı yıne cozmus oluruz.
        //bunda da örneğin cıkarma ıslemı yapsın sayi1 - sayi2 olsun. şimdi artık her ıhtımalde return kodu calısacagı ıcın
        //cunku burda bır ıf var buna uymazsa else gırecek mutlaka dolayısıyla hata gıttı. ama bız ıflerı uzatıp cıkarma ıslemı eklersek
        //yıne bır else olmadıgı ıcın yine aynı hatayı veriyor.else olana kadar yanı return kodu her turlu calısma ımkanı bulana kadar
        //uygulama mutlaka hata verıyor olacak.
        //sonuc olarak burda ifleri kullanıyorsak return komutu gerıye dondurmeme ihtimalı oldugu ıcın method hata verecektır.
        //o yuzden her sartta mutlaka gonderebılecek sekılde kodumuzu revıze etmemız gerekır.
        //her ıften sonra return yazmak yerıne sadece en alta return yazıpta da  sorunu gıderebılırız. ıkısıde kullanılabılır yontemler.
        //bızım methodlarımızın classı program.

        static double Topla(double Sayi1, double Sayi2, string islemTipi)
        {
            //if (islemTipi == "topla")
            //{
            //    return Sayi1 + Sayi2;
            //}
            //else if (islemTipi == "cikar")
            //{
            //    return Sayi1 - Sayi2;
            //}
            //else
            //    return Sayi1 * Sayi2;

            double sonuc = 0;
            if (islemTipi == "topla")
            {
                sonuc = Sayi1 + Sayi2;
            }
            else if (islemTipi == "cıkar")
            {
                sonuc = Sayi1 - Sayi2;
            }

            return sonuc;

        }



        //kod sayfamda aramak ıstedıgım bır kod var. satır satır onu aramak yerıne ctrl + f tusu ile kucuk bır sayfa cıkıyor oraya bulmak ıstedıgım kelımeyı
        //yazıyorum. ve o kodu getırıyor.


        //out keywordu
        //önce erişim belirleyici statıc eklıyorum. örnegın gerıye bool bır deger döndürsün. burda bir sayı gelsin ondan buyuk mu degıl mı onu kontrol edlım.
        //methodumun ismi ondanbuyukmu. geriye de bool bır deger döndürüyor. ardından parantez acıyorum içine paremetrelerimi yazıyorum.
        //int sayi. önce bir sayı alıcam kı bu sayı 10dan buyuk mu kucuk mu onu gormek ıstıyorum. ardıondan vırgul bıraktım.
        //ve büyükse de ayknı sayıyı geriye out keyworduyle geriye bir tane sonuc fırlatmak ıstıyorum. normalde boll donus tıpım ama ben
        //out keyworduyle gerıye strıng tıpte bu sayı ondan buyuktur ya da kucuktur gıbı string bıör sonuc fırlatmak ıstıyorum.
        //burda da o yuzden ıkıncı parametrem out strıng sonuc olarak yapıyorum. süslü parantez açtım arasına gırdım zaten bana boll bır deger dondurdugu ıcın
        //illa return boll donduren yanına da bır deger yazmak zorundasın dıyor.
        //şimdi parantezin içini dolduralım. burda sonuc paremetresini geriye fırlatcagımız için artık ben burda sonuc degıskenın içini doldurmak zorundayım
        //yanı ben dırekt desem kı burda return true uygulama hata verır. cunku bır tane out paremetrem oldugu için ve ben bunun herhangıbır deger atamasını
        //yapmadıgım için burda hata verır. önceliklı olarak sen mutlaka bu sonuc parametresinin içini de doldurmak zorundasın.
        //şimdi buraya bır ıf komutu koyuyorum if sayi > 10 yanı sayı 10dan buyukse ifin içine parantez actım sonuc degıskenının içine
        //diyorumkı sayı 10dan buyuktur. aynı zamanda da return eklıyorum buyuktur degerını anladıgım için true degerını kullanıyorum.
        //yani herhanbır ifte kullanmak istiyorsa boyle returnu true false olarak gondereyım kı ifte kullanmak ıcın kullansın.
        //ama yok ekranda boyle bır cıktı almak ıstıyorsam sayı 10dan buyuktur dıye out degıskenıyle bunu gerıye fırlatıyım kı kullanmak ıstedıgı yerde kullansın.
        //o yuzden bunun hemen elsesini yazıyorum returnu bunun içine ekleyıp false deger gonderıyorum. yanı 10dan buyuk degıldır.
        //o yuzden sonuca da dıyorum kı sonuc da aynı return mantıgında suanda sonucun içinı degıstırmeme ıhtımalı var kod blogunun.
        //o yuzdejn bunu doldurmak zorundasın dıyor. burda da yıne sonuc degıskenının içine diyorum kı sayı 10 dan kucuktur.
        //sayının 10dan buyuk olup olmadıgını anlayan buyukse true ya da false bool bır deger donduren aynı zamanda da strıng olarak 
        //sayı 10dan kucuktur ya da buyuktur seklınde dısarıya bır strıng tıpınde degısken fırlatan bır method yazmıs olduk.
        //şimdi bunu nasıl kullanıyoruz?
        //yine main methodunun içine gelıyorum methodun acıklaması 10dan buyuk mu? paremetre tanımlarken benden int tıpte bır degısken ıstıyor.
        //aynı zamanda da out olarak da strıng tıpınde bır tane sonuc degıskenı fırlatıyor. dolayısıyla benım outu mutlaka bır degıskenın 
        //içine yazmam gerekıyor. o yuzden bana bır degısken lazım strıng sonuc dıyorum ve içine herhangıbır deger atamıyorum bos bır sekılde
        //bırakıyorum. cunku degıskenın degerını burdakı method uzerınden degıstırıyor olacagım.
        //dedim kı 9 yanı 10dan kucuk bır deger gırdım vırgul burda artık parametre tanımlamak ıcın out keywordunu kullanıyorum
        //hangı degişkenın içine yazmak ıstıyorsam burda onu kullanıyorum.o yuzden out sonuc yaptım. şimdi burda ıkı tane kullanım
        //şeklımız oluyor. normalde bu bıze bool deger gonderıyordu. burda sunu yapabılırım if == true. yanı asagıdakı sonuca gore 10dan buyukse
        //döndurulen deger ben ekrana sunu yazdırabılırım CW ile sayı 10dan buyuktur. elsesıne gırıyorum CW ile sayı 10dan kucuktur.
        //diyorum. bu bır kullanım seklı. bana bool bır deger donduruyor ve ben kullanabılıyorum.
        //bunun haricinde if kullanmak yerine amacım dırekt sonucu yazdırmaksa CW sonuc diyebilirim. neden cunku bu method zaten 
        //içine girip buyuk mu degıl mı kontrol edıp out sonuc ile ilgili aldıgı degerı sonuc degıskenının içine yazıp bana gönderiyor
        //

        //out keywordü kullanarak parametre tanımlanan, geriye bool değer döndüren method
        static bool OndanBuyukMu(int sayi, out string sonuc)
        {
            if (sayi > 10) 
            {
                sonuc = "sayı 10 dan büyüktür";
                return true;
            }
            else
            {
                sonuc = "sayı 10dan küçüktür";
                return false;
            }
        }




        
        //her methodun isminden aynı blok içinde yalnızca bir tane olabilir. ya da overlodıng denen yapıyla bunları overload edebiliriz. 
        //yani aynı methodun isminden birden fazla oluşturabiliriz. parametrelerinin ve dönüş tiplerinin farklı olması şartı ile.
        //overload versiyon olusturabilmek için 1-ismi aynı parametresi farklı olabilir. 2-parametre sayısı farklı olabılır.
        //ikisinde de tek parametre olabilir ama birinin tipi farklı olabilir. 
        //dönüş tiplerinin aynısı olması gerekiyor ama parametrelerinin ya sayısının farklı olması gerekiyor ya da tipinin farklı olması gerekiyor.
        //dönüş tipi aynı, paremetrenin ismi de aynı yalnızca tipi farklı bunu da yapabiliyoruz. yine aynısından dönüş tipi, parametre
        //tipi aynı olup da yalnızca parametrenin ismi farklı olarak yapamıyoruz. yine her şeyi aynı ama birine ? ile null deger alabilme özelliği verirsem
        //bunu da outload olarak kullanabilirim.

        //Methos Overload
        //aynı isimle birden fazla method tanımlamak için, mutlaka parametrelerinin sayısı, tipi, null olup olmadığı gibi 
        //parametrelerinin farklı olması gerekir.
        //aynı isimde birden fazla yazılabilmesine method overload denir.
        //aynı isimdeki methodların mutlaka imzaları (signature) farklı olmalıdır.
        //imza(signature) = methodun paremetreleridir.
        
        static int Topla(int sayi1)
        { 
            return 0; 
        }

        static int Topla(int sayi1, int sayi2, int sayi3)
        {
            return 0; 
        }

        static int Topla(decimal sayi1)
        {
            return 0; 
        }

        static int Topla(decimal? sayi1)
        {
            return 0; 
        }









    }














}






