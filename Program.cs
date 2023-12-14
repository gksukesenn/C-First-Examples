using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# öğrenmeye başladım."); //WriteLine ekrana yazıldıktan SONRA imleci alt satıra indiriyor.
            string ad_soyad = "Adı Soyadı";
            Console.WriteLine(ad_soyad);
            Console.WriteLine("Türkiye Cumhuriyeti");
            int student_number = 901;
            Console.WriteLine("Öğrenci adı-soyadı: " + ad_soyad + " " + "Öğrenci numarası: " + student_number);
            //String birleştrimenin ikinci bir yöntemi daha var.
            Console.WriteLine("Öğrenci adı-soyadı: {0} Öğrenci numarası: {1} ", ad_soyad, student_number);
            string student_school;
            Console.Write("Lütfen okulunuzun adını giriniz: ");
            student_school = Console.ReadLine();//veeri girişşi readline ile alınır.
            Console.WriteLine("Öğrenci Adı: {0} Öğrenci numarası: {1} Öğrencinin Okulu: {2} " , ad_soyad,student_number,student_school);



            int sayi1, sayi2, toplam;
            Console.Write("1. sayıyı giriniz: ");
            //sayi1=(int)Console.ReadLine();//C#  klavyeden girilen bütün verileri string olarak kabul eder.
                                          //Klavyeden girilen değeri int değerine aktarmak istiyorsak dönüşüm yapmalıyız.
            sayi1=Convert.ToInt16(Console.ReadLine());//burdaki 16 bit anlamında kullanıldı.
            Console.Write("2. sayıyı giriniz: ");
            sayi2= Convert.ToInt16(Console.ReadLine());
            toplam=sayi1+sayi2;
            Console.WriteLine("Sayıların toplamı: {0}", toplam);


            double boy, kilo, bki;
            Console.Write("Boyunuzu metre cinsinde giriniz: ");
            boy=Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilonuzu kg cinsinden giriniz: ");
            kilo = Convert.ToDouble(Console.ReadLine());
            bki = kilo / (boy * boy);
            Console.WriteLine("Beden kitle indeksiniz: {0}", bki);


            const double pi = 3.14;
            // pi'yi const değerinde değiştirilemez bir sabit olarak atadığımız için başka değer veremeyiz.
            //Const türünde bir değişken girildiğinde değişkenin değeri aynı satırda verilmek zorundadır.
            double yaricap, alan;

            Console.Write("Yarıçap değerini giriniz: ");
            yaricap= Convert.ToDouble(Console.ReadLine());
            alan = pi * (yaricap * yaricap);
            Console.WriteLine("Dairenin alanı: {0}", alan);
            //Const ifadesini tüm değişken türlerinde kullanabiliriz.
            const string vatan = "Türkiye Cumhuriyeti";
            Console.WriteLine("Vatanımız: {0}", vatan);

            if(true)
            {
                Console.WriteLine("Doğru");
            }
            else {
                Console.WriteLine("Yanlış");
            }


            int ortalama = 50;
            if (ortalama < 50)
            {
                Console.WriteLine("Kaldı");
            }
            else
            {
                Console.WriteLine("Geçti");
            }

            int sayi, sonuc;
            Console.Write("Bir sayı giriniz: ");
            sayi=Convert.ToInt16(Console.ReadLine());
            sonuc = sayi % 2;

            if (sonuc == 0)

                Console.WriteLine("Girilen sayi çifttir.");
            else
                Console.WriteLine("Girilen sayı tektir.");
            
            
            Console.ReadKey(); //Asıl amacı klavyeden hangi tuşa basıldığını kontrol etmektir.
                               //Biz burada komutu çalıştırdığımızda gerçekleşen olayları görmek için kullandık.


        }
    }
}
