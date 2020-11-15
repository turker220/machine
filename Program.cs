using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir sayı giriniz");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            int y = Convert.ToInt32(Console.ReadLine());
           
                 //void hesapmak()
           // {
                Console.WriteLine("Taplama için 1 ,çıkarma için 2 ,bölme için 3 ,çarpma için ise 4 tuşuna basınız");
                int hesapmakine = Convert.ToInt32(Console.ReadLine());
            //}      
            
             
            
            if (hesapmakine== 1)
            {
                int topsonuc = X + y;
                Console.WriteLine("Toplamınız:"+topsonuc);
                Console.ReadLine();
                

            }
            else if (hesapmakine == 2)
            {
                int cıksonuc = X - y;
                Console.WriteLine("Çıkarma:"+ cıksonuc);
                Console.ReadLine();


            }
            else if (hesapmakine == 3)
            {
                int bolsonuc = X / y;
                Console.WriteLine("Bölme:"+ bolsonuc);
                Console.ReadLine();


            }
            else if (hesapmakine == 4)
            {
                int carpmason = X * y;
                Console.WriteLine("çarpma:"+ carpmason);
                Console.ReadLine();



            }
            else
            {
                Console.WriteLine("Yanlış Yazdınız");
                
            }
            

        }
    }
}
