namespace CampFifthDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu dersin konusu *soyutlama* 
            //SO*L*İD 

            //Mücahit Durdu
            GercekMüsteri musteri1 = new GercekMüsteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Mücahit";
            musteri1.Soyadi = "Durdu";
            musteri1.TcNo = "09876543212";

            // Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1231321321321";


            Musteri musteri3 = new GercekMüsteri();
            Musteri musteri4 = new TuzelMusteri();
            //Base sınıf referans tutucu olduğu için  gercek ve tuzel musteriyide tutabilir

            MüsteriManager musteriManager = new MüsteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);   
            musteriManager.Add(musteri3);   
            musteriManager.Add(musteri4);
            /*
                Yukarıda musteri 1 2 3 4  hepsini gönderebişlmemizin sebebi 
            hepsinin soyutlama ile müşteri sınıfından soyutlanmasıdır.
            Hepsi müşteri ama aralarında kendine özel özellikleri ıolduğu için
            onları farklı classlar halinde oluşturduk. Bu sayede küşterilerlin
            birbiri ile karışmasını azaltmış olduk.

            */
        }
    }
}