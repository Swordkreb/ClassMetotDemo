using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        //Musteri ekleme, listeleme,silme 

        public static void MusteriEkleme(Musteri musteri)
        {

            Console.WriteLine("Müşteri Eklendi !");

        }

        public static void MusteriListele(Musteri[] musteriler)
        {

            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine("Müşteri Adı : "+ musteri.Name);
                Console.WriteLine("Müşteri Soyadı : "+ musteri.Surname);
                Console.WriteLine("Müşteri Hesap Numarası : "+ musteri.AccountNumber);

            }

        }

        public static void MusteriSil(Musteri musteri, Musteri[] musteriler)
        {

            for (int i = 0; i < musteriler.Length; i++)
            {

                if (musteriler[i].Id == musteri.Id)
                {
                    Console.WriteLine("Müşteri silindi.");
                    break;

                }
                

            }

        }

    }
}
