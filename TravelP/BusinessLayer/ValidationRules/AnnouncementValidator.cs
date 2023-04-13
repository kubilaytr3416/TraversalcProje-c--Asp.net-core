using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTOs>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Başlığı Boş Geçmeyiniz");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen İçeriği Boş Geçmeyiniz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Content).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen En Az 5 Karakter Veri Girişi Yapınız");
   
        }
    }
}
