using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        char[] cards = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        Random rnd = new Random();
        cards = cards.OrderBy(x => rnd.Next()).ToArray();

        string[] displayCards = new string[16];
        for (int i = 0; i < 16; i++)
        {
            displayCards[i] = (i + 1).ToString();
        }

        int steps = 0;
        DateTime startTime = DateTime.Now;

        while (displayCards.Contains("*") == false)
        {
            Console.Clear();
            PrintCards(displayCards);
            int firstCardIndex = GetCardIndex(displayCards);
            displayCards[firstCardIndex] = cards[firstCardIndex].ToString();
            Console.Clear();
            PrintCards(displayCards);

            int secondCardIndex = GetCardIndex(displayCards);
            displayCards[secondCardIndex] = cards[secondCardIndex].ToString();
            Console.Clear();
            PrintCards(displayCards);

            if (cards[firstCardIndex] == cards[secondCardIndex])
            {
                Console.WriteLine("Eşleşme bulundu!");
            }
            else
            {
                Console.WriteLine("Eşleşme yok!");
                displayCards[firstCardIndex] = (firstCardIndex + 1).ToString();
                displayCards[secondCardIndex] = (secondCardIndex + 1).ToString();
            }

            steps++;
            Console.WriteLine("Devam etmek için herhangi bir tuşa basın...");
            Console.ReadKey();
        }

        DateTime endTime = DateTime.Now;
        TimeSpan duration = endTime - startTime;
        Console.WriteLine($"OYUN BİTTİ! TOPLAM ADIM SAYISI = {steps}, TOPLAM SÜRE = {duration.TotalMinutes} dakika");
    }

    static void PrintCards(string[] displayCards)
    {
        for (int i = 0; i < displayCards.Length; i++)
        {
            Console.Write($"{displayCards[i],3} ");
            if ((i + 1) % 4 == 0)
            {
                Console.WriteLine();
            }
        }
    }

    static int GetCardIndex(string[] displayCards)
    {
        int index;
        while (true)
        {
            Console.Write("Kart seçin (1-16): ");
            if (int.TryParse(Console.ReadLine(), out index) && index >= 1 && index <= 16 && displayCards[index - 1] != "*")
            {
                return index - 1;
            }
            Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
        }
    }
}
