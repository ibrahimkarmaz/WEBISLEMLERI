using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("ÜRÜN ADI BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("ÜRÜN ADI EN AZ 3 KARAKTER OLMALIDIR.");

            RuleFor(y => y.Stock).NotEmpty().WithMessage("STOK SAYISI BOŞ GEÇİLEMEZ");
            RuleFor(y => y.Price).NotEmpty().WithMessage("FİYAT BOŞ GEÇİLEMEZ");
        }
    }
}
