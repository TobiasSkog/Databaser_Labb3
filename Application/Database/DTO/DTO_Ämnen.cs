using System.ComponentModel.DataAnnotations;

namespace Databaser_Labb3.Application.Database.DTO
{
    internal class DTO_Ämnen
    {
        [Key]
        private int ÄmneId { get; set; }

        [MaxLength(50)]
        private string ÄmneNamn { get; set; }
    }
}
