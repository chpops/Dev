using System;
using System.Diagnostics;
using Xunit;

namespace Dev.E2e
{
	public class Test:E2eMain
	{
		[Fact]
		public void First()
		{
			var presentation = WaitByXpathContains("�������� ���� �������");

			if(presentation!=null)
			{
				driver.FindElement(ByXPathContains("������"));

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

			else
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
		}
	}
}
