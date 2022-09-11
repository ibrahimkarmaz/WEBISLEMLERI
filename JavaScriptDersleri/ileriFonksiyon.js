let selamFonksiyon=function selam()
{
    console.log("Merhaba");
}

selamFonksiyon();


const selamFonksiyon2=() =>{
    console.log("Selam 2");
}
selamFonksiyon2();

const OnuneMerhabaEkle=(isim="")=>{
    return "MERHABA "+isim.toUpperCase();
}

console.log(OnuneMerhabaEkle("ibrahim"));