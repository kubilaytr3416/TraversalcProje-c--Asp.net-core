using System.ComponentModel.DataAnnotations;

namespace TRAVEL.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen Adınızı Giriniz")]
		public string Name { get; set; }


		[Required(ErrorMessage = "Lütfen Soyadınız Giriniz")]
		public string Surname { get; set; }


		[Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Lütfen Kullanıcı Mailinizi  Giriniz")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Lütfen Şifreyi Giriniz")]
		public string Password { get; set; }


		[Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
		[Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil")]	
		public string ConfirmPassword { get; set; }
	}
}
