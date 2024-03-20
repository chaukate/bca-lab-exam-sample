using BcaLabExam2024.Application.Interfaces;
using BcaLabExam2024.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BcaLabExam2024.Persistence
{
    public class ExamDbContext : DbContext, IExamDbContext
    {
        public ExamDbContext(DbContextOptions<ExamDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var customerInitializer = new CustomerInitializer(modelBuilder);
            customerInitializer.SeedCustomers();
        }
    }
}
