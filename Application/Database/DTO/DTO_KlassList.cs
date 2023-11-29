using System.ComponentModel.DataAnnotations.Schema;

namespace Databaser_Labb3.Application.Database.DTO
{
    internal class DTO_KlassList
    {
        [ForeignKey("StudentId")]
        private int FK_StudentId { get; set; }

        [ForeignKey("KlassId")]
        private int FK_KlassId { get; set; }

    }
}
