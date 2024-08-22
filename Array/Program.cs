


using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 adet sayı verisi alacak dizi
            int[] numbers = new int[10];

            // Dizinin elemanlarını bir for döngüsü ile doldurup, ekrana yazdır
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
                Console.WriteLine(i);
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int newnumber = Convert.ToInt32(Console.ReadLine());

            int[] newnumbers = new int[numbers.Length + 1];

            for (int i = 0; i < numbers.Length; i++)
            {
                newnumbers[i] = numbers[i];
            }

            // Kullanıcıdan alınan yeni değeri diziye ekliyoruz
            newnumbers[newnumbers.Length - 1] = newnumber;

            // Yeni diziyi ekrana yazdırıyoruz
            Console.WriteLine("Güncellenmiş dizi:");
            foreach (int number in newnumbers)
            {
                Console.WriteLine(number);
            }

            // Diziyi büyükten küçüğe sıralıyoruz
            Array.Sort(newnumbers);
            Array.Reverse(newnumbers);

            // Sıralanmış diziyi ekrana yazdırıyoruz
            Console.WriteLine("Büyükten küçüğe sıralanmış dizi:");
            foreach (int number in newnumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}