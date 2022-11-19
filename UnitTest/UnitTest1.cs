using SchoolLibrary;

namespace UnitTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(4<5);
    }

    [Fact]
    public void Test2()
    {
        Course course1 = new Course("math101");
        Student s = new Student("JJWW");
        Assert.D(
                () => course1.Grade
            ) 
    }
}
