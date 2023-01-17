namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
           Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Id = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Id = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Id+"\n"+urun.Adi + "\n" + urun.Aciklama);
                Console.WriteLine();
            }

            Console.WriteLine("------------METODLAR--------------");

            //instance -> örnek
            //Mor küçük kutu resmi metod anlamına gelir
            //İngiliz anahtarı 
            //encapsulation ürünün parametre(patlamaya müsait) olarak değilde özellik olarak eklenmesi örneği

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,9);
            sepetManager.Ekle2("Armut", "Yeşil armut", 12,8);


        }


    }
}