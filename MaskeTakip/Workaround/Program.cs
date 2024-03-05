// See https://aka.ms/new-console-template for more information

//string mesaj = "selam";
//double tutar = 10000;
//int sayi = 100;
//bool girisYapmisMİ=false;

//string ad = "Arife";
//string soyad = "Kıldacı";
//int dogumYili = 2002;
//long tcNo = 12345678910;

//Console.WriteLine(mesaj);

//Console.WriteLine(tutar*1.18);

//Console.WriteLine(mesaj);

using Business.Concrete;
using Entities.Concrete;

Vatandas vatandas1 = new Vatandas();

SelamVer(isim:"arife");
SelamVer(isim:"aslı");
SelamVer(isim:"nil");
SelamVer();

int sonuc = Topla(3,5);

//Arrays
string[] ogrenciler = new string[3];
ogrenciler[0] ="Arife";
ogrenciler[1] = "Aslı";
ogrenciler[2] = "Nil";
ogrenciler = new string[4];
ogrenciler[3] = "Arzu";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}


Person person1 = new Person();
person1.FirstName = "Arife";
person1.LastName = "KILDACI";
person1.DateOfBirthYear = 20002;
person1.NationalIdentity =123;

Person person2 = new Person();
person2.FirstName = "aslı";

foreach (string sehir in ogrenciler)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string>{ "Ankara", "İstanbul", "İzmir" };
yeniSehirler1.Add(item:"izmir");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

PttManager pttManager= new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();

//resharper
static void SelamVer(string isim="isimsiz")
{
    Console.WriteLine("merhaba "+ isim);
}

static int Topla(int sayi1=1, int sayi2=5)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam "+ sonuc.ToString());
    return sonuc ;
}

class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}