using System;

class Program
{
    static void Main()
    {
        Console.Write("Lütfen üçgenin kaç satır içereceğini giriniz: ");
        int satirSayisi = int.Parse(Console.ReadLine());


        int[][] pascalUcgeni = new int[satirSayisi][];

        for (int i = 0; i < satirSayisi; i++)
        {
            pascalUcgeni[i] = new int[i + 1];
            pascalUcgeni[i][0] = pascalUcgeni[i][i] = 1;

            for (int j = 1; j < i; j++)
            {
                pascalUcgeni[i][j] = pascalUcgeni[i - 1][j - 1] + pascalUcgeni[i - 1][j];
            }
        }

        for (int i = 0; i < satirSayisi; i++)
        {
            for (int k = 0; k < satirSayisi - i; k++)
            {
                Console.Write("   ");
            }

            for (int j = 0; j <= i; j++)
            {
                Console.Write("{0,6}", pascalUcgeni[i][j]);
            }
            Console.WriteLine();
        }
    }
}