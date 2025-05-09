﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;

namespace WebDataExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public string UserInput { get; set; }

        public List<string> AllWords => Info.Words;


        public void OnGet()
        {
            Info.AddWord(UserInput);
        }
    }
}