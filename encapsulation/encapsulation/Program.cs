using System;

public class Araba
{
    
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    
    private int _kapiSayisi; 

    
    public int KapiSayisi
    {
        get { return _kapiSayisi; }
        set
        {
            if (value == 2 || value == 4)
            {
                _kapiSayisi = value;
            }
            else
            {
                Console.WriteLine("Geçersiz kapı sayısı! Kapı sayısı yalnızca 2 veya 4 olabilir.");
                _kapiSayisi = -1; 
            }
        }
    }

   
    public Araba(string marka, string model, string renk, int kapiSayisi)
    {
        Marka = marka;
        Model = model;
        Renk = renk;
        KapiSayisi = kapiSayisi; 
    }
}

class Program
{
    static void Main()
    {
        // Geçerli kapı sayısı ile bir araba nesnesi
        Araba araba1 = new Araba("Toyota", "Corolla", "Beyaz", 4);
        Console.WriteLine($"{araba1.Marka} {araba1.Model} - Kapı Sayısı: {araba1.KapiSayisi}");

        // Geçersiz kapı sayısı ile bir araba nesnesi
        Araba araba2 = new Araba("Ford", "Fiesta", "Kırmızı", 3);
        Console.WriteLine($"{araba2.Marka} {araba2.Model} - Kapı Sayısı: {araba2.KapiSayisi}");
    }
}