using ClassMethodDemo.Concrete;
using ClassMethodDemo.Entity;

MusteriManager musteriManager = new MusteriManager();

Musteri musteri1 = new GercekMusteri
{
    MusteriNo = "1",
    Adi = "Muhammed Ali",
    Soyadi= "Ak",
    TcNo = "12345678901"
};  

Musteri musteri2 = new TuzelMusteri
{
    MusteriNo = "2",
    SirketAdi = "Kodlama.io",
    VergiNo = "123124512512"
};

GercekMusteri musteri3 = new GercekMusteri
{
    MusteriNo = "3",
    Adi = "Durdu",
    Soyadi = "Baltacı",
    TcNo = "412124124124"
};

TuzelMusteri musteri4 = new TuzelMusteri
{
    MusteriNo = "4",
    SirketAdi = "Youtube.com",
    VergiNo = "513123123123"
};

musteriManager.Add(musteri1);
musteriManager.Add(musteri2);
musteriManager.Add(musteri3);
musteriManager.Add(musteri4);
musteriManager.Add(new TuzelMusteri { MusteriNo = "5", SirketAdi = "Google.com", VergiNo = "123123123123" });

Console.WriteLine("---------------------------------");

List<Musteri> musteriler = new List<Musteri>
{
    musteri1,
    musteri2, 
    musteri3, 
    musteri4 , 
    new GercekMusteri{MusteriNo = "6",Adi = "Batuhan",Soyadi = "Teke",TcNo = "12312512312312"}
};
musteriManager.AddRange(musteriler);




