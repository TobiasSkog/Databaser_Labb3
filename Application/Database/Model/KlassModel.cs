using System.ComponentModel.DataAnnotations;

namespace Databaser_Labb3.Application.Database.DTO
{
    internal class KlassModel
    {
        [Key]
        public int KlassId { get; set; }

        [MaxLength(50)]
        public string KlassNamn { get; set; }
    }
}
