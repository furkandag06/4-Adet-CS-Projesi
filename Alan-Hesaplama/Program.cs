using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Lütfen bir işlem seçiniz:");
            Console.WriteLine("1. Hesaplama için");
            Console.WriteLine("0. Çıkış için");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Hesaplama işlemi seçildi.");
                    Console.WriteLine("Lütfen yapmak istediğiniz işlem türünü seçiniz:");
                    Console.WriteLine("1. Alan için");
                    Console.WriteLine("2. Çevre için");

                    string islemSecim = Console.ReadLine();

                    switch (islemSecim)
                    {
                        case "1":
                            Console.WriteLine("Alan hesaplama işlemi seçildi.");
                            AlanHesaplama();
                            break;
                        case "2":
                            Console.WriteLine("Çevre hesaplama işlemi seçildi.");
                            CevreHesaplama();
                            break;
                        default:
                            Console.WriteLine("Geçersiz işlem türü seçimi. Lütfen tekrar deneyin.");
                            break;
                    }
                    break;
                case "0":
                    Console.WriteLine("Çıkış işlemi seçildi. Programdan çıkılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;
            }

            Console.WriteLine("\nDevam etmek için bir tuşa basın, çıkış için 'q' tuşuna basın.");
            if (Console.ReadLine().ToLower() == "q")
            {
                Console.WriteLine("Programdan çıkılıyor...");
                return;
            }

            Console.Clear();
        }
    }

    static void AlanHesaplama()
    {
        Console.WriteLine("Lütfen hesaplamak istediğiniz şekli seçiniz:");
        Console.WriteLine("1. Üçgen için");
        Console.WriteLine("2. Kare için");
        Console.WriteLine("3. Dikdörtgen için");
        Console.WriteLine("4. Daire için");

        string sekilSecim = Console.ReadLine();

        switch (sekilSecim)
        {
            case "1":
                Console.WriteLine("Üçgen seçildi.");
                SecilenUcgenHesaplama("alan");
                break;
            case "2":
                Console.WriteLine("Kare seçildi.");
                KareAlanHesapla();
                break;
            case "3":
                Console.WriteLine("Dikdörtgen seçildi.");
                DikdortgenAlanHesapla();
                break;
            case "4":
                Console.WriteLine("Daire seçildi.");
                DaireAlanHesapla();
                break;
            default:
                Console.WriteLine("Geçersiz şekil seçimi. Lütfen tekrar deneyin.");
                break;
        }
    }

    static void CevreHesaplama()
    {
        Console.WriteLine("Lütfen hesaplamak istediğiniz şekli seçiniz:");
        Console.WriteLine("1. Üçgen için");
        Console.WriteLine("2. Kare için");
        Console.WriteLine("3. Dikdörtgen için");
        Console.WriteLine("4. Daire için");

        string sekilSecim = Console.ReadLine();

        switch (sekilSecim)
        {
            case "1":
                Console.WriteLine("Üçgen seçildi.");
                SecilenUcgenHesaplama("çevre");
                break;
            case "2":
                Console.WriteLine("Kare seçildi.");
                KareCevreHesapla();
                break;
            case "3":
                Console.WriteLine("Dikdörtgen seçildi.");
                DikdortgenCevreHesapla();
                break;
            case "4":
                Console.WriteLine("Daire seçildi.");
                DaireCevreHesapla();
                break;
            default:
                Console.WriteLine("Geçersiz şekil seçimi. Lütfen tekrar deneyin.");
                break;
        }
    }

    static void SecilenUcgenHesaplama(string hesapTuru)
    {
        Console.WriteLine("Lütfen üçgen türünü seçiniz:");
        Console.WriteLine("1. Eşkenar üçgen için");
        Console.WriteLine("2. İkizkenar üçgen için");
        Console.WriteLine("3. Çeşitkenar üçgen için");

        string ucgenTur = Console.ReadLine();

        switch (ucgenTur)
        {
            case "1":
                if (hesapTuru == "alan")
                    EskenarUcgenAlanHesapla();
                else
                    EskenarUcgenCevreHesapla();
                break;
            case "2":
                if (hesapTuru == "alan")
                    IkizkenarUcgenAlanHesapla();
                else
                    IkizkenarUcgenCevreHesapla();
                break;
            case "3":
                if (hesapTuru == "alan")
                    CesitkenarUcgenAlanHesapla();
                else
                    CesitkenarUcgenCevreHesapla();
                break;
            default:
                Console.WriteLine("Geçersiz üçgen türü seçimi. Lütfen tekrar deneyin.");
                break;
        }
    }

    static double GirdiAl(string mesaj)
    {
        double deger;
        while (true)
        {
            Console.WriteLine(mesaj);
            if (double.TryParse(Console.ReadLine(), out deger))
            {
                return deger;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen sayı giriniz.");
            }
        }
    }

    static void EskenarUcgenAlanHesapla()
    {
        double kenar = GirdiAl("Lütfen bir kenar uzunluğunu giriniz:");
        double alan = (Math.Sqrt(3) / 4) * Math.Pow(kenar, 2);
        Console.WriteLine("Eşkenar üçgenin alanı: " + alan);
    }

    static void EskenarUcgenCevreHesapla()
    {
        double kenar = GirdiAl("Lütfen bir kenar uzunluğunu giriniz:");
        double cevre = 3 * kenar;
        Console.WriteLine("Eşkenar üçgenin çevresi: " + cevre);
    }

    static void IkizkenarUcgenAlanHesapla()
    {
        double kenar = GirdiAl("Lütfen iki eşit kenarın uzunluğunu giriniz:");
        double taban = GirdiAl("Lütfen taban uzunluğunu giriniz:");
        double yukseklik = Math.Sqrt(Math.Pow(kenar, 2) - Math.Pow(taban / 2, 2));
        double alan = (taban * yukseklik) / 2;
        Console.WriteLine("İkizkenar üçgenin alanı: " + alan);
    }

    static void IkizkenarUcgenCevreHesapla()
    {
        double kenar = GirdiAl("Lütfen iki eşit kenarın uzunluğunu giriniz:");
        double taban = GirdiAl("Lütfen taban uzunluğunu giriniz:");
        double cevre = 2 * kenar + taban;
        Console.WriteLine("İkizkenar üçgenin çevresi: " + cevre);
    }

    static void CesitkenarUcgenAlanHesapla()
    {
        double a = GirdiAl("Lütfen üç kenarın uzunluğunu giriniz (a):");
        double b = GirdiAl("Lütfen üç kenarın uzunluğunu giriniz (b):");
        double c = GirdiAl("Lütfen üç kenarın uzunluğunu giriniz (c):");
        double s = (a + b + c) / 2;
        double alan = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        Console.WriteLine("Çeşitkenar üçgenin alanı: " + alan);
    }

    static void CesitkenarUcgenCevreHesapla()
    {
        double a = GirdiAl("Lütfen üç kenarın uzunluğunu giriniz (a):");
        double b = GirdiAl("Lütfen üç kenarın uzunluğunu giriniz (b):");
        double c = GirdiAl("Lütfen üç kenarın uzunluğunu giriniz (c):");
        double cevre = a + b + c;
        Console.WriteLine("Çeşitkenar üçgenin çevresi: " + cevre);
    }

    static void KareAlanHesapla()
    {
        double kenar = GirdiAl("Lütfen bir kenar uzunluğunu giriniz:");
        double alan = Math.Pow(kenar, 2);
        Console.WriteLine("Karenin alanı: " + alan);
    }

    static void KareCevreHesapla()
    {
        double kenar = GirdiAl("Lütfen bir kenar uzunluğunu giriniz:");
        double cevre = 4 * kenar;
        Console.WriteLine("Karenin çevresi: " + cevre);
    }

    static void DikdortgenAlanHesapla()
    {
        double uzunKenar = GirdiAl("Lütfen uzun kenar uzunluğunu giriniz:");
        double kisaKenar = GirdiAl("Lütfen kısa kenar uzunluğunu giriniz:");
        double alan = uzunKenar * kisaKenar;
        Console.WriteLine("Dikdörtgenin alanı: " + alan);
    }

    static void DikdortgenCevreHesapla()
    {
        double uzunKenar = GirdiAl("Lütfen uzun kenar uzunluğunu giriniz:");
        double kisaKenar = GirdiAl("Lütfen kısa kenar uzunluğunu giriniz:");
        double cevre = 2 * (uzunKenar + kisaKenar);
        Console.WriteLine("Dikdörtgenin çevresi: " + cevre);
    }

    static void DaireAlanHesapla()
    {
        double yaricap = GirdiAl("Lütfen yarıçap uzunluğunu giriniz:");
        double alan = Math.PI * Math.Pow(yaricap, 2);
        Console.WriteLine("Dairenin alanı: " + alan);
    }

    static void DaireCevreHesapla()
    {
        double yaricap = GirdiAl("Lütfen yarıçap uzunluğunu giriniz:");
        double cevre = 2 * Math.PI * yaricap;
        Console.WriteLine("Dairenin çevresi: " + cevre);
    }
}