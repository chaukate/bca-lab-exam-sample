using BcaLabExam2024.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BcaLabExam2024.Persistence
{
    public class CustomerInitializer
    {
        private readonly ModelBuilder _builder;
        public CustomerInitializer(ModelBuilder builder)
        {
            _builder = builder;
        }

        public void SeedCustomers()
        {
            var customers = new List<Customer>
            {
                new() { Id = 1, FirstName = "Tony", LastName = "Stark", AnnualIncome = 100000, DateOfBirth = DateTime.Now.AddYears(-55), PhoneNumber = "9876333345" },
                new() { Id = 2, FirstName = "Thor", LastName = "Odinson", AnnualIncome = 100000, DateOfBirth = DateTime.Now.AddYears(-50), PhoneNumber = "9887633333" },
                new() { Id = 3, FirstName = "Bruce", LastName = "Banner", AnnualIncome = 100000, DateOfBirth = DateTime.Now.AddYears(-44), PhoneNumber = "9876333344" },
                new() { Id = 4, FirstName = "Peter", LastName = "Parker", AnnualIncome = 100000, DateOfBirth = DateTime.Now.AddYears(-20), PhoneNumber = "9873444452" }
            };

            _builder.Entity<Customer>().HasData(customers);
        }
    }
}
