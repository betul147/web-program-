
// ++ veya i+1 demek bir bir artır demek
// <10 (10 dahil değil) <=10 (10 dahil)


string  kurs1 = "Yetiştirme kampı";
string  kurs2 = "Temel kurs";
string  kurs3 = "Java";
// bu tip veriler dizilerde (array) tutulur.
Console.WriteLine(kurs1);
Console.WriteLine(kurs2);   
Console.WriteLine(kurs3);



string[] kurslar = new string[] { "Yetiştirme kampı", "Temel kurs", "Java" };

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(kurslar[i]);

}
Console.WriteLine("For bitti");

// forreach dizi temelli yapıları tek tek dönmeye yarıyor.

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}
Console.WriteLine("sayfa sonu - footer");