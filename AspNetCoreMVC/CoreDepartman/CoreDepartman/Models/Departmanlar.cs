using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreDepartman.Models
{
    public class Departmanlar
    {
        [Key]
        public int ID { get; set; }
        public string DepartmanAd { get; set; }

        public List<Personel> personels { get; set; }
    }
}
