// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Eğitmen = "Engin";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Eğitmen = "Zeynep";
kurs2.IzlenmeOrani = 64;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Eğitmen = "Ayşe";
kurs3.IzlenmeOrani = 80;

//Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Eğitmen);

Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + ":" + kurs1.Eğitmen );
}


class Kurs
{
    public string KursAdi { get; set; }
    public string Eğitmen { get; set; }
    public int IzlenmeOrani { get; set; }



}