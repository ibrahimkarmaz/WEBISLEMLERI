/*var sayi=10;
var sehir="Ankara";

sayi=11;
sehir="istanbul";

var sehir="Bursa";

console.log(sayi);
console.log(sehir);*/

/*
let il="Ankara";
il="İstanbul";
//let il="sa";//Var ile yaptınız tanımlama tekrar yapılabilir fakat let ile yapılamaz EmmaScriptte engeller.

console.log(il);

function a(){
    console.log("das");
    var abc="yazdir";
    console.log(abc);
}

//console.log(abc);//FONSİYONUN İÇİNDE KULLANILAN VAR DIŞARDA YAZDIRILAMAZ
a();

for(var z=0;z<10;z++)
{

}
//FORDA TANIMLANAN VAR DIŞARDA TANIMLANABİLİR.
console.log(z);

*/

//****************** */
//PEKİ ENGELLEMEK İÇİN NE YAPILACAK ??
//VAR YERİNE LET KOYARAK ENGELLENEBİLİR.
//***************** */
//ÖRNEK

/*for(let Q=0;Q<10;++)
{
}

console.log(Q);*/

//const sabit anlamına gelir.

const Soyad="KARMAZ";
//Soyad="S";//HATA VERİR SABİT OLDUĞU İÇİN

const Sehirler=["ANKARA","İSTANBUL"];//BELLEKTE REFERANS YERİ AYRILIR BU REFERANS BÖLÜMÜNE REFERANSA BAĞLI OLARAK EKLEME GÜNCELLEME VE SİLME İŞLEMLERİ YAPILABİLİR
Sehirler.push("BURSA");
//Sehirler=["SİVAS"];//HATA VERİR ÇÜNKÜ YENİ BİR YER YANI REFERANS TANIMLAMAZ 

console.log(Sehirler);
console.log(Soyad);
//DİKKAT BURADA DEĞER VE REFERANS ARASINDA FARK NET BİLGİ VERİLİR.



