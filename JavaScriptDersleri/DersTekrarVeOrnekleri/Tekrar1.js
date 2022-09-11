//Girilen sayı çift ise yarısını , tek ise 2 katını alarak ekrana yazdıran program.
/*var Sayi=prompt("Sayı Giriniz:");

if(Sayi%2==0){
    console.log("Sayının Yarısı:"+(Sayi/2))
}
else{
    console.log("Sayının Yarısı:",(Sayi*2))
}*/

//C# Console Uygulamasında Kullanıcıdan 2 tane sayı istenerek 1. sayının 2. sayıya tam bölünmesi durumunda 
//“Tam bölünüyor” yazan, aksi durumda Tam bölünmüyor diyerek kalanı ekranda gösteren örnek
/*
var s1,s2;
s1=prompt("SAYI 1:");
s2=prompt("SAYI 1:");
if((s1%s2)==0){
    console.log("TAM BÖLÜNÜYOR");
}
else{
    console.log("TAM BÖLÜNMÜYOR");
}*/

//Klavyeden girilen bir sayının seçime bağlı olarak karesini, küpünü ve karekökünü alan programı yazınız.
/*var sayi = prompt("SAYI GİRİNİZ:");
var secim = prompt("1-KARE\n2-KÜP\n3-KAREKÖK\n\nSEÇİM[1-3]:");

switch (secim) {
    case "1":
        console.log(Math.pow(sayi,2));
        break;

    case "2":
        console.log(Math.pow(sayi,3));
        break;

    case "3":
        console.log(Math.sqrt(sayi));
        break;

    default:
        break;
}*/

//Örnek: 1’den 10’a kadar sayıları ekrana yazdıran örneği while döngüsü kullanarak yapınız.
/*
var sayac=1;
while(sayac<=10){
    console.log(sayac);
    sayac++;
}*/

///Örnek: Klavyeden girilen sayı 0 (Sıfır) olana kadar, girilen sayılardan çift sayıları toplayan,tek sayıları
//çıkaran ve sonucu ekranda gösteren programı yapınız.
/*var girilenSayi=0,ciftSayilarTopla=0,TekSayilariCikar=0;
do{
    girilenSayi=Number(prompt("SAYI GİRİNİZ:"));
    if(girilenSayi%2==0)
        ciftSayilarTopla+=girilenSayi;
    else
        TekSayilariCikar-=girilenSayi;

}while(girilenSayi!=0)

console.log("ÇİFT SAYILARIN TOPLAMI:"+ciftSayilarTopla.toString());
console.log("TEK SAYILARIN ÇIKARMA:"+TekSayilariCikar.toString());
*/

//Örnek: Sayı 0 olduğunda döngünün bitirme :

/*while(true)
{
    var sayi=Number(prompt("SAYI GİRİNİZ:"));
    if(sayi==0)
        break;
}*/
/*
var Sehir=["Adana","Ankara","Çorum","İstanbul"];

Sehir.forEach(function x(a){
    console.log(a)
});

Sehir.push("Ordu");

console.log("-----------------");
Sehir.forEach(function x(a){
    console.log(a)
});

console.log(Sehir.pop());

Sehir.forEach(function x(a){
    console.log(a)
});

var sehir2=["Yalova"]
var birlestir=Sehir.concat(sehir2);
console.log(birlestir)

Sehir.sort().forEach(function yazdir(sehirsirali)
{
    console.log(sehirsirali)
});

Sehir.reverse().forEach(function yazdir(sehirsirali)
{
    console.log(sehirsirali)
});
*/


/*var kisi={
    'Ad':"İBRAHİM",
    'Soyad':"KARMAZ",
    'Telefon':"441515616",
    'Yas':26
}
console.log(kisi.Ad)
*/
/*
var Sehir=["Adana","Ankara","Çorum","İstanbul"];

console.log(Sehir.indexOf("Adana"))
console.log(Sehir.slice(0,2))

var a="ibrahim karmaz";
console.log(a.substring(0,5))
console.log("Merhaba ${a}")
*/
/*
console.log(Math.max(1,2,3))
console.log(Math.min(1,2,3))

var a=new Date();
console.log(a);
a=new Date(2025,30,2)
console.log(a);
*/


//SAYI TAHMİN OYUNU)

class SayiTahminOyunu {
    constructor(firstBetween, EndBetween, Prediction) {
        this.firstBetweenx = firstBetween;
        this.EndBetweenx = EndBetween;
        this.Predictionx = Prediction;
    }
    RandomNumber() {
        this.RamdomSelection = Math.round((Math.random() * (this.EndBetweenx - this.firstBetweenx)) + this.firstBetweenx);
    }
}


class STO extends SayiTahminOyunu {
    DoPrediction(Number) {
        this.Predictionx--;
        console.log(this.Predictionx);
        if (this.Predictionx > 0) {
            console.log(this.RamdomSelection)
            if (this.RamdomSelection == Number) {
                console.log('TEBRİKLER DOĞRU SAYI')
                return false;
            }
            else if (this.RamdomSelection > Number) {
                console.log("YUKARI TAHMİN ET")
            }
            else if (this.RamdomSelection < Number) {
                console.log("ASAĞIYA TAHMİN ET")
            }
        }
        else {
            console.log("TAHMİN HAKKINIZ BİTMİŞTİR.")
            return false;
        }

    }
}

var TahminEt = new STO(5, 10, 3);
TahminEt.RandomNumber();
var Durum = true;
while (Durum) {
    if (TahminEt.DoPrediction(prompt("Tahmin Et:") == false)) {
        console.log("a")
        Durum = false;
    }
}




