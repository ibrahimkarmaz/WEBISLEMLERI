var kullanicilar = [{
    email: "ibrahimkarmaz@hotmail.com",
    sifre: "12345"
},
{
    email: "mustafakarmaz@hotmail.com",
    sifre: "12345"
}]

var tivitler = [{
    email: "ibrahimkarmaz@hotmail.com",
    tivit: "güzel 1"
},
{
    email: "ibrahimkarmaz@hotmail.com",
    tivit: "güzel 2"
},
{
    email: "mustafakarmaz@hotmail.com",
    tivit: "sakin adam"
}]

var email = prompt("E Mail Adresi:")
var sifre = prompt("Şifre?")


function KullaniciMevcutMu(emailx, sifrex) {
    for (i = 0; i < kullanicilar.length; i++) {
        if (kullanicilar[i].email == emailx && kullanicilar[i].sifre == sifrex) {
            return true;
        }
    }
    return false;
}




function giris() {
    if (KullaniciMevcutMu(email, sifre)) {
        console.log(tivitler)
    }
    else{
        console.log("HATALI")
    }
}
giris()