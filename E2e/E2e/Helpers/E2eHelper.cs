using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using System.Linq;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;
using System.IO;
using System.Reflection;

namespace Dev.E2e
{
	public partial class E2eHelper
	{
		protected IWebDriver driver;

		public E2eHelper()
		{
			var appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

			ChromeOptions option = new ChromeOptions();
			option.AddArguments("headless","disable-gpu","no-sandbox","window-size=1280,720");
			this.driver=new ChromeDriver(appPath);
			//Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
		}

		protected IWebElement WaitByClass(string className)
		{
			var started = DateTime.Now;
			int timeOut = 15;

			IWebElement result;

			while((result=driver.FindElements(By.ClassName(className)).FirstOrDefault())==null&&(DateTime.Now-started).TotalSeconds<timeOut)
				Sleep(1);

			return result;
		}

		protected IWebElement WaitByClassWithCheck(string className)
		{
			var started = DateTime.Now;
			int timeOut = 60;

			IWebElement result;

			while((result=driver.FindElements(By.ClassName(className)).FirstOrDefault())==null&&(DateTime.Now-started).TotalSeconds<timeOut)
				Sleep(1);

			if(result==null)
			{
				Stop();
				throw new Exception($"element with class name: {className} not loaded! Timeout = {timeOut} sec");
			}
			else
				return result;
		}

		protected IWebElement WaitByXpathContainsWithCheck(string content)
		{
			var started = DateTime.Now;
			int timeOut = 60;

			IWebElement result;

			while((result=driver.FindElements(ByXPathContains(content)).FirstOrDefault())==null&&(DateTime.Now-started).TotalSeconds<timeOut)
				Sleep(1);

			if(result==null)
			{
				Stop();
				throw new Exception($"element with content: {content} not loaded! Timeout = {timeOut} sec");
			}
			else
				return result;
		}

		protected IWebElement WaitByXpathContains(string content)
		{
			var started = DateTime.Now;
			int timeOut = 15;

			IWebElement result;

			while((result=driver.FindElements(ByXPathContains(content)).FirstOrDefault())==null&&(DateTime.Now-started).TotalSeconds<timeOut)
				Sleep(1);

			return result;
		}

		protected void Sleep(int sec) => Thread.Sleep(sec*1000);

		protected By ByXPathContains(string content) => By.XPath($"//*[contains(text(),'{content}')]");

		protected void Stop() => driver.Quit();
	}
}
