using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidatonRules
{
	public class WriterValidator:AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("YAZAR ADI SOYADI KISMI BOŞ GEÇİLEMEZ...")
				.MinimumLength(2).WithMessage("EN AZ 2 KARAKTER OLMALI")
				.MaximumLength(50).WithMessage("EN FAZLA 50 KARAKTER OLMALI");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("MAİL ADRESİ BOŞ GEÇİLEMEZ...");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("PAROLA BOŞ GEÇİLEMEZ...")
                .MinimumLength(8).WithMessage("PAROLA 8 KARAKTERDEN KÜÇÜK OLAMAZ...")
                .MaximumLength(16).WithMessage("PAROLA 16 KARAKTERDEN BÜYÜK OLAMAZ...")
                .Matches(@"[A-Z]+").WithMessage("Şifrede en az bir büyük harf olmalıdır.")
                .Matches(@"[a-z]+").WithMessage("Şifrede en az bir küçük harf olmalıdır.")
                .Matches(@"[0-9]+").WithMessage("Şifrede en az bir rakam olmalıdır");
        }
	}
}
