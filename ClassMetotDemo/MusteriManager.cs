using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    { 
    
        public void Listele(Musteri i)
        {
            Console.WriteLine("Müşterinin adı soyadı :  " +i.Adi + " " + i.Soyadi);
            Console.WriteLine("Müşterinin Yaşı       :  " + i.MusteriYasi);
            Console.WriteLine("Mşterinin Mesleği     :  " + i.Meslek);
            Console.WriteLine("-------------------------------------------");
        }
        public void Ekle(string ad, string soyad, int yas, string meslek)
        {
            Console.WriteLine("*"+" "+ad+" "+soyad+" müşteri listesine başarıyla eklendi.");

            Console.WriteLine("Müşterinin adı soyadı :  " + ad + " " + soyad);
            Console.WriteLine("Müşterinin Yaşı       :  " + yas);
            Console.WriteLine("Mşterinin Mesleği     :  " + meslek);
            Console.WriteLine("-------------------------------------------");
        }
        public void Sil(Musteri x)
        {
            string onay;
            Console.WriteLine(x.Adi+" "+x.Soyadi+" kişisini müşteri listesinden silmek istiyor musunuz? (evet/hayır): ");
            onay = Console.ReadLine();
            if (onay == "evet" )
            {
                Console.WriteLine("*" + " " + x.Adi + " " + x.Soyadi + ", müşteri listesinden çıkarıldı.");
            }
            else
            {
                Console.WriteLine("Ana ekrana döndürülüyorsunuz. Lütfen bekleyin.");
            }
        }
    }
}
