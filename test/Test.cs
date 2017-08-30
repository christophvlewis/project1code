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
			Course English = new Course("English",20);
			bool success = Registrar.RegistrarGuy().AddStudenttoCourse(john,English);
			Assert.True(success);
			//Assert.Equal();
		}

		[Fact]
		public void AddCourseTest()
		{
			Course English = new Course("English-101",2);
			Course Math = new Course("Math-101", 2, 5);
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
			Student james = new Student("james",12);
			Student jane = new Student("jane", 10);
			Student sam = new Student("sam", 16);
			Student bill = new Student("bill", 11);
			Course math = new Course("mathstuff", 3, 20);
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

    }
}
