using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PreStudentRegister.src;

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
		public void TimeDOWintegrationTest()
		{
			
		}

    }
}
