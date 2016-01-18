using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public class Student
    {
        public Student()
        {
			this.Courses = new List<Course>();
        }

		public string FirstName { get; set; }

		public string MiddleName { get; set; }

		public string LastName { get; set; }

		public string FacultyNumber { get; set; }

		public virtual List<Course> Courses { get; set; }

	}
}
