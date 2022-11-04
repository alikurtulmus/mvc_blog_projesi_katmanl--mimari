using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactMail).NotEmpty().WithMessage("Maili boş geçemezsin");
            RuleFor(x => x.ContactName).NotEmpty().WithMessage("Ad kısmını boş geçemezsin");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsin");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj bölümünü boş geçemezsin");

        }
    }
}
