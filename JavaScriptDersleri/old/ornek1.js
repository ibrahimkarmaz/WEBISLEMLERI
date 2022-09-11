var kullanicilar=[{
    email:"ibrahimkarmaz@hotmail.com",
    sifre:"12345"
},
{
    email:"mustafakarmaz@hotmail.com",
    sifre:"12345"
}]

var tivitler=[{
    email:"ibrahimkarmaz@hotmail.com",
    tivit:"güzel 1"
},
{
    email:"ibrahimkarmaz@hotmail.com",
    tivit:"güzel 2"
},
{
    email:"mustafakarmaz@hotmail.com",
    tivit:"sakin adam"
}]

var email= prompt("E Mail Adresi:")
var sifre=prompt("Şifre?")

function giris(){
    if((email==kullanicilar[0].email && sifre==kullanicilar[0].sifre) || ((email==kullanicilar[1].email && sifre==kullanicilar[1].sifre)))
    {
        console.log(tivitler)
    }
    else{
        console.log("KULLANICI ADI VEYA ŞİFRE HATALIDIR.")
    }
}
giris()