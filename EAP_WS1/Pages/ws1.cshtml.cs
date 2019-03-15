using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EAP_WS1.Pages
{
    public class ws1Model : PageModel
    {
        public string[] MyTestArray { get; set; } = { "Ireland", "England", "Scotland", "Wales" };
        public string message = "";

        [BindProperty]
        public string name { get; set; }
       
        [BindProperty]
        public int age { get; set; }

        [BindProperty]
        public string car { get; set; }
       

        public void OnGet()
        {

        }
        public void OnPost()
        {
            // message += Request.Form["name"];
            // message += "Age:  " + Request.Form["age"];
            // message = " from the OnPost method ...!!!";
            message = $"Name is {name}, age is {age}, favourite care is: {car}";

        }
    }
}