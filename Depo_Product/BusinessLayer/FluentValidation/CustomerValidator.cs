﻿using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("MÜŞTERİ ADI BOŞ GEÇİLEMEZ");
            RuleFor(X => X.CustomerCity).NotEmpty().WithMessage("ŞEHİR BİLGİSİ BOŞ GEÇİLEMEZ");
        }
    }
}
