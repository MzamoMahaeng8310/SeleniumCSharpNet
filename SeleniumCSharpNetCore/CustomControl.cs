using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore
{
    public class CustomControl : DriverHelper
    {

        public static void ComboBox(String controlName, String ValueToSelect)
        {
            //The combobox
            IWebElement cmbxAllFoods = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            //C# striing Interpolation is $ and {} enter the variable name
            cmbxAllFoods.Clear();
            cmbxAllFoods.SendKeys(ValueToSelect);
            //Click the item in the combobox
            Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{ValueToSelect}']")).Click();
        }



    }
}
