using CoreDepartman.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CoreDepartman
{
    public class DepartmanPersonelView
    {
        public Personel Personel { get; set; }
        public List<SelectListItem> DepartmanList { get; set; }
    }
}