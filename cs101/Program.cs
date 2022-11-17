using cs101;
Console.WriteLine("START:");


//      Course   //
Course course1 = new Course("Chinese 101");
Course course2 = new Course("Chinese 102");
Course course3 = new Course("CS 101");
Course course4 = new Course("CS 161");
List<Course> courses = new List<Course>();
courses.Add(course1); courses.Add(course2); courses.Add(course3); courses.Add(course4);
////////testing all students INFO/////
foreach (var cour in courses)
{
    cour.Info();
}

//      Student  //
List<Student> students = new List<Student>();
cs101.Student student1 = new cs101.Student("Ming");
Student student2 = new Student("Joan");
Student student3 = new Student("Jian");
Student student4 = new Student("Wong");
students.Add(student1);students.Add(student2);students.Add(student3);students.Add(student4);

student1.take_course(course3);
student1.add_course_grade(course3, 99);
////////testing all students INFO/////
foreach (var stu in students)
{
    stu.Info();
}

/////////TESTING////////
//   Exception   //
Console.WriteLine("\n\nTesing\n");
Console.WriteLine("Add course grade to student who dose take that class: ");
student2.add_course_grade(course3, 99);

Console.WriteLine("Checking course grade to student who dose take that class: ");
student1.see_course_grade(course1);

//Console.WriteLine(course1.ToString());

await Task.Delay(1000);
Console.WriteLine("\n\n\nEND");