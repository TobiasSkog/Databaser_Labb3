using System.ComponentModel.DataAnnotations;

namespace Databaser_Labb3.Application.Database.DTO
{
    internal class DTO_Studenter
    {
        [Key]
        private int StudentId { get; set; }

        [MaxLength(50)]
        private string StudentNamn { get; set; }

        [MinLength(10), MaxLength(12)]
        private string StudentSSN { get; set; }
    }
}
