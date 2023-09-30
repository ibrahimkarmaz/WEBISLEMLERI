using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class JobValidator:AbstractValidator<Job>
    {
        public JobValidator()
        {
            RuleFor(x => x.JobName).NotEmpty().WithMessage("İŞ ADI BOŞ GEÇİLEMEZ.");
            RuleFor(x => x.JobName).MinimumLength(2).WithMessage("İŞ ADI EN AZ 2 KARAKTER İÇERMELİ.");
        }
    }
}
