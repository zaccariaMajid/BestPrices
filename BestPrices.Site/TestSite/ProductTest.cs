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
    public class ProductTest
    {
        [Fact]
        public void ProductTypeIdTest_1()
        {
            //Arrange
            Product prodotto = new Product()
            {
                Id = new Guid().ToString(),
                Name = "Amazon",
                Price = "30.00€",
                PathPhoto = "/bin/debug/",
                Link = "https://www.amazon.it",
                IdEcommerce = "A"
            };
            var result = prodotto.Id;

            //Assert
            result.Should().BeOfType(typeof(string));
        }

        [Fact]
        public void ProductNameTest_1()
        {
            //Arrange
            Product prodotto = new Product()
            {
                Id = new Guid().ToString(),
                Name = "Amazon",
                Price = "30.00€",
                PathPhoto = "/bin/debug/",
                Link = "https://www.amazon.it",
                IdEcommerce = "A"
            };

            //Assert
            Assert.Equal("Amazon", prodotto.Name);
        }

        [Fact]
        public void ProductPriceTest_1()
        {
            //Arrange
            Product prodotto = new Product()
            {
                Id = new Guid().ToString(),
                Name = "Amazon",
                Price = "30.00€",
                PathPhoto = "/bin/debug/",
                Link = "https://www.amazon.it",
                IdEcommerce = "A"
            };

            //Assert
            Assert.Equal("30.00€", prodotto.Price);
        }

        [Fact]
        public void ProductPathphotoTest_1()
        {
            //Arrange
            Product prodotto = new Product()
            {
                Id = new Guid().ToString(),
                Name = "Amazon",
                Price = "30.00€",
                PathPhoto = "/bin/debug/",
                Link = "https://www.amazon.it",
                IdEcommerce = "A"
            };

            //Assert
            Assert.Equal("/bin/debug/", prodotto.PathPhoto);
        }

        [Fact]
        public void ProductLinkTest_1()
        {
            //Arrange
            Product prodotto = new Product()
            {
                Id = new Guid().ToString(),
                Name = "Amazon",
                Price = "30.00€",
                PathPhoto = "/bin/debug/",
                Link = "https://www.amazon.it",
                IdEcommerce = "A"
            };

            //Assert
            Assert.Equal("https://www.amazon.it", prodotto.Link);
        }

        [Fact]
        public void ProductIdEcommerceTest_1()
        {
            //Arrange
            Product prodotto = new Product()
            {
                Id = new Guid().ToString(),
                Name = "Amazon",
                Price = "30.00€",
                PathPhoto = "/bin/debug/",
                Link = "https://www.amazon.it",
                IdEcommerce = "A"
            };

            //Assert
            Assert.Equal("A", prodotto.IdEcommerce);
            prodotto.IdEcommerce.Length.Should().Be(1);
        }

        [Fact]
        public void ProductsCount_1()
        {
            //Arrange
            Product prodotto = new Product()
            {
                Id = new Guid().ToString(),
                Name = "Amazon",
                Price = "30.00€",
                PathPhoto = "/bin/debug/",
                Link = "https://www.amazon.it",
                IdEcommerce = "A"
            };

            //Act
            List<Product> eleproducts = new List<Product>();
            eleproducts.Add(prodotto);


            //Assert
            eleproducts.Count.Should().Be(1);
        }

        [Fact]
        public void ProductEcommerceTest_1()
        {
            //Arrange
            Product prodotto = new Product()
            {
                Id = new Guid().ToString(),
                Name = "Amazon",
                Price = "30.00€",
                PathPhoto = "/bin/debug/",
                Link = "https://www.amazon.it",
                IdEcommerce = "A"
            };

            //Act
            List<Product> eleproducts = new List<Product>();
            eleproducts.Add(prodotto);

            var result = eleproducts.Where(a => a.IdEcommerce == "A").FirstOrDefault();


            //Assert
            result.Should().NotBeNull();
        }

        [Fact]
        public void ProductEcommerceTest_2()
        {
            //Arrange
            Product prodotto = new Product()
            {
                Id = new Guid().ToString(),
                Name = "eBay",
                Price = "30.00€",
                PathPhoto = "/bin/debug/",
                Link = "https://www.amazon.it",
                IdEcommerce = "B"
            };

            //Act
            List<Product> eleproducts = new List<Product>();
            eleproducts.Add(prodotto);

            var result = eleproducts.Where(a => a.IdEcommerce == "B").FirstOrDefault();


            //Assert
            result.Should().NotBeNull();
        }

        [Fact]
        public void ProductTest_1()
        {
            //Arrange
            Product prodotto = new Product()
            {
                Id = new Guid().ToString(),
                Name = "Amazon",
                Price = "30.00€",
                PathPhoto = "/bin/debug/",
                Link = "https://www.amazon.it",
                IdEcommerce = "A"
            };

            Product prodotto2 = new Product()
            {
                Id = new Guid().ToString(),
                Name = "eBay",
                Price = "40.00€",
                PathPhoto = "/bin/debug/eBay/",
                Link = "https://www.ebay.it",
                IdEcommerce = "B"
            };

            //Act
            List<Product> eleproducts = new List<Product>();
            eleproducts.Add(prodotto);
            eleproducts.Add(prodotto2);

            var result = eleproducts[0];

            //Assert
            result.Name.Should().Be("Amazon");
            result.Price.Should().Be("30.00€");
            result.PathPhoto.Should().Be("/bin/debug/");
            result.Link.Should().Be("https://www.amazon.it");
            result.IdEcommerce.Should().Be("A");
        }

        [Fact]
        public void ProductTest_2()
        {
            //Arrange
            Product prodotto = new Product()
            {
                Id = new Guid().ToString(),
                Name = "Amazon",
                Price = "30.00€",
                PathPhoto = "/bin/debug/",
                Link = "https://www.amazon.it",
                IdEcommerce = "A"
            };

            Product prodotto2 = new Product()
            {
                Id = new Guid().ToString(),
                Name = "eBay",
                Price = "40.00€",
                PathPhoto = "/bin/debug/eBay/",
                Link = "https://www.ebay.it",
                IdEcommerce = "B"
            };

            //Act
            List<Product> eleproducts = new List<Product>();
            eleproducts.Add(prodotto);
            eleproducts.Add(prodotto2);

            var result = eleproducts[1];

            //Assert
            result.Name.Should().Be("eBay");
            result.Price.Should().Be("40.00€");
            result.PathPhoto.Should().Be("/bin/debug/eBay/");
            result.Link.Should().Be("https://www.ebay.it");
            result.IdEcommerce.Should().Be("B");
        }
    }
}
