using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolWebApp.Models
{
	public class Teacher
	{
		public int teacherid { get; set; }
		public string teacherfname { get; set; }
		public string teacherlname { get; set; }
		public string employeenumber { get; set; }
		public DateTime hiredate { get; set; }
		public decimal salary { get; set; }

		public Teacher(int teacherid, string teacherfname, string teacherlname, string employeenumber, DateTime hiredate, decimal salary)
		{
			this.teacherid = teacherid;
			this.teacherfname = teacherfname;
			this.teacherlname = teacherlname;
			this.employeenumber = employeenumber;
			this.hiredate = hiredate;
			this.salary = salary;
		}
	}
}
