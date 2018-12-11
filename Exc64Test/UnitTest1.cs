using System;
using Exercise64;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exc64Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var testNumber = "10";
            var testString = "Test";
            var testValidator = new Validator();

            //Act
            var resultNumber = testValidator.IsInt(testNumber);
            var resultString = testValidator.IsInt(testString);

            //Assert
            Assert.IsTrue(resultNumber);
            Assert.IsFalse(resultString);

        }
    }
}
