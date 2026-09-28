using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TtcLab05.Models
{
	public class TtcAccount
	{
		[Key]
		public int id { get; set; }

		[
			Display(Name = "Họ và tên"),
			Required(ErrorMessage = "Họ không được để trống"),
			MinLength(6, ErrorMessage = "Họ tên ít nhất là 6 ký tự"),
			MaxLength(20, ErrorMessage = "Họ tên tối đa 20 ký tự")
		]
		public string fullName { get; set; }

		[
			Display(Name = "Địa chỉ email"),
			Required(ErrorMessage = "Địa chỉ email không được để trống"),
			EmailAddress(ErrorMessage = "Địa chỉ email không đúng định dạng"),
			DataType(DataType.EmailAddress)
		]
		public string email { get; set; }

		[
			Display(Name = "Số điện thoại"),
			DataType(DataType.PhoneNumber),
			Remote(action: "TtcVerifyPhone", controller: "TtcAccount"),
			Required(ErrorMessage = "Số điện thoại không được để trống")
		]
		public string phone { get; set; }

		[
			Display(Name = "Địa chỉ thường trú"),
			Required(ErrorMessage = "Địa chỉ không được để trống"),
			StringLength(35, ErrorMessage = "Địa chỉ không vượt quá 35 ký tự")
		]
		public string address { get; set; }

		[Display(Name = "Ảnh đại diện")]
		public string avatar { get; set; }

		[
			Display(Name = "Ngày sinh"),
			Required(ErrorMessage = "Ngày sinh không được để trống"),
			DataType(DataType.Date)
		]
		public DateTime birthday { get; set; }

		[Display(Name = "Giới tính")]
		public string gender { get; set; }

		[
			Display(Name = "Mật khẩu"),
			DataType(DataType.Password)
		]
		public string password { get; set; }

		[
			Display(Name = "Link Facebook cá nhân"),
			Required(ErrorMessage = "Linh Facebook không được để trống"),
			Url(ErrorMessage = "Url phải đúng định dạng")
		]
		public string facebook { get; set; }
	}
}
