using System;
using System.Diagnostics;
using Xunit;

namespace Dev.E2e
{
	public partial class PersonalDataPage : E2eMain
	{
		// Страница с личными данными
		[Fact]
		public void Test1()
		{
			var presentation = WaitByXpathContains("Добро пожаловать, Тестовый Аккаунт!");

			if (presentation!=null)
			{
				WaitByXpathContains("Личные данные").Click();

				try
				{
					WaitByXpathContainsWithCheck("Основная информация (например, имя и фото), которую вы используете в сервисах Google.");
					WaitByXpathContainsWithCheck("Некоторая информация может быть видна другим пользователям сервисов Google. ");
					WaitByXpathContainsWithCheck("Профиль");
					WaitByXpathContainsWithCheck("Фотография");
					WaitByXpathContainsWithCheck("Имя");
					WaitByXpathContainsWithCheck("Дата рождения");
					WaitByXpathContainsWithCheck("Пол");
					WaitByXpathContainsWithCheck("Пароль");
				}
				catch
				{
					Stop();
					throw new Exception("[FAIL] - На странице 'Личные данные' чего-то не хватает в блоке 'Профиль'");
				}

				try
				{
					WaitByXpathContainsWithCheck("Контактная информация");
					WaitByXpathContainsWithCheck("Электронная почта");
					WaitByXpathContainsWithCheck("Телефон");
				}
				catch
				{
					Stop();
					throw new Exception("[FAIL] - На странице 'Личные данные' чего-то не хватает в блоке 'Контактная информация'");
				}

				try
				{
					WaitByXpathContainsWithCheck("Доступ к данным о вас");
					WaitByXpathContainsWithCheck("Вы можете указать, какая личная информация будет видна другим пользователям в сервисах Google.");
				}
				catch
				{
					Stop();
					throw new Exception("[FAIL] - На странице 'Личные данные' чего-то не хватает в блоке 'Доступ к данным о вас'");
				}

				try
				{
					WaitByXpathContainsWithCheck("Политика конфиденциальности");
					WaitByXpathContainsWithCheck("Условия использования");
					WaitByXpathContainsWithCheck("Справка");

					Stop();
					Debug.WriteLine("[DONE] - Personal Data Test Done!");
				}
				catch
				{
					Stop();
					throw new Exception("[FAIL] - На странице 'Личные данные' чего-то не хватает в подвале");
				}
			}
			else
			{
				driver.FindElement(ByXPathContains("Готово")).Click();
				WaitByXpathContains("Личные данные").Click();

				try
				{
					WaitByXpathContainsWithCheck("Основная информация (например, имя и фото), которую вы используете в сервисах Google.");
					WaitByXpathContainsWithCheck("Некоторая информация может быть видна другим пользователям сервисов Google. ");
					WaitByXpathContainsWithCheck("Профиль");
					WaitByXpathContainsWithCheck("Фотография");
					WaitByXpathContainsWithCheck("Имя");
					WaitByXpathContainsWithCheck("Дата рождения");
					WaitByXpathContainsWithCheck("Пол");
					WaitByXpathContainsWithCheck("Пароль");
				}
				catch
				{
					Stop();
					throw new Exception("[FAIL] - На странице 'Личные данные' чего-то не хватает в блоке 'Профиль'");
				}

				try
				{
					WaitByXpathContainsWithCheck("Контактная информация");
					WaitByXpathContainsWithCheck("Электронная почта");
					WaitByXpathContainsWithCheck("Телефон");
				}
				catch
				{
					Stop();
					throw new Exception("[FAIL] - На странице 'Личные данные' чего-то не хватает в блоке 'Контактная информация'");
				}

				try
				{
					WaitByXpathContainsWithCheck("Доступ к данным о вас");
					WaitByXpathContainsWithCheck("Вы можете указать, какая личная информация будет видна другим пользователям в сервисах Google.");
				}
				catch
				{
					Stop();
					throw new Exception("[FAIL] - На странице 'Личные данные' чего-то не хватает в блоке 'Доступ к данным о вас'");
				}

				try
				{
					WaitByXpathContainsWithCheck("Политика конфиденциальности");
					WaitByXpathContainsWithCheck("Условия использования");
					WaitByXpathContainsWithCheck("Справка");

					Stop();
					Debug.WriteLine("[DONE] - Personal Data Test Done!");
				}
				catch
				{
					Stop();
					throw new Exception("[FAIL] - На странице 'Личные данные' чего-то не хватает в подвале");
				}
			}
		}
	}
}
