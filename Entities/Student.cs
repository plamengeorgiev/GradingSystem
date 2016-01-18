using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
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
