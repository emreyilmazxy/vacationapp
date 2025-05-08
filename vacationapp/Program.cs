bool tekrar = true; 
while (tekrar)                       //uygulama sonunda tekrar yapılmak istenebilceği için tüm kodlar bir döngü içine alındı.
{                                           
    string city;
do
{

    Console.WriteLine(@"lütfen 3 günlük gitmek istediğiniz şehri giriniz
                  1-)Bodrum (başlangıç 4000 tL)
                  2-)Marmaris (Başlangıç 3000 TL)
                  3-)Çeşme (başlangıç 5000 TL) ");
    city = Console.ReadLine().ToLower().Trim();

    if (city != "bodrum" && city != "çeşme" && city != "marmaris")  // döngü içinde kullanıcı doğru değer kontrölü yapıldı.
    {
        Console.WriteLine(@"hatalı giriş yaptınız!ÖRN:bodrum
");
    }
} while (city != "bodrum" && city != "çeşme" && city != "marmaris");  //do while dögülerinin bittiği yerlerler
    
    int personNumber;
    string input;

    Console.WriteLine("Kaç kişilik bir tatil planlıyorsunuz?");

    while (true)
    {
        input = Console.ReadLine();
        
        // Eğer input bir tam sayıya çevrilebiliyorsa ve pozitifse
        if (int.TryParse(input, out personNumber) && personNumber > 0)    //BURADA TRY PARSE METODU İLE KULLANICIDAN ALINAN DEĞER int çevrildi
        {
            break; 
        }
        else
        {
            Console.WriteLine("Lütfen geçerli pozitif bir sayı girin.");
        }
    }

    switch (city)
{
    case "bodrum":
        {
            Console.WriteLine(@"gitmek istediğiniz yer bodrum.
                 YAPILABİLECEKLER: deniz,kum,güneş");
            break;
        }
    case "çeşme":
        {
            Console.WriteLine(@"gitmek istediğiniz yer çeşme.
                 YAPILABİLECEKLER: deniz,kum,güneş,disco disco partizani");     //iflerden daha kolay olduğu için switch case yapısı kullanıldı.
                break;  
        }

    case "marmaris":
        {
            Console.WriteLine(@"gitmek istediğiniz yer marmaris.
                 YAPILABİLECEKLER: sahil gezintisi,deniz,");
            break;

        }
}
    // şehir maliyetleri tutulduğu değişken .değişken duruma göre yeni bir alabilir.
int cityPrice;

if (city == " bodrum")
{
    cityPrice = 4000;
}

else if (city == "marmaris")
{
    cityPrice = 3000;
}

else { 
  
    cityPrice = 5000;

}

    int way;

do
{
    Console.WriteLine();
    Console.WriteLine(@"tatile gitmek istediğiniz yöntemi belirtin");
    Console.WriteLine(@"1-) KARA YOLU GİDİŞ-DÖNÜŞ 1500 TL
                        2-) HAVA YOLU GİDİŞ-DÖNÜŞ 4000 TL");

    Console.WriteLine();
    Console.WriteLine(@"lÜTFEN yukarıdakiseçeneklerden birtanesini seçiniz"); //yanlış değer girilmesi halinde kontrol döngüsü
    Console.WriteLine();
    way = Convert.ToInt32(Console.ReadLine());

    if (way != 1 && way != 2)
    {
        Console.WriteLine(@"lütfen geçerli bir değer giriniz!");

    }
} while (way != 1 && way != 2);
    //yol maliyetinin tutulduğu değişken. değişken duruma göre yeni bir alabilir.
    int wayPrice;

if (way == 1)
{
    wayPrice = 1500;
}
else
{
    wayPrice = 4000;
}


Console.WriteLine();
int sum = (cityPrice + wayPrice)* personNumber;   // alınan verilerin matematiksel işlemleri sum değişkenine atandı.

    Console.WriteLine();

Console.Write($@"tatilinizin toplam maliyeti >{sum} TL");
Console.WriteLine();
Console.WriteLine(@"başka bir tatil planlamak ister misiniz?
                 1-) EVET  2-)HAYIR 
");

    Console.WriteLine();

    string answer;
    do {

        answer = Console.ReadLine();

        if (answer != "1" && answer != "2")
        {
            Console.WriteLine("lütfen sadece 1 veya 2 girin");
            Console.WriteLine();
            Console.WriteLine(@"başka bir tatil planlamak ister misiniz?
                 1-) EVET  2-)HAYIR 
");
        }
        else if (answer == "1")
        {
            tekrar = true;
        }
        else
        {
            Console.WriteLine("iyi tatiller");
            tekrar = false;
        }

        }while (answer != "1" && answer != "2");
    }



