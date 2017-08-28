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
			Course English = new Course("English");
			Registrar.ConditionS t0 = new Registrar.ConditionS(studentcondition);
			Registrar.ConditionC t1 = new Registrar.ConditionC(coursecondition);
			bool success = Registrar.RegistrarGuy().AddStudenttoCourse(t0,t1);
			Assert.True(success);

		}




		[Fact]
		public void AddCourseTest()
		{
			Course English = new Course("English-101");
			Student john = new Student("john");
			Student doe = new Student();
			bool success = john.addtoCourse(English);
			doe.addtoCourse(English);
			Assert.True(success);
			//bool fail = doe.addtoCourse(English);
			//Assert.False(fail);
		}

		[Fact]
		public void RemoveCourseTest()
		{

		}

		private Student studentcondition()
		{
			return new Student();
		}

		private Course coursecondition()
		{
			return new Course("English");
		}

    }
}
