using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator:AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("lÜTFEN REHBER ADINI GİRİNİZ");
            RuleFor(x => x.Description).NotEmpty().WithMessage("LÜTFEN REHBER AÇIKLMASINI GİRİNİZ");
            RuleFor(x => x.Image).NotEmpty().WithMessage("lÜTFEN REHBER GÖRSELİNİ GİRİNİZ");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("LÜTFEN 30 KARAKTERDEN DAHA KISA BİR İSİM GİRİNİZ");
            RuleFor(x => x.Name).MinimumLength(8).WithMessage("LÜTFEN 8 KARAKTERDEN DAHA UZUN BİR İSİM GİRİNİZ");


        }
    }
}
