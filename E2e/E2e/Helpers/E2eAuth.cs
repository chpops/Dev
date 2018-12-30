using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.E2e
{
	public partial class E2eAuth:E2eHelper
	{
		public E2eAuth()
		{
			var login = "akkaunttestovyj69@gmail.com";
			var password = "IdjLKsi297fsa";

			try
			{
				driver.Navigate().GoToUrl("https://accounts.google.com/ServiceLogin");
				WaitByXpathContainsWithCheck("Телефон или адрес эл. почты");
				driver.FindElement(By.Id("identifierId")).SendKeys(login);
				driver.FindElement(ByXPathContains("Далее")).Click();
			}
			catch
			{
				Stop();
				throw new Exception("[FAILED] - Что-то пошло не так на странице ввода логина");
			}

			try
			{
				WaitByXpathContainsWithCheck("Введите пароль");
				driver.FindElement(By.Name("password")).SendKeys(password);
				driver.FindElement(ByXPathContains("Далее")).Click();
			}
			catch
			{
				Stop();
				throw new Exception("[FAILED] - Что-то пошло не так на странице ввода пароля");
			}
		}
	}
}
