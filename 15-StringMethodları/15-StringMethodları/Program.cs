namespace _15_StringMethodları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trim() metodu string değerin başındaki ve sonundaki boşluk karekterini kaldırır.
            string _adiSoyadi = "  aykut bastug  ";
            string adiSoyadi1 = _adiSoyadi.Trim();
            string adiSoyadi2 = _adiSoyadi.TrimEnd();
            string adiSoyadi3 = _adiSoyadi.TrimStart();
            Console.WriteLine(adiSoyadi1);

            //benim adı soyadı değişkenimde başında ıkı bosluk ortada bır bosluk ve sonunda ıkı bosluk vardı.
            //ben bu strıng ıfadenın sonunda trım metodunu calıstırdıgımda bana bastakı ve sondakı kac tane bosluk olursa olsun
            //boslukların hepsını kaldırır ama aradakı bosluklar duruyor. trım metodu bu ıse yarıyor.
            //trimend metodu ıse sadece sondakı boslukları kaldırıyor.
            //trimstart metodu ise sadece bastakı boslukları kaldırıyor.






            //Tolower() tüm harfleri küçük harfe dönüştürür.
            string _isim = " AyKUt bAŞtUĞ";
            string isim1 = _isim.ToLower();




            //ToUpper() tüm harfleri büyük harfe dönüştürür.
            string isim2 = _isim.ToUpper();



            //Replace() metnin içindeki herhangibir değeri farklı bır deger ile degıstırmek için kullanılır.
            //örneğin ben bu degıskenın içindekı bosluk ıfadelerını sılmek ıstıyorum ya da aykut yazan kelımenın hepsını sılmek ıstediğimde kullanılır.
            string _aciklama = "metnin içindeki herhangibir değeri";
            string aciklama1 = _aciklama.Replace('i', 'İ');
            string aciklama2 = _aciklama.Replace(' ', '-');
            string aciklama3 = _aciklama.Replace(" ", "");
            string aciklama4 = _aciklama.Replace("a", "");
            string aciklama5 = _aciklama.Replace("bir", "iki");
            //char tipinde olduğu için yani tek karakter tek tırnak içinde yazabiliyorum.
            //acıklama. replace dediğimde parantezin içine küçük i ve vırgul buyuk i yazıyorum. yanı bu metındekı butun kucuk 
            //i harflerini bülyük i yap demiş oluyorum.
            //örnegın metnın içindekı tum bosluk karakterlerını - yap deyebılırım.
            //ama ben burdakı tum boslukları silmek isteseydim '' bu sekılde yapamazdım cunku charda bir karakter gırmem gerekiyor cunku.
            //onun için strıng olarak kullanmam gerekıyor yanı tek tırnak degıl cıft tırnak." ", "" bu sekılde. yanı sen ıcınde boslukbuldugun her seyı
            //içinde hıcbırsey olmayanla degıstır yanı sıl demek oluyor. burda artık bastakı sondakı onemlı degıl nerde bosluk bulursa sıler.
            //aynı mantıkla sadece a harflerini silmek ıstıyorsam aynı sekılde yapabılırım.
            //ya da ornegın burdakı bıır kelımesını sılmek ıstıyorum. aynı sekılde aynı mantıkla strıng bır ıfade oldugu için
            //buraya bır yazıyorum örnegın bırlerın hepsını ıkı yap.butun bır gordugu yerı ıkı olarak degıstırır. 


            //ToCharArray() metnin içindeki tüm karakterleri char dizisine dönüştürerek geriye döner.
            //yani bizim herhangibir sebeple yazılan bir metnin içindeki karakterlerin sayılarını bulmak istedik.
            //o yüzden tochararray her zaman ihtiyacımız oluyor. nasıl yapıldıgına bakalım.
            string ilce = "ümraniye";
            char[] karakter1 = ilce.ToCharArray();//bu direkt ümraniye yazan hali.
            char[] karakter2 = ilce.ToCharArray(3, 2);//bu a ve n.
            //bir ilçe değişkenim var ve içinde de ümraniye yazıyor. ben burda ilce.tochararray() dediğimde. bana bunun start ve stop indexini verebilirsin diyor.
            //örnegın burda start dersek indexlerinden 3, 2 dediğimde 3.indexten itibaren iki tanesini ver demiş olurum.
            //burda ümranıye kelimesinin harflerini tek tek diziye sokacak. start indexi verdiğimde 3 ten itibaren iki tanesini diziye cevirecek.
            //yani a ve n yi bir dizinin içine atmış oldu.
            //elimizde bir char dizisi olduğu için sıralama yapmak istediğimizde dizi methodlarında short ve reverse methodlarını kullanabiliriz.
            //parantezin yanına. koyu short ve reverse yazarak kullanabiliriz.


            //padleft() metnin istediğimiz karakter sayısına ulaşana kadar sol tarafına değer ekliyor.
            //örneğin fatura numaraları normalde bı serısı olur 8 haneli olur. plakalarda örnegın en sonu 10 sa 010 yazmak zorundadır 
            //çünkü 3 hanelidir orası. örneğin böyle durumlarda belli bir karakter sayısına ulaştırmak istiyorsak mutlaka bu padlefti kullanmamız gerekiyor.
            //örneğin elimizde fatura numarası 1 degerı var ama ben bunu 5 haneli yapmak istiyorum. dolayısıyla bunun yanına 4 tane 0 eklemem lazım.
            //ve bu işlemler uygulamanın içinde oldugu için bu işlemler her zaman 1 gelmez. 120 gelebilir 2 karakter eklememiz gerekir 2 karakter gelebilir 3 eklememiz gerekebilir.
            //bunu biz kontrol edemeyeceğimiz için padleftten yararlanıyoruz. string faturano1 dıyorum mevcut faturanonun içinde padleft methodunu calıştır.
            //ben bunu kac karaktere getırmek ıstıyorum. parantez içine 5, yapıyorum yanı ben bunu 5 karakter yapmak ıstıyorum.
            //ve olmayanların yerıne sen gıt tek tırnak ıcınde cunku tıpı char, '0' ekle dıyorum. yanı 1 se burdakı deger 00001 olacak.
            //yukardakı deger 10 sa üç tane 0 ekler. 5 karakter olana kadar bunu değiştiriyor olacak.
            //parantez içi en baştakını normal sonrakını char yazma sebebım, üstüne geldiüimde de yazıyor zaten ılk total olan int tıpınde  ıkıncısı karakter olacagı ıcın char tıpınde olacak çünku ben buraya a da gırebılırım.
            //ben buraya hangı karakterı yazarsam onu eklıyor olacak. ıllakı 1 yazmak zorunda değilim ef gırebılırım 5 karakter olana kadar yanı basına 3 tane 0 ekler.
            //ama burda karakter eklemek ıstedıgımızde char tıpınde oldugu ıcın tek karakter ekleyebılıyoruz yanı 4 karakter eklenecekse bunların hepsı 0 olur 1234 olsun deyemem.

            string _faturaNo = "1";
            string faturaNo1 = _faturaNo.PadLeft(5, '0');


            //padright() metnin istediğimiz karakter sayısına ulaşana kadar sağ tarafına değer ekliyor.
            //burda da başına değil sonuna ekleme yapabılırız aynı şekilde.

            string faturaNo2 = _faturaNo.PadRight(4, '0');



            //Equals() parametre olarak verilen değer ile değişkenin değeri aynı mı değil mi diye kontrol eder.
            string _metin = "kıyaslamak için kullanılır";
            bool esitMi1 = _metin.Equals("için");
            bool esitMi2 = _metin.Equals("kıyaslamak için kullanılır");


            //hemen değişkenimi olusturuyorum metin isminde. sonra metın ısmındekı değişkenımın içine gırıyorum nokta equals dedıgımde
            //zaten üzerine geldiğimizde sol tarafta nasıl bır method oldugunu bana soyluyor. önemlı olan dıger nokta parametrelerden sonra
            //gerıye deger gonderıp gondermedıgı. burda ustune geldıgımde boll tıpte bır deger dondurdugunu gosterıyor. zaten gerıye aynı mı degıl
            //dıye deger donduruyor. aynıysa true degılse false olarak dondurur. hemen uygulayalım. parantez içine için yazıyorum. yanı 
            //metnımızın ıcınde gecen bır deger. ya da gecmeyen de yazabılırım çunku aynı mı degıl mı dıye kontrol edıyor. hemen bır degıskenın içine atıyorum.
            //yıne bunun aynısından bır tane daha olusturuyorum. bunun içine de degerın bırebır kendısını yazıyorum ki bu şekilde kontrolunu yapsın.

            //metin değişkeninin içine bır deger atmıstım. equals methodunu calıstırdıgımda degerın içinden bır kelime atmıstım methoda
            //o yuzden bırebır aynısı olmadıgı için bana falso degerı dondu. gonderdıgım degıskenle degerın bırebır aynısı olma durumunda ise
            //true degerı dondurmus oldu. kucuk bır nokto gıbı fark olsa bıle false degerı dondurur.
            //equals methodunun mantıgı bunu if ile su suysa true degılse yanı else ise false dıye kontrol etmektense bunu yapıyoruz.
            //bır yerde kontrol etme durumunda kalırsak uzun uzun ıf yazmak yerıne bunu kullanabılırız.


            //SubString() metodu string bir değer içerisinden parça almak için kullanılır.
            string _ornek = "örnek metni buraya giriyorum.";
            string ornek1 = _ornek.Substring(5);
            string ornek2 = _ornek.Substring(5, 4);

            //değişkenımı olusturdum. şimdi bunun içinden belli parcaları almaya calısalım.
            //ornek.substrıng dedım ve parantezı acıp overload versıyonlarına bakıyorum.2 versıyon var. birisi benden dırekt startindex istiyor
            //yanı burdakı karakterlerın hangısınden ıtıbaren sonuna kadar almak ıstıyorsun yanı baslangıc indexını bana soyle ben ona gore alayım.
            //örnegın 5 gırıyorum. gerıye donus tıpının de strıng oldugunu goruyoruz. cunku strıng bır metnın ıcınden parca alacak.
            //dolayısıyla aldıgı parcayı gerı gonderecek. o yuzden strıng gerı donus tıpı olması gerekıyor.
            //bır tane daha yapıyorum. bu sefer dıger overload versıyonunu kullanalım. ıkıncısınde de bır tane startindex 
            //ikincı olarak da length yanı uzunlugunu ıstıyor. örnegın 5. indexten ıtıbaren 4 karakter gonder deyebılırım.5inden ıtıbaren 4 karakter verıyor olacak.
            //diğerınde 5inden ıtıbaren hepsını verıyor olacak. 5. karakter de dahıl olmak uzere alır.



            //Reverse() metodu metnin içindekı karakterlerı bır dizi haline getırerek tersten sıralar.
            string _terstenMetin = "Aykut BAŞTUĞ";
            char[] metinDizisi = _terstenMetin.Reverse().ToArray();




            //hemen bır degısken olusturuyorum. reversenın ustune geldıgımde daha once gormedıgımız bır tıpe dondugunu goruyoruz. bu da
            //enumerable tıpı sıralanabılır bır lıste anlamına gelıyor. numaralandırılmıs bır lıste anlamına gelıyor. o yuzden bızım
            //bunu sonradan char dızısıne cevırmemız gerekıyor. dolayısıyla bu metodu calıstırdıgımda gerıye bana bır tıp donduruyor ama
            //benim istedıgım tıp toarray olsun yanı bunu bı char dızısı halıne getırerek listelesin ıstıyorum. o yuzden bunu da bı char dızısının
            //içine atıyorum basına char[] yazıyorum ve ısmı de metındızısı. artık toarray metodu da bunu char dızısı halıne getıryor oldu.
            //calıstırdıgımızda tersten asagı dogru tum harflerı sıralayarak dızının ıcıne aldı.
            //örneğin bunu ekrana yazdırmak ıstıyorsak foreach ıle yazdırabılırız. ornegın strıng terstenmetın. sonra foreach ıle içinde
            //donebılırız. metındızımızın ıcınde donuyoruz her dondugun elemanı da item degıskenının ıcıne at. dolayısıyla sonra da elımızdekı
            //terstenmetın degıskenının ıcıne de dırekt ılgılı karakterlerı += dıyerek ıtemı de buraya ekleyerek yazdırabılırız. item burda 
            //char oldugu ıcın bunu strınge de tostrıng metodu ıle cevırebılırız burda cevırmesek de olur. ihtıyaca gore cevırmesek de olur. en sonda da CW ile terstenmetını ekrana yazdırıyorum.
            //calıstırdıgımda ekrana tersten bır sekılde metnı yazdırır. ekrana tersten bır sekılde cıktısını aldırabılırım.
            //eger boyle bır duruma ıhtıyacımız varsa dogrudan reverse metodunu kullanabılırız. karakterlerı sıralayıp içine farklı bır işlem
            //yapmak ıstıyorsak kullanabılırız. ama normal kullandıgımız sıralama metodları da aynı sekılde işimizi görebilir.



            //IndexOf() metodu metnin içindeki bir karakterin ya da kelimenin kaçıncı indexte olduğunu bize geriye döner.
            string notebook = "Asus Zenbook";
            int index1 = notebook.IndexOf('o');
            int index2 = notebook.IndexOf("Zen");
            int index3 = notebook.IndexOf("zen");



            //dolayısıyla sayısal bır deger doner, dönüş tıpı ınt olması lazım.
            //hemen değişkenimizi oluşturuyoruz. değişken olusturdum ve içine bır deger verdım.içinde zaten benden bır char ıstıyor
            //yanı bı karakterın kacıncı ındexte oldugunu bulmak ıstıyorsam charı kullanabılırım, strıng, char startindex gıbı 10 tane
            //overload edılmıs versıyonu var. örnegın char kullanıyorum. charları tek tırnak ıcınde kullanıyorduk örn. o diyorum. degerımde
            //ıkı tane o oldugu için ılk buldugu o nun ındexını doner.int tıpte deger donuyor o yuzden ınt ındex1 dıyorum, index degıskenının 
            //içine bunu atsın.ardından aynısını kopyalıyorum ve zen kelımesını yazıyorum. bırden fazla kelıme oldugu ıcın cıft tırnak ıcınde kullanıyorum.
            //3.yu de yapıyorun ve zen in kucuk z ıle baslayan sekılde yazıyorum.
            //çalıştırdıgımda o nun 9da oldugunu gerı dondu. Zen e baktıgımde 5 olarak gerı dondu. yanı zen kelımesının ilk basladıgı
            //kelımenın ındexını bıze donuyor. sonuncusuna baktıgımda da yukarda olmayan bır deger gırdım. dolayısıyla bu metnın ıcınde
            //bulamadı zaman int tıpte bır deger dondurdugu ıcın de -1 olarak dondu. cunku -1ın karsılıgı yok.ındexler 0 dan baslıyor, 0ın
            //karsılıgı var ama -1in index degerı olarak karsılıgı yok.


            //Remove() metodu metnin içindeki herhangi bir indexten itibaren karakterleri silmek için kullanılır. metnın içinden parça silmek için.
            string _mevsim = "Ağustos";
            string mevsim1 = _mevsim.Remove(3);
            string mevsim2 = _mevsim.Remove(3, 2);

            //hemen kullanalım.metni oluşturdum. ıkı tane overload versıyonu var bırısı startindex alıyor. sen buraya bı startindex verıyorsun
            //o indexten ıtıbaren sonuna kadar sılıyor.diğer metodta da bı startindex verıyorsun bır tane de count yanı startindexten 
            //itibaren kac tane karakter sılmek ıstıyorsun dıye soruyor. gerıye de int deger donduruyor. yanı sıldıkten sonrakı metnın kalan
            //halını gerıye bıze donuyor. ıkı değişken olusturdum. ilkıne 3 dedım ıkıncısıne 3, 2 dedım.
            //çalıştırıyorum. ilk degerıme baktıgımda Ağu olarak dondurdu. cunku 3 ten ıtıbaren yanı s den ıtıbaren sıl dedım. s den ıtıbaren sılıyor
            //gerı kalanını da gerıye donuyor. yanı 3 ten oncekı karakterlerı gerı dondu.
            //ıkıncısıne baktıgımda Ağuos olarak dondu yanı sden ıtıbaren ıkı tane sıldı.gerı kalanını bırlestırıp gerı dondurdu.
            //aradan sadece parca sılmek ıcın kullanılır.
            //bır tane daha kopyalıyorum aynı ornekten ve 3. indexten ıtıbaren 5 tane sıl dıyorum ama 3ten sonra 5 karakter yok 4 var.
            //o yuzden burda hata verır. baslangıcını da olmayan bır ındex yazarsak yıne burda da hata verır.


            //Contains() metodu metnin içinde  bir karakteri ya da kelimeyi içeriyor mu diye kontrol etmek için kullanılır.
            string marka = "philips";
            bool iceriyorMu1 = marka.Contains('i');
            bool iceriyorMu2 = marka.Contains("lip");
            bool iceriyorMu3 = marka.Contains("olip");



            //içeriyorsa true içermiyorsa false degerını donduruyor olacak.
            //hemen bakalım actıgımda yıne bunun 5 tane varyasyonu oldugunu goruyorum. yıne bır char tek karakter var mı yok mu dıye kontrol eedeblılrım.
            //strıng ıcerıyor mu dıye kontrol edebılırım vs.
            //bool deger dondurdugu ıcın bool tıpınde bı degıdten ataması yapıyorum.
            //bırden cok olması onemlı degıl bır tane varsa dırekt true dondurur. olmayan bır sey gırdıgımde false dondurur.



            //Split() metodu metnin içindeki bir karakterden itibaren tüm metni parçalayarak bir string dizisi haline dönüştürür.
            string gunler = "pazartesi;salı;çarşamba;perşembe;cuma;cumartesi;pazar";
            string[] gunlerDizisi = gunler.Split(';');
            foreach (var item in gunlerDizisi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------");


            string gunler2 = "pazartesi--salı--çarşamba--perşembe--cuma--cumartesi--pazar";
            string[] gunlerDizisi2 = gunler2.Split("--");
            foreach (var item in gunlerDizisi)
            {
                Console.WriteLine(item);
            }



            //yanı donus tıpı strıngtır.
            //heman bakalım degerlerımı tanımladım. sonra bır strıng dızısı olusturuyorum. içine bır tane ; tanımlıyorum. demiş oldum kı
            //noktalı vırgle gore  bunları parcala.9 tane overload versıyonu var en cok char ile parcalanmasını bır tane de 
            //strıng ıle parcalanmasını kullanıyoruz.
            //cıktısına baktıgımda noktalı vıgulden ıtıbaren bolerek bır dızı halıne alt alta getırdı. noktalı vırgulu de kaldırdı.
            //parcalayarak dızıye cevırdı ve alt alta yazdırdı.



            //StartsWith() metodu metnin herhangibir karakter ya da kelime ile başlayıp başlamadığını kkontrol eder.
            string meyve = "Portakal";
            bool ileBasliyorMu1 = meyve.StartsWith('p');
            bool ileBasliyorMu2 = meyve.StartsWith('P');
            bool ileBasliyorMu3 = meyve.StartsWith('x');
            bool ileBasliyorMu4 = meyve.StartsWith("por");
            bool ileBasliyorMu5 = meyve.StartsWith("Por");



            //hemen bakalım, metodun içine baktıgımda yıne bana bool bır deger dondurdugunu ve 4 tane overload versıyonu oldugunu 
            //soyluyor. içine char tıpı atarak o bununla baslıyor mu baslamıyor mu diye kontrolunu saglayabılırım.
            //strıng gondererek yapabilirim vs.
            //ornegın ben burda p harfı ıle baslayıp baslamadıgını kontrol etmek ıstıyorum. kucuk p gırdım. yıne buyuk kucuk ısaretı onemlı.
            //gerıye boll donduruyor  o yuzden bool bır degısken olusturuyorum kı buldugu degerı oraya yazsın dıye.
            //aynısından bır tane daha olusturuyorum bu da buyuk P olsun.
            //calıstırıyorum ılkınde false dondu cunku kucuk p ilşe baslamıyor. ikincisine bakıyorum buyuk p oldugu ıcın
            //true dondurdu.3.sunde x ıle baslamıyor o yuzden false dondurdu. strıng tıpınde de kontrol yapabılırım. cıft tırnak ıle.
            //






            //StartsWith() metodu metnin herhangibir karakter ya da kelime ile bitip bitmediğini kontrol eder.

            bool ileBitiyorMu1 = meyve.EndsWith('l');
            bool ileBitiyorMu2 = meyve.EndsWith('L');
            bool ileBitiyorMu3 = meyve.EndsWith('x');
            bool ileBitiyorMu4 = meyve.EndsWith("kal");
            bool ileBitiyorMu5 = meyve.EndsWith("Kal");







            //IsNullOrEmpty() methodu metnin null veya boş olup olmadığını kontrol eder. boş veya null ise true değilse false döndürür.
            //içine parametre olarak atadığımız değişkenin içi boş mu ya da null mu bunun kontrolunu yapıyor. bunun sonucunda
            //bıze true false bır deger donduruyor yanı bool.true false dondurdugu şçşn şaertların içinde bunu kullanıyoruz yani ifin.
            //ifin içinde bunu kontrol etmem gerekiyor. isim degerı null ya da bos mu bunun kontrolunu yap. null ya da boşsa bana burdan
            //true gelecek demektir.bunun elsesi de ısım gırıldı demek oluyor Cw ile yazdırıyorum, merhaba aykut deyecek.
            //isim girmeyip veya null degerı verırsem bana isim girmediniz diye dönüyor eğer girersem merhaba aykut dıye dönüyor.
            //bu cok fazla kullanılan bır method.

            //string isim = "";
            string? isim = null;
            isim = "Aykut";


            if (string.IsNullOrEmpty(isim) == true)
                Console.WriteLine("isim girmediniz");
            else
                Console.WriteLine("merhaba" + isim);







        }
    }
}