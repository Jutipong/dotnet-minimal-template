using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        //Arrange
        var expect = 123;

        //Act
        var actual = 123;

        //Assertå
        Assert.AreEqual(expect, actual);
    }

    [TestMethod]
    public void Test2()
    {
        //Arrange
        var expect = 123;

        //Act
        var actual = 222;

        //Assert
        Assert.AreNotEqual(expect, actual);
    }
}