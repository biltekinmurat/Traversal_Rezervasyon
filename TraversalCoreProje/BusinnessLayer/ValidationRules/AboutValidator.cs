using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Açıklama alanı en az 3 karakter olmalıdır");
            RuleFor(x => x.Description).MaximumLength(800).WithMessage("Açıklama alanı en az 3 karakter olmalıdır");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Resim alanı boş geçilemez");
        }
    }
}
