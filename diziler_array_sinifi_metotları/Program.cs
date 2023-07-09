internal class Program
{
    private static void Main(string[] args)
    {//
     //   // Sort
     //   int[] sayiDizisi = { 23, 12, 4, 86, 72, 3,11,17};
//
//
     //   Console.WriteLine("***** Sırasız Dizi *****");
     //   foreach (var sayi in sayiDizisi)
     //   Console.WriteLine(sayi);
//
//
     //   Console.WriteLine("***** Sıralı Dizi *****");
     //   Array.Sort(sayiDizisi);
     //   foreach (var sayi in sayiDizisi)
     //   Console.WriteLine(sayi);
//
     //   // Clear
     //   Console.WriteLine("***** Array Clear *****");
     //   // Sayı dizi elemanlarını kullanarak 2. indexten itibaren 2 tane elemanı sıfırlar.
     //   Array.Clear(sayiDizisi,2,2);
     //   foreach (var sayi in sayiDizisi)
     //   Console.WriteLine(sayi);
//
     //   // Reverse
     //   Console.WriteLine("***** Array Reverse *****");
     //   Array.Reverse(sayiDizisi);
     //   foreach (var sayi in sayiDizisi)
     //   Console.WriteLine(sayi);
     //   
     //   
     //   // Index of
     //   Console.WriteLine("***** Array Index of *****");        
     //   Console.WriteLine(Array.IndexOf(sayiDizisi,23));
//
     //   // Resize
     //   Console.WriteLine("***** Array Resize *****");        
     //   Array.Resize<int>(ref sayiDizisi,9);
     //   sayiDizisi[8] = 99;
     //   foreach (var sayi in sayiDizisi)
     //   Console.WriteLine(sayi);
//
//
     
        // Plus Minus
        int[] arr = {-4, 3, -9, 0, 4, 1};
        double pos = 0;
        double neg = 0;
        double zero = 0;
        double length = arr.Count<int>();

        foreach(int num in arr) 
        {
            if (num > 0)
            {
                ++pos;
            }
            else if (num < 0)
            {
                ++neg;
            }
            else 
            {
                ++zero;
            }
            
        }
        
        Console.WriteLine((pos / length).ToString("0.000000"));
        Console.WriteLine((neg / length).ToString("0.000000"));
        Console.WriteLine((zero / length).ToString("0.000000"));




    }
}