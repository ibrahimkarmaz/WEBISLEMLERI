//document.getElementById("bio").innerHTML="İBRAHİM KARMAZ";
/*var intro1=document.getElementById("intro1");


var mesaj=document.getElementById("mesaj");


mesaj.innerHTML=intro1.innerHTML;


var TumListeler=document.getElementsByTagName ("ul");
var sehirler=TumListeler[0];

tumElemanlar=sehirler.getElementsByTagName("li");

for(i=0;i<tumElemanlar.length;i++)
{
    alert(tumElemanlar[i].innerHTML); 
}*/

/*
var classElemanlari=document.getElementsByClassName("intro1");

alert(classElemanlari[0].innerHTML);
*/

/*
var queryElemenlari=document.querySelectorAll("p.intro1");
alert(queryElemenlari.length);
*/
/*
var NameElementlari=document.getElementsByName("MusteriAdi");
alert(NameElementlari[0].value);*/


/*var idElemani=document.getElementById("hasan").addEventListener("click",RengiDegistir);

function RengiDegistir(){
    document.getElementById("div1").style.color="red";
    var NameElementlari=document.getElementsByName("MusteriAdi");
    NameElementlari[0].value="ESRA";
}*/
/*
var node=document.getElementById("agac");

console.log(node.childNodes[0].nodeValue);
*/

var baslik=document.createElement("h2");
var node=document.createTextNode("Merhaba JS");

baslik.appendChild(node);


var div1=document.getElementById("div1");
var p2=document.getElementById("p2");
alert("EKLENİYOR...");
div1.insertBefore(baslik,p2);

alert("SİLİNİYOR...");
div1.removeChild(p2);

var p1=document.getElementById("p1");

div1.replaceChild(baslik,p1);

