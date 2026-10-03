using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TtcLesson07.Models
{
	public class TtcMember
	{
		public int id { get; set; }

		[DisplayName("Tài khoản")]
		[Required(ErrorMessage = "Tài khoản không được để trống")]
		[StringLength(20, MinimumLength = 3, ErrorMessage = "Tài khoản có độ dài trong khoảng 3-20 ký tự")]
		public string userName { get; set; }

		[DisplayName("Mật khẩu")]
		[StringLength(100,MinimumLength = 8, ErrorMessage = "Mật khẩu tối thiểu 8 ký tự")]
		public string password { get; set; }

		[DisplayName("Email")]
		[Required(ErrorMessage = "Email không được để trống")]
		[RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$^[^@\s]+@[^@\s]+\.[^@\s]+$")]
		public string email { get; set; }

		[DisplayName("Điện thoại")]
		[Required(ErrorMessage = "Điện thoại không được để trống")]
		[RegularExpression(@"^0\d{9,9", ErrorMessage = "Điện thoại phải là 10 ký tự số, bắt đầu bằng 0")]
		public string phone { get; set; }
	}
}
