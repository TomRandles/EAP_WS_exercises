using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EAP_WS1.Pages
{
    public class WS1bModel : PageModel
    {
        public string message { get; set; }

        [BindProperty]
        public int number1 { get; set; }

        [BindProperty]
        public int number2 { get; set; }


        public string operation {get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            int tot = number1 + number2;
            message = $"Total of {number1} {operation} {number2} is: {tot}";
        }
    }
}