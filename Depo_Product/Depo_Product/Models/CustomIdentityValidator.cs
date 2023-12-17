using Microsoft.AspNetCore.Identity;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Depo_Product.Models
{/*BURADA Identity AIT ERROR AÇIKLAMALARI ÜZERİNDE DEĞİŞİKLİK YAPILMASINI SAĞLAR.
  
  NOT:SERVİSİ EKLEMEYİ UNUTMA.
    */
    public class CustomIdentityValidator:IdentityErrorDescriber //İngilizce Identity için yazılan hatalarin listesi
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = "Parola En az 6 karakter olmalı"
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola en az 1 büyük karakter içermeli."
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola en az 1 küçük karakter içermeli."
            };
        }
    }
}
