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
    public class UserProductTest
    {
        [Fact]
        public void UserProductIdTest_1()
        {
            //Arrange
            UserProduct utente = new UserProduct()
            {
                Id = "1",
                IdUser = "1",
                IdProduct = "50",
                IsFavourite = true,
                Date = DateTime.Parse("13/07/2003")
            };

            //Assert
            utente.Id.Should().Be("1");
        }

        [Fact]
        public void UserProductIdUserTest_1()
        {
            //Arrange
            UserProduct utente = new UserProduct()
            {
                Id = "1",
                IdUser = "1",
                IdProduct = "50",
                IsFavourite = true,
                Date = DateTime.Parse("13/07/2003")
            };

            //Assert
            utente.IdUser.Should().Be("1");
        }

        [Fact]
        public void UserProductIdProductTest_1()
        {
            //Arrange
            UserProduct utente = new UserProduct()
            {
                Id = "1",
                IdUser = "1",
                IdProduct = "50",
                IsFavourite = true,
                Date = DateTime.Parse("13/07/2003")
            };

            //Assert
            utente.IdProduct.Should().Be("50");
        }

        [Fact]
        public void UserProductIsFavouriteTest_1()
        {
            //Arrange
            UserProduct utente = new UserProduct()
            {
                Id = "1",
                IdUser = "1",
                IdProduct = "50",
                IsFavourite = true,
                Date = DateTime.Parse("13/07/2003")
            };

            //Assert
            utente.IsFavourite.Should().Be(true);
        }

        [Fact]
        public void UserProductDateTest_1()
        {
            //Arrange
            UserProduct utente = new UserProduct()
            {
                Id = "1",
                IdUser = "1",
                IdProduct = "50",
                IsFavourite = true,
                Date = DateTime.Parse("13/07/2003")
            };

            //Assert
            utente.Date.Should().Be(DateTime.Parse("13/07/2003"));
        }

        [Fact]
        public void UserProductsCountTest_1()
        {
            //Arrange
            UserProduct utente = new UserProduct()
            {
                Id = "1",
                IdUser = "1",
                IdProduct = "50",
                IsFavourite = true,
                Date = DateTime.Parse("13/07/2003")
            };

            UserProduct utente2 = new UserProduct()
            {
                Id = "2",
                IdUser = "2",
                IdProduct = "23",
                IsFavourite = false,
                Date = DateTime.Parse("19/01/2016")
            };

            List<UserProduct> userproducts = new List<UserProduct>();
            userproducts.Add(utente);
            userproducts.Add(utente2);

            //Act
            var result = userproducts.Count();

            //Assert
            result.Should().Be(2);
        }

        [Fact]
        public void UserProductsTest_1()
        {
            //Arrange
            UserProduct utente = new UserProduct()
            {
                Id = "1",
                IdUser = "1",
                IdProduct = "50",
                IsFavourite = true,
                Date = DateTime.Parse("13/07/2003")
            };

            UserProduct utente2 = new UserProduct()
            {
                Id = "2",
                IdUser = "2",
                IdProduct = "23",
                IsFavourite = false,
                Date = DateTime.Parse("19/01/2016")
            };

            List<UserProduct> userproducts = new List<UserProduct>();
            userproducts.Add(utente);
            userproducts.Add(utente2);

            //Act
            var result = userproducts[0];

            //Assert
            result.Id.Should().Be("1");
            result.IdUser.Should().Be("1");
            result.IdProduct.Should().Be("50");
            result.IsFavourite.Should().Be(true);
            result.Date.Should().Be(DateTime.Parse("13/07/2003"));
        }

        [Fact]
        public void UserProductsTest_2()
        {
            //Arrange
            UserProduct utente = new UserProduct()
            {
                Id = "1",
                IdUser = "1",
                IdProduct = "50",
                IsFavourite = true,
                Date = DateTime.Parse("13/07/2003")
            };

            UserProduct utente2 = new UserProduct()
            {
                Id = "2",
                IdUser = "2",
                IdProduct = "23",
                IsFavourite = false,
                Date = DateTime.Parse("19/01/2016")
            };

            List<UserProduct> userproducts = new List<UserProduct>();
            userproducts.Add(utente);
            userproducts.Add(utente2);

            //Act
            var result = userproducts[1];

            //Assert
            result.Id.Should().Be("2");
            result.IdUser.Should().Be("2");
            result.IdProduct.Should().Be("23");
            result.IsFavourite.Should().Be(false);
            result.Date.Should().Be(DateTime.Parse("19/01/2016"));
        }


    }
}
