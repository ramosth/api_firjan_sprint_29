using DemonstracaoPageObject;

using NUnit.Framework;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;

using System;
using System.IO;
using System.Linq;

namespace DemonstracaoTesteSelenium
{
    [TestFixture]
    public class SuiteHomePage
    {
        public ChromeDriver driver;

        public HomePage homePage;

        string projectFolder = AppDomain.CurrentDomain.BaseDirectory.Replace(@"bin\Debug", "").Replace(@"bin\Release", "");
        string testName;
        string screenshotFolder;

        [OneTimeSetUp]
        public void PreTesteGeral()
        {
            // Configuração do teste
            driver = new ChromeDriver(projectFolder + @"\Resources\Drivers");
            driver.Manage().Window.Maximize();

            // Instanciação dos Page Objects
            homePage = new HomePage(driver);
        }

        [SetUp]
        public void PreTeste()
        {
            testName = TestContext.CurrentContext.Test.MethodName.Split('.').Last();
            screenshotFolder = projectFolder + @"Evidences\" + testName + @"\" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss");
            Directory.CreateDirectory(screenshotFolder);

            homePage.NavegarParaPagina();
        }

        [Test]
        public void Teste01()
        {            
            homePage.InformarEmail("automacao@ilab.com");
            Console.WriteLine("Informou \"automacao@ilab.com\" no campo \"e-mail\".");
            Assert.IsTrue(homePage.EmailFoiInformado());
            Console.WriteLine("Validou que o campo \"e-mail\" foi informado.");
            driver.TakeScreenshot().SaveAsFile(screenshotFolder + @"\teste_resultado.png");
        }

        [TearDown]
        public void PosTeste()
        {
            Console.WriteLine(testName + " finalizado.");
        }

        [OneTimeTearDown]
        public void PosTesteGeral()
        {
            driver.Quit();
        }
    }
}