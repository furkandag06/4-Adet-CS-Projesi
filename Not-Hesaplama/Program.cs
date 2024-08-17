using System;

class Program
{
    static void Main()
    {
        string input;
        do
        {
            Console.WriteLine("Çıkış için 'E'");
            Console.WriteLine("Not hesaplamak için 'H'");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            input = Console.ReadLine().Trim().ToUpper();

            if (input == "H")
            {
                CalculateGrade();
            }
            else if (input != "E")
            {
                Console.WriteLine("Geçersiz işlem! Lütfen yapmak istediğiniz işlemi seçiniz.");
            }
        } while (input != "E");

        Console.WriteLine("Programdan çıkılıyor..");
    }

    static void CalculateGrade()
    {
        Console.Write("Lütfen dersin adını giriniz: ");
        string courseName = Console.ReadLine();

        int numberOfGrades;
        while (true)
        {
            Console.Write("Lütfen girmek istediğiniz not adedini (1 veya 2) giriniz: ");
            if (int.TryParse(Console.ReadLine(), out numberOfGrades) && (numberOfGrades == 1 || numberOfGrades == 2))
                break;
            Console.WriteLine("Lütfen 1 veya 2 sayısını giriniz.");
        }

        int[] grades = new int[numberOfGrades];
        int[] percentages = new int[numberOfGrades];

        int totalPercentage = 0;

        for (int i = 0; i < numberOfGrades; i++)
        {
            int grade;
            while (true)
            {
                Console.Write($"{i + 1}. notunuzu giriniz: ");
                if (int.TryParse(Console.ReadLine(), out grade) && grade >= 0 && grade <= 100)
                    break;
                Console.WriteLine("Girilen not 0 ile 100 arasında olmalıdır.");
            }
            grades[i] = grade;

            int percentage;
            while (true)
            {
                Console.Write($"{i + 1}. notunuzun yüzdesini giriniz: ");
                if (int.TryParse(Console.ReadLine(), out percentage) && percentage >= 0 && percentage <= 100 && totalPercentage + percentage <= 100)
                    break;
                Console.WriteLine($"Yüzde değeri 0 ile 100 arasında olmalıdır ve kalan yüzde hakkınız {100 - totalPercentage}'dir.");
            }
            totalPercentage += percentage;
            percentages[i] = percentage;
        }

        if (totalPercentage != 100)
        {
            Console.WriteLine("Yüzdeler toplamı 100 olmalıdır. Not hesaplama iptal edildi.");
            return;
        }

        double average = 0;
        for (int i = 0; i < numberOfGrades; i++)
        {
            average += grades[i] * (percentages[i] / 100.0);
        }

        string letterGrade = "";
        string status = "";

        if (average >= 90)
        {
            letterGrade = "AA";
            status = "GEÇTİ";
        }
        else if (average >= 85)
        {
            letterGrade = "BA";
            status = "GEÇTİ";
        }
        else if (average >= 80)
        {
            letterGrade = "BB";
            status = "GEÇTİ";
        }
        else if (average >= 75)
        {
            letterGrade = "CB";
            status = "GEÇTİ";
        }
        else if (average >= 70)
        {
            letterGrade = "CC";
            status = "GEÇTİ";
        }
        else if (average >= 65)
        {
            letterGrade = "DC";
            status = "ŞARTLI GEÇTİ";
        }
        else if (average >= 60)
        {
            letterGrade = "DD";
            status = "ŞARTLI GEÇTİ";
        }
        else
        {
            letterGrade = "FF";
            status = "KALDI";
        }

        Console.WriteLine($"Sonuç: {courseName} dersi not ortalamanız {average:F1} Harf notunuz {letterGrade} Durumunuz {status}");
    }
}
