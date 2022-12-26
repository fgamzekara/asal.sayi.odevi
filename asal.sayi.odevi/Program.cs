internal class Program
{
    private static void Main(string[] args)
    {
        int sayi = 0;
        bool durum = true;
        while (sayi<100)
        {
            sayi++;
            for (int i =2; i<sayi; i++)
            {
                if (sayi % i == 0) durum = false;
                
            }
            if (durum == true) Console.WriteLine(sayi);
            durum = true;
        }
         Console.ReadKey();
    }
}