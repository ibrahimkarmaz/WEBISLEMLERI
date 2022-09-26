using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustemerValidator:AbstractValidator<Customer>
    {
        public CustemerValidator()
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("ŞEHİR BİLGİSİ BOŞ GEÇİLEMEZ");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İSİM BOŞ GEÇİLEMEZ");
        }
    }
}
