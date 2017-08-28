using System;
using System.Collections.Generic;
using System.Text;

namespace PreStudentRegister.src
{

	public class Student
	{
		public string _name { get; set; }

		public Student()
		{
			_name = "samplename";
		}

		public Student(string name)
		{
			_name = name;
		}

		public bool addtoCourse(Course course_to_add)
		{
			return true;
		}

		public bool removefromCourse(Course course_to_remove)
		{
			return true;
		}
    }
}
