using API_pcto.Entities;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace ApiTest
{
    public class ProductsRepositoryTest
    {
        #region Amazon
        [Fact]
        public void ScrapingCountTest_1()
        {
            //Arrange
            string nomeProdottoDaCercare = "palla da basket";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.amazon.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();


            //Act
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[3]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("a-size-base-plus")).Text;
                    product.Price = decimal.Parse(ele.FindElement(By.ClassName("a-price-whole")).Text) + ele.FindElement(By.ClassName("a-price-symbol")).Text;
                    product.PathPhoto = ele.FindElement(By.ClassName("s-image")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    product.IdEcommerce = "A";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //Assert
            elencoProdotti.Count.Should().BeInRange(60, 65);
        }

        [Fact]
        public void ScrapingCountTest_2()
        {
            //Arrange
            string nomeProdottoDaCercare = "tavolo";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.amazon.it/";

            List<Prodotto> elencoProdotti = new List<Prodotto>();

            //Act
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[3]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("a-size-base-plus")).Text;
                    product.Price = decimal.Parse(ele.FindElement(By.ClassName("a-price-whole")).Text) + ele.FindElement(By.ClassName("a-price-symbol")).Text;
                    product.PathPhoto = ele.FindElement(By.ClassName("s-image")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    product.IdEcommerce = "A";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //Assert
            elencoProdotti.Count.Should().BeInRange(55, 70);
        }

        [Fact]
        public void ScrapingCountTest_3()
        {
            //Arrange
            string nomeProdottoDaCercare = "computer";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.amazon.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();


            //Act
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[3]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("a-size-base-plus")).Text;
                    product.Price = decimal.Parse(ele.FindElement(By.ClassName("a-price-whole")).Text) + ele.FindElement(By.ClassName("a-price-symbol")).Text;
                    product.PathPhoto = ele.FindElement(By.ClassName("s-image")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    product.IdEcommerce = "A";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //Assert
            elencoProdotti.Count.Should().Be(61);
        }

        [Fact]
        public void ScrapingCountTest_4()
        {
            //Arrange
            string nomeProdottoDaCercare = "pane";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.amazon.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();


            //Act
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[3]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("a-size-base-plus")).Text;
                    product.Price = decimal.Parse(ele.FindElement(By.ClassName("a-price-whole")).Text) + ele.FindElement(By.ClassName("a-price-symbol")).Text;
                    product.PathPhoto = ele.FindElement(By.ClassName("s-image")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    product.IdEcommerce = "A";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //Assert
            elencoProdotti.Count.Should().Be(64);
        }

        [Fact]
        public void ScrapingTest_1()
        {
            //Arrange
            string nomeProdottoDaCercare = "palla da basket";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.amazon.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();


            //Act
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[3]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("a-size-base-plus")).Text;
                    product.Price = decimal.Parse(ele.FindElement(By.ClassName("a-price-whole")).Text) + ele.FindElement(By.ClassName("a-price-symbol")).Text;
                    product.PathPhoto = ele.FindElement(By.ClassName("s-image")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    product.IdEcommerce = "A";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var prodotto = elencoProdotti[0];

            //Assert
            Assert.Equal("Amazon Basics - Palla da basket composita in PU", prodotto.Name);
            Assert.Equal("21,44€", prodotto.Price);
            Assert.Equal("https://m.media-amazon.com/images/I/91BfjS5PFSL._AC_UL320_.jpg", prodotto.PathPhoto);
            Assert.NotEqual("https://www.amazon.it/gp/slredirect/picassoRedirect.html/ref=pa_sp_atf_aps_sr_pg1_1?ie=UTF8&adId=A003119025DZU2KJQC0Y6&url=%2FAmazonBasics-basket-composita-dimensioni-ufficiali%2Fdp%2FB07VL3NHMY%2Fref%3Dsr_1_1_sspa%3F__mk_it_IT%3D%25C3%2585M%25C3%2585%25C5%25BD%25C3%2595%25C3%2591%26keywords%3Dpalla%2Bda%2Bbasket%26qid%3D1645363642%26sr%3D8-1-spons%26psc%3D1&qualifier=1645363902&id=8480469944828774&widgetName=sp_atf", prodotto.Link);
            Assert.Equal("A", prodotto.IdEcommerce);
        }

        [Fact]
        public void ScrapingTest_2()
        {
            //Arrange
            string nomeProdottoDaCercare = "tavolo";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.amazon.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();


            //Act
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[3]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("a-size-base-plus")).Text;
                    product.Price = decimal.Parse(ele.FindElement(By.ClassName("a-price-whole")).Text) + ele.FindElement(By.ClassName("a-price-symbol")).Text;
                    product.PathPhoto = ele.FindElement(By.ClassName("s-image")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    product.IdEcommerce = "A";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var prodotto = elencoProdotti[10];

            //Assert
            Assert.Equal("TemaHome Nice, Tavolo da Pranzo, White & Oak (Bianco/Beige), 110 x 70 x 73 cm", prodotto.Name);
            Assert.Equal("80,79€", prodotto.Price);
            Assert.Equal("https://m.media-amazon.com/images/I/61YC3-8miIL._AC_UL320_.jpg", prodotto.PathPhoto);
            Assert.NotEqual("https://www.amazon.it/TemaHome-Tavolo-Pranzo-Bianco-Rovere/dp/B07HSDBQXS/ref=sr_1_8?__mk_it_IT=%C3%85M%C3%85%C5%BD%C3%95%C3%91&keywords=tavolo&qid=1645364246&sr=8-8", prodotto.Link);
            Assert.Equal("A", prodotto.IdEcommerce);
        }

        [Fact]
        public void ScrapingTest_3()
        {
            //Arrange
            string nomeProdottoDaCercare = "pane";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.amazon.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();


            //Act
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[3]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("a-size-base-plus")).Text;
                    product.Price = decimal.Parse(ele.FindElement(By.ClassName("a-price-whole")).Text) + ele.FindElement(By.ClassName("a-price-symbol")).Text;
                    product.PathPhoto = ele.FindElement(By.ClassName("s-image")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    product.IdEcommerce = "A";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var prodotto = elencoProdotti[5];

            //Assert
            Assert.Equal("Nutrifree Panbauletto - 300 gr", prodotto.Name);
            Assert.Equal("2,99€", prodotto.Price);
            Assert.Equal("https://m.media-amazon.com/images/I/71JKDVWBnfL._AC_UL320_.jpg", prodotto.PathPhoto);
            Assert.NotEqual("https://www.amazon.it/Nutri-Free-Panbauletto-0-3-gr/dp/B07P8JNGB8/ref=sr_1_5?__mk_it_IT=%C3%85M%C3%85%C5%BD%C3%95%C3%91&keywords=pane&qid=1645374107&sr=8-5", prodotto.Link);
            Assert.Equal("A", prodotto.IdEcommerce);
        }
        #endregion

        #region eBay
        [Fact]
        public void WebScrapingCountTest_1()
        {
            //Arrange
            string nomeProdottoDaCercare = "palla da basket";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.ebay.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();


            //Act
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            var element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("s-item__title")).Text;
                    product.Price = ele.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
                    product.PathPhoto = ele.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
                    product.IdEcommerce = "B";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            //Assert
            elencoProdotti.Count.Should().Be(60);
        }

        [Fact]
        public void WebScrapingCountTest_2()
        {
            //Arrange
            string nomeProdottoDaCercare = "tavolo";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.ebay.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();


            //Act
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            var element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("s-item__title")).Text;
                    product.Price = ele.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
                    product.PathPhoto = ele.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
                    product.IdEcommerce = "B";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            //Assert
            elencoProdotti.Count.Should().Be(60);
        }

        [Fact]
        public void WebScrapingCountTest_3()
        {
            //Arrange
            string nomeProdottoDaCercare = "computer";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.ebay.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();


            //Act
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            var element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("s-item__title")).Text;
                    product.Price = ele.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
                    product.PathPhoto = ele.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
                    product.IdEcommerce = "B";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            //Assert
            elencoProdotti.Count.Should().Be(60);
        }

        [Fact]
        public void WebScrapingCountTest_4()
        {
            //Arrange
            string nomeProdottoDaCercare = "pane";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.ebay.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();


            //Act
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            var element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("s-item__title")).Text;
                    product.Price = ele.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
                    product.PathPhoto = ele.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
                    product.IdEcommerce = "B";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            //Assert
            elencoProdotti.Count.Should().Be(60);
        }

        [Fact]
        public void WebScrapingTest_1()
        {
            //Arrange
            string nomeProdottoDaCercare = "palla da basket";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.ebay.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();


            //Act
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            var element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement ele in element)
            {
                try
                {
                    Prodotto product = new Prodotto();
                    product.Name = ele.FindElement(By.ClassName("s-item__title")).Text;
                    product.Price = ele.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
                    product.PathPhoto = ele.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
                    product.IdEcommerce = "B";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            var prodotto = elencoProdotti[0];

            //Assert
            Assert.Equal("MINI PALLONE DA BASKET MISURA 5\" PALLA GIOCO BALL BASKETBALL PER PALLACANESTRO", prodotto.Name);
            Assert.Equal("10,22", prodotto.Price);
            Assert.Equal("https://i.ebayimg.com/thumbs/images/g/JeQAAOSw1vFfZiMT/s-l225.webp", prodotto.PathPhoto);
            Assert.NotEqual("https://www.ebay.it/itm/224162734380?_trkparms=ispr%3D1&hash=item343123e12c:g:JeQAAOSw1vFfZiMT&amdata=enc%3AAQAGAAACoPYe5NmHp%252B2JMhMi7yxGiTJkPrKr5t53CooMSQt2orsSvtkx670Z0mbyfWqmxLFLYdgpRZFMgrLvxZGs5JU8sb%252FHZrF7mlF%252B2inxswdEMe4QmqJoehiiKF49J1084rm%252FhyKpHVvwxbxyOZ99PDbT%252FsgVMdcrbZGRHZm5FXYlnJIH0k1ZNjZxonLyfGmS%252FI9G11OpdC3kqzTUGjBZnrpEMFjS7ahe4CBDNm7XKm5Em4ZuQC92aMJuZRucsIIOvjymZWYFNVUYJSJCjkUl0SYse0L398SJpnUiXCSGvHKxoQTq8hc%252BdKn9Cow8nzPwLy8sSQcjgxWTz3fANqjwe1IAXJ9OsWGeVH%252FExKSJgjAxVr1WN4xX0%252BfIcQlVHoA0RHWKeEkIKMastL7WHGYKlAq4vmhjbPN9MF56NTRWGKJj5p3ZJIe0Z7EHkUe2h5vuZ5LOtLfQJk4ti1HR41EYGsF36LndYiU%252FByVKjp%252FVkVvqpPucknVOfJ8NinhsFZJGRzYrZjALgPsM%252FAXZ%252FP88vhhah4fPgB7%252BJnmSb4GhkrBg3%252B5xnrOrMylQwsR6iVONjHHtTVWk0nKuUssaXNYjYyq8NR9%252FdtbHrxPt5kjPFeQFgsN0s9RZm8S54pmNz7b377fh2EEHQqSEO7Kjpp%252BFXztrSPCJGkFUFVVEjVx9x9kQitxV4VYZA1mvpHV%252B8fI1zwMuKPyfKgBjRRO86HviD32cj7DbSKDqmwdPyvSdeP5bV6KqtblKOPEsHuWXSV1Pz9HO5ghj8oWUMs9b3Z6G7ejdHUZbGgSCoWDuqMmQ8fHUE51sTMZa6YvehJibls9oT6ZAuY9NIlT0qhPtZUVnVSSYeUIWxjjS35Diy6pmmQnRB1O5sPsJ6yY1N6enKRlaolVWag%253D%253D%7Cclp%3A2334524%7Ctkp%3ABFBMtur8gONf", prodotto.Link);
            Assert.Equal("B", prodotto.IdEcommerce);
        }

        [Fact]
        public void WebScrapingTest_2()
        {
            //Arrange
            string nomeProdottoDaCercare = "tavolo";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.ebay.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();


            //Act
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            var element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement ele in element)
            {
                try
                {
                    Prodotto product = new Prodotto();
                    product.Name = ele.FindElement(By.ClassName("s-item__title")).Text;
                    product.Price = ele.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
                    product.PathPhoto = ele.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
                    product.IdEcommerce = "B";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            var prodotto = elencoProdotti[10];

            //Assert
            Assert.Equal("Tavolo de sala da pranzo, estensible,Kendra", prodotto.Name);
            Assert.Equal("149,00", prodotto.Price);
            Assert.Equal("https://i.ebayimg.com/thumbs/images/g/YX4AAOSwYnhcbsSv/s-l225.webp", prodotto.PathPhoto);
            Assert.Equal("https://www.ebay.it/itm/113632922176?hash=item1a750cca40:g:YX4AAOSwYnhcbsSv", prodotto.Link);
            Assert.Equal("B", prodotto.IdEcommerce);
        }

        [Fact]
        public void WebScrapingTest_3()
        {
            //Arrange
            string nomeProdottoDaCercare = "pane";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.ebay.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();


            //Act
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            var element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement ele in element)
            {
                try
                {
                    Prodotto product = new Prodotto();
                    product.Name = ele.FindElement(By.ClassName("s-item__title")).Text;
                    product.Price = ele.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
                    product.PathPhoto = ele.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
                    product.IdEcommerce = "B";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            var prodotto = elencoProdotti[4];

            //Assert
            Assert.Equal("Vero Pane Paesano Napoletano Kg. 1 CASERECCIO", prodotto.Name);
            Assert.Equal("9,99", prodotto.Price);
            Assert.Equal("https://i.ebayimg.com/thumbs/images/g/EOUAAOSwPgxVTnbB/s-l225.webp", prodotto.PathPhoto);
            Assert.Equal("https://www.ebay.it/itm/333588798148?hash=item4dab711ac4:g:EOUAAOSwPgxVTnbB", prodotto.Link);
            Assert.Equal("B", prodotto.IdEcommerce);
        }
        #endregion

        #region Amazon-eBay
        [Fact]
        public void SitesCountTest_1()
        {
            //Arrange
            string nomeProdottoDaCercare = "palla da basket";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.amazon.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[3]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("a-size-base-plus")).Text;
                    product.Price = decimal.Parse(ele.FindElement(By.ClassName("a-price-whole")).Text) + ele.FindElement(By.ClassName("a-price-symbol")).Text;
                    product.PathPhoto = ele.FindElement(By.ClassName("s-image")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    product.IdEcommerce = "A";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            driver.Url = "https://www.ebay.it/";
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("s-item__title")).Text;
                    product.Price = ele.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
                    product.PathPhoto = ele.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
                    product.IdEcommerce = "B";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            //Assert
            elencoProdotti.Count.Should().BeInRange(115, 130);
        }

        [Fact]
        public void SitesCountTest_2()
        {
            //Arrange
            string nomeProdottoDaCercare = "tavolo";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.amazon.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[3]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("a-size-base-plus")).Text;
                    product.Price = decimal.Parse(ele.FindElement(By.ClassName("a-price-whole")).Text) + ele.FindElement(By.ClassName("a-price-symbol")).Text;
                    product.PathPhoto = ele.FindElement(By.ClassName("s-image")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    product.IdEcommerce = "A";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            driver.Url = "https://www.ebay.it/";
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("s-item__title")).Text;
                    product.Price = ele.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
                    product.PathPhoto = ele.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
                    product.IdEcommerce = "B";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            //Assert
            elencoProdotti.Count.Should().BeInRange(115, 130);
        }

        [Fact]
        public void SitesCountTest_3()
        {
            //Arrange
            string nomeProdottoDaCercare = "computer";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.amazon.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[3]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("a-size-base-plus")).Text;
                    product.Price = decimal.Parse(ele.FindElement(By.ClassName("a-price-whole")).Text) + ele.FindElement(By.ClassName("a-price-symbol")).Text;
                    product.PathPhoto = ele.FindElement(By.ClassName("s-image")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    product.IdEcommerce = "A";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            driver.Url = "https://www.ebay.it/";
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("s-item__title")).Text;
                    product.Price = ele.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
                    product.PathPhoto = ele.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
                    product.IdEcommerce = "B";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            //Assert
            elencoProdotti.Count.Should().BeInRange(115, 130);
        }

        [Fact]
        public void SitesCountTest_4()
        {
            //Arrange
            string nomeProdottoDaCercare = "pane";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.amazon.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[3]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("a-size-base-plus")).Text;
                    product.Price = decimal.Parse(ele.FindElement(By.ClassName("a-price-whole")).Text) + ele.FindElement(By.ClassName("a-price-symbol")).Text;
                    product.PathPhoto = ele.FindElement(By.ClassName("s-image")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    product.IdEcommerce = "A";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            driver.Url = "https://www.ebay.it/";
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("s-item__title")).Text;
                    product.Price = ele.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
                    product.PathPhoto = ele.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
                    product.IdEcommerce = "B";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            //Assert
            elencoProdotti.Count.Should().BeInRange(115, 130);
        }

        [Fact]
        public void SitesTest_1()
        {
            //Arrange
            string nomeProdottoDaCercare = "palla da basket";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.amazon.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[3]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("a-size-base-plus")).Text;
                    product.Price = decimal.Parse(ele.FindElement(By.ClassName("a-price-whole")).Text) + ele.FindElement(By.ClassName("a-price-symbol")).Text;
                    product.PathPhoto = ele.FindElement(By.ClassName("s-image")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    product.IdEcommerce = "A";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            driver.Url = "https://www.ebay.it/";
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("s-item__title")).Text;
                    product.Price = ele.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
                    product.PathPhoto = ele.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
                    product.IdEcommerce = "B";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            var prodotto = elencoProdotti[0];
            //Assert
            Assert.Equal("Amazon Basics - Palla da basket composita in PU", prodotto.Name);
            Assert.Equal("21,44€", prodotto.Price);
            Assert.Equal("https://m.media-amazon.com/images/I/91BfjS5PFSL._AC_UL320_.jpg", prodotto.PathPhoto);
            Assert.NotEqual("https://www.amazon.it/gp/slredirect/picassoRedirect.html/ref=pa_sp_atf_aps_sr_pg1_1?ie=UTF8&adId=A003119025DZU2KJQC0Y6&url=%2FAmazonBasics-basket-composita-dimensioni-ufficiali%2Fdp%2FB07VL3NHMY%2Fref%3Dsr_1_1_sspa%3F__mk_it_IT%3D%25C3%2585M%25C3%2585%25C5%25BD%25C3%2595%25C3%2591%26keywords%3Dpalla%2Bda%2Bbasket%26qid%3D1645363642%26sr%3D8-1-spons%26psc%3D1&qualifier=1645363902&id=8480469944828774&widgetName=sp_atf", prodotto.Link);
            Assert.Equal("A", prodotto.IdEcommerce);
        }

        [Fact]
        public void SitesTest_2()
        {
            //Arrange
            string nomeProdottoDaCercare = "tavolo";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.amazon.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[3]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("a-size-base-plus")).Text;
                    product.Price = decimal.Parse(ele.FindElement(By.ClassName("a-price-whole")).Text) + ele.FindElement(By.ClassName("a-price-symbol")).Text;
                    product.PathPhoto = ele.FindElement(By.ClassName("s-image")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    product.IdEcommerce = "A";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            driver.Url = "https://www.ebay.it/";
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("s-item__title")).Text;
                    product.Price = ele.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
                    product.PathPhoto = ele.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
                    product.IdEcommerce = "B";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            var prodotto = elencoProdotti[10];
            //Assert
            Assert.Equal("TemaHome Nice, Tavolo da Pranzo, White & Oak (Bianco/Beige), 110 x 70 x 73 cm", prodotto.Name);
            Assert.Equal("80,79€", prodotto.Price);
            Assert.Equal("https://m.media-amazon.com/images/I/61YC3-8miIL._AC_UL320_.jpg", prodotto.PathPhoto);
            Assert.NotEqual("https://www.amazon.it/TemaHome-Tavolo-Pranzo-Bianco-Rovere/dp/B07HSDBQXS/ref=sr_1_8?__mk_it_IT=%C3%85M%C3%85%C5%BD%C3%95%C3%91&keywords=tavolo&qid=1645364246&sr=8-8", prodotto.Link);
            Assert.Equal("A", prodotto.IdEcommerce);
        }

        [Fact]
        public void SitesTest_3()
        {
            //Arrange
            string nomeProdottoDaCercare = "pane";

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.amazon.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[3]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("a-size-base-plus")).Text;
                    product.Price = decimal.Parse(ele.FindElement(By.ClassName("a-price-whole")).Text) + ele.FindElement(By.ClassName("a-price-symbol")).Text;
                    product.PathPhoto = ele.FindElement(By.ClassName("s-image")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    product.IdEcommerce = "A";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            driver.Url = "https://www.ebay.it/";
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement ele in element)
            {
                Guid guid = Guid.NewGuid();
                try
                {
                    Prodotto product = new Prodotto();
                    product.Id = guid.ToString();
                    product.Name = ele.FindElement(By.ClassName("s-item__title")).Text;
                    product.Price = ele.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
                    product.PathPhoto = ele.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
                    product.IdEcommerce = "B";
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            var prodotto = elencoProdotti[5];
            //Assert
            Assert.Equal("Nutrifree Panbauletto - 300 gr", prodotto.Name);
            Assert.Equal("2,99€", prodotto.Price);
            Assert.Equal("https://m.media-amazon.com/images/I/71JKDVWBnfL._AC_UL320_.jpg", prodotto.PathPhoto);
            Assert.NotEqual("https://www.amazon.it/Nutri-Free-Panbauletto-0-3-gr/dp/B07P8JNGB8/ref=sr_1_5?__mk_it_IT=%C3%85M%C3%85%C5%BD%C3%95%C3%91&keywords=pane&qid=1645374107&sr=8-5", prodotto.Link);
            Assert.Equal("A", prodotto.IdEcommerce);
        }
        #endregion
    }
}
