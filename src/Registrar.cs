using System;
using System.Collections.Generic;
using System.Text;

namespace PreStudentRegister.src
{
    public class Registrar
    {
		private List<Course> List_of_Courses = new List<Course>();

		private List<Student> List_of_Students = new List<Student>();

		private List<Professor> List_of_Professors = new List<Professor>();

		private static Registrar _instance;

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

		public bool AddStudenttoCourse(Student s, Course c)
		{
			try
			{
				if (!List_of_Students.Contains(s))
				{
					List_of_Students.Add(s);
					//Console.WriteLine("Student added");
				}
				c._Roster.Add(s._name,s);
				s._hours_total += c._credit_hours;
				//Console.WriteLine("Added to Roster");
				//code to add student to course
				//add student to list if he/she isnt on list
				//update course function, update roster
				return true;
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.StackTrace);
				return false;

			}
		}

		public void AddProfessortoCourse(Professor p, Course c)
		{

		}


		public void UpdateCourse (Course c)
		{

		}


    }
}
