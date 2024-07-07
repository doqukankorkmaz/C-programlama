// Bilet fiyatları
int VIPBiletFiyati = 50;
int NormalBiletFiyati = 30;

// Kullanıcıdan bilet sayısı ve tipi isteniyor
Console.Write("VIP bilet sayısı: ");
int VIPBiletSayisi = Convert.ToInt32(Console.ReadLine());

Console.Write("Normal bilet sayısı: ");
int NormalBiletSayisi = Convert.ToInt32(Console.ReadLine());

// Toplam bilet fiyatı hesaplanıyor
int toplamFiyat = VIPBiletSayisi * VIPBiletFiyati + NormalBiletSayisi * NormalBiletFiyati;

// Kullanıcıya toplam fiyat gösteriliyor
Console.WriteLine("Toplam fiyat: " + toplamFiyat + " TL");

// Ödeme işlemi gerçekleştiriliyor
Console.Write("Ödeme yapmak istediğinizden emin misiniz? (E/H)");
string cevap = Console.ReadLine();

if (cevap.ToLower() == "e")
{
    Console.WriteLine("Ödeme işlemi gerçekleştirildi.");
    Console.WriteLine("Biletleriniz e-posta yoluyla gönderilecektir. İyi seyirler!");
}
else
{
    Console.WriteLine("İşlem iptal edildi.");
}

Console.ReadLine();