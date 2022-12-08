using OpenQA.Selenium;

namespace DemonstracaoPageObject
{
    public class HomePage : Dictionary
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavegarParaPagina()
        {
            driver.Navigate().GoToUrl(HOME_PAGE.URL);
        }

        public void InformarEmail(string email)
        {
            driver.FindElement(HOME_PAGE.INPUT_EMAIL).SendKeys(email);
        }

        public bool EmailFoiInformado()
        {
            return !driver.FindElement(HOME_PAGE.INPUT_EMAIL).GetAttribute("value").Equals("");
        }
    }
}