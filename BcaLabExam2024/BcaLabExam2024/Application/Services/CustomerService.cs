using BcaLabExam2024.Application.Interfaces;
using BcaLabExam2024.Application.Models.Customer;
using Microsoft.EntityFrameworkCore;

namespace BcaLabExam2024.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IExamDbContext _dbContext;
        public CustomerService(IExamDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<CustomerVM> List()
        {
            var customers = _dbContext.Customers.Select(s => new CustomerVM
            {
                Id = s.Id,
                FirstName = s.FirstName,
                LastName = s.LastName,
                AnnualIncome = s.AnnualIncome,
                DateOfBirth = s.DateOfBirth,
                Email = s.Email,
                PhoneNumber = s.PhoneNumber
            })
            .ToList();

            return customers;
        }
    }
}
