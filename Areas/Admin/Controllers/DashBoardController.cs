﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EnGlamor.Areas.Admin.Controllers;
[Area("Admin")]
// [Authorize(Roles = "Admin")]

public class DashBoardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
