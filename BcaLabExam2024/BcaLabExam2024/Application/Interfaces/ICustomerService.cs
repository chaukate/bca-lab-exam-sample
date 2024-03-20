using BcaLabExam2024.Application.Models.Customer;

namespace BcaLabExam2024.Application.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerVM> List();
    }
}
