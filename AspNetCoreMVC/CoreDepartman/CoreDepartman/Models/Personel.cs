using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreDepartman.Models
{
    public class Personel
    {
        [Key]
        public int PerID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }
        public int DepartmanID { get; set; }
        public Departmanlar Departman { get; set; }
    }
}
