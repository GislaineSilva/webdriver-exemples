using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using SeleniumTest.POM;

namespace SeleniumTest
{
    [TestClass]
    public class GoogleTests
    {
        [TestMethod]
        public void TestSearchPluralSight()
        {
            using (var driver = new ChromeDriver(@"C:\libraries\"))
            {
                var page = new GooglePage(driver);

                page.OpenPage();
                page.FillSearchBox("Pluralsight");
                var resultPage = page.ClickSearchButton();

                Assert.AreEqual(
                    resultPage.FirstLink.Text,
                    "Pluralsight.com | Pluralsight Online Tutor | Save $100 Now",
                    "The text on the first result was different of the one expected");
            }
        }

        [TestMethod]
        public void TestSearchMicrosoft()
        {
            using (var driver = new ChromeDriver(@"C:\libraries\"))
            {
                var page = new GooglePage(driver);

                page.OpenPage();
                page.FillSearchBox("microsoft");
                var resultPage = page.ClickSearchButton();

                Assert.IsTrue(
                    resultPage.FirstLink.Text.ToLower().Contains("microsoft"),
                    "The text on the first result was different of the one expected");
            }
        }
    }
}
