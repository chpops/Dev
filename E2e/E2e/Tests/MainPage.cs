using System;
using System.Diagnostics;
using Xunit;

namespace Dev.E2e
{
	public class MainPage : E2eMain
	{
		// Главная страница
		[Fact]
		public void Test1()
		{
			var presentation = WaitByXpathContains("Добро пожаловать, Тестовый Аккаунт!");

			if ( presentation!=null )
			{
				try
				{
					WaitByXpathContainsWithCheck("Добро пожаловать, Тестовый Аккаунт!");
					WaitByXpathContainsWithCheck("Главная");
					WaitByXpathContainsWithCheck("Личные данные");
					WaitByXpathContainsWithCheck("Данные и персонализация");
					WaitByXpathContainsWithCheck("Безопасность");
					WaitByXpathContainsWithCheck("Настройки доступа");
					WaitByXpathContainsWithCheck("Платежи и подписки");
					WaitByXpathContainsWithCheck("Справка");
					WaitByXpathContainsWithCheck("Отправьте отзыв");

					Stop();
					Debug.WriteLine("[DONE] - Ура! Тест прошёл успешно!");
				}
				catch
				{
					Stop();
					throw new Exception("[FAILED] - Что-то пошло не так :(");
				}
			}

			else
			{
				driver.FindElement(ByXPathContains("Готово")).Click();

				try
				{
					WaitByXpathContainsWithCheck("Добро пожаловать, Тестовый Аккаунт!");
					WaitByXpathContainsWithCheck("Главная");
					WaitByXpathContainsWithCheck("Личные данные");
					WaitByXpathContainsWithCheck("Данные и персонализация");
					WaitByXpathContainsWithCheck("Безопасность");
					WaitByXpathContainsWithCheck("Настройки доступа");
					WaitByXpathContainsWithCheck("Платежи и подписки");
					WaitByXpathContainsWithCheck("Справка");
					WaitByXpathContainsWithCheck("Отправьте отзыв");
				}
				catch
				{
					Stop();
					throw new Exception("[FAILED] - Сначало выскачило окошко о защите аккаунта, я вроде даже нажал 'Готово', но потом что-то пошло не так :(");
				}
			}
		}
	}
}
