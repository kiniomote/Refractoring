using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Lab_4_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// Декомпозиция условного оператора

		private int CalculatedNumber1(int start_number)
		{
			int result = start_number;

			if ((result + 10) * 15 > 1999)
				result = 16 + 12 / 4;
			else
				result = 16 - 12 / 6;

			return result;
		}

		//_______________________________________________

		private int CalculatedNumber2(int start_number)
		{
			int result = start_number;

			if (CheckReuslt(result))
				result = IfTrue(result);
			else
				result = IfFalse(result);

			return result;
		}

		private bool CheckReuslt(int result)
		{
			return (result + 10) * 15 > 1999;
		}

		private int IfTrue(int result)
		{
			return result * 16 + 12 / 4;
		}

		private int IfFalse(int result)
		{
			return result * 16 - 12 / 6;
		}

		// Консолидация условного оператора

		private bool SingUpPerson1(string name, int years, string Id)
		{
			if (name == null)
			{
				return false;
			}

			if (years > 2018)
			{
				return false;
			}

			if (Id.Length < 6 && Id.Length > 9)
			{
				return false;
			}

			//...

			return true;
		}

		//_______________________________________________

		private bool SingUpPerson2(string name, int years, string Id)
		{
			if (CheckValidationPerson(name,years,Id))
			{
				return false;
			}

			//...

			return true;
		}

		private bool CheckValidationPerson(string name, int years, string Id)
		{
			if (name == null)
			{
				return false;
			}

			if (years > 2018)
			{
				return false;
			}

			if (Id.Length < 6 && Id.Length > 9)
			{
				return false;
			}

			return true;
		}

		// Консолидация дублирующихся условных фрагментоа

		private void ShowGederPerson1(string name, string gender)
		{
			if (gender == "man")
			{
				Console.WriteLine("Mr. ");
				Console.WriteLine(name);
			}

			if (gender == "woman")
			{			Console.WriteLine(name);
				Console.WriteLine("Ms. ");
				Console.WriteLine(name);
			}
		}

		//_______________________________________________

		private void ShowGederPerson2(string name, string gender)
		{
			if (gender == "man")
			{
				Console.WriteLine("Mr. ");
			}

			if (gender == "woman")
			{
				Console.WriteLine("Ms. ");
			}

			Console.WriteLine(name);
		}

		// Удаление управляющего флага

		private void FindFirstNegativeNumber1(List<int> numbers)
		{
			bool founded = false;
			int rememb = 0;

			foreach (int number in numbers)
			{
				if (!founded)
					if (number < 0)
					{
						rememb = number;
						founded = true;
					}
			}

			Console.WriteLine(rememb);
		}

		//_______________________________________________

		private void FindFirstNegativeNumber2(List<int> numbers)
		{
			int rememb = 0;

			foreach (int number in numbers)
			{
				if (number < 0)
				{
					rememb = number;
					break;
				}
			}

			Console.WriteLine(rememb);
		}

	}
}
