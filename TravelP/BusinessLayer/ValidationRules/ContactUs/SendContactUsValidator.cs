using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator:AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("MAİL ALANI BOŞ BIRAKILAMAZ");
            RuleFor(x => x.subject).NotEmpty().WithMessage("MAİL ALANI BOŞ BIRAKILAMAZ");
            RuleFor(x => x.Name).NotEmpty().WithMessage("MAİL ALANI BOŞ BIRAKILAMAZ");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("MAİL ALANI BOŞ BIRAKILAMAZ");
            RuleFor(x => x.subject).MinimumLength(5).WithMessage("KONU ALANINA EN AZ 5 KARAKTER VERİ GİRİŞİ  YAPMALISINIZ");
            RuleFor(x => x.subject).MaximumLength(100).WithMessage("KONU ALANINA EN FAZLA 100 KARAKTER VERİ GİRİŞİ");

        }

    }
}
