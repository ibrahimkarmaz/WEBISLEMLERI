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
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("ÜRÜN ADINI BOŞ GEÇİLEMEZ");
            RuleFor(x => x.ProductName).MinimumLength(3).WithMessage("ÜRÜN ADINI EN AZ 3 KARAKTER OLMALI");
            RuleFor(x => x.ProductStock).NotEmpty().WithMessage("STOK SAYISI BOŞ GEÇİLEMEZ");
            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("FİYAT BOŞ GEÇİLEMEZ");
        }
    }
}
