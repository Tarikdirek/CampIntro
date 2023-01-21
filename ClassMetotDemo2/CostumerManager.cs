using ClassMetotDemo.Concrete;
using ClassMetotDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
	public class CostumerManager : IOperators
	{
		public void Listed(List<Costumer> costumers)
		{
			foreach (var costumer in costumers)
			{
				Console.WriteLine(costumer.Id + "\n" + costumer.FirstName + "\n" + costumer.LastName + "\n" + costumer.FatherName);
				Console.WriteLine("-----------------------------");
			}


		}

		public void Add(Costumer costumer)
		{
			Console.WriteLine("Costumer: " + costumer.FirstName + " added!");
		}
		public void Delete(Costumer costumer)
		{
			Console.WriteLine("Costumer: " + costumer.FirstName + " deleted!");
		}
	}
}
