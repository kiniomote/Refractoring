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

		// Выделение метода and Встраивание метода

		private int Calculated1()
		{
			int startNumber = 0;

			startNumber++;

			startNumber *= startNumber * 2;
			for (int i = 0; i < 10; i++)
			{
				startNumber += i;
			}

			if (startNumber > 20)
				return 3;
			else
				return 5;
		}

		//__________________________________________

		private int Calculated2()
		{
			if (NumberMoreTwenty(CalculetedStartNumber1(0)))
				return 3;
			else
				return 5;
		}

		private bool NumberMoreTwenty(int number)
		{
			if (number > 20)
				return true;
			else
				return false;
		}

		private int CalculetedStartNumber1(int startnumber)
		{
			int result = startnumber;
			result++;

			result *= result * 2;
			for (int i = 0; i < 10; i++)
			{
				result += i;
			}

			return result;
		}

		//__________________________________________

		private int Calculated3()
		{
			if (CalculetedStartNumber2(0) > 20)
				return 3;
			else
				return 5;
		}

		private int CalculetedStartNumber2(int startnumber)
		{
			int result = startnumber;
			result++;

			result *= result * 2;
			for (int i = 0; i < 10; i++)
			{
				result += i;
			}

			return result;
		}


		// Встраивание временной переменной

		private string GetPiceMoreNumber1(string price,int number)
		{
			string temp = price;

			return temp + " more " + number;
		}

		//__________________________________________________________

		private string GetPiceMoreNumber2(string price, int number)
		{
			return price + " more " + number;
		}

		// Замена временной переменной

		private bool CalculatedCostMoreThousand1(int start_cost)
		{
			int cost = start_cost * 19;

			if (cost > 1000)
			{
				return true;
			}
			else
				return false;
		}

		//__________________________________________________________

		private bool CalculatedCostMoreThousand2(int start_cost)
		{
			if (CalculatedEndCost(start_cost) > 1000)
			{
				return true;
			}
			else
				return false;
		}

		private int CalculatedEndCost(int start_cost)
		{
			return start_cost * 19;
		}

		// Удаление присвоения параметра метода

		private int GetNumber1(int start_number)
		{
			for(int i = 1; i < 10; i++)
			{
				start_number *= i;
			}

			return start_number;
		}

		//____________________________________________________________

		private int GetNumber2(int start_number)
		{
			int result = start_number;

			for (int i = 1; i < 10; i++)
			{
				result *= i;
			}

			return result;
		}

	}
}
