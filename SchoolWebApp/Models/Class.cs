using System;

namespace SchoolWebApp.Models
{
	public class Class
	{
		public int classid { get; set; }
		public string classcode { get; set; }
		public long teacherid { get; set; }
		public DateTime startdate { get; set; }
		public DateTime finishdate { get; set; }
		public string classname { get; set; }

		public Class(int classid, string classcode, long teacherid, DateTime startdate, DateTime finishdate, string classname)
		{
			this.classid = classid;
			this.classcode = classcode;
			this.teacherid = teacherid;
			this.startdate = startdate;
			this.finishdate = finishdate;
			this.classname = classname;
		}
	}
}
