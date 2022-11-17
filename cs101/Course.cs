using System;
namespace cs101
{
	public class Course
	{
		private static int ID_SEED = 1000000;
		private String course_id;

        public String Name { get; set; }
		public String ID { get=>course_id; }
		public double Grade { get; set; }

		public Course(String name)
		{
			Name = name;
			this.course_id = ID_SEED.ToString();
			ID_SEED++;
		}

		public void Info()
		{
			Console.WriteLine($"Course id: {this.ID};\tCourse name: {this.Name}.");
		}
	}
}

