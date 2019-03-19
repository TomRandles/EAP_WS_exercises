using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EAP_WS1.Pages
{
    public class DataTypeModel : PageModel
    {
        [BindProperty]
        public string message { get; set; } = "";

        [BindProperty]
        [DataType(DataType.Date)]
        public DateTime   myDate { get; set; }

        [BindProperty]
        [DataType(DataType.PhoneNumber)]
        public string phoneNumber { get; set; }

        [BindProperty]
        [DataType(DataType.Currency)]
        public Decimal currency { get; set; }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            message = $"My DoB is: {myDate}; Savings are: {currency}; Phone number is: {phoneNumber}; ";
        }
    }
}