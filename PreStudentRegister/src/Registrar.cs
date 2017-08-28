using System;
using System.Collections.Generic;
using System.Text;

namespace PreStudentRegister.src
{
    public class Registrar
    {
		private List<Course> List_of_Courses = new List<Course>();

		private static Registrar _instance;

		public delegate Student ConditionS();

		public delegate Course ConditionC();

		private Registrar()
		{
		}

		public static Registrar RegistrarGuy()
		{
			if (_instance == null)
			{
				_instance = new Registrar();
			}
			return _instance;

		}

		public bool AddStudenttoCourse(ConditionS student_can_register, ConditionC no_course_conflicts)
		{
			if (student_can_register() != null && no_course_conflicts() != null)
			{
				//add student to course
				//course will need to update its roster
				Console.WriteLine("Registration Success!");
				return true;
			}
			else
			{
				Console.WriteLine("Registration Failed.");
				return false;
			}
		}




    }
}
