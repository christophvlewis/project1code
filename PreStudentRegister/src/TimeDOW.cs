using System;

namespace PreStudentRegister.src
{
    public class TimeDOW
    {
        public int[] _days_of_week;
        public int _time_start {get;set;}

        public int _time_end {get;set;}

        public TimeDOW(int[] days_of_week, int time_start,  int time_end)
        {
            try
            {
                _days_of_week = days_of_week;
                if( time_start > 24 || time_start < 0 || time_end > 24 || time_end < 0)
                {
                    Console.WriteLine("Time of Course is invalid. Please update the time of Course");
                    _time_start = 0;
                    _time_end = 0;
                } 
                else
                {
                    _time_start = time_start;
                    _time_end = time_end;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string DaysofWeek()
        {   try
            {
                string returning = "";
                for(int i = 0; i < 7; i++)
                {
                    if(_days_of_week[i] > 0)
                    {
                        returning += NumtoDay(i) + " ";
                    }
                }
                return returning;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Error: Please update the Course Date and Time.";
            }
        }

        private string NumtoDay(int day)
        {
            switch(day)
            {
                case 0:
                    return "Monday";
                case 1:
                    return "Tuesday";
                case 2: 
                    return "Wednesday";
                case 3: 
                    return "Thursday";
                case 4:
                    return "Friday";
                case 5: 
                    return "Saturday";
                case 6:
                    return "Sunday";
                default:
                    return "ERROR!!!@&^$&$@&";
            }
        }

        public override string ToString()
        {
            return DaysofWeek() + _time_start + ":00 - " + _time_end + ":00";
        }

		public bool Overlap(TimeDOW other)
		{
			for (int i = _time_start; i <= _time_end; i++)
			{
				if (i >= other._time_start && i <= other._time_end)
				{
					for (int j = 0; j < 7; j++)
					{
						if (other._days_of_week[j] > 0 && _days_of_week[j] > 0)
						{
							return true;
						}
					}
				}
			}
			return false;
		}
	}
}