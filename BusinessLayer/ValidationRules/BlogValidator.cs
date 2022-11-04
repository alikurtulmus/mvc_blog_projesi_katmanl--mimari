using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogName).NotEmpty().WithMessage("Blog adını boş geçemezsiniz.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş geçemezsiniz.");
            RuleFor(x => x.BlogName).MinimumLength(2).WithMessage("Lütfen en az 2 karakterlik blog adı belirleyiniz.");
            RuleFor(x => x.BlogName).MaximumLength(50).WithMessage("Lütfen en fazla 100 karakterlik blog adı belirleyiniz.");
            RuleFor(x => x.BlogContent).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik blog içeriği giriiniz.");
        }
    }
}
