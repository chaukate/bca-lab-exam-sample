using BcaLabExam2024.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BcaLabExam2024.Application.Interfaces
{
    public interface IExamDbContext
    {
        DbSet<Customer> Customers { get; set; }
    }
}
