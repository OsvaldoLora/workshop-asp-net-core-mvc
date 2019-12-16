using System.Linq;
using System.Collections.Generic;
using System;

namespace SalesWebMvc.Models
{
	public class Department
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

		public Department()
		{
		}

		//Tive que retirar os IDs pois no SQLSERVER existe o autoincremento de ID e se colocar o ID por aqui dá erro na aplicação
		public Department(string name)
		{			
			Name = name;
		}


		public void AddSelles(Seller seller)
		{
			Sellers.Add(seller);
		}

		public double TotalSales(DateTime initial, DateTime final)
		{
			return Sellers.Sum(s => s.TotalSales(initial, final));
		}

	}
}
