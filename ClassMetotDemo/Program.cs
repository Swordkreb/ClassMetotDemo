using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Name= "Kemal";
            musteri.Surname = "Yıldırım";
            musteri.AccountNumber = "11111111111";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Mesut";
            musteri2.Surname = "Aziz";
            musteri2.AccountNumber = "222222222222";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Name = "Hüseyin";
            musteri3.Surname = "Abdi";
            musteri3.AccountNumber = "3333333333333";

            Musteri[] musteriler = { musteri, musteri2, musteri3 };




            MusteriManager.MusteriListele(musteriler);

            Console.ReadLine();



        }
    }
}
