using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PreStudentRegister.src;
using System.Diagnostics;

namespace PreStudentRegister.test
{
	public class Test
	{
		[Fact]
		public void RegistrarAddStudent()
		{
			Student john = new Student("john");
			int[] days = {1,0,0,0,1,0,0};
			Course English = new Course("English", 3, 20, days, 20, 21);
			bool success = Registrar.RegistrarGuy().AddStudenttoCourse(john,English);
			Assert.True(success);
			//Assert.Equal();
		}

		[Fact]
		public void AddCourseTest()
		{
			int[] days = {0,1,0,1,0,1,0};
			Course English = new Course("English-101", 3, 2, days, 20, 21);
			Course Math = new Course("Math-101", 2, 5, days, 21, 22);
			Student john = new Student("john");
			Student doe = new Student();
			Student alex = new Student("alex");
			Student james = new Student("james",17);


			bool success = john.addtoCourse(English);
			doe.addtoCourse(English);
			Assert.True(success);

			bool fail = doe.addtoCourse(English);
			Assert.False(fail);

			bool fail2 = alex.addtoCourse(English);
			Assert.False(fail2);

			bool fail3 = james.addtoCourse(Math);
			Assert.False(fail3);
		}

		[Fact]
		public void parttime_fulltime()
		{
			int[] days = {0,1,0,1,0,1,0};
			Student james = new Student("james",12);
			Student jane = new Student("jane", 10);
			Student sam = new Student("sam", 16);
			Student bill = new Student("bill", 11);
			Course math = new Course("mathstuff", 3, 20, days, 2,5);
			bill.addtoCourse(math);
			Assert.True(james._part_time);
			Assert.True(jane._part_time);
			Assert.False(sam._part_time);
			Assert.False(bill._part_time);

		}

		[Fact]
		public void RemoveCourseTest()
		{
			
		}

		[Fact]
		public void TimeDOWtest()
		{
			int[] dow = {0,1,0,1,0,0,0};
			int[] dow2 = {1,0,1,0,1,0,0};
			int[] dow3 = {0,0,0,0,1,1,1};
			int[] dow4 = {1,1,3,2,5,6,1,5,8};
			int[] dow5 = {1,5,8,4,2,1};
			TimeDOW time = new TimeDOW(dow,14,15);
			TimeDOW time2 = new TimeDOW(dow2,9,10);
			TimeDOW time3 = new TimeDOW(dow3,20,21);
			TimeDOW time4 = new TimeDOW(dow4,12,13);
			TimeDOW time5 = new TimeDOW(dow5,16,17);
			TimeDOW time6 = new TimeDOW(dow,-1,23);
			TimeDOW time7 = new TimeDOW(dow,4,98);
			TimeDOW time8 = new TimeDOW(dow,52,9);
			TimeDOW time9 = new TimeDOW(dow,4,-9);
			Console.WriteLine(time5.DaysofWeek());
			Assert.Equal(time2.DaysofWeek(),"Monday Wednesday Friday ");
			Assert.Equal(time3.DaysofWeek(),"Friday Saturday Sunday ");
			Assert.Equal(time.DaysofWeek(),"Tuesday Thursday ");
			Assert.Equal(time6._time_start,0);
			Assert.Equal(time7._time_end,0); 
			Assert.Equal(time8._time_start,0);
			Assert.Equal(time9._time_end,0);

			Console.WriteLine(time2);
			Console.WriteLine(time3);
			Console.WriteLine(time7);
		}

		[Fact]
		public void OverlapFunction()
		{
			int[] dow = { 0, 1, 0, 1, 0, 1, 0 };
			int[] dow2 = { 0, 0, 0, 0, 0, 1, 0 };
			int[] dow3 = { 0, 0, 1, 0, 1, 0, 0 };

			TimeDOW time1 = new TimeDOW(dow, 9, 10);
			TimeDOW time12 = new TimeDOW(dow, 9, 11);
			TimeDOW time13 = new TimeDOW(dow, 7, 10);
			TimeDOW time2 = new TimeDOW(dow2, 10, 12);
			TimeDOW time21 = new TimeDOW(dow2, 14, 15);
			TimeDOW time3 = new TimeDOW(dow3, 9, 10);

			Assert.True(time1.Overlap(time12));
			Assert.True(time1.Overlap(time12));
			Assert.True(time1.Overlap(time13));
			Assert.True(time1.Overlap(time2));
			Assert.False(time1.Overlap(time21));
			Assert.False(time1.Overlap(time3));
		}



		[Fact]
		public void TimeDOWintegrationTest()
		{
			int[] dow = { 0, 1, 0, 1, 0, 1, 0 };
			int[] dow1 = { 1, 0, 1, 0, 1, 0, 0 };
			TimeDOW time = new TimeDOW(dow, 9, 10);
			TimeDOW time1 = new TimeDOW(dow1, 10, 11);
			Course English = new Course("English-101", 3, 40, time);
			Course English1 = new Course("English-101", 3, 20, time1);
			Course Math = new Course("Math-101", 3, 10, time);
			Course Math1 = new Course("Math-101", 3, 10, time1);

			Student matt = new Student("matt");
			Assert.True(matt.addtoCourse(English));
			Assert.False(matt.addtoCourse(Math));
			Assert.True(matt.addtoCourse(Math1));
			Assert.False(matt.addtoCourse(English1));

		}

		[Fact]
		public void ShowStudentScheduleTest()
		{
			int[] dow = { 0, 1, 0, 1, 0, 1, 0 };
			int[] dow1 = { 1, 0, 1, 0, 1, 0, 0 };
			TimeDOW time = new TimeDOW(dow, 9, 10);
			TimeDOW time1 = new TimeDOW(dow1, 10, 11);
			TimeDOW time2 = new TimeDOW(dow, 3, 4);
			TimeDOW time3 = new TimeDOW(dow, 12, 1);
			TimeDOW time4 = new TimeDOW(dow1, 15, 18);
			Course English = new Course("English-101", 3, 40, time);
			Course English1 = new Course("English-101", 3, 20, time1);
			Course Math = new Course("Math-101", 3, 10, time);
			Course Math1 = new Course("Math-101", 3, 10, time1);
			Course PE = new Course("Physical Education", 3, 5, time2);
			Course Science = new Course("Science Stuff", 3, 14, time3);
			Course History = new Course("History", 3, 15, time4);

			Student matt = new Student("matt");
			Assert.True(matt.addtoCourse(English));
			Assert.False(matt.addtoCourse(Math));
			Assert.True(matt.addtoCourse(Math1));
			Assert.False(matt.addtoCourse(English1));
			Assert.True(matt.addtoCourse(PE));
			Assert.True(matt.addtoCourse(Science));
			Assert.True(matt.addtoCourse(History));

			Trace.Write(matt.ShowStudentSchedule());

		}
    }
}
