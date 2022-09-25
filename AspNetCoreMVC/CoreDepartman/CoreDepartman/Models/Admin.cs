using System.ComponentModel.DataAnnotations.Schema;

namespace CoreDepartman.Models
{
	public class Admin
	{
		public int ID { get; set; }
		[Column(TypeName ="Varchar(20)")]
		public string KullaniciAdi{ get; set; }
		public string Parola{ get; set; }
	}
}
