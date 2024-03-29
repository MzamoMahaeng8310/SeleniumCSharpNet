using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Interactions;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {

        //    // execute headless
        //    ChromeOptions options = new ChromeOptions();
        //    options.AddArguments("--headless");
        //    options.AddArgument("--start-maximized");
        //    // options.AddArguments("start-maximized");
        //    driver = new ChromeDriver(options);

        //    Console.WriteLine("Setup To Execute In Headless Mode");

        // Execute in normal browser mode
        driver = new ChromeDriver();
        Console.WriteLine("Setup");
        
            }

        //[Test]
        ////public void Test1()
        //{
        //    driver.Navigate().GoToUrl("https://executeautomation.com/");
        //    driver.Manage().Window.FullScreen();
        //    Console.WriteLine("Tets 1");
        //    Assert.Pass();
        //    driver.Close();
        //}

        [Test]
        public void ScrollJavaScript()
        {
            driver.Navigate().GoToUrl("http://en.wikipedia.org");
            driver.Manage().Window.FullScreen();


           // Scroll virtical top to bottom
           // IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver; // casting the driver
            System.Threading.Thread.Sleep(5000);
            js.ExecuteScript("window.scrollBy(0,3000);");
            Console.WriteLine("Tets 1");
            Assert.Pass();
            //driver.Close();
            driver.Quit();

            //You should use Actions class to perform scrolling to element.
            //use this library using OpenQA.Selenium.Interactions;
            //var element = driver.FindElement(By.XPath("//a[contains(text(),'Community portal')]"));
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(element);
            //actions.Perform();
            //element.Click();

            //////You should use Actions class to perform scrolling to element.
            //IJavaScriptExecutor jsscroll = (IJavaScriptExecutor)driver; // cast the driver into IJavaScriptExecutor
            //                                                            //IJavaScriptExecutor jsscroll = driver as IJavaScriptExecutor;
            //var elem = driver.FindElement(By.XPath("//a[contains(text(),'Community portal')]"));
            //jsscroll.ExecuteScript("arguments[0].scrollIntoView(true);", elem);
            //elem.Click();


            //If you want to scroll horizontally in the right direction, use the following JavaScript.
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("windot.scrollBy(2000,0)");

            //If you want to scroll horizontally in the left direction, use the following JavaScript.
            // IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollBy(-2000,0)");

            //Virtical scroll scroll from up to down
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");



        }
        //    [Test]
        //public void Part3Lesson()
        //{

        //    driver.Navigate().GoToUrl("https:///demowf.aspnetawesome.com/");
        //    driver.Manage().Window.Maximize();
         
        //    //type in the auto complete checkbox
        //    IWebElement txtBox = driver.FindElement(By.Id("ContentPlaceHolder1_Meal"));
        //    txtBox.SendKeys("Tomato");
        //    //select the ajax checkbox
        //    //IWebElement chkAjaxCheckBox = driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']//following-sibling::div[text()='Cauliflower']"));
        //    //chkAjaxCheckBox.Click();

        //    //string comboxControlName = "ContentPlaceHolder1_AllMealsCombo";
        //    //CustomControl control = new CustomControl();
        //    CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Tomato");
        //    //CustomControl.ComboBox();

        //    Console.WriteLine("Part3Lesson");
        //    Assert.Pass();
        //    driver.Close();
        //    driver.Quit();


        //}

    }
}