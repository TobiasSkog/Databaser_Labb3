using System.ComponentModel.DataAnnotations.Schema;

namespace Databaser_Labb3.Application.Database.DTO
{
    internal class KlassListModel
    {
        [ForeignKey("StudentId")]
        public int FK_StudentId { get; set; }

        [ForeignKey("KlassId")]
        public int FK_KlassId { get; set; }

    }
}
