using System;
using System.Collections.Generic;
using System.Linq;
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
            Product asd = new Product();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[1]/span/form/div[2]/span[1]/span/input")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div[1]/input")).SendKeys("palla da basket");
            driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[4]/div/span/input")).Click();
            var element = driver.FindElements(By.ClassName("sg-col-4-of-12"));
            List<string> lista = new List<string>();
            foreach (WebElement a in element)
            {
                try
                {
                    asd.Name = a.FindElement(By.ClassName("a-size-large")).Text;
                    asd.Description = a.FindElement(By.ClassName("a-unordered-list a-vertical a-spacing-mini")).Text;
                    asd.Price = decimal.Parse(a.FindElement(By.ClassName("a-price-whole")).Text);
                    asd.Price = decimal.Parse(a.FindElement(By.ClassName("a-price-fraction")).Text);
                    asd.Date = DateTime.Parse(a.FindElement(By.ClassName("a-text-bold")).Text);
                    asd.PathPhoto = a.FindElement(By.ClassName("https://m.media-amazon.com/images/I/71iHRMQFUFL._AC_UL320_.jpg")).Text;
                    listaprodotti.Add(asd);
                }
                catch
                {

                }
            }

            driver.Url = "https://www.ebay.it/";
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[5]/div[1]/div[2]/div[2]/div[2]/button[2]")).Click();
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[1]/div[1]/div/input[1]")).SendKeys("palla da basket");
            driver.FindElement(By.XPath("/html/body/header/table/tbody/tr/td[3]/form/table/tbody/tr/td[3]/input")).Click();
            element = driver.FindElements(By.ClassName("s-item"));
            foreach (WebElement a in element)
            {
                try
                {
                    lista.Add(a.FindElement(By.ClassName("s-item__title")).Text + "\n" + a.FindElement(By.ClassName("s-item__price")).Text + "\n-------------------------------------------------------------------------------------------\n");
                }
                catch { }
            }
            foreach (string x in lista)
            {
                Console.WriteLine(x);
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
    
