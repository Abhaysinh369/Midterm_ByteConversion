using Conversion;
using Midterm_ByteConversion;
using NUnit.Framework;

namespace Midterm_ByteConversionTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConvertMegabytestobytes()
        {
            //Arrange
            var ans = ByteConversion.ConvertMegabytestoBytes(12);
            //Act
            bool result = false;
            if(ans >= 12000000)
            {
                result = true;
            }
            //Assert
            Assert.IsTrue(result);
        }
        
        [Test]
        public void ConvertMegabytestobytes_test3()
        {
            //Arrange
            var ans = ByteConversion.ConvertMegabytestoBytes(32);
            bool result = false;
            //Act

            if (ans >= 33554432)
            {
                result = true;
            }
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void ConvertGigabytestoMegabytes_test1()
        {
            //Arrange
            var ans = ByteConversion.ConvertGigabytestoMegaBytes(32);
            bool result = false;
            //Act

            if (ans >= 32768)
            {
                result = true;
            }
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void ConvertGigabytestoMegabytes_test2()
        {
            //Arrange
            var ans = ByteConversion.ConvertGigabytestoMegaBytes(12);
            //Act
            //Assert
            Assert.AreNotEqual(ans, 12000, "Result is not same");
        }
        [Test]
        public void ConvertTerabytestoGigabytes_test1()
        {
            //Arrange
            var ans = ByteConversion.ConvertTerabytestoGigaBytes(12);
            bool result = false;
            //Act

            if (ans >= 12288)
            {
                result = true;
            }
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void ConvertTerabytestoGigabytes_test2()
        {
            //Arrange
            var ans = ByteConversion.ConvertTerabytestoGigaBytes(12);
            //Act
            //Assert
            Assert.AreNotEqual(ans, 12200, "Result is not same");
        }
    }
}