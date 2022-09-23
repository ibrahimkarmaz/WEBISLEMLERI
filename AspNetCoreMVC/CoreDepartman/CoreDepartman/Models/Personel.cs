using System.ComponentModel.DataAnnotations;

namespace CoreDepartman.Models
{
    public class Personel
    {
        [Key]
        public int PerID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }

        public Departmanlar Departman { get; set; }
    }
}
