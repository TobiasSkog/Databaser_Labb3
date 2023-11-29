using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Databaser_Labb3.Application.Database.DTO
{
    internal class DTO_Betyg
    {
        [Key]
        private int BetygId { get; set; }

        [MaxLength(3)]
        private string Betyg { get; set; }
        private DateOnly BetygDatum { get; set; }

        [ForeignKey("ÄmneId")]
        private int FK_ÄmneId { get; set; }

        [ForeignKey("StudentId")]
        private int FK_StudentId { get; set; }

        [ForeignKey("PersonalId")]
        private int FK_PersonalId { get; set; }
    }
}
