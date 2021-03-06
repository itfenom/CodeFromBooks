﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OSIM.Core.Persistence;
using OSIM.Core.Entities;

namespace MvcApplication1.Controllers
{
    public class ItemTypeController : Controller
    {
		IItemTypeRepository _itemTypeRepository;

		public ItemTypeController(IItemTypeRepository itemRepository)
		{
			_itemTypeRepository = itemRepository;
		}

        public ActionResult Index()
        {
			ViewData.Model = _itemTypeRepository.GetAll;
            return View();
        }

		public ActionResult Details(int id)
		{
			return View();
		}

		public ActionResult Create()
		{
			var ItemType = new ItemType();

			return View(ItemType);
		}

		[HttpPost]
		public ActionResult Create(ItemType itemType)
		{
			if(ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}

			return View("create", itemType);
		}
    }
}
