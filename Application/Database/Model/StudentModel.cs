using System.ComponentModel.DataAnnotations;

namespace Databaser_Labb3.Application.Database.DTO
{
    internal class StudentModel
    {
        [Key]
        public int StudentId { get; set; }

        [MaxLength(50)]
        public string StudentNamn { get; set; }

        [MinLength(10), MaxLength(12)]
        public string StudentSSN { get; set; }
        public string? StudentFirstName { get; set; }
        public string? StudentLastName { get; set; }
    }
}
