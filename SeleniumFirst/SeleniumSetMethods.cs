using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if(value == "Id")
            driver.FindElement(By.Id(element)).SendKeys(value);
            if (value == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value); ;

        }
        //Click into a button, Checkbox, option etc
        public static void Click(IWebDriver driver, string element, string elementtype)
        {

        }
    }
}
