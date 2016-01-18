using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public class Course
    {
		public Course()
		{
			this.Students = new List<Student>();
		}
		public string Name { get; set; }

		public string Signature { get; set; }

		public virtual List<Student> Students { get; set; }
	}
}
