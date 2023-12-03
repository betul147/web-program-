başlık='İlginizi çekebilir!!!' #string
vade=48 #integer
faizOrani=1.69 #float

print('Başlık : ' + başlık) 
print(vade + vade)
print(faizOrani)

print(type(faizOrani))
print(type(vade))
print(type(başlık))

#type = veri tipi
#operator

dolarDun = 7.35
dolarBugun = 7.35

#if else elif= şart 
#indentation= kendiliğinden boşluk brakması
#syntax=her prolamlama dilinin yazımı farklıdır
#true/false

if dolarDun>dolarBugun:
    print("Azalık oku")

if dolarDun<dolarBugun:
    print("Artış oku")

if dolarDun>dolarBugun:
    print("Azalış oku")
elif dolarDun<dolarBugun:
    print("Artış oku")
else:
    print("Değişmedi oku")



kredi1 = "Hızlı kredi"
kredi2 = "Maaşını Halkbanktan..."
kredi3 = "Mutlu emekli"

print(kredi1)
print(kredi2)
print(kredi3)

krediler = ["Hızlı Kredi","Maaşını Halkbanktan...","Mutlu emekli"]

for kredi in krediler:
    print(kredi)


def kredilerilistele():
    krediler = ["Hızlı Kredi","Maaşını Halkbanktan...","Mutlu emekli"]
for kredi in krediler:
    print(kredi)


kredilerilistele()
kredilerilistele()
kredilerilistele()
kredilerilistele()
kredilerilistele()
