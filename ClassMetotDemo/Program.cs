using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Adi = "Emre";
            musteri.Soyadi = "Koçak";
            musteri.MusteriYasi = 26;
            musteri.Meslek = "Çalşmıyor";

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ayşe";
            musteri1.Soyadi = "Yıldırım";
            musteri1.MusteriYasi = 32;
            musteri1.Meslek = "Ev hanımı";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Merve";
            musteri2.Soyadi = "Sağdıç";
            musteri2.MusteriYasi = 28;
            musteri2.Meslek = "Doktor";


            Musteri[] musteriler = new Musteri[] { musteri, musteri1, musteri2};
            MusteriManager manager = new MusteriManager();
            
            foreach (var item in musteriler)
            {
                manager.Listele(item);
            }
            manager.Ekle("Ali", "Koç", 34, "Öğretmen");
            manager.Sil(musteri1);
        }
    }
}
