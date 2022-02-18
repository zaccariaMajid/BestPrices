using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using BestPrices.Site.Models;

namespace TestSite
{
    public class EcommerceTest
    {
        [Fact]
        public void AmazonTest_1()
        {
            //Arrange
            Ecommerce sito = new Ecommerce()
            {
                Id = "A",
                Name="Amazon",
                Link= "https://www.amazon.it"
            };

            //Assert
            Assert.Equal("A", sito.Id);
        }

        [Fact]
        public void AmazonTest_2()
        {
            //Arrange
            Ecommerce sito = new Ecommerce()
            {
                Id = "A",
                Name = "Amazon",
                Link = "https://www.amazon.it"
            };

            //Assert
            Assert.Equal("Amazon", sito.Name);
        }

        [Fact]
        public void AmazonTest_3()
        {
            //Arrange
            Ecommerce sito = new Ecommerce()
            {
                Id = "A",
                Name = "Amazon",
                Link = "https://www.amazon.it"
            };

            //Assert
            Assert.Equal("https://www.amazon.it", sito.Link);
        }

        [Fact]
        public void AmazonTestNotNull_1()
        {
            //Arrange
            Ecommerce sito = new Ecommerce()
            {
                Id = "A",
                Name = "Amazon",
                Link = "https://www.amazon.it"
            };

            //Assert
            Assert.NotNull(sito);
        }

        [Fact]
        public void AmazonTestLength_1()
        {
            //Arrange
            Ecommerce sito = new Ecommerce()
            {
                Id = "A",
                Name = "Amazon",
                Link = "https://www.amazon.it"
            };

            //Assert
            Assert.Equal(1, sito.Id.Length);
        }

        [Fact]
        public void AmazonTestLength_2()
        {
            //Arrange
            Ecommerce sito = new Ecommerce()
            {
                Id = "A",
                Name = "Amazon",
                Link = "https://www.amazon.it"
            };

            //Assert
            Assert.Equal(6, sito.Name.Length);
        }

        [Fact]
        public void AmazonTestLength_3()
        {
            //Arrange
            Ecommerce sito = new Ecommerce()
            {
                Id = "A",
                Name = "Amazon",
                Link = "https://www.amazon.it"
            };

            //Assert
            Assert.Equal(21, sito.Link.Length);
        }

        [Fact]
        public void EbayTest_1()
        {
            //Arrange
            Ecommerce sito = new Ecommerce()
            {
                Id = "B",
                Name = "eBay",
                Link = "https://www.ebay.it"
            };

            //Assert
            Assert.Equal("B", sito.Id);
        }

        [Fact]
        public void EbayTest_2()
        {
            //Arrange
            Ecommerce sito = new Ecommerce()
            {
                Id = "B",
                Name = "eBay",
                Link = "https://www.ebay.it"
            };

            //Assert
            Assert.Equal("eBay", sito.Name);
        }

        [Fact]
        public void EbayTest_3()
        {
            //Arrange
            Ecommerce sito = new Ecommerce()
            {
                Id = "B",
                Name = "eBay",
                Link = "https://www.ebay.it"
            };

            //Assert
            Assert.Equal("https://www.ebay.it", sito.Link);
        }

        [Fact]
        public void EbayTestNotNull_1()
        {
            //Arrange
            Ecommerce sito = new Ecommerce()
            {
                Id = "B",
                Name = "eBay",
                Link = "https://www.ebay.it"
            };

            //Assert
            Assert.NotNull(sito);
        }

        [Fact]
        public void EbayTestLength_1()
        {
            //Arrange
            Ecommerce sito = new Ecommerce()
            {
                Id = "B",
                Name = "eBay",
                Link = "https://www.ebay.it"
            };

            //Assert
            Assert.Equal(1, sito.Id.Length);
        }

        [Fact]
        public void EbayTestLength_2()
        {
            //Arrange
            Ecommerce sito = new Ecommerce()
            {
                Id = "B",
                Name = "eBay",
                Link = "https://www.ebay.it"
            };

            //Assert
            Assert.Equal(4, sito.Name.Length);
        }

        [Fact]
        public void EbayTestLength_3()
        {
            //Arrange
            Ecommerce sito = new Ecommerce()
            {
                Id = "B",
                Name = "eBay",
                Link = "https://www.ebay.it"
            };

            //Assert
            Assert.Equal(19, sito.Link.Length);
        }

        [Fact]
        public void SitesCountTest_1()
        {
            //Arrange
            Ecommerce amazon = new Ecommerce()
            {
                Id = "A",
                Name = "Amazon",
                Link = "https://www.amazon.it"
            };

            Ecommerce ebay = new Ecommerce()
            {
                Id = "B",
                Name = "eBay",
                Link = "https://www.ebay.it"
            };

            //Act
            List<Ecommerce> elesites = new List<Ecommerce>();
            elesites.Add(amazon);
            elesites.Add(ebay);
            var result = elesites.Count;

            //Assert
            result.Should().Be(2);
        }

        [Fact]
        public void SitesNotNullTest_1()
        {
            //Arrange
            Ecommerce amazon = new Ecommerce()
            {
                Id = "A",
                Name = "Amazon",
                Link = "https://www.amazon.it"
            };

            Ecommerce ebay = new Ecommerce()
            {
                Id = "B",
                Name = "eBay",
                Link = "https://www.ebay.it"
            };

            //Act
            List<Ecommerce> elesites = new List<Ecommerce>();
            elesites.Add(amazon);
            elesites.Add(ebay);
            var result = elesites[0];

            //Assert
            result.Should().NotBeNull();
        }

        [Fact]
        public void SitesNotNullTest_2()
        {
            //Arrange
            Ecommerce amazon = new Ecommerce()
            {
                Id = "A",
                Name = "Amazon",
                Link = "https://www.amazon.it"
            };

            Ecommerce ebay = new Ecommerce()
            {
                Id = "B",
                Name = "eBay",
                Link = "https://www.ebay.it"
            };

            //Act
            List<Ecommerce> elesites = new List<Ecommerce>();
            elesites.Add(amazon);
            elesites.Add(ebay);
            var result = elesites[1];

            //Assert
            result.Should().NotBeNull();
        }

        [Fact]
        public void SitesTest_1()
        {
            //Arrange
            Ecommerce amazon = new Ecommerce()
            {
                Id = "A",
                Name = "Amazon",
                Link = "https://www.amazon.it"
            };

            Ecommerce ebay = new Ecommerce()
            {
                Id = "B",
                Name = "eBay",
                Link = "https://www.ebay.it"
            };

            //Act
            List<Ecommerce> elesites = new List<Ecommerce>();
            elesites.Add(amazon);
            elesites.Add(ebay);
            var result = elesites[0];

            //Assert
            result.Id.Should().Be("A");
            result.Name.Should().Be("Amazon");
            result.Link.Should().Be("https://www.amazon.it");
        }

        [Fact]
        public void SitesTest_2()
        {
            //Arrange
            Ecommerce amazon = new Ecommerce()
            {
                Id = "A",
                Name = "Amazon",
                Link = "https://www.amazon.it"
            };

            Ecommerce ebay = new Ecommerce()
            {
                Id = "B",
                Name = "eBay",
                Link = "https://www.ebay.it"
            };

            //Act
            List<Ecommerce> elesites = new List<Ecommerce>();
            elesites.Add(amazon);
            elesites.Add(ebay);
            var result = elesites[1];

            //Assert
            result.Id.Should().Be("B");
            result.Name.Should().Be("eBay");
            result.Link.Should().Be("https://www.ebay.it");
        }
    }
}
