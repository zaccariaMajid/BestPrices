using BestPrices.Site.Models;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestSite
{
    public class UserTest
    {
        [Fact]
        public void UserIdTest_1()
        {
            //Arrange
            User utente = new User()
            {
                Id = "1",
                Username = "Mario",
                Email = "mario@gmail.com",
                Password = "ciao"
            };

            //Assert
            utente.Id.Should().Be("1");
        }

        [Fact]
        public void UserUsernameTest_1()
        {
            //Arrange
            User utente = new User()
            {
                Id = "1",
                Username = "Mario",
                Email = "mario@gmail.com",
                Password = "ciao"
            };

            //Assert
            utente.Username.Should().Be("Mario");
        }

        [Fact]
        public void UserEmailTest_1()
        {
            //Arrange
            User utente = new User()
            {
                Id = "1",
                Username = "Mario",
                Email = "mario@gmail.com",
                Password = "ciao"
            };

            //Assert
            utente.Email.Should().Be("mario@gmail.com");
        }

        [Fact]
        public void UserPasswordTest_1()
        {
            //Arrange
            User utente = new User()
            {
                Id = "1",
                Username = "Mario",
                Email = "mario@gmail.com",
                Password = "ciao"
            };

            //Assert
            utente.Password.Should().Be("ciao");
        }

        [Fact]
        public void UsersTest_1()
        {
            //Arrange
            User utente = new User()
            {
                Id = "1",
                Username = "Mario",
                Email = "mario@gmail.com",
                Password = "ciao"
            };

            User utente2 = new User()
            {
                Id = "2",
                Username = "Paolo",
                Email = "paolo@gmail.com",
                Password = "mondo"
            };

            List<User> eleusers = new List<User>();
            eleusers.Add(utente);
            eleusers.Add(utente2);

            //Act
            var result = eleusers[0];

            //Assert
            utente.Id.Should().Be("1");
            utente.Username.Should().Be("Mario");
            utente.Email.Should().Be("mario@gmail.com");
            utente.Password.Should().Be("ciao");
        }

        [Fact]
        public void UsersTest_2()
        {
            //Arrange
            User utente = new User()
            {
                Id = "1",
                Username = "Mario",
                Email = "mario@gmail.com",
                Password = "ciao"
            };

            User utente2 = new User()
            {
                Id = "2",
                Username = "Paolo",
                Email = "paolo@gmail.com",
                Password = "mondo"
            };

            List<User> eleusers = new List<User>();
            eleusers.Add(utente);
            eleusers.Add(utente2);

            //Act
            var result = eleusers[1];

            //Assert
            utente.Id.Should().Be("1");
            utente.Username.Should().Be("Mario");
            utente.Email.Should().Be("mario@gmail.com");
            utente.Password.Should().Be("ciao");
        }

        [Fact]
        public void UsersCountTest_1()
        {
            //Arrange
            User utente = new User()
            {
                Id = "1",
                Username = "Mario",
                Email = "mario@gmail.com",
                Password = "ciao"
            };

            User utente2 = new User()
            {
                Id = "2",
                Username = "Paolo",
                Email = "paolo@gmail.com",
                Password = "mondo"
            };

            List<User> eleusers = new List<User>();
            eleusers.Add(utente);
            eleusers.Add(utente2);

            //Act
            var result = eleusers.Count();

            //Assert
            result.Should().Be(2);
        }
    }
}
