using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {

        //create the reference for our browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            
        }
        [SetUp]
        public void Initialize ()
        {
            //navigate to Google page
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Enter text(element, value, type)


            //Find the element
            IWebElement element = driver.FindElement(By.Name("q"));
            //Perform Ops
            element.SendKeys("executeautomation");
            Console.WriteLine("Execute Test");
        }

        [Test]
        public void NextTest()
        {
            //Find the element
            IWebElement element = driver.FindElement(By.Name("q"));
            //Perform Ops
            element.SendKeys("executeautomation");
            Console.WriteLine("Execute Test");

        }


        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Close the browser");
        }
    }

}
