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
			driver.Navigate().GoToUrl("https://esfebodega.netlify.app");

			// Espera un momento para que se carguen los resultados
			System.Threading.Thread.Sleep(5000);

			var nombre = driver.FindElement(By.Id("dui"));

			nombre.SendKeys("000000000");

			var precio = driver.FindElement(By.Id("password"));

			precio.SendKeys("susadmin");

			// Encuentra el cuadro de búsqueda
			var btn = driver.FindElement(By.ClassName("btn-primary"));

			btn.Click();
			// Espera un momento para que se carguen los resultados
			System.Threading.Thread.Sleep(2000);

			// Encuentra el cuadro de búsqueda
			var btn1 = driver.FindElement(By.LinkText("Roles"));

			btn1.Click();

			// Espera un momento para que se carguen los resultados
			System.Threading.Thread.Sleep(1000);

			// Encuentra el cuadro de búsqueda
			var btn2 = driver.FindElement(By.ClassName("btn-success"));

			btn2.Click();


			// Espera un momento para que se carguen los resultados
			System.Threading.Thread.Sleep(1000);

			var nombreRol = driver.FindElement(By.Id("Nombre"));

			nombreRol.SendKeys("ADMINPRUEBA");

			var descripcion = driver.FindElement(By.Id("Descripcion"));

			descripcion.SendKeys("ES UNA PRUEBA ");

			var btnGuardar = driver.FindElement(By.ClassName("btn-primary"));

			btnGuardar.Click();

			System.Threading.Thread.Sleep(1000);

			var regresar = driver.FindElement(By.ClassName("btn-success"));

			regresar.Click();

			System.Threading.Thread.Sleep(3000);


			//
			// Encuentra el cuadro de búsqueda
			var btn10 = driver.FindElement(By.LinkText("Bodega"));

			btn10.Click();

			// Espera un momento para que se carguen los resultados
			System.Threading.Thread.Sleep(1000);

			// Encuentra el cuadro de búsqueda
			var btn20 = driver.FindElement(By.ClassName("btn-success"));

			btn20.Click();


			// Espera un momento para que se carguen los resultados
			System.Threading.Thread.Sleep(1000);

			var nombreBodega = driver.FindElement(By.Id("Nombre"));

			nombreBodega.SendKeys("PRUEBABODEGA");

			var descripcionBodega = driver.FindElement(By.Id("Descripcion"));

			descripcionBodega.SendKeys("ES UNA PRUEBA ");

			var btnGuardar1 = driver.FindElement(By.ClassName("btn-primary"));

			btnGuardar1.Click();

			System.Threading.Thread.Sleep(1000);

			var regresar1 = driver.FindElement(By.ClassName("btn-success"));

			regresar1.Click();

			System.Threading.Thread.Sleep(3000);


		}

		public void Dispose()
		{
			// Cierra el navegador
			driver.Quit();
		}
	}
}
 