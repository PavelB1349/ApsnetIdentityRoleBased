﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApsnetIdentityRoleBased.Controllers
{
    public class InventoryController : Controller
    {
        [Authorize(Roles ="Admin")]
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
