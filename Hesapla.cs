using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesÖdev_22._3._19
{
    class Hesapla
    {
        #region Sınıf Bilgisi ve Kısıtlamaları
        public int Sayi1 { get; set; }
        public int Sayi2 { get; set; }

        public Hesapla(int Sayi1,int Sayi2)
        {
            this.Sayi1 = Sayi1;
            this.Sayi2 = Sayi2;
        }
        public Hesapla(int Sayi1)
        {
            this.Sayi1 = Sayi1;
        }
        public Hesapla() { }
        #endregion
        public int Toplama(int S1,int S2)
        {
            return (S1+S2);
        }
        public int Çıkartma(int s1,int s2)
        {
            return (s1 - s2);
        }
        public double Bölme(int s1,int s2)
        {
            double Sonuc = 0;
        Basla:
            if (s2 != 0)
            {
                Sonuc = s1 / s2;
            }
            else
            {
                Console.WriteLine("İkinci sayıyı sıfırdan farklı giriniz.");
                Console.Clear();
                Console.WriteLine("Bölen sayıyı giriniz: ");
                s2 = Int32.Parse(Console.ReadLine());
                goto Basla;
            }
            return (Sonuc);
        }
        public long Çarpma(int s1, int s2)
        {
            long Sonuc = s1 * s2;
            return (Sonuc);
        }
        public long Faktöriyel(int s1)
        {
            long Sonuc = 1;
            for (int i = 1; i <= s1; i++)
            {
                Sonuc = Sonuc * i;
            }
            return (Sonuc);
        }
        public int AsallıkKontrol(int s1)
        {
            int Kontrol =1;
            for (int i = 2; i < s1; i++)
            {
                if (s1 % i == 0)
                    Kontrol = 0;
                else
                    Kontrol = 1;             
            }
            return (Kontrol);
        }

        public double Karakök(int s1)
        {
            double Sonuc = Math.Sqrt(s1);
            return (Sonuc);
        }
        public double UsAlma(int s1, int s2)
        {
           double Sonuc= Math.Pow(s1, s2);//Sayı,üs
            return (Sonuc);
        }
    }
}
