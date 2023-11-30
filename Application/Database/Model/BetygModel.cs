using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Databaser_Labb3.Application.Database.DTO
{
    internal class BetygModel
    {
        [Key]
        public int BetygId { get; set; }

        [MaxLength(3)]
        public string Betyg { get; set; }
        public DateOnly BetygDatum { get; set; }

        [ForeignKey("ÄmneId")]
        public int FK_ÄmneId { get; set; }

        [ForeignKey("StudentId")]
        public int FK_StudentId { get; set; }

        [ForeignKey("PersonalId")]
        public int FK_PersonalId { get; set; }
    }
}
