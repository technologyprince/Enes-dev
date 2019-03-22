using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesÖdev_22._3._19
{
    class İşlem
    {
        public void YapılacakOlanTercih()
        {
            Console.WriteLine("1- Toplama işlemi");
            Console.WriteLine("2- Çıkarma işlemi");
            Console.WriteLine("3- Bölme işlemi");
            Console.WriteLine("4- Çarpma işlemi");
            Console.WriteLine("5- Faktöriyel alma");
            Console.WriteLine("6- Asallık kontrolü");
            Console.WriteLine("7- Karakök alma işlemi");
            Console.WriteLine("8- Üs alma işlemi");
            Console.WriteLine(" ");
            BasaDon:
            Console.WriteLine("Yapmak istediğiniz işlem numarasını giriniz.");
            int Yapılmakİstenilenİşlem=Int32.Parse(Console.ReadLine());

            Hesapla İşlem = new Hesapla();


            switch (Yapılmakİstenilenİşlem)
            {
                case 1:
                    Console.WriteLine("1.Sayıyı girimiz: ");
                    int s1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("2.Sayıyı girimiz: ");
                    int s2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("{0}+{1}={2}",s1,s2,İşlem.Toplama(s1, s2) );
                    break;
                case 2:
                    Console.WriteLine("1.Sayıyı girimiz: ");
                    int sa1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("2.Sayıyı girimiz: ");
                    int sa2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("{0}-{1}={2}", sa1, sa2,İşlem.Çıkartma(sa1, sa2));
                    break;
                case 3:
                    Console.WriteLine("Bölüm Olan Sayıyı girimiz: ");
                    int say1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Bölen Sayıyı girimiz: ");
                    int say2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("{0}/{1}={2}",say1,say2,İşlem.Bölme(say1, say2));
                    break;
                case 4:
                    Console.WriteLine("1.Sayıyı girimiz: ");
                    int sayi1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("2.Sayıyı girimiz: ");
                    int sayi2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("{0}x{1}={2}",sayi1,sayi2, İşlem.Çarpma(sayi1, sayi2));
                    break;
                case 5:
                    Console.WriteLine("Faktöriyelini almak istediğiniz sayıyı giriniz: ");
                    int sf1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Sayınız= {0}, Faktöriyeli= {1}",sf1, İşlem.Faktöriyel(sf1));
                    break;
                case 6:
                    Console.WriteLine("Asal olup olmadığını merak ettiğiniz sayıyı giriniz: ");
                    int Asmı = Int32.Parse(Console.ReadLine());    
                    if (İşlem.AsallıkKontrol(Asmı)==0)
                    {
                        Console.WriteLine("Sayınız= {0} Asal değildir.",Asmı);
                    }
                    else 
                    {
                        Console.WriteLine("Sayınız= {0} Asaldır.", Asmı);
                    }
                    break;
                case 7:
                    Console.WriteLine("Karakök almak istediğiniz sayıyı giriniz: ");
                    int Kkök = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("/{0}= {1}",Kkök, İşlem.Karakök(Kkök));
                    break;
                case 8:
                    Console.WriteLine("Taban sayısını giriniz: ");
                    int tbn = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Üs sayısını giriniz: ");
                    int üs = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Taban= {0}, Üs= {1}, Sonuç= {2}",tbn,üs, İşlem.UsAlma(tbn, üs));
                    break;
                default:
                    Console.WriteLine("Yanlış bir tercih yaptınız. Yönlendiriliyorsunuz.");
                    Console.Clear();
                    goto BasaDon;
            }
        }
    }
}
