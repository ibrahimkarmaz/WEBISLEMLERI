using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidatonRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("KATEGORİ ADINI BOŞ GEÇİLEMEZ.")
                .MaximumLength(50).WithMessage("KATEGORİ ADI EN FAZLA 50 KARAKTERLİ OLMALIDIR.")
                .MinimumLength(2).WithMessage("KATEGORİ ADI EN AZ 2 KARAKTERLİ OLMALIDIR.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("KATEGORİ AÇIKALAMASI BOŞ GEÇİLEMEZ.");
        }
    }
}
