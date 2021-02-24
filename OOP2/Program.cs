using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Berkay";
            musteri1.Soyadi = "Güntürk";
            musteri1.TcNo = "22222222222";


            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";
            

            //Gerçek Müsteri ve Tüzel Müsteri
            //57:00:00 kaldım
        }
    }
}
