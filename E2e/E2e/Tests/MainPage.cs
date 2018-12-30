using System;
using System.Diagnostics;
using Xunit;

namespace Dev.E2e
{
	public class MainPage : E2eMain
	{
		// ������� ��������
		[Fact]
		public void Test1()
		{
			var presentation = WaitByXpathContains("����� ����������, �������� �������!");

			if ( presentation!=null )
			{
				try
				{
					WaitByXpathContainsWithCheck("����� ����������, �������� �������!");
					WaitByXpathContainsWithCheck("�������");
					WaitByXpathContainsWithCheck("������ ������");
					WaitByXpathContainsWithCheck("������ � ��������������");
					WaitByXpathContainsWithCheck("������������");
					WaitByXpathContainsWithCheck("��������� �������");
					WaitByXpathContainsWithCheck("������� � ��������");
					WaitByXpathContainsWithCheck("�������");
					WaitByXpathContainsWithCheck("��������� �����");

					Stop();
					Debug.WriteLine("[DONE] - ���! ���� ������ �������!");
				}
				catch
				{
					Stop();
					throw new Exception("[FAILED] - ���-�� ����� �� ��� :(");
				}
			}

			else
			{
				driver.FindElement(ByXPathContains("������")).Click();

				try
				{
					WaitByXpathContainsWithCheck("����� ����������, �������� �������!");
					WaitByXpathContainsWithCheck("�������");
					WaitByXpathContainsWithCheck("������ ������");
					WaitByXpathContainsWithCheck("������ � ��������������");
					WaitByXpathContainsWithCheck("������������");
					WaitByXpathContainsWithCheck("��������� �������");
					WaitByXpathContainsWithCheck("������� � ��������");
					WaitByXpathContainsWithCheck("�������");
					WaitByXpathContainsWithCheck("��������� �����");
				}
				catch
				{
					Stop();
					throw new Exception("[FAILED] - ������� ��������� ������ � ������ ��������, � ����� ���� ����� '������', �� ����� ���-�� ����� �� ��� :(");
				}
			}
		}
	}
}
