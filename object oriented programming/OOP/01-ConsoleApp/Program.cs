namespace _01_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object orientıng programıng= nesne yönetimli pşrogramlama.
            //gerçek hayatta karşımıza çıkan ve bunları koda dökmek istediğimizde birebir normal güncel hayattaki 
            //nesneleri yazılım tarafında da aynı şekilde, aynı işleri karşılayacak şekilde nesnelere dönüştürülmesi.
            //çözülmesi istenen problemi ya da geliştirilmesi istenen uygulamayı çeşitli
            //parçalara-nesnelere ayırarak, her parçanın da sadece kendi işini yapabildiği 
            //ve parçalar arsındaki ilişkileri de gerçeğe uygun şekilde birebir kod tarafındaki
            //nesnelerle(burda bahsettiğimiz nesneler classlar oluyor) bu claslara dönüştürülme tekniğidir.
            //tamamen classlara özel ya da classlarla yapabildiğimiz işlemlerin geneline deniyor.
            //object orientedın içinde ekstra birşey yok tamamen classlar üzerinden ilerlememiz gereken bir
            //durum var.



            //normal şartlarda bizim hazırda gelen bir tane cs dosyamız vardı ve bu
            //bizim olmzsa olmazımızdı çünkü uygulamayı çalıştırdığımızda doğrudan bu
            //bu program classının altına girip main metodunu çalıştırarak içerdeki kodlarla
            //ekrana bir şey yazdırdıysak ya da almak istiyorsak o yazdığımız kodların hepsi çalışıyordu.
            //artık class libraryde herhangibir program cs yok örnek olarak bir tane bize class eklemiş. bu classı da zaten silip yeniden ekleyebiliriz.
            //onun haricinde içinde hiçbir şey yok. örneğin buraya bir tane class ekleyelim. projenin üstünde sağ tıkladım
            //ardından add dedim ve aşağıdaki classa tıkladım. daha sonra bana bir ekran çıkıyor. burda classıma isim giriyorum
            //örneğin araba girdim ve bunu da class librarynin altına ekledim. arydından açılan ekranda bakıyorum. classlarda
            //neler var, neler eklememiz gerekiyor, içinedeki classın öğeleri nelerdir onlara bi bakalım.
            //ilk olarak bizim classlarda kullanma mantığımız bu şekilde. önce bir erişim belirleyicimiz var bunlara
            //axes modıfyl deniliyor yanı ınternal yazan. bunun bır tane de publıc olan hali var. bır de prıvate var. aynı class isminden yine projenın
            //içinde iki tane olamaz. elimizde 3 tane erişim belirleyici var. bu erişim belirleyiciler nedir onlara bakalım
            //şimdi normalde bizim artık iki tane projemiz var dolayısıyla ben bu projedeki classlara diğer proje içinden de erişmem gerekiyor.
            //ya da yine aynı şekilde bu projenın içindeki bu classa diğer classların içinde erişip erişemeyeceğimi belirlemem gerekiyor.
            //burda işte prıvate diye tanımladığımız erişim beliryeyici sadece bu classın içinde kullanılır yani bu classın içinden 
            //erişebiliriz. onun haricinde hiçbir projeden ya da aynı projenın içindekı farklı bır classtan dahi bu private olan 
            //classların içine erişim sağlayamayız. yani bu özel zaten ingilizce karşılığı da özel demek.
            //ardından birde publıc var. bu publıc de artık herkes bunu kullanabilir demek oluyor. yani ben bu classı bu projenin içindeki
            //her yerden erişebilirim. ama yukardaki projeden aşağıdakine erişmem için ikisi arasında bağlantı kurmam, birbirine referans vermem gerekiyor.
            //ınternal olanlarda ise bu projenin içinde kullanılabilen bir erişim belirleyicisidir. yine aynı publıc gibi bu
            //projenın içinde her yerde kullanabiliriz ancak eğerki ınternal yaptığımız bu classlar varsa bır projeyı dıger projeye
            //referans alsam bile bu projeye başka projeden erişemem sadece publıc olana erişebilirim. herhangibir sebeple yeni bir class oluşturduğumuzda
            //her zaman ınternal olarak oluşturulur. ya da erişim belirleyicisini yazmazsak bile yazmak zorunda değiliz yazmasakta
            //bu ınternal anlamına gelir. yani varsayılan defalt olarak erişim belirleyici ınternaldır.
            //PRİVATE: iki parantez içine eklediğim herhangibir öğenin erişim belirleyicisi eğer pıvate ise ben o öğeye sadece bu iki
            //parantez içinden erişebilirim. en başta olusturdugum consolapp ve classlibrary bu projelerin ikisinden de erişemem. prıvatenın karsılıgı bu.
            //İNTERNAL:internal bır classa ya da öğeye classlibrary projesinin her yerinden erişebilirim ama gidipte consolenın
            //içinden classlıbrarynin içindeki internal erişim belirleyicili bir classa erişemem.
            //PUBLİC: publik olduğunda classlibraryden de erişebilirim, consoleappten de erişebilirim,her yerden erişebilirim. publıc herkese acık anlamına geliyor.
            //dolayısıyla biz nesnelerimizi oluştururken özellikle buna dikkat etmemiz gerekiyor. örneğin uygulamanın cok önemli bır classı
            //vardır dolayısıyla bunu publıc yapmamalıyız kı o classlibrarye erişen hiçkimse o metoda dokunamasın, o yüzden özel olanları
            //mutlaka pıvate olarak ayarlamamız gerekiyor.
            //bunlar bizim classlarımız. classlarımızı oluşturma şeklimiz bu. mutlaka dışarda biryerde olması lazım yani ben classı
            //örneğin gidipte bir metodun içinde oluşturamam yani ınternal classı içinde iç içe classlar olusturamam.
            //mutlaka bir classın dışında oluşturmam gerekiyor. ama aynı program içinde birden fazla class olusturabılırım.
            //gidipte hepsi için yeni program eklememe gerek yok.
            //classları olustururken once erişim belirleyicisini yazıyorum sonra class yazıyorum sonra ismini yazıyorum. nasılkı değişken
            //olustururken once tıpını yazıyorduk sonra ismini vs. aynı o mantık.
            //classlarda erişim belirleyiciyi girdikten sonra class olarak belirtiyorum ki onun bir class olduğu belli olsun.
            //ardından classın ismini yazıyoruz. başka bir yerden classa erişmek için bu araba keyworduyle artık erişiyor olacağız.
            //ardından da yine iki parantezi açıp kapattık ve artık bu classın butun öğelerini bütün kodlarını bu iki süslü parantez arasına yazıyor olacağız.
            //ilk olarak bizim kullanacağımız fields'ler var. bunlar da değişkenler. değişkenleri daha önce de zaten hep kullanmıştık.
            //yine bu bi classın öğesi olabiliyor bir class için bunlar tanımlanabiliyor ve dışardan da bunlara erişim sağlanabiliyor.
            //içine hem değer atılabilir hem de değer çekilebilir.
            //örneğin bir tane oluşturalım örneğin int tipinde bir değişkenimiz olsun classımız arabaydı buna da diyelimki suankihiz
            //arabanın şuanki hizini burda tutmak istiyoruz örneğin. araba nesnesini yavaş yavaş buraya işliyor olacağız.
            //ihtiyacımıza göre mümkün olduğunca classları gerçeğe yakın yapmamızda fayda var. şimdi burda tipini belirledim ve değişkenin
            //ismini belirledim. aynı zamanda buraya örneğin publıc ya da prıvate olarak iki değişken ekliyorum diğer değişkenin adı da suankiyolcusayisi
            //bu ikisi artık bu classın öğesi, bu clasın değişkenleri. bunlar araba classına bağlı. ben bunlara erişmek için mutlaka artık her yerde
            //önce bu arabayı yazmam lazım ardından da bunun içindeki öğelere erişebilmem gerekiyor. burdaki iki değişkene de değer ataması
            //ve değer çekmesi yapabiliriz.
            //ikinci öğemiz de propertıes (özellikler) en sık kullanılan. burdaki özellikler de değişkenlere benziyor sadece değişkenlerin biraz daha gelişmiş hali
            //burda yine aynı önce bir erişim belirleyicimiz var ardından yıne bu propertinin tipi var. örneğin buraya deyelim ki string.
            //arabanın ne özelliği olur örneğin markası olur. bu markanın yani özelliğin adını giriyorum. araba classının bir özelliği artık bu.
            //içine değer atılabilir ve değer çekilebilir anlamında. değişkenlerden farklı olarak, değişkenlerin yanında hiçbie şey yoktu
            //herhangibir değer de atamadık parantez de yok. şimdi özelliğin içinde get ve set yazan iki tane keyword çıktı.
            //ikisinin arasındaki tek fark get ve set metotlarının olması. bu metotlar sayesinde bu öğelerin içine bir değer atarken
            //bu metotlar sayesinde araya girerek bazı işlemler yapmamıza imkan sağlıyor. bunun haricinde birkaç tane daha ekleyelim.
            //model ve maksimimhız gibi özellikler ekliyorum. bu özelliğin adını biz yazıyoruz. değişkenler genelde bu class özelinde kullanılmak için
            //tanımlanır.dışardan erişip içindeki değerleri değiştirmek için kullanılmaz. o yüzden bunlar genelde prıvate olarak tanımlanır.
            //bunları tanımlarken alt tire ve küçük harfle başlayabiliriz. özellikleri tanımlarken büyük harfle ve ikinci kelimenin ilk harfi büyük
            //olacak şekilde yazabiliriz. bu ortak bir kuraldır, yazım kuralları bu şekildir.
            //bir de events(olaylar) var. yani örneğin araba çalıştırıldı, araba durduruldu. bir olay bir eylem oldu yani onlar için
            //kullanılan tanımlamalar. bunda da önce erişim belirleyici sonra event keywordu daha sonra eventhandler dediğimiz bir
            //tane classla mutlaka bunun türetilmesi gerekiyor. bunlar olaylara karşılık geliyor yani sen araba çalıştığında bir şey yapmak
            //istiyorsan burdaki eventın içinde yapman gerekiyor. örneğin araba çalıştı çalıştığı süre boyunca benzin harcama işlemini bu
            //eventler vasıtasıyla yapabiliyoruz.
            //birde bunların haricinde çok kullanılan constructors(temel yapı oluşturucusu). bu da eğerki bizim cllassı herhangi birisi kullandığı
            //anda, bizim illaki şu işlemi de yap ya da şu değişkenin değerini alsın ya da şu propertye değer versin ya da bana x herhangibir
            //değer göndersin gibi bazı zorunluluklar sağlayabiliyoruz. bunun için de yine ctor deyerek hızlıca bunu oluşturabiliyoruz.
            //bunu içi boş şekilde de oluşturabiliriz. illaki içini doldurmak zorunda değiliz. burda yine bir erişim belirleyicimiz var
            //ama isim verdiğimizde bunun ismi classımızın ismi neyse o olmak zorunda farklı bir isim veremiyoruz. birden cok da olustursak
            //aynı isimle oluşturmak zorundayız. aynı metotlardaki gibi metotların içeriğini overload ederek birden fazla metot haline getirebiliyorduk.
            //bunlar da aynı şekilde aynısının birebir halini kullanamıyorsunuz mutlaka içerinde bazı değerler değişmesi gerekiyor.
            //örneğin burda diyorum ki parantez içinde int yolcusayisi yani ben artık bu classı oluştururken mutlaka kişinin buoraya girip
            //bir yolcu sayısını göndermesini istiyorum dersek bunu bu şekilde kullanmasını sağlayabiliriz. peki yolcu sayısını gönderdi bunu
            //napıcam örneğin yukardaki değişkenimin içine atabilirim. suankıyolcu sayısı eşittir bana bu constructors da gelen yolcusayısı diyebilirim.
            //yani suankıyolcu = yolcusayısı; burdakı constructors içinden gelen yolcu sayısını sen al yukardaki değişkenin içine yaz. burdaki
            //değişken neydi prıvate idi dolayısıyla hiçbir yerden erişemezken contructors vasıtasıyla bunun içine erişebiliyoruz deyebiliriz.
            //son olarak metotlar var methods(metotlar) geçen dersimizde işlediğimiz metotların aynısı metotlarda classın öğesi olduğu için için 
            //mutlaka bır classın içine yazılıyor. yine aynı mantıkla erişim belirleyicisi var ardından dönüş tipini belirliyoruz void ve 
            //metotun ismi örneğin kapilarikilitle metodun ismi. şuan iççine bir kod yazmıyoruz, ihtiyaca göre daha sonra bunlar yazılabilir.
            //yine aynı mantıkla overload edilebilirler. nasılkı daha önce aynı metodun aynı dönüş tipiyle içine paremetre alarak
            //örneğin boll anahtarkontaktamı yani bir parametre istiyorum amacım o. birden fazla parametre isteyerek bunları değiştirerek.
            //metotların overload versiyonlarını buraya ekliyorum. illakı erışım belirleyici ve dönüş tipi aynı olmak zorunda değil
            //eğerki bu metoda başka birinin baska bır proje veya classtan erişmesini istemiyorsak erişim belirleyicisini değiştirebiliriz.
            //aynı mantıkla dönüş tipi yine eklenebilir ya da farklı farklı isimlerle metotlar da eklenebilir illaki tek metot değil.
            //örneğin bir tane de publıc voıd ılerle() şuan artık ben en bastakı araba classını olusturdugumda bu classın içindeki tüm elemanlara her yerden
            //erişebiliyor olacağım.
            //şimdi bu classı oluşturduk ve bu classı nasıl kullanabiliriz ona bakalım.
            //şimdi bizim elimizde bir classımız var. biz ne yapmak istiyoruz consolapp projesinin içinden oluşturduğumuz araba 
            //classına erişmek istiyoruz. ben burda direkt araba yazdığımda burda bır sey cıkmıyor cunku ben bu classı referans almadım
            //herhangibir sey yapmadım. biz burda classın adını doğru bir sekılde yazdıgımızda ve ctrl. yaptıgımızda bize doğrudan bir
            //referans olarak ekte 02_classslibrary projesi diye bir sekme cıkıyor. buna tıklayarak referans alabiliriz ya da bunu manuel
            //almak istiyorsak consoleapp in altındaki dependencies üzerine sağ tıklayıp add öproject reference tıklayıp ardından bir pencere
            //acılıyor ve burda bu solutıon içersindeki referance alabilecegimiz butun projeler alt alta listeleniyor. ben burdan reference 
            //almak istediğim projeyi seciyorum ve dependencies altına project isimli bir sekme geldi ve hangi projeyi referans aldıysak ilgili 
            //projenin buraya gelmesini sağladı. artık ben burdaki arabaya erişebilir durumdayım. şimdi araba yazdığımda direkt çıkıyor.
            //ama sadece araba yazdıgımda kullanamıyorum isminin yeşil olması gerekiyor. onun sebebi de bizim normalde bizim namespace
            //diye bir tipimiz vardı, ben bu araba classına erişmem için mutlaka bu namespacenin ismini kullanmam gerekiyor. yani önce namespacenin adı
            //nokta araba diyebilirim, bu bir kullanım yöntemi ama bunu uzun uzun yazmak istemiyorsam sadece araba yazdıgımda cıkmasını istiyorum.
            //o zaman bunun üst tarafta usıng satırı var onu eklemem gerekiyor. yine üzerinde ctrl. ya bastım hemen sekme olarak
            //üst tarafta cıkıyor usıng 02classlibrary olarak tıkladıgımda bunu ust tarafa ekledi. artık ben bu classın ıcınde yanı 
            //internal class program yazan yerden, her yerden artık bu classlibrarynın içindeki erişim belirleyicisi de publıc olan
            //classların hepsine erişebilirim anlamına geliyor. arabaya burda erişebildim arabanın içini nasıl dolduracagım.
            //öncelikle bizim arabanın bi nesnesini oluşturmamız gerekiyor. o yuzden burda diyorum kı araba boşluk değişken yani ismini belirliyorum örneğin nesne.
            //aynı bir değişken oluşturuyormuşuz gibi. ardından eşittir deyip new araba deyerek oluşturuyorum. artık ben arabanın içindeki
            //her şeye burdan erişebilir durumdayım(prıvate olmayan öğelerin hepsine). örneğin nesne.marka bizim zaten classımızda 
            //propertıes vardı bır tane marka,model,maksimumhız bunların herbırıne .marka deyerek tıpını de burda gorebiliyorum,get set
            //metotlarını da görebiliyorum yani bunun içine bir değer atabilirim anlamına geliyor. marka eşiittir "opel" dedim. artık
            //benim oluşturduğum araba nesnemin içindeki marka propertıesının değeri opel. ardından yine bakalım, private tanımlana ıkı değişkenimiz vardı
            //nesne._suankihız dediğimde cıkmıyor cunku bunlar publıc değil prıvate, o yuzden o tarafta erişemiyorum. erişim belirleyicinin
            //en net özelliği burda cıkıyor karsımıza. publıc olanlara erişebiliyorum nesne.model dedim = "corsa" ardından yıne nesne.maksımumhız = 180;
            //int tıpte. her bir propertıysine tek tek tanımlama yapabiliyorum. yine bunu ekrana yazdırmak isteseydık. örneğin markasını yazdırmak istiyorum.
            //Console.wrıteline("arabanın markası" + deyıp artık bu markayı yazdırmak istiyorum. artık ne yapmam gerekıyor benim elimde
            //oluşturdugum bır nesne var zaten bu ram de tutulan bır deger. bizim daha önceki derslerde değişkenleri tanımlarken veri tiplerinde bazıları reference types bazıları value types demiştik
            //ve bunların ramın stack ve heap bolmelerınde ayrı ayrı tutuldugundan bahsetmıştık. yine burda da bu reference typesoldugu için ramın step bolmesınde tutuluyor
            //sadece soyle bır fark var ramın stack bölgesinde burdakı araba nesnesinin kendisi tutuluyor. araba tipindeki  nesne ismiyle
            //bir değişken stack bölmesinde tutuluyor ama onun içindeki bütün değerler tip int ya da strıng olsun önemli değil bu nesneye ait
            //bütün verilerin hepsi heap bölmesinde tutuluyor. bu önemli bir nokta.
            //şimdi dedik ki Console.wrıteline("arabanın markası:" + bu araba nesnesinin markasını ekrana yazdırmak istiyorum dolayısıyla buraya artıdan
            //sonra nesne.marka dediğimde ben bu nesnenin markasına erişebilir durumda oluyorum. yine burda birden fazla nesne tanımlayabiliriz.
            //örneğin alta da nesne2 diyorum. artık benım ramda arba clasından 2 tane nesnem var. ben burda hangısını kullanmak ıstıyorsam ısmını yazarak
            //erişebiliyorum.
            //iki parantez arasında ben bu nesneyi oluşturdugum ıcın bu iki parantez içinde her yerde bunu kullanabılırım. yanı sadece
            //bu metodun ıcınde bu nesne ve nesne2 isimli nesnelerı her yerde kullanabılırım.
            //bırde bızım tanımladıgımız ıkı tane constructorsumuz vardı bır de bunun metotları vardı. yine öncelikle bı metotlara bakalım
            //örnegın nesne2 nokta ılerle metodu içine herhangıbır paremetre almıyordu donus tıpı voıd.
            //yine nesne2 nokta kapılarıkılıtle metodu ve bunun bı overload versıyonunun oldugunu gosterıyor. bırıncısı parantezı acıp
            //hıcbır sey kullanmadan gonderebılırsın bır tane de boll tıpte bır deger gondererek bunu kullanabılırsın anlamında bıze bunları 
            //sunuyor.
            //bizim bı constructorsumuz vardı o ne işe yarıyor. bu classta yenı bır nesne olustururken new araba deyıp parantez acıp kapattık.
            //dolayısıyla arabanın bır nesnesını olusturduk. constructorslar ıste burda devreye gırıyor. örnegın burda arabayı
            //olustururken parantez actıgımda artık burda ıkı tane var nedencunku bunun constructorsları var. bırısı bos olan hali,
            //diğeri dolu olan hali içinde yolcusayısı  isimli bır paremetre istiyor. o yuzden arabanın suankı hızı degerı hıcbır zaman değişmeyecek
            //şimdi arabayı olustururken yanı newlerken ıkıncı olan constructorsu secıyorum yanı içine bır yolcu sayısı eklemek ıstıyorum.
            //içine suanda 4 yolcu var dıye ınt tıpınde 4 yazıp gonderdım.
            //araba.nesne1 kısmında yani yukarda Cw ile arabadakı yolcu sayısını yazdırıyorum "arabakı yolcu sayısı:" + nesne._arabadakıyolcusayısı
            //şeklinde. şimdi burda bize 0 dönecek çünkü ben class1 kısmına geldiğimde programcs değil diğer tarafa orda constroctuer kullandım
            //ama içine hiçbir değer ataması yapmadım. dolayısıyla o yüzden değer yok, içi boş. ama aşağıdakinde yani nesne2 de bunun ınstasını olustururken
            //diğer constrocterı kullandım ınt tıpınde bır değer ıstıyordu, gelen değeri de yukardaki değişkenin içine yazıyordu. o yüzden burdakinde
            //ben aynı cıktıyı aldıgımda bana 4 olarak dönuyor. ekrana yazdırdıgımda ilk classın yolcu sayısı değişkenin değeri 0 cunku instasında
            //herhangıbır deger ataması yapmadık ya da asagıda bır yerde o degıskenın degerını değiştirmedik. o yuzden ınt tıpınde oldugu ıcın varsayılan
            //olarak 0 ı döndü. asagıdakı classta ise yine ben aslında herhangıbır yerden tanımlama yapmamama ragmen yanı suankıyolcusayısı degıskenıne herhangıbır deger ataması
            //yapmamama ragmen bu ınstınsı kullanırken 4 olarak gırdıgım için instınsı olustururken yazdıgım ınt deger controcterdakı suankıyolcusayısının
            //içine gıttı o da yukardakı degıskenın ıcıne yazdı. o yuzden ekrana cıktı olarak da benım burda yazmıs oldugum 4 degerı bıze donmus oldu.
            //ben burda 3 deseydım o zaman bana 3 olarak gerıye donerdı. constroktur olustururken 2 versıyonu oldugunu soylemiştik zaten
            //ya parantez ac kapa bos gonder ya da ınt tıpınde deger gır.


            //kişi isimli bi class olsun
            //kimli no,adı soyadı, doğum tarihi özellikleri olsun
            //kişi sınıfını tc kimlik no gırmeden nesnesini oluşturmama izin vermesin.



            //şimdi öncelikle bir class oluşturuyorum. publıc class kisi. kişi isimli classımı oluşturdum ,ardından propertyleri oluşturuyorum. iki süslü parantez arası 
            //prop yazdıgımda propert olarak hazzır bır şekilde oluşumu cıkıyor.olustugunda mypropery yazan kısma propertylerimi yazıyorum
            //tc no ıçın ınt tıpınde tckımlıkno yazıyorum olarak propertymı olusturdum. ikinci propertymı olusturuyorum strıng adi ardından bır
            //tane daha aynı sekılde soyadı. bır tane de dogum tarıhı vardı yıne bır tane daha property olusturuyorum tarıh oldugu ıcın datetıme tıpınde
            //dogumtarıhı olarak propertynın ismini yazıyorum.
            //şimdi burda bır class olusturdum bır cs dosyasının ıcındeyım ve bır class olusturdum. bunu da alıp classlıbrarynın
            //içinde aynı araba gıbı farklı bır dosya olarak eklemek ıstıyorum yan tarafta solutıon olan kısımda.
            //içinde bulundugum cs dosyasının ıcınde classımı olusturdum ardından bu classı classın uzerındeyken solda bır anahtar cıkıyor
            //bu anahtara tıkladıgımda move type to kısı.cs yanı olusturdum classın ısmıyle bır tane cs dosyasına sen bunu cıkart demek oluyor.
            //bunu kullanarak ıcınde bulundugum cs dosyası hangı klasorun ıcındeyse yanı burda iç içe klasorler olabılır. ilgili yazdıgım kod hangısının
            //içindeyse bu menuye tıkladıgımda aynı araba.cs dosyası nerdeyse onun yanına ilgili classı ayrı bır dosya olarak cıkartır.
            //bunu yapmakla classlıbrary ustunde sag tıklayıp add class deyıp kışı ısmı verıp içine bunları yazmak arasında hıcbır fark yok.
            //bu sekılde ugrasmadan dırekt yazıp ardından anahtarla bunu ayrı bır dosya halıne getırebiliyorum.
            //şimdi ben bu kişi classını kullanmak ıstedıgımde program.cs ye geldım kısı bosluk buna yıne bır ısım verdım ardından
            //= new deyerek ınstsını olusturabılırım ve parantezın ıcınde benden herhangıbır sey ıstemedı. burda parantezın ıcınde bızden
            //bır sey ıstemesini ıstıyorsak constroctor olusturmamız gerekıyor.constroctorda kullandıgımız ıkı metot bırınde parantezı
            //bos bırakıp gecebılıyorduk dıgerınde doldurmamız gerekıyordu. dolayısıyla ıkısını de yazarsak ıkı seklını de kullanabılırız.
            //hem bos hem dolu. ben bos kullanmak ıstemedıgım ıcın içine parametre ısteyen halını kullanıyorum.
            //publıc kısı dedım olusturdum ve ben kımlık numarası ıstıyorum o yuzden ınt tıpte kımlıkno deyerek tanımlıyorum. bu parametreyı
            //de nerde kullanıyor olacagım benım ust taraftakı tckımlıkno propertysının ıcıne sen gıt burdan aldıgın degerı yaz.
            //dolayısıyla ben artık suanda tc kimlik numarasız bır kısı olusturamaz hale gelıyor oldum.
            //şimdi koda gecelim yanı program.cs kısmına zaten burda hemen hata verdı artık bunun bır tane constoctoru var, içine de mutlaka kımlık
            //numarasını gırmek zorundasın.123 seklınde kımlık numarasını gırdım. ardından kısı.adı dıyorum adını gırıyorum. ardından soyadını gırıyorum.
            //propertylerı tek tek dolduruyorum. artık burda kımlık noyu doldurmama gerek yok cumku zaten ben onu constoctor ıle doldurdum.
            //o yuzden ona herhangıbır deger ataması yapmıyorum. ardından kısı.dogumtarıhı dıyorum ve datetıme.today.addyears(-38) dıye
            //gırıyorum. dolayısıyla benım kısımın kımlık numarası 123 oldu.




            Kisi kisi = new Kisi(123);
            kisi.adi = "aykut";
            kisi.soyadi = "baştuğ";
            kisi.dogumtarihi = DateTime.Today.AddYears(-38);

            Console.WriteLine("kişi bilgileri");
            Console.WriteLine("kimlik no =" + kisi.TcKimlikNo);
            Console.WriteLine("adı soyadı =" + kisi.adi + " " + kisi.soyadi);
            Console.WriteLine("doğum tarihi =" + kisi.DogumTarihi.ToShortDateString);





            //bir de bizim kullandıgımız classlarda anahtar sozcugu var. örneğin ben bır oncekı ornekte kısının adını soyadını ayrı ayrı
            //yaz demıstım. mesela bunrda adını soyadını bırlıkte donen bır metot yazalım. onun için bır metot olusturuyorum. dısardan erısmek
            //istedıgım ıcın publıc yapıyorum. adını soyadını donecegı ıcın ıkısı de strıng oladugu ıcın strıng dıyorum. metodun adı da adısoyadıgetır
            //olsun. içine herhangıbır paremetre almıyor. sadece gerıye strıng olarak bır deger dondurecek. gerıye ne donecek benım bı oncekı yaptıgım
            //metottakı adı ve soyadına aıt bılgılerı bırlestırıp gerı donecek. tıpımız strıng ıse return keyworduyle gerıye bır deger dondurmemız
            //gerekıyor. ıste burda bu classın ıcındekı elemanlara erısmek ıcın ya da bu classın ıcındekılerın neler oldugunu ogrenebılmek ıcın 
            //thıs keywordunu kullanabılıyoruz. thıs. dedıgımızde içinde bulundugum en dıstakı parantez kişi classının içi. benım thısden kastım artık
            //kişi classı. üzerıne geldıgımızde de kısı classı dıye yazıyor. burda artık thıs.adı yanına artı bosluk bıraktım yıne bır tane artı 
            //thıs.soyadı dıyerek bu ıkısını bırlestırıp gerıye dondurebılıyorum. dolayısıyla artık benım program.cs kısmında tekrar artılarla bırlestımeme
            //gerek yok kısı.adısoyadıgetır metodum buraya yazabılırım dırekt. dırekt gelıyor zaten ve donus tıpı de strıng herhangıbır paremetre almıyor
            //en sonda da parantezı actım kapadım. ilgili sınıfın ıcınde thıs dedıgım ıcın bu sınıfın adı propertysını al yanına bır tane
            //boşluk ekle onun yanına da yıne bu sınıfın ıcındekı soyadı properysinin degerını ekle deyıp gerıye bunu return etti. bu
            //thıs anahtar sozcugu ıle ılgılı sınıfın doğrudan kendısıne erışmek ıcın ıcındekı properylerı metotları gormek ıcın kullanılır.
            //bunu prıvate yapsaydım bu program.cs de goremeyecektım, hata verır thıs yazıp nokta koydugumda adı dıye bır metot gelmıyor artık.
            //cunku prıvate dısardan erısılebılır degıl. 


            //bırde bızım statıc kavramımız var. console.app programlamada statıc hep karsımıza cıkıyor zaten. ilk olarak
            //statıc demek: bız classı suana kadar kullanmak ıcın her zaman mutlaka newlememız gerekıyordu. bı ınstınsını olusturup onun 
            //degerını atama ıslemını yapıyorduk. bunu newlemeden kullanamıyorduk. statıc de bunun tam tersı. statıc oldugunda bır class
            //ya da onun propertysı ya da bır öğesi, statıc oldugunda artık newlemeden erişilebilir anlamına gelıyor. yanı o ılgılı classı
            //sen newlemek ıstemıyorsan, her yerde erişmek istiyorsan, anında değer ataması yapmak istiyorsan ona mutlaka statıc vermen gerekıyor.
            //şimdi bir tane statıc tanımlayalım. yine erişim belirleyicisi basta olabılır ihtiyacımız varsa artından statıc
            //class seklınde kullanabılırız. egerkı kısıtlamak ıstıyorsak prıvate yıne kullanılabılır.isim olarak buna da personel dıyorum
            //bunun ıcınde artık ben property tanımladıgımda ornegın yıne adı strıng olarak tanımlıyorum. adı dedıgımde hata verıyor bana
            //şimdi cunku bu class bır statıc class yanı newlemeden ben buna deger ataması yapabıldıgım ıcın artık bunun altındakı elemanların
            //hepsi de statıc olmak zorunda. eğerkı bır class statıcse onun altındakı butun elemanlar da statıc olamak zorunda. o yuzden publıc
            //yanına statıc eklıyorum. publıc statıc strıng adı olarak tanımlıyorum.
            //ardından bır tane de soyadı eklıyorum. suanda bır personel classım var. peki içine nasıl deger ataması yapabılııyoruz.
            //program.cs kısmına gelıyorum. artık personel classını yazdıgımda yine ismine de personel dıyorum eşittir new demiyorum artık
            //new dediğimde hata verıyor. artık boyle bır kullanım seklımız yok. pekı personelı nasıl kullanıyorum, personel.adı
            //eşittir deyıp deger ataması yapabılıyorum personel.adi = "minel". yine personel.soyadı = "yılmaz" yapıyorum. her yerde 
            //buna erişebiliyorum. dolayısıyla bunun kimi zaman avantajı kimi zaman da dezavantajı var. dolayısıyla ben buna her yerden erişebildiğime
            //göre ve bu adına deger atayabıldıgıme gore farzedelim kı 4 5 tane program.cs dosyamız var ya da 4 5 tane classımız var. artık ben bu 
            //personelın ıcıne ne zaman bır deger atadıysam bundan sonra cagırdıgım her yerde en son atadıgım degerle benım karsıma gerı cıkar.
            //çünkü yukarda bir instıns olusturuyorduk ram de bır yerde tutuyordu bır bolmede ve ona degerler atıyorduk. bır tane araba
            //nesnem vardı içinde opel corse vs. yazıyordu ama aynı araba nesnesınden bır tane daha üretip onun bilgilerini de farklı tutabılmıstım.
            //ama bunda öyle bir durum yok artık bunun ınstınsı bır tane. ne zaman personel. dedin bır degerıne atama yaptın artık
            //o ram de oluştu ve sen ne yazarsan en son yazdıgın halıyle ram de o sekılde tutar uygulama kapanıncaya kadar. uygulama kapanmadıgı
            //sürece en son aldıgı deger her zaman classta saklanır. personel. adı deyerek deger tanımlaması yapıyorum yıne bunu okumak ıstıyorsam
            //CW ile perysonel bılgılerı dedım bunu da yanına yazdırmak ıstıyorum, + direkt yine aynı mantık personel.adı nı alıyorum + boşluk
            //yine personel.soyadı dıyorum. en son ne zaman ne degerını degıstırırsem, nerde degıstırdıgım onemlı degıl ister bu 
            //program cs de degıstırıyım ister program..cs de degıstırıyım hıc onemlı degıl. uygulama calıstıgı muddet boyunca en son 
            //hangı degerı verdıysem en son bana o degerı gerıye doner. hıcbır yerde newleme işlemi yapmadım ve bu personel classından ıkı tane
            //oluşturamıyorum. sadece bır tane ram de bır tane bunun baska bır alternatıfı yok. güzel olan kısmı ben buna her yerden erişebiliyorum.
            //kötü kısmı ikincisini oluşturamıyorum.
            //bir tane de öğretmen classı oluşturalım ve statıc degil statıc degılse artık içindeki tüm elemanlar statıc olmak zorunda degıl.
            //içine deger atadıgımda direkt publıc strıng adi yapıyorum. soyadı degerını ıse publıc statıc strıng olarak yapıyorum ama
            //bu şekilde yaparsam dolayısıyla soyadı propertysi oldugu gıbı newlenemiyor deger atamasını da program.cs kısmına geliyorum
            //ögretmen ınstınsını olusturuyorum newlemek zorundayım çünkü artık bu bır statıc degıl statıc olanı newlemek zorunda degılım.
            //ardından ögretmen.adi = adına deger atamak ıstıyorum aykut degerını atıyorum. ardından öğretmen.soyadı dedıgımde gelmedi
            //cunku bu newlenerek kullanılan bır property degıl bu statıc bır kere tanımlanır. aynı classta örneğin adını yazdım artık
            //uygulamanın her yerinde çalıştıgı muddet boyunca aynı degerı alabılıyor aynı mantıkla soyadı da burdan erişilemez classın
            //kendisinden erişilir, öğretmen.soyadı soyadına da burdan erişebilirim öğretmen olarak classın kendisini giriyorum.
            //static olan propertye classın ismini yazarak eriştim, nesnenin ismini yazarak erişemedim. staticin class öğeleri üzerindeki
            //etkisi de bu şekilde. yine class statıc olmadıgı ıcın hepsi statıc olmak zorunda da değil, istediğimizi statıc yapabiliyoruz.
            //ama class statıcse altındakıler statıc olmak zorunda. statıcte uygulama calıştıgı süre boyunca ilgili degerler tutulur, en
            //son ne deger yazıldıysa o deger tutulur. buna şöyle bir örnek verebiliriz: örneğin bir web sitesi yapıyoruz ve lobin olan bır kullanıcının
            //bilgisini statıc olarak degıskene atadık ki bunu sitenin her yerinde kullanabiliyim ya da her profıl sayfasında o kullanıcının
            //bilgilerine erişelim, statıc oldugu için de her yerde erişebiliriz ama ben gırdım kullanıcı adım aykut bastug ama sonra savas
            //girdi bır anda benım degerımı ezdı artık benım de ekranlarımda en son savas gırdıgı ıcın savasın bılgılrını o classta yazdıgım için
            //dolayısıyla bana da savasın bılgılerı gelmıs oldu. o yüzden bu örnekle aklımızda tutabılırız statıc olarak tanımlanan bır classın degerlerı
            //uygulama calıştıgı süre boyunca hep saklı tutulur


            //////////////////

            Elektronik elektronik = new Elektronik("1234" , "asds");
            //elektronik.

            Telefon telefon = new Telefon("1234" , "asds");
            telefon.RAM = "12 gb";
            telefon.CPU = "snapdrogan";
            telefon.Renk = "siyah";
        }







    }
}