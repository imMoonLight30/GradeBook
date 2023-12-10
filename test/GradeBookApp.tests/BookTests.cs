using GradeBookApp;

namespace GradeBookApp.tests
{
[TestClass]
public class BookTests
{
    [TestMethod]
    public void TestMethod1()
    {
        //arrange
        var book = new Book("TestBook");
        //act
        book.AddGrade(10.5);
        var ans = book.GetGrades();
        //assert
        Assert.AreEqual(10.5, ans[0]);
    }

    [TestMethod]
    public void Testmethod2()
    {

    }
}
}