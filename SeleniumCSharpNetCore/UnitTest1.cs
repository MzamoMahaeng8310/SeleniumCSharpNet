using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Interactions;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {
        //public  IWebDriver driver;

        [SetUp]
        public void Setup()
        {

            // execute headless
            //ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--headless");
            //Console.WriteLine("Setup");
            //Driver = new ChromeDriver(options);

            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
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

       // [Test]
        //public void scrollJavaScript()
        //{
        //    driver.Navigate().GoToUrl("http://en.wikipedia.org");
        //    ///driver.Manage().Window.FullScreen();


        //    ////Scroll virtical top to bottom
        //    ////IJavaScriptExecutor js = driver as IJavaScriptExecutor;
        //    //IJavaScriptExecutor js = (IJavaScriptExecutor)driver; // casting the driver
        //    //System.Threading.Thread.Sleep(5000);
        //    //js.ExecuteScript("window.scrollBy(0,3000);");
        //    //Console.WriteLine("Tets 1");
        //    //Assert.Pass();
        //    ////driver.Close();


        //    //You should use Actions class to perform scrolling to element.
        //    //use this library using OpenQA.Selenium.Interactions;
        //    var element = driver.FindElement(By.XPath("//a[contains(text(),'Community portal')]"));
        //    Actions actions = new Actions(driver);
        //    actions.MoveToElement(element);
        //    actions.Perform();
        //    element.Click();

        //    ////You should use Actions class to perform scrolling to element.
        //    IJavaScriptExecutor jsscroll = (IJavaScriptExecutor) driver; // cast the driver into IJavaScriptExecutor
        //    //IJavaScriptExecutor jsscroll = driver as IJavaScriptExecutor;
        //    var elem = driver.FindElement(By.XPath("//a[contains(text(),'Community portal')]"));
        //    jsscroll.ExecuteScript("arguments[0].scrollIntoView(true);", elem);
        //    elem.Click();
           

        //    //If you want to scroll horizontally in the right direction, use the following JavaScript.
        //    //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //    //js.ExecuteScript("windot.scrollBy(2000,0)");

        //    //If you want to scroll horizontally in the left direction, use the following JavaScript.
        //    // IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //    //js.ExecuteScript("window.scrollBy(-2000,0)");

        //    //Virtical scroll scroll from up to down
        //    //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //    //js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");



        //}
        [Test]
        public void Part3Lesson()
        {

            Driver.Navigate().GoToUrl("https:///demowf.aspnetawesome.com/");
            //type in the auto complete checkbox
            IWebElement txtBox = Driver.FindElement(By.Id("ContentPlaceHolder1_Meal"));
            txtBox.SendKeys("Tomato");
            //select the ajax checkbox
            IWebElement chkAjaxCheckBox = Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']//following-sibling::div[text()='Cauliflower']"));
            chkAjaxCheckBox.Click();

            //string comboxControlName = "ontentPlaceHolder1_AllMealsCombo";
            // CustomControl control = new CustomControl();
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Tomato");

                                

            Console.WriteLine("Part3Lesson");

            Assert.Pass();
            Driver.Quit();
      

        }

    }
}