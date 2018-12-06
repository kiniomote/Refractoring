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
	}

	// Поднятие и спуск методов и полей

	class Person
	{
		string Name { get; set; }
		string Office { get; set; }
		int Grants { get; set; }
		string Adress { get; set; }
		
		string GiveAdressOfice()
		{
			return "Office: " + Office;
		}

		string GiveAdress()
		{
			return "Adress: " + Adress;
		}
	};

	class Student : Person
	{
		int YearBorn { get; set; }

		int GiveAge()
		{
			return 2018 - YearBorn;
		}
	};

	class Teacher : Person
	{
		int YearBorn { get; set; }

		int GiveAge()
		{
			return 2018 - YearBorn;
		}
	};

	//_______________________________________________

	class Person1
	{
		protected string Name { get; set; }
		protected string Adress { get; set; }
		protected int YearBorn { get; set; }

		int GiveAge()
		{
			return 2018 - YearBorn;
		}

		string GiveAdress()
		{
			return "Adress: " + Adress;
		}
	};

	class Student1 : Person1
	{
		int Grants { get; set; }
	};

	class Teacher1 : Person1
	{
		string Office { get; set; }

		string GiveAdressOfice()
		{
			return "Office: " + Office;
		}
	};
}
