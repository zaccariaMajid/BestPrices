using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Web_Scraping
{
    class Program
    {
        static void Main(string[] args)
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://www.amazon.it/";
            List<Product> listaprodotti = new List<Product>();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[2]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys("palla da basket");
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            string pagesource = driver.PageSource;
            List<string> lista = new List<string>();
            foreach (WebElement a in element)
            {
                try
                {
                    Product asd = new Product();
                    asd.Name = a.FindElement(By.ClassName("a-size-base-plus")).Text;
                    asd.Price = decimal.Parse(a.FindElement(By.ClassName("a-price-whole")).Text) + a.FindElement(By.ClassName("a-price-symbol")).Text;
                    asd.PathPhoto = driver.FindElement(By.ClassName("s-image")).GetAttribute("src");
                   // asd.Link = driver.FindElement(By.ClassName("a-link-normal")).GetAttribute("href");
                    listaprodotti.Add(asd);
                }
                catch
                {
                   
                }       
            }

            driver.Url = "https://www.ebay.it/";
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys("palla da basket");
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement a in element)
            {
                try
                {
                    Product asd = new Product();
                    asd.Name = a.FindElement(By.ClassName("s-item__title")).Text;
                    asd.Price = a.FindElement(By.ClassName("s-item__price")).Text.Split(" ")[1];
                    asd.PathPhoto = a.FindElement(By.ClassName("s-item__image-img")).GetAttribute("src");
                   // asd.Link = driver.FindElement(By.ClassName("s-item__link")).GetAttribute("href");
                    listaprodotti.Add(asd);
                }
                catch
                {

                }
            }
            Console.ReadKey();
        }
        private static bool IsElementPresent(By by, WebDriver driver)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}