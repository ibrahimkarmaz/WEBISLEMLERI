const dizi=[1,2,3,4];

const kareDizisi=[]

dizi.forEach(sayi=>{
    kareDizisi.push(sayi*sayi);
});

console.log(kareDizisi);

//map ?
//Her sayiyi 3 ile çarpıp mapDiziye ekliyoruz.
const mapDizi = dizi.map(sayilar=>sayilar*3);
console.log(mapDizi);


//filter ?

const filterliDizi=dizi.filter(sayi=>sayi>2);
console.log(filterliDizi);

//reduce ?

const toplam=dizi.reduce((acc,sayi)=>{
    return acc+sayi;
},10);
console.log(toplam);


