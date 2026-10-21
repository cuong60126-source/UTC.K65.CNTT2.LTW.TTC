namespace TtcLesson10_Lab1.Models
{
	public class Student
	{
		public int id { get; set; }
		public string? name { get; set; }
		public string? email {  get; set; }
		public string? password {  get; set; }
		public Branch? branch { get; set; }
		public Gender? gender {  set; get; }
		public bool isRegular {  get; set; }
		public string? address {  get; set; }
		public DateTime dateofbirth {  get; set; }
	}
}
