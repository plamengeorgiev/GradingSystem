using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Enumerations;

namespace DAL
{
    public class Group
    {
		public Course Course { get; set; }

		public GroupNumbers GroupNumber { get; set; }
	}
}
