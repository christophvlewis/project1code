using System;
using System.Collections.Generic;
using System.Text;

namespace PreStudentRegister.src
{
    public class Course
    {
		public Dictionary<string,Student> _Roster;
		public String _Course_Name;
		public int _credit_hours;
		private int _max_roster_size;
		public Course(String Course_Name, int max_roster_size)
		{
			_Course_Name = Course_Name;
			_Roster = new Dictionary<string, Student>();
			_credit_hours = 3;
			_max_roster_size = max_roster_size;
		}

		public Course(String Course_Name, int credit_hours, int max_roster_size)
		{
			_Course_Name = Course_Name;
			_Roster = new Dictionary<string,Student>();
			_credit_hours = credit_hours; 
			_max_roster_size = max_roster_size;
		}

		public bool isFull()
		{
			if( _Roster.Count >= _max_roster_size )
			{
				return true;
			}
			return false;
		}

		public override string ToString()
		{
			return _Course_Name;
		}

    }
}
