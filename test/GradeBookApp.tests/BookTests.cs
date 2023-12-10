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
        int expected =5;
        int actual = 5;
        //act
        
        //assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Testmethod2()
    {

    }
}
}