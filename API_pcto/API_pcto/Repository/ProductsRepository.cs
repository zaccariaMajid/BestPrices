using API_pcto.Context;
using API_pcto.Entities;
using API_pcto.Interfaces;
using Dapper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace API_pcto
{
    public class ProductsRepository : IProductsRepository
    {

        public List<Prodotto> nuovoProdotto(string nomeProdottoDaCercare)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            WebDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));

            driver.Url = "https://www.amazon.it/";
            List<Prodotto> elencoProdotti = new List<Prodotto>();

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[2]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys(nomeProdottoDaCercare);
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            foreach (WebElement ele in element)
            {
                try
                {
                    Prodotto product = new Prodotto();
                    product.Name = ele.FindElement(By.ClassName("a-size-base-plus")).Text;
                    product.Price = decimal.Parse(ele.FindElement(By.ClassName("a-price-whole")).Text) + ele.FindElement(By.ClassName("a-price-symbol")).Text;
                    product.PathPhoto = ele.FindElement(By.ClassName("s-image")).GetAttribute("src");
                    product.Link = ele.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    elencoProdotti.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //driver.Url = "https://www.ebay.it/";
            //Thread.Sleep(1000);
            //driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys(nomeProdottoDaCercare);
            //driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            //element = driver.FindElements(By.ClassName("s-item"));
            //foreach (WebElement ele in element)
            //{
            //    try
            //    {
            //        Prodotto product = new Prodotto();
            //        //productForCreation product = new productForCreation();
            //        product.Name = ele.FindElement(By.ClassName("s-item__title")).Text;
            //        product.Price = ele.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
            //        product.PathPhoto = ele.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
            //        product.Link = ele.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
            //        elencoProdotti.Add(product);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //}
            return elencoProdotti;
        }

        private readonly DapperContext _context;
        public ProductsRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Prodotto>> GetProducts()
        {
            var query = "SELECT * FROM prodotto";
            using (var connection = _context.CreateConnection())
            {
                var prodotti = await connection.QueryAsync<Prodotto>(query);
                return prodotti.ToList();
            }
        }

        public async Task CreateProduct(string nomeProdottoDaCercare)
        {

            var parameters = new DynamicParameters();
            var prodotti = nuovoProdotto(nomeProdottoDaCercare);

            //Prodotto createdProduct = default(Prodotto);
            //int rows = 0;
            foreach (var newProduct in prodotti)
            {
                var query = "INSERT INTO prodotto(id, name, price, link, pathPhoto, idEcommerce) VALUES (@IdProdotto, @Name, @Price, @Link, @PathPhoto, @IdEcommerce);";
                Guid guid = Guid.NewGuid();
                parameters.Add("IdProdotto", guid.ToString(), DbType.String);
                parameters.Add("Name", newProduct.Name, DbType.String);
                parameters.Add("Price", newProduct.Price, DbType.String);
                parameters.Add("Link", newProduct.Link, DbType.String);
                parameters.Add("PathPhoto", newProduct.PathPhoto, DbType.String);
                parameters.Add("IdEcommerce", "a", DbType.String);
                using (var connection = _context.CreateConnection())
                {
                    await connection.ExecuteAsync(query, parameters);
                }

            }
            //return rows;
        }
    }
}
