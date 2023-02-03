using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Automation.Base
{
    public class WebBase : IDisposable
    {

        public IWebDriver Driver { get; private set; }

        public TimeSpan ImplicitWaitDuration = TimeSpan.FromSeconds(15);
        public TimeSpan PageLoadWaitDuration = TimeSpan.FromSeconds(15);
        public TimeSpan AsyncJSDuration = TimeSpan.FromSeconds(15);
        public TimeSpan ExplicitWaitDuration = TimeSpan.FromSeconds(15);

        public WebBase()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = ImplicitWaitDuration;
            Driver.Manage().Timeouts().PageLoad = PageLoadWaitDuration;
            Driver.Manage().Timeouts().AsynchronousJavaScript = AsyncJSDuration;
            Driver.Navigate().GoToUrl("https://testpages.herokuapp.com/styled/index.html");
        }

        public void GoToUrl(string urlAddress)
        {
            Driver.Navigate().GoToUrl(urlAddress);
        }

        public void ClickElement(string locator)
        {
            Driver.FindElement(By.XPath(locator)).Click();
        }

        public void ClearElement(string locator)
        {
            Driver.FindElement(By.XPath(locator)).Clear();
        }

        public void TypeToElement(string locator, string textToType)
        {

            Driver.FindElement(By.XPath(locator)).SendKeys(textToType);
        }

        public string GetElementText(string locator)
        {
            string elemText = Driver.FindElement(By.XPath(locator)).Text;
            return elemText;
        }

        public string GetCurrentUrl()
        {
            return Driver.Url;
        }

        public string GetPageTitle()
        {
            return Driver.Title;
        }

        public void SelectDropboxByVisibleText(string locator, string textToType)
        {
            
            SelectElement dropDown = new SelectElement(Driver.FindElement(By.XPath(locator)));
            dropDown.SelectByText(textToType);
        }

        public void SelectDropboxByValue(string locator, string optionValue)
        {

            SelectElement dropDown = new SelectElement(Driver.FindElement(By.XPath(locator)));
            dropDown.SelectByValue(optionValue);
        }

        public void SelectDropboxByOptionIndex(string locator, int optionIndex)
        {

            SelectElement dropDown = new SelectElement(Driver.FindElement(By.XPath(locator)));
            dropDown.SelectByIndex(optionIndex);
        }

        public int GetNumberOfElement(string locator)
        {
            int NumOfElems = Driver.FindElements(By.XPath(locator)).Count;
            return NumOfElems;
        }

        public void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, ExplicitWaitDuration);
            wait.Until(EC.ElementIsVisible(By.XPath(locator)));
        }

        public void WaitForElementToBeInvisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, ExplicitWaitDuration);
            wait.Until(EC.InvisibilityOfElementLocated(By.XPath(locator)));
        }

        public bool CheckElementExist(string locator)
        {
            try
            {
                Driver.FindElement(By.XPath(locator));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void ScrollToBottomOfThePage()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
        public void ScrollToElement(string locator)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView()", Driver.FindElement(By.XPath(locator)));
        }

        public void Dispose()
        {
            Driver.Dispose();
            Driver.Quit();
        }
    }
}
