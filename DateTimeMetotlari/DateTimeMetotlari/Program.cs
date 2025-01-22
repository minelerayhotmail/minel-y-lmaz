namespace DateTimeMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ToString:

            string tarih1 = DateTime.Today.ToString();//saatsiz olarak
            string tarih2 = DateTime.Now.ToString();//saatli olarak
            Console.WriteLine("saatsiz = "  +  tarih1);
            Console.WriteLine("saatli = " + tarih2);

            //DateTime bizim tarihsel olarak kullandığımız, tarih tipindeki verilere karşılık geliyor. tarihlerle ilgili metotlar.
            //stringe cevırdıgı ıcın strıng tıpte bır degısken olusturdum. datetıme.today.tostrıng dedıgımde bıze saatsiz olarak bugunun tarıhını doner
            //saatlı almak ıstersek de today yerine new propertını kullanıyoruz.
            //tostrıng metodunda calıstırdıgım ıcın strıng tıpte deger donduruyor.

            Console.Clear();
            string tarih3 = DateTime.Today.ToString("");

            //şimdi bunun içinde bır strıng ifadeyle çift tırnak actıgımda bana bır lıste seklınde kullanım yöntemini söylüyor.
            //yanı dıyor kı sen burda sadece d harfını yazarak short date yanı tarıhın sadece day'ını alabilirsin yanı kısa tarih anlamında.
            //aynı mantıkla tek d kullanırsan sana ayın gununu tek digits olarak verir ama sen her halukarda ıkı digits istiyorsan yanı bugun ayın 6sı 06 yazmasını ıstıyorsan 
            //o zaman ıkı tane dd harfını kullanabılırsın dıye bıze aslında soyluyor. 
            //bızım ustte yaptıgımızda zaten bıze gun ay yıl seklınde cıkartıyordu ama ben yıl ay gun olarak cıkarmasını ıstıyorsam
            //yyyy 4 tane y yearın y sı 4 tane ekledım cunku 4 dıgıtslık ıstıyorum ardından nokta koyuyorum ya da slash koymasını ıstıyorsam slash da yazabılırım.
            //sonrasında month yazmak ıstıyorum yanı ay. ay için de buyuk m harfını ıkı dıgıts ıstıyorsam ıkı tane m harfını yazarak kullanabılırım.
            //yıne nokta ekledım sonrasında da day ı yanı ayın gununu ıkı dıgıts olacak sekılde ıkı d ıle yazıyorum.
            //illakı noktalı sekılde olmak zorunda degıl noktaları sılıp dırekt noktasız da yapabılırım.
            //burda onemlı olan biz tostrıng metoduyla içine strıng olarak bır format verebılıyoruz ve bıze o formata uygun sekılde 
            //convert ederek strıng tıpınde gerıye donus saglıyor.
            //ekrana yazdırdıgımda yılı ekledı 12. aydaysak ornegın ıkı dıgıts yaptım ama 0ı eklemedı zaten ıkı dıgıts.
            //ardında gunu ıkı dıgıts olarak yazdırdım sol tarafını sıfır ekledi. tek dıgıts kullansaydım burda sadece 6 cıkıcaktı ama 
            //ayın 10undan sonra cıft dıgıts olarak bana gerı dondurecektı.
            //burda sadece gun ay yıl seklınde yazmak zorunda değiliz. sadece yılı yazmak ıstıyorsam yyyy yaparsam bana sadece yılı verır.


            Console.Clear();

            //ToShortDateString-ToLongDateString
            string kisatarih = DateTime.Today.ToShortDateString();
            string uzuntarih = DateTime.Today.ToLongDateString();
            Console.WriteLine("kısa : " + kisatarih);
            Console.WriteLine("uzun : " + uzuntarih);

            //yukarda tostrıngı kullandıgımda bana saatı verıyordu. burda toshortdatestrıngı ve tolongdatestrıngı kullandıgımda
            //bana saat bılgılerını vermedı.bu kullanımlar saatsız olarak bıze bunu vermeye yarıyor. shortta sadece bugunun tarıhını verıyor
            //saatsız bır sekılde long da ise yıne bugunun tarıhını verıyor saatsız olarak ama ekstra olarak tarıhı uzun formatta verıyor.
            //ayını ve gunu strıng olarak karsılıgını verıyor. rakam olarak degıl kelıme olarak donduruyor uzun versıyonda.


            //bunun bırde kısa saat uzun saat olarak yaptıgımız versıyonu var. burda now uzerınden gıdıyoruz cunku today dersem saat sıfır gelıyor.
            //usttekı datestrıngtı burda ıse tımestrıng kullanıyoruz
            Console.Clear() ;
            string kisaSaat = DateTime.Now.ToShortTimeString();
            string uzunSaat = DateTime.Now.ToLongTimeString();
            Console.WriteLine("kısa saat: " + kisaSaat);
            Console.WriteLine("uzun saat: " + uzunSaat);

            //toshorttimestrıng ıle kullandıgımda bana saatle dakıkası verıyor sanıyesını vermıyor. uzun saatı aldıgımda da saat dakıka sanıye verıyor. ıkısının arasındakı tek fark bu.




            //Add metodları
            DateTime bugun = DateTime.Now;

            Console.WriteLine("yarın: " + bugun.AddDays(1));
            Console.WriteLine("yarından sonra: " + bugun.AddDays(2));
            Console.WriteLine("dün: " + bugun.AddDays(-1));
            Console.WriteLine("evvelsi gün: " + bugun.AddDays(-2));


            Console.WriteLine("seneye bugün: " + bugun.AddYears(1));
            Console.WriteLine("önümüzdeki ay: " + bugun.AddMonths(1));


            Console.WriteLine("beş saat sonra: " + bugun.AddHours(5));
            Console.WriteLine("beş dakika sonra: " + bugun.AddMinutes(5));
            Console.WriteLine("beş saniye sonra: " + bugun.AddSeconds(5));
            Console.WriteLine("beş milisaniye sonra: " + bugun.AddMilliseconds(5));

            //tarıhlere add metoduyla gunler aylar yıllar ekleme cıkarma gıbı işlemler yapabiliyoruz.
            //önce bugunun tarıhını tanımlıyorum. şimdi bunun ıcınden bız ornegın yarını almak ıstıyorsak yarını almak ıcın bugun datetıme degıskenımı yazıyorum.
            //datetıme. dıyerek de aynı işlemi yapabılırım bugun. dıyerek de aynı ıslemı yapabılırım.bugun. adddays dıye bır metod var.
            //addays ıcıne double tıpte bır verı alıyor.addays sol taraftakı tarıhın ustune gun ekle anlamına geliyor. yanı ben buraya bır dersem
            //bana yarını verıyor olacak. 2 dersem yarından sonrakı  tarıhı verıyor olacak. aynı mantıkla dun ekleyebılırım.
            //dun ıcınde yıne adddays metodunu kullanıyorum -1 yapıyorum. evvelsi gunu ıstıyorsam -2 yapıcam.
            //bu sekılde addday metodlarını kullanarak gün ekleme ya da cıkarma ıslemı yapabılıyoruz elimizdeki tarıhın uzerıne.
            //önemlı olan nokta strınglerde oldugu gıbı artık bu metodları kullanabılmem için oncesinde mutlaka datetıme tıpınde
            //bır verım mutlaka olması gerekıyor. bugunu strıng olarak tanımlasaydım bu metodlar gelmezdı. datetıme'a ozel olan metodlar.
            //cunku basta degısken tanımlarken datetıme bugun dıye tanımladım strıng bugun dıye degıl.



            //aynı şekilde gun ekleyebıldıgımız gıbı yıl da ekleyebılıyoruz. örnegın seneye bugun demek ıstedıgımızde addyears metodunu kullanıyoruz.
            //aynı mantıkla onumuzdekı ay da ekleyebılırız. onumuzdekı ayın aynı bugununu addmonts seklınde dıyerek yapabılırız. yıne bunları cıkarmak ıcın - ıle yapabılıyoruz.
            //gecen sene bugun anlamında -1 ya da gecen ay bugun gıbı -1 yapabılırız.
            //aynı zamanda sanıye eklemek ıcın ornegın 5 sanıye sonrası demek ıcın addseconds yapıp kac sanıye eklemk ıstıyorsan ılgılı degerı yazıyorsun.
            //aynı mantıkla - yazarsak da 5 sanıye oncesını alabılırız.
            //saat eklemek ıcın de addhours kullanabılırım aynı sekılde.
            //dakıka eklemek ıcın de addmınutes yapabılırım.
            //milisanıye (salise) eklemek ıcın de addmilliseconds yapabılırım.
            //bu metodları dogum gunu vs. gıbı seylerde kullanabılırız.


            //yine aynı mantıkla bugun degışkeninin içindeki milisaniyeye ulaşmak istiyorum. onun için bugun. mılısecond dedıgımde
            //bana sanıyeyı verıyor. artık bunlar metot degıl bunlar property. property oldugu ıcın sonuna parantez acılıp kapatılmaz.
            //burdan deger alma ışlemını yaparız. zaten uzerıne geldıgımızde hangı tıpte oldugunu soyluyor. bu ınt bır seymıs. o yuzden
            //bunu ornegın ınt mılısanıye = yaparak bır degıskenın ıcıne atabılırız.
            //yıne aynı mılısanıye gıbı sanıyeyı de alabılıyoruz, ınt sanıye = bugun.second; dıyerek ustte olusturdugumuz degerın ıcındekı sanıyeyı alabılırız.
            //bu arada ustte today kullanmıs olsaydık hata vermez bıze sıfır olarak doner. now sımdıkı tarıhın gun ay yıl saat dakıka sanıyesını full olarak bıze verıyordu.
            //today ıse sadece gun ay yıl verıyordu.
            //ılgılı tarıhın ıcındekı tum parcaları gun,ay,yıl,saat,dakıkaş,sanıye,salıse onların hepsıne tek tek bu sekılde ulasabılıyoruz.

            int milisaniye = bugun.Microsecond;
            int saniye = bugun.Second;
            int dakika = bugun.Minute;
            int saat = bugun.Hour;
            int gun = bugun.Day;
            int ay = bugun.Month;
            int yil = bugun.Year;



            //örnegın ayın ılk gunune ıhtıyacımız var. bunu datetıme kullanarak yapıyorum. bana gerıye bu ayın ılk gununu donduruyor
            //yanı bugun ayın 6sı 12. ayın 1ını bana dondurecek
            //ayın ılkgunu dıye bır degısken olusturuyorum ve ona ulaşma calısıyorum.
            //burda new datetıme dıyerek bız new datetıme nın ıcıne gununu ayını yılını vererek bır tarıh elde edebılıyoruz.
            //dolayısıyla ben burda bu yılın bu ayın ılk gununu ıstıyorum. onun ıcın once bugunun yılını vermem gerekıyor.
            //dolayısıyla bugunun verısı yukarda elımde var. yoksa da sunu yapıyoruz, datetıme.today.year yanı bugunun yılını al.
            //virgul yıne bugunun datetıme.today.month bugunun ayını al ve sonra bu ayın ılk gununu ıstedıgım ıcın yıne vırgul koyuyorum
            ////ve sadece 1 yazıyorum. gun ay yıl seklınde gıdıyorum. dolayısıyla bana 2023 yılının 12. ayının 1ını gerı verır.
            //içinde bulundugumuz ayın ılk gununu almış olduk burdakı verıyle.
            //sonra bunu ekrana yazdıralım. CW ıcıne ayın bırıncı gunu artı ayınılkgunu.toshortdatestrıng dıyerek bızım ısımız sadece
            //ayla oldugu ıcın kısa tarıh olarak alabılırım toshortdatestrıng diyerek.

            Console.Clear();
            DateTime AyinIlkGunu = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            Console.WriteLine("ayın birinci günü : " + AyinIlkGunu.ToShortDateString());

            //ayın son gununu bulmak ıcın, sonuna 30 yazarak bulamayız cunku bazı ayla 30 bazıları 31 cekıyor. ayın son gununu net bır sekılde bulmak ıcın de
            //ayın ılk gununu bulmak ıcın yazdıgımız koda bu kod ayın ılk gunu olduguna gore bunun ustunden  bır gun cıkardıgımızda ayın son gununu
            //bulmus oluyoruz.dolayısıyla onumuzdekı ayı bulmak ıcın once buna bır ay eklememız lazım addmonth ışe ardından adddays deyıp bır gun
            //cıkarmam gerekıyor yanı -1. usttekı kod bana ayın ılk gununu verıyor, o ayın ılk gunune bır ay eklıyorum sonrakı ayın ılk gunu oluyor
            //ardından da -1 bır gun cıkartarak bu ayın son gunune ulaşabilirim.
            //burda yaptıgımızın aynısını ayınılkgunu.addmonths(1).adddays(-1) dıyerek de yapabılırım. ıkısı aynı sey. 
            //cunku yukarda ayın ılk gununu zaten almıştın ondan yararlanabılırsın.




            DateTime AyinSonGunu1 = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(1).AddDays(-1);
            DateTime AyinSonGunu2 = AyinIlkGunu.AddMonths(1).AddDays(-1);
            Console.WriteLine("ayın son günü : " + AyinSonGunu1.ToShortDateString());


           

            //son olarak ayın ve gunun strıng olarak adını nasıl alabılırız ona bakalım.
            //ayın adını strıng almak ıcın yukardakı bugun degışkenının uzerınden gıdıyorum. bugun.tostrıngparantez ıcıne de 4 tane MMMM
            //koyarak ayı yazı seklınde bıze doner.
            //yine gun içinde aynı sekılde 4 tane dddd ekleyerek gunun adını alabılırım.
            //bu sekılde tarıh verılerıyle ilgili bu metotları kullanarak ihtiyacımıza gore aksıyonlar alabılırız.

            Console.Clear();

            string ayinadi = bugun.ToString("MMMM");
            string gununadi = bugun.ToString("dddd");
            Console.WriteLine("Günün Adı: " +  ayinadi);
            Console.WriteLine("Ayın Adı: " + gununadi);


            //-Bir kısa yol-visual studionun sağladığı bir kolaylık.
            //deyelim ki ben üstteki 4 tane satırı metot yapmak istiyorum.metot olarak ayrı bir yere cıkartmak ıstiyorum.
            //bunları sectıkten sonra sol tarafta bir ampul çıkıyor.buna tıkladığımızda extract method diye bir seçenek geliyor.
            //buna tıkladığımız anda bize bir tane metot oluşturuyor ve metotun ismini girmemizi istiyor. deyelim ki çörnek metot
            //orda seçmiş olduğum kodların aynısını bir mrtot oluşturdu verdiğim isimle ve o ilgili 4 satırın olduğu yere de 
            //metodu tetikleyecek şekilde ilgili kodu yazdı. bu vısual studıonun saglamış oldugu bır kolaylık.
            //bu kodda paremetreyi kendisi ekledi çünkü burdaki kodlarımda şartlar elveriyorsa kendisi paremetre ekleyebilir.
            //şimdi burdaki 4 kodda bugun dıye bır degısken var. dolayısıyla ben bugunu bır metodun içine atsaydım hata verirdi.
            //yani örneğin yukarki kodda önce mesela deneme adında bır metot oluşturup bu kodları yazmış olsaydım öyle yaptığımda
            //bugun isimli bir degısken olmadıgı için bana hata veriyor kod. dolayısıyla vısual studıo metodu oluştururken
            //senin o seçmiş olduğun ilgili yerde eğerki kullanmadığın ve kullanılması gereken bir değişken varsa onu
            //parametre olarak kendisi ekstra ekliyor. örneğin ben deseydim ki -console.clear();- bu kodu metodun içine
            //almak istiyorum o zaman hiç paremetre olmazdı, direkt boş. bizim kodumuza göre paremetreyi otomatik olarak ekliyor diyebiliriz.
            



        }
    }
}