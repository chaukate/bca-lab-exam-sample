using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BcaLabExam2024.Domain.Entities
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; } = "";

        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        [Precision(14, 4)]
        public decimal AnnualIncome { get; set; } = 0;
    }
}
