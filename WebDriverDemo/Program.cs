using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          
            IWebDriver driver = new ChromeDriver(@"C:\libraries\");
            driver.Url = @"file:///C:/Users/Anderson/Documents/Gislaine/Projects/WebDriverDemo/WebDriverDemo/index.html";

            //ADVANCED EXEMPLES

            //radiobutoon
            var radioButton = driver.FindElements(By.Name("Color"))[0];
            radioButton.Click();

            //Checkbox
            var checkbox = driver.FindElement(By.Id("check1"));
            checkbox.Click();

            //Select combobox 1
            //var select = driver.FindElement(By.Id("select1"));
            //var frankOption = select.FindElements(By.TagName("option"))[3];
            //frankOption.Click();

            //Select combobox 2
            var select = driver.FindElement(By.Id("select1"));
            var selectElement = new SelectElement(select);
            selectElement.SelectByText("Tom");

            //table 1 
            //var outTable = driver.FindElement(By.TagName("table"));
            //var innerTable = outTable.FindElement(By.TagName("table"));
            //var row = innerTable.FindElements(By.TagName("td"))[0];
            //Console.WriteLine(row.Text);

            //table 2
            var row = driver.FindElement(By.XPath("/html/body/table/tbody/tr[2]/td[2]/table/tbody/tr[1]/td"));
            Console.WriteLine(row.Text);


            // BASIC EXEMPLES
            //driver.Url = "http://www.google.com";

            //var searchBox = driver.FindElement(By.Name("q"));
            //searchBox.SendKeys("Pluralsight images");
            
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //var searchButton = driver.FindElement(By.Name("btnK"));
            //searchButton.Submit();

            //var ImageLink = driver.FindElement(By.ClassName("iu-card-header"));
            //ImageLink.Click();

            //driver.PageSource.Contains("Images for pluralsight images");

            //var firstimagelink = driver.findelement(by.id("s3_a4scqnv83um:"));
            //firstimagelink.click();







        }
    }
}
