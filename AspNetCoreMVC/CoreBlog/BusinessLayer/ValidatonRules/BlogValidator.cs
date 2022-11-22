using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidatonRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("BAŞLIK BOŞ GEÇİLEMEZ.")
                .MinimumLength(5).WithMessage("BAŞLIK 5 KARAKTERDEN AZ OLAMAZ.")
                .MaximumLength(150).WithMessage("BAŞLIK 150 KARAKTERDEN FAZLA OLAMAZ.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("BLOG İÇERİĞİNİ BOŞ GEÇİLEMEZ.")
             .MinimumLength(5).WithMessage("BLOG İÇERİĞİ 5 KARAKTERDEN AZ OLAMAZ.")
                .MaximumLength(1000).WithMessage("BLOG İÇERİĞİ 1000 KARAKTERDEN FAZLA OLAMAZ.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("BLOG GÖRSELİNİ BOŞ GEÇİLEMEZ.");
        }
    }
}
