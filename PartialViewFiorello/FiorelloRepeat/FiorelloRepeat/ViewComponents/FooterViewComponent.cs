﻿using FiorelloRepeat.Controllers.DAL;
using FiorelloRepeat.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloRepeat.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio model = _context.Bios.FirstOrDefault();
            return View(await Task.FromResult(model)); 
        }
    }
}
