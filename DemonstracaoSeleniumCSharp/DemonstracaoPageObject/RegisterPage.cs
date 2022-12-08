using OpenQA.Selenium;

namespace DemonstracaoPageObject
{
    public class RegisterPage : Dictionary
    {
        IWebDriver driver;

        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavegarParaPagina()
        {
            driver.Navigate().GoToUrl(REGISTER_PAGE.URL);
        }

        public void InformarFirstName(string firstName)
        {
            driver.FindElement(REGISTER_PAGE.INPUT_FIRST_NAME).SendKeys(firstName);
        }

        public bool FirstNameFoiInformado()
        {
            return !driver.FindElement(REGISTER_PAGE.INPUT_FIRST_NAME).GetAttribute("value").Equals("");
        }

        public void InformarLastName(string lastName)
        {
            driver.FindElement(REGISTER_PAGE.INPUT_LAST_NAME).SendKeys(lastName);
        }
    }
}