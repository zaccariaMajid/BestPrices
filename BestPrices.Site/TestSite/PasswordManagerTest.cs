using FluentAssertions;
using System;
using Xunit;
using static BestPrices.Site.PasswordManager;

namespace TestSite
{
    public class PasswordManagerTest
    {
        #region PasswordManager
        [Fact]
        public void TestEncodePasswordToBase64_1()
        {
            //Arrange
            string password = "ciao";

            //Act
            var result = EncodePasswordToBase64(password);

            //Assert
            result.Should().Be("Y2lhbw==");
        }

        [Fact]
        public void TestEncodePasswordToBase64_2()
        {
            //Arrange
            string password = "12345";

            //Act
            var result = EncodePasswordToBase64(password);

            //Assert
            result.Should().Be("MTIzNDU=");
        }

        [Fact]
        public void TestEncodePasswordToBase64_3()
        {
            //Arrange
            string password = "paleocapa";

            //Act
            var result = EncodePasswordToBase64(password);

            //Assert
            result.Should().Be("cGFsZW9jYXBh");
        }

        [Fact]
        public void TestEncodePasswordToBase64_4()
        {
            //Arrange
            string password = "password";

            //Act
            var result = EncodePasswordToBase64(password);

            //Assert
            result.Should().Be("cGFzc3dvcmQ=");
        }

        [Fact]
        public void TestDecodeFrom64_1()
        {
            //Arrange
            string encodedpassword = "Y2lhbw==";

            //Act
            var result = DecodeFrom64(encodedpassword);

            //Assert
            result.Should().Be("ciao");
        }

        [Fact]
        public void TestDecodeFrom64_2()
        {
            //Arrange
            string encodedpassword = "MTIzNDU=";

            //Act
            var result = DecodeFrom64(encodedpassword);

            //Assert
            result.Should().Be("12345");
        }

        [Fact]
        public void TestDecodeFrom64_3()
        {
            //Arrange
            string encodedpassword = "cGFsZW9jYXBh";

            //Act
            var result = DecodeFrom64(encodedpassword);

            //Assert
            result.Should().Be("paleocapa");
        }

        [Fact]
        public void TestDecodeFrom64_4()
        {
            //Arrange
            string encodedpassword = "cGFzc3dvcmQ=";

            //Act
            var result = DecodeFrom64(encodedpassword);

            //Assert
            result.Should().Be("password");
        }

        [Fact]
        public void TestEncodePasswordToBase64Length_1()
        {
            //Arrange
            string password = "ciao";

            //Act
            var result = EncodePasswordToBase64(password);

            //Assert
            result.Length.Should().Be(8);
        }

        [Fact]
        public void TestEncodePasswordToBase64Length_2()
        {
            //Arrange
            string password = "12345";

            //Act
            var result = EncodePasswordToBase64(password);

            //Assert
            result.Length.Should().Be(8);
        }

        [Fact]
        public void TestEncodePasswordToBase64Length_3()
        {
            //Arrange
            string password = "paleocapa";

            //Act
            var result = EncodePasswordToBase64(password);

            //Assert
            result.Length.Should().Be(12);
        }

        [Fact]
        public void TestEncodePasswordToBase64Length_4()
        {
            //Arrange
            string password = "password";

            //Act
            var result = EncodePasswordToBase64(password);

            //Assert
            result.Length.Should().Be(12);
        }

        [Fact]
        public void TestDecodeFrom64Length_1()
        {
            //Arrange
            string encodedpassword = "Y2lhbw==";

            //Act
            var result = DecodeFrom64(encodedpassword);

            //Assert
            result.Length.Should().Be(4);
        }

        [Fact]
        public void TestDecodeFrom64Length_2()
        {
            //Arrange
            string encodedpassword = "MTIzNDU=";

            //Act
            var result = DecodeFrom64(encodedpassword);

            //Assert
            result.Length.Should().Be(5);
        }

        [Fact]
        public void TestDecodeFrom64Length_3()
        {
            //Arrange
            string encodedpassword = "cGFsZW9jYXBh";

            //Act
            var result = DecodeFrom64(encodedpassword);

            //Assert
            result.Length.Should().Be(9);
        }

        [Fact]
        public void TestDecodeFrom64Length_4()
        {
            //Arrange
            string encodedpassword = "cGFzc3dvcmQ=";

            //Act
            var result = DecodeFrom64(encodedpassword);

            //Assert
            result.Length.Should().Be(8);
        }

        #endregion
    }
}
