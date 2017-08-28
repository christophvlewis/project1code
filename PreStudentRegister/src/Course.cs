using System;
using System.Collections.Generic;
using System.Text;

namespace PreStudentRegister.src
{
    public class Course
    {
		private Dictionary<string,Student> Roster;
		String Course_Name;

		public Course(String Course_Name)
		{
			this.Course_Name = Course_Name;
			Roster = new Dictionary<string, Student>();
		}

    }
}
