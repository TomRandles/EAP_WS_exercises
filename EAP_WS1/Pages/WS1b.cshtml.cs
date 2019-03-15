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

        [BindProperty]
        public string operation { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            message = "Hello. ";
            int tot=0;
            switch (operation)
            {
                case "plus":
                    tot = number1 + number2;
                    message += $" {number1} {operation} {number2} is: {tot}";
                    break;

                case "minus":
                    tot = number1 - number2;
                    message += $" {number1} {operation} {number2} is: {tot}";
                    break;
                    
                case "multiply":
                    tot = number1 * number2;
                    message += $" {number1} {operation} by {number2} is: {tot}";
                    break;

                case "divide":
                    float total = number1 / number2;
                    message += $" {number1} {operation} by {number2} is: {total}";
                    break;
            }          
        }
    }
}