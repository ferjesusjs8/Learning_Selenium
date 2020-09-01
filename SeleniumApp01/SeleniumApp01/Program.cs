using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);
            driver.Manage().Window.Maximize();
                        
            Thread.Sleep(1000);

            driver.Navigate().GoToUrl("https://www.google.com");
            WriteArt(driver, "Agora eu Fernando");
            WriteArt(driver, "sou DEV de RPA também!!");
            WriteArt(driver, "Vlews!! :D");
            WriteArt(driver, "Veja meus Projetos no GitHub");

            Thread.Sleep(500);

            driver.Navigate().GoToUrl("https://github.com/ferjesusjs8");

            Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://sourcerer.io/ferjesusjs8");

            Thread.Sleep(2000);

            ScrollDownPageToElement(driver, actions, "langs-section");
            Thread.Sleep(1000);

            ScrollDownPageToElement(driver, actions, "tech-section");
            Thread.Sleep(1000);

            ScrollDownPageToElement(driver, actions, "fun-facts-section");
            Thread.Sleep(1000);

            driver.Navigate().GoToUrl("https://www.youtube.com/watch?v=VSVkDi2G_I4&vq=hd1080");
            Thread.Sleep(10000);

            driver.Quit();
        }

        private static void ScrollDownPageToElement(IWebDriver driver, Actions actions, string id)
        {
            var e = driver.FindElement(By.Id(id));

            actions.MoveToElement(e).Perform();
        }

        private static void WriteArt(IWebDriver driver, string text)
        {
            driver.FindElement(By.Name("q")).SendKeys(text);
            Thread.Sleep(500);
            driver.FindElement(By.Name("q")).Clear();
        }
    }
}
