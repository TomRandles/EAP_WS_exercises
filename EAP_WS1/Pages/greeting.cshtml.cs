using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EAP_WS1.Pages
{
    public class greetingModel : PageModel
    {
        public void OnGet()
        {
            if (DateTime.Now.Hour > 12)
                message += ", good afternoon";
            else
                message += ", good morning";
        }
        public string message { get; set; } = "Hello";
    }
}