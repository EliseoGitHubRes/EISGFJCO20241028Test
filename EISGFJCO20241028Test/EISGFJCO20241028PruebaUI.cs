using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EISGFJCO20241028Test
{
	[TestClass]
	public class EISGFJCO20241028PruebaUI : IDisposable
	{
		private IWebDriver driver;

		public EISGFJCO20241028PruebaUI()
		{
			// Inicializa el controlador de Chrome
			driver = new ChromeDriver();
		}

		[TestMethod]
		public void Blazor()
		{
			// Navega a Google
			driver.Navigate().GoToUrl("https://esfebodega.netlify.app/login");

			// Espera un momento para que se carguen los resultados
			System.Threading.Thread.Sleep(1000);

			// Encuentra el cuadro de búsqueda
			var btn = driver.FindElement(By.ClassName("btn btn-primary"));

			btn.Click();
			// Espera un momento para que se carguen los resultados
			System.Threading.Thread.Sleep(1000);

		}

		public void Dispose()
		{
			// Cierra el navegador
			driver.Quit();
		}
	}
}
