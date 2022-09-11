//Classların Kelimelerin Baş Harfı Büyük Olmalı
class Personel{

    constructor(ad,soyad){
        this.adi=ad;
        this.soyadi=soyad;
    }

    Kaydet(){
     console.log("YENİ KAYIT BAŞARILI "+this.adi);   
    }
}

let PersonelProcess= new Personel("İbrahim","KARMAZ");
console.log(PersonelProcess.Kaydet());
console.log(PersonelProcess.adi);
console.log(PersonelProcess.soyadi);