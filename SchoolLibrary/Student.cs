using System;
namespace SchoolLibrary
{
	public class Student
	{
		private int ID_LENGHT = 7;
		private static int ID_SEED = 0;

		private String name;
		private String id;
        private List<Course> courses_take;

        public String Name { get => name; set => name = value; }
        public String Id { get => id; }

		public Student(String name)
        {
            this.name = name;
            String s_id = ID_SEED.ToString();
			while(s_id.Length<ID_LENGHT)
			{
				s_id = "0" + s_id;
			}
			this.id = s_id;
            ID_SEED++;
			courses_take = new List<Course>();
		}

		public void take_course(Course course)
		{
			courses_take.Add(course);
		}

		public void add_course_grade(Course course, double grade)
		{
			try
			{
                courses_take[courses_take.IndexOf(course)].Grade = grade;
            }
			catch(Exception e)
			{
                //Console.WriteLine($"Error {e}" +". Not such course");
                Console.WriteLine($"Sorry {Name}, you don't take {course.Name} yet.");
            }
        }

		public void see_course_grade(Course course)
        {
            try
            {
                Course cour = courses_take[courses_take.IndexOf(course)];
                Console.WriteLine($"{name}, your {cour.Name} grade is {cour.Grade}.");
            }
            catch (Exception e)
            {
                //Console.WriteLine($"Error {e}" + $". Sorry, you haven't take {course.Name}.");
                Console.WriteLine($"Sorry {Name}, you don't take {course.Name} yet.");
            }
        }

		public void Info()
		{
			Console.WriteLine($"Student: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.Write($"Courses taken: ");
			foreach(Course cour in courses_take)
			{
				Console.Write(cour.Name + $": {cour.Grade}; ");
            }
			Console.WriteLine();
        }

	}
}

