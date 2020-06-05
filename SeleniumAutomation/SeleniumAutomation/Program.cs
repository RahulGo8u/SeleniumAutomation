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
        static string imgPath = @"D:\SeleniumTestingScreenshot.jpg";
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");//Comment if we want to see the window. 
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            driver.Navigate().GoToUrl(url);
            var screenshot = (driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile(imgPath, ImageFormat.Jpeg);
            driver.Close();
            driver.Quit();
        }
    }
}
