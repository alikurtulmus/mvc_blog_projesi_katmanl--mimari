using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz.");
            RuleFor(x => x.AuthorJob).NotEmpty().WithMessage("Yazarın mesleğini boş geçemezsiniz.");
            RuleFor(x => x.AuthorImage).NotEmpty().WithMessage("Resim linkimi boş geçemezsiniz.");
            RuleFor(x => x.AuthorAbout).NotEmpty().WithMessage("Hakkında kısmını boş geçemezsiniz.");
            RuleFor(x => x.AboutShort).NotEmpty().WithMessage("Yazara ait özet bilgileri boş geçemezsiniz.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Yazara ait maili boş geçemezsiniz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Yazara ait şifreyi boş geçemezsiniz.");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Yazara ait telefon bilgilerini boş geçemezsiniz.");
        }
    }
}
