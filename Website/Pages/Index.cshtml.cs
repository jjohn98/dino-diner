﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public Menu menu = new Menu();
        
        public void OnGet()
        {

        }
    }
}
