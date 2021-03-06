using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium; //add Webdriver downloaded from add Nuget
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

//TRANSLATE FROM ENGLISH TO DANISH AND CLICK ON LANGUAGE SWAP

namespace Challenge_LanguageWire_3
{
    class Program3
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Test 3!");


            using IWebDriver driver = new FirefoxDriver(); //driver will be the object in order to control browser

            driver.Navigate().GoToUrl("https://demo-qa-interview-lwt.staging.lw-ml.net/en/?token=%2Fc1GhVuGfgguExbjPGInJcHKcxIzRWdXOaHvOoU0BiY%3D.eyJOb25jZSI6ICJOb25jZSIsICJGaXJzdE5hbWUiOiAiUUEtRmlyc3ROYW1lIiwgIkxhc3ROYW1lIjogIlFBLUxhc3ROYW1lIiwgIlBob3RvRnNlSWQiOiAiUUEtUGhvdG9Gc2VJZCIsICJVc2VySWQiOiAxLCAiRGVmYXVsdENvbXBhbnlJZCI6IDEsICJMd3RTdWJzY3JpcHRpb25JZCI6IDQyLCAiUGVybWlzc2lvbnMiOiBbMzA5Ml0sICJFeHBpcmF0aW9uVGltZSI6ICIvRGF0ZSgxNjQ3NTkwNjIwNzQwKS8ifQ%3D%3D"); //open the link 
            driver.Manage().Window.Maximize(); //maximize window       

            //Explicit wait until website is loaded
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));

            //Declare the object for selecting input/output Language 
            new SelectElement(driver.FindElement(By.Id(""))).SelectByText("English");//not working as I do not know by which element I need to find this
            new SelectElement(driver.FindElement(By.Id(""))).SelectByText("Danish");//same as above


            //Writing input text to be translated
            IWebElement input = driver.FindElement(By.Name("translation-input")); //find by name but giving error 
            input.SendKeys("Hello Language Wire, my name is Eduardo.");//send our text to the input variable



            //Swap languages

            driver.FindElement(By.XPath("//input[@type='button']")).Click();



            Console.WriteLine("Test 3 done!");


        }
    }
}
