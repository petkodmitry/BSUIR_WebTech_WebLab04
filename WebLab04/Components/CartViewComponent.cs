﻿using Microsoft.AspNetCore.Mvc;

namespace WebLab04.Components
{
	public class CartViewComponent : ViewComponent {
		public IViewComponentResult Invoke() {
			return View();
		}
	}
}
