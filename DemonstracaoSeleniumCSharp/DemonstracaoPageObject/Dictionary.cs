using OpenQA.Selenium;

namespace DemonstracaoPageObject
{
    public class Dictionary
    {
        public static readonly string BASE_URL = "https://demo.automationtesting.in";

        public class HOME_PAGE
        {
            public readonly static string URL = BASE_URL + "/Index.html";

            public readonly static By INPUT_EMAIL = By.Id("email");
        }

        public class REGISTER_PAGE
        {
            public readonly static string URL = BASE_URL + "/Register.html";

            public readonly static By INPUT_FIRST_NAME = By.XPath("//input[@placeholder='First Name']");
            public readonly static By INPUT_LAST_NAME = By.XPath("//input[@placeholder='Last Name']");
        }
    }
}