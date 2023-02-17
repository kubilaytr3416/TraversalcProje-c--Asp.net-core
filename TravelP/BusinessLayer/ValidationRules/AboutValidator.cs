using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class AboutValidator:AbstractValidator<About>
	{
		public AboutValidator() 
		{
			RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Kısmını Boş Geçmeyiniz!!");
			RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Göresel Seçiniz");
			RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen En Az 50 Karakter Açıklama Yazınız");
			RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Lütfen Açıklamayı Kısaltınız");
		}
	}
}
