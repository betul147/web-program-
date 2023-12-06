
//typ safety - tip güvenliği 
//DO not repeat yourself - Kendini tekrarlama

string katagoriEtiketi = "Katagori";
int ogrenciSayisi = 32000;
double faizOranı = 1.45;
bool sistemeGirisYapmisMi = true;
//üstteki true kısmı veri kaynağından gelir.
//if else durumdan sadece birisi çalışır.

double dolarDun = 7.35;
double dolarBugun = 7.45;

if (dolarDun>dolarBugun) 
{
    Console.WriteLine("Azalış butonu");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artıs butonu");
}
else
{
    Console.WriteLine("değişmedi butonu");
}



if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giris yap butonu");
}

Console.WriteLine(katagoriEtiketi); 
