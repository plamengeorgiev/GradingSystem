using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Enumerations;

namespace Entities
{
    public class Group
    {
		public Course Course { get; set; }

		public GroupNumbers GroupNumber { get; set; }
	}
}
