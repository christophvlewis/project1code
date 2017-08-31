using System;
using System.Collections.Generic;
using System.Text;

namespace PreStudentRegister.src
{
	
	public class Student
	{
		public string _name { get; set; }
		public bool _part_time { get;set;}

		private int _student_hours = 0;
		public int _hours_total 
		{ 
			get
			{
				return _student_hours;
			}
			set
			{
				_student_hours = value;
				if(_student_hours > 12){ _part_time = false;}
				else if(_student_hours <= 12){_part_time = true;}
			}
		}

		private List<Course> _course_list;

		public Student()
		{
			_name = "samplename";
			_hours_total = 0;
			_course_list = new List<Course>();
		}

		public Student(string name)
		{
			_name = name;
			_hours_total = 0;
			_course_list = new List<Course>();
		}

		public Student(string name, int hours_total)
		{
			_name = name;
			_hours_total = hours_total;
			_course_list = new List<Course>();
		}


		// this is a combination of the select and register course
		public bool addtoCourse(Course course_to_add)
		{
			if (_course_list.Contains(course_to_add))
			{
				Console.WriteLine("Student is already registered for {0}", course_to_add.ToString());
				return false;
			}
			else if (_hours_total + course_to_add._credit_hours > 18)
			{
				Console.WriteLine("Student can't register for over 18 credit hours");
				return false;
			}
			else if (course_to_add.isFull())
			{
				Console.WriteLine("This class is already full");
				return false;
			}
			else if (IsCourseOverlap(course_to_add))
			{
				Console.WriteLine("The time of this class overlaps with others.");
				return false;
			}

			Registrar.RegistrarGuy().AddStudenttoCourse(this,course_to_add);
			_course_list.Add(course_to_add);
			_hours_total += course_to_add._credit_hours;

			//if(_hours_total + course_to_add._hours <= && _course_list.contains(course_to_add) &&
			//	_times.contains(course_to_add.time) && course_to_add.notfull)
			//{
				// call Register function in Registrar: pass student and course
				// the Registrar function will add student to class and update course
				// Place Student into registrar list if they try to add course and they arent in system.
				// add course to list for the student.
			//}
			//else
			//{
				// error message 
			//}
			return true;
		}

		public bool removefromCourse(Course course_to_remove)
		{
			return true;
		}

		private bool IsCourseOverlap(Course c)
		{
			foreach (Course c_compare in _course_list)
			{
				if (c_compare._dateandtime.Overlap(c._dateandtime))
				{
					return true;
				}
			}

			return false;
		}

		public string ShowStudentSchedule()
		{
			string temp = "";
			foreach (Course c in _course_list)
			{
				temp = c._dateandtime.ToString() + "\n";
			}
			return temp;
		}
    }
}
