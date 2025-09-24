using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kitaplik_Uygulamasi
{
    internal class Kitaplik_Uygulamasi  
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            string secim;
            Console.WriteLine("************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("** Türkçe Kitaplar Kategorisi               **               Yabancı Kitaplar Kategorisi      **");
            Console.WriteLine();
            Console.WriteLine("** 1: Kürk Mantolu Madonna - Sabahattin Ali **    7: Fareler ve İnsanlar - John Steinback     **");
            Console.WriteLine();
            Console.WriteLine("** 2: Ateşten Gömlek - Halide Edib Adıvar   **    8:  Simyacı - Paulo Coelho                  **");
            Console.WriteLine();
            Console.WriteLine("** 3: Çalıkuşu - Reşat Nuri Güntekin        **    9: Suç ve Ceza - Dostoyevski                **");
            Console.WriteLine();
            Console.WriteLine("** 4: Mai ve Siyah - Halit Ziya Uşaklıgil   **    10: İki Şehrin Hikayesi - Charles Dickens   **");
            Console.WriteLine();
            Console.WriteLine("** 5: Eylül - Mehmet Rauf                   **    11: Anna Karenina – Lev Nikolayeviç Tolstoy **");
            Console.WriteLine();
            Console.WriteLine("** 6: Aşk - Elif Şafak                      **    12: Hayvan Çiftliği - George Orwell         **");
            Console.WriteLine();
            Console.WriteLine("************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine("7-Çıkış");
            Console.WriteLine();
            Console.Write("Yapmak İstediğiniz İşlemi Seçiniz: ");
            int islem;
            islem = Convert.ToInt32(Console.ReadLine());

            if (islem == 1)
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("***** Fiyat Sorgulama *****");
                    Console.WriteLine();
                    Console.Write(" Lütfen Fiyatını Sorgulamak İstediğiniz Kitabın Numarasını Giriniz  (Çıkış Yapmak İçin 'çıkış' yazınız.) : ");
                    string numara = Console.ReadLine();
                    if (numara.ToLower() == "çıkış")
                    {
                        Console.WriteLine("Fiyat Sorgulama İşleminden Çıkış Yapılıyor...");
                        break;
                    }
                    switch (numara)
                    {
                        case "1":
                            Console.WriteLine("Kürk Mantolu Madonna - Sabahattin Ali: 45 TL");
                            break;
                        case "2":
                            Console.WriteLine("Ateşten Gömlek - Halide Edib Adıvar: 35 TL");
                            break;
                        case "3":
                            Console.WriteLine("Çalıkuşu - Reşat Nuri Güntekin: 40 TL");
                            break;
                        case "4":
                            Console.WriteLine("Mai ve Siyah - Halit Ziya Uşaklıgil: 30 TL");
                            break;
                        case "5":
                            Console.WriteLine("Eylül - Mehmet Rauf: 25 TL");
                            break;
                        case "6":
                            Console.WriteLine("Aşk - Elif Şafak: 50 TL");
                            break;
                        case "7":
                            Console.WriteLine("Fareler ve İnsanlar - John Steinback: 55 TL");
                            break;
                        case "8":
                            Console.WriteLine("Simyacı - Paulo Coelho: 60 TL");
                            break;
                        case "9":
                            Console.WriteLine("Suç ve Ceza - Dostoyevski: 70 TL");
                            break;
                        case "10":
                            Console.WriteLine("İki Şehrin Hikayesi - Charles Dickens: 65 TL");
                            break;
                        case "11":
                            Console.WriteLine("Anna Karenina – Lev Nikolayeviç Tolstoy: 80 TL");
                            break;
                        case "12":
                            Console.WriteLine("Hayvan Çiftliği - George Orwell: 45 TL");
                            break;
                        default:
                            Console.WriteLine("Geçersiz Kitap Numarası. Lütfen Tekrar Deneyiniz.");
                            break;
                    }

                }
            }
            if(islem == 2)
            {
                
                    Console.WriteLine("***** Yeni Okur Kaydı *****");
                    string ad, soyad, uni;
                    Console.Write("Adınız: ");
                    ad = Console.ReadLine();
                    Console.Write("Soyadınız: ");
                    soyad = Console.ReadLine();
                    Console.Write("Üniversiteniz: ");
                    uni = Console.ReadLine();
                    Console.WriteLine("Kaydınız Başarıyla Oluşturulmuştur. Hoşgeldiniz " + ad + " " + soyad + "!");

                    string dosya = "C:\\Users\\yelda\\OneDrive\\Masaüstü\\kullanici.txt";
                    StreamWriter sw = new StreamWriter(dosya);
                    sw.WriteLine("Ad: " + ad);
                    sw.WriteLine("Soyad: " + soyad);
                    sw.WriteLine("Üniversite: " + uni);
                    sw.Close();
                    Console.WriteLine();
                
            }
            if(islem == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Günün Kitabı: Kürk Mantolu Madonna - Sabahattin Ali");
                Console.WriteLine();    
                Console.WriteLine("Öne Çıkan Karakterler: Anlatıcı (isimsiz genç) – Rasim’in arkadaşı, romanı bize aktaran kişi.\r\n\r\nRasim – Anlatıcının arkadaşı, Raif Efendi’yle tanışmasına vesile olur.\r\n\r\nRaif Efendi – İçine kapanık, sessiz memur. Romanın merkezine defteriyle oturur.\r\n\r\nRaif Efendi’nin iş arkadaşları ve ailesi – Kısaca bahsedilir.\r\n\r\nMaria Puder (Madonna) – Raif Efendi’nin hatıra defterinde ortaya çıkar; resmini gördüğü ve sonradan tanıştığı kadın.");
                Console.WriteLine();
                Console.WriteLine("Kısa Tanıtım: Kürk Mantolu Madonna, Sabahattin Ali'nin 1943 yılında yayımladığı bir romanıdır. Kitapta dokunaklı bir aşk hikâyesi anlatılmaktadır.");
                Console.WriteLine();
                Console.WriteLine("Kısa Özeti: Raif Efendi, içine kapanık ve silik bir memurdur. Gençliğinde Almanya’da bulunduğu sırada bir resim sergisinde “Kürk Mantolu Madonna” tablosunu görür ve tablonun sahibi Maria Puder ile tanışır. Aralarında güçlü bir aşk doğar; fakat Maria’nın ani ölümü bu aşkı yarım bırakır. Yıllar sonra Raif Efendi, bu unutulmaz aşkın acısıyla sıradan, sessiz bir hayat sürmeye devam eder. ") ;
                Console.WriteLine();
                Console.WriteLine("Fiyatı: 45 TL");
                Console.WriteLine();
            }
            if(islem == 4)
            {
                Console.WriteLine();
                Console.WriteLine("******************************");
                Console.WriteLine();
                FileStream fs = new FileStream("C:\\Users\\yelda\\OneDrive\\Masaüstü\\kitaplar.txt ", FileMode.Open, FileAccess.Read);  
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin != null)  
                {
                    Console.WriteLine(metin);  
                    metin = sr.ReadLine();
                }   
                sr.Close();
                fs.Close();
                
                Console.WriteLine("******************************");  
                Console.WriteLine();    
            }
            if (islem == 5)
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("***** Yeni Kitap Satın Al *****");
                    Console.WriteLine();
                    Console.Write("Satın Almak İstediğiniz Kitabın Numarasını Giriniz (İşlemi Bitirmek İçin Çıkış Yazınız) : ");
                    Console.WriteLine();
                    secim = Console.ReadLine();

                    if (secim.ToLower() == "çıkış")
                    {
                        Console.WriteLine("Kitap Satın Alma İşleminden Çıkış Yapılıyor...");
                        break;
                    }

                    if (secim == "1")
                    {
                        toplam = toplam + 45;
                    }
                    else if (secim == "2")
                    {
                        toplam = toplam + 35;
                    }
                    else if (secim == "3")
                    {
                        toplam = toplam + 40;
                    }
                    else if (secim == "4")
                    {
                        toplam = toplam + 30;
                    }
                    else if (secim == "5")
                    {
                        toplam = toplam + 25;
                    }
                    else if (secim == "6")
                    {
                        toplam = toplam + 50;
                    }
                    else if (secim == "7")
                    {
                        toplam = toplam + 55;
                    }
                    else if (secim == "8")
                    {
                        toplam = toplam + 60;
                    }
                    else if (secim == "9")
                    {
                        toplam = toplam + 70;
                    }
                    else if (secim == "10")
                    {
                        toplam = toplam + 65;
                    }
                    else if (secim == "11")
                    {
                        toplam = toplam + 80;
                    }
                    else if (secim == "12")
                    {
                        toplam = toplam + 45;
                    }
                    else

                        Console.WriteLine("Geçersiz Kitap Numarası. Lütfen Tekrar Deneyiniz.");
                    Console.WriteLine();
                    Console.Write("Başka Kitap Satın Almak İstiyor Musunuz? (E (EVET) / H (HAYIR): ");
                    string cevap = Console.ReadLine();
                    if (cevap == "H" || cevap == "h" || cevap == "HAYIR" || cevap == "hayır")
                    {
                        Console.WriteLine("Toplam Tutar: " + toplam + " TL");
                        break;
                    }

                }

                }
               
                if (islem == 6)
                {
                    Console.WriteLine();
                    Console.WriteLine("***** Sayı Tahmin Oyununa Hoşgeldiniz! *****");  
                    Console.WriteLine();
                    int tahmin = 0; 
                    Random rastgele = new Random(); 
                    int sayi = rastgele.Next(1, 101);   
                    Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Bakalım bilebilecek misin?");
                    while(sayi != tahmin)
                    {
                        Console.Write("Tahmininiz: ");
                        tahmin = Convert.ToInt32(Console.ReadLine());  
                        if (tahmin < sayi)
                        {
                            Console.WriteLine("Daha yüksek bir sayı giriniz: ");
                        }
                        else if (tahmin > sayi)
                        {
                            Console.WriteLine("Daha düşük bir sayı giriniz: ");
                        }
                        else
                        {
                            Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                        }
                    }   



                }

                if (islem == 7)
                {
                    Console.WriteLine("Uygulamadan Çıkış Yapılıyor... ");
                }



                Console.ReadLine();
            
        }
    }
}
