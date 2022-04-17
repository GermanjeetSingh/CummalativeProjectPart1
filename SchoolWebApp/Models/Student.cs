using System;

namespace SchoolWebApp.Models
{
	public class Student
	{
		public int studentid { get; set; }
		public string studentfname { get; set; }
		public string studentlname { get; set; }
		public string studentnumber { get; set; }
		public DateTime enroldate { get; set; }

		public Student(int studentid, string studentfname, string studentlname, string studentnumber, DateTime enroldate)
		{
			this.studentid = studentid;
			this.studentfname = studentfname;
			this.studentlname = studentlname;
			this.studentnumber = studentnumber;
			this.enroldate = enroldate;
		}
	}
}
