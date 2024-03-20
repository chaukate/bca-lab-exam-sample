using BcaLabExam2024.Application.Interfaces;
using BcaLabExam2024.Application.Models.Customer;
using Microsoft.AspNetCore.Mvc;

namespace BcaLabExam2024.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            var customers = _customerService.List();
            return View(customers);
        }
    }
}
