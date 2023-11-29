using System.ComponentModel.DataAnnotations;

namespace Databaser_Labb3.Application.Database.DTO
{
    internal class DTO_Personal
    {
        [Key]
        private int PersonalId { get; set; }

        [MaxLength(50)]
        private string PersonalName { get; set; }

        [Range(0, 255)]
        private Befattning PersonalBefattning { get; set; }
    }
}
