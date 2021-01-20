using System;

namespace ClassMetotDemoo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 01234567890;
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Demir";
            musteri1.HesapNo = 12345;
            musteri1.Açiklama = "Vadeli Hesap";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 09876543210;
            musteri2.Adi = "Elif";
            musteri2.Soyadi = "Doğan";
            musteri2.HesapNo = 67890;
            musteri2.Açiklama = "Altın Hesabı";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 01478523690;
            musteri3.Adi = "Enes";
            musteri3.Soyadi = "Yakacı";
            musteri3.HesapNo = 48269;
            musteri3.Açiklama = "Yatırım Hesabı";

            MusteriManager musteriManager = new MusteriManager();

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            Console.WriteLine("Eklenen Hesaplar");
            Console.WriteLine("*********************************************");
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Ekle(musteri);
                Console.WriteLine(Environment.NewLine);
            }

            Console.WriteLine("Listelenen Hesaplar");
            Console.WriteLine("*********************************************");
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Listele(musteri);
                Console.WriteLine(Environment.NewLine);
            }

            Console.WriteLine("Silinen Hesaplar");
            Console.WriteLine("*********************************************");
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Sil(musteri);
                Console.WriteLine(Environment.NewLine);
            }

            Console.ReadLine();

        }
    }
}
