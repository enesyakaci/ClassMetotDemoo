using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemoo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("TC NO : " + musteri.Id + " " + Environment.NewLine + musteri.Adi + " " + musteri.Soyadi + " " + Environment.NewLine + musteri.HesapNo + " " + musteri.Açiklama + " " + "bilgilerine sahip müşteri sisteme eklendi.");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("TC NO : " + musteri.Id + " " + Environment.NewLine + musteri.Adi + " " + musteri.Soyadi + " " + Environment.NewLine + musteri.HesapNo + " " + musteri.Açiklama);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("TC NO : " + musteri.Id + " " + Environment.NewLine + musteri.Adi + " " + musteri.Soyadi + " " + Environment.NewLine + musteri.HesapNo + " " + musteri.Açiklama + " " + "bilgilerine sahip müşterinin kaydı sistemden kaldırıldı.");
        }
    }
}
