using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
	public class SalesRecord
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public double Amount { get; set; }
		public SaleStatus Status { get; set; }
		public Seller Seller { get; set; }

		public SalesRecord()
		{
		}

		//Tive que retirar os IDs pois no SQLSERVER existe o autoincremento de ID e se colocar o ID por aqui dá erro na aplicação
		public SalesRecord(DateTime date, double amount, SaleStatus status, Seller seller)
		{			
			Date = date;
			Amount = amount;
			Status = status;
			Seller = seller;
		}
	}
}
