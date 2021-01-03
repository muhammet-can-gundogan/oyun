using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            int seviye, rastgele, tahmin, hak1 = 6, hak2 = 4, hak3 = 2;
            Random rnd = new Random();
            Console.WriteLine("oyunun zorluk seviyesini seçin.\nKolay seviye(0-10)-6 hak icin ‘1’ \nOrta seviye(0-25) -4 hak icin ‘2’ \nZor seviye(0-50) -2 hak icin ‘3’ giriniz");

            try
            {
                seviye = Int32.Parse(Console.ReadLine());
                switch (seviye)
                {
                    case 1:
                        rastgele = rnd.Next(1, 10);
                        for (int i = 0; i < 6; i++)
                        {

                            Console.WriteLine("Tahmininiz?");
                            tahmin = Int32.Parse(Console.ReadLine());
                            hak1--;

                            if (hak1 == 0)
                            {

                                Console.WriteLine("Hakkınız bitti çıkış yapılıyor");

                                break;
                            }
                            if (tahmin == rastgele)
                            {
                                Console.WriteLine("doğru bildiniz tebrikler..");
                                break;
                            }
                            else
                            {
                                Console.WriteLine(hak1 + " hakkınız kaldı");


                            }

                        }

                        break;

                    case 2:
                        rastgele = rnd.Next(1, 25);
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine("tahmininiz?");
                            tahmin = Int32.Parse(Console.ReadLine());
                            hak2--;
                            if (hak2 == 0)
                            {
                                Console.WriteLine("Hakkınız bitti çıkış yapılıyor");
                                break;
                            }
                            if (tahmin == rastgele)
                            {
                                Console.WriteLine("doğru bildiniz tebrikler..");
                                break;
                            }
                            else
                            {
                                Console.WriteLine(hak2 + " hakkınız kaldı");
                            }

                        }

                        break;

                    case 3:
                        rastgele = rnd.Next(1, 50);
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine("tahmininiz?");
                            tahmin = Int32.Parse(Console.ReadLine());
                            hak3--;
                            if (hak3 == 0)
                            {
                                Console.WriteLine("Hakkınız bitti çıkış yapılıyor");
                                break;
                            }
                            if (tahmin == rastgele)
                            {
                                Console.WriteLine("doğru bildiniz tebrikler..");
                                break;
                            }
                            else
                            {
                                Console.WriteLine(hak3 + " hakkınız kaldı");
                            }

                        }

                        break;

                    default:
                        Console.WriteLine("yanlış giriş tekrar deneyiniz..");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Rakamsal değer giriniz");

            }
            Console.ReadKey();
        }
    }
}
