using System.ComponentModel.DataAnnotations;

namespace Databaser_Labb3.Application.Database.DTO
{
    internal class ÄmnenModel
    {
        [Key]
        public int ÄmneId { get; set; }

        [MaxLength(50)]
        public string ÄmneNamn { get; set; }
    }
}
