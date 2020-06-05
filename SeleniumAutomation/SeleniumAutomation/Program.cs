using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace SeleniumAutomation
{
    class Program
    {
        static string url = @"https://www.google.com";
        static string imgPath = @"D:\SeleniumTestingScreenshot1.jpg";
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");//Comment if we want to see the window. 
            var driver = new ChromeDriver(@"E:\git\Automation\SeleniumAutomation\SeleniumAutomation\packages\Selenium.WebDriver.ChromeDriver.2.36.0\driver\win32", options);
            driver.Navigate().GoToUrl(url);
            var screenshot = (driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile(imgPath, ImageFormat.Jpeg);
            driver.Close();
            driver.Quit();
        }
    }
}
