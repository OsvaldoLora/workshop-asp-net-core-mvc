using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
		private readonly SellerService _sellerService;

		public SellersController(SellerService sellerService)
		{
			_sellerService = sellerService;
		}

		public IActionResult Index()
        {
			var list = _sellerService.FindAll();

            return View(list);
        }

		public IActionResult Create()
		{			
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Seller seller)
		{
			_sellerService.Insert(seller);
			return RedirectToAction(nameof(Index));//poderia ser ("Index"), porém essa forma é melhor para fazer manutenções futuras no site, caso o nome da index precise ser alterado não precisaremos alterar essa linha de código
		}

	}
}