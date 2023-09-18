using Proje_OPP.Entity;

namespace Proje_OPP.Examples
{
	/*
	 Entity ulaşmak için nesneler oluşturulmalı

	Bunları şu şekilde düşünülebilir entity direk içindeki property ulaşmada ikide bir uzun kod yazamnı 
	engelleyen ara kapman görev yöneticisi gibi düşünülebilir.
	 */

	/*
	 İsimlendirme kuralları Rules of names

	Eğer dışarıdan bir entity alınıyor ise ProductKategory olsun ismi bu productKategory yani ilk harfi küçük olmalı.

	Dikkat eğer dışarıdan alınan nesne veriyi işlemeye yönelik ise;
	ProductManager gibi _productManager olarak belirlenir.

	 */
	public class Class1
	{

		Product _product = new Product();
		
	}
}
