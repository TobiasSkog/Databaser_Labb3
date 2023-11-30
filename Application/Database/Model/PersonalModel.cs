using System.ComponentModel.DataAnnotations;

namespace Databaser_Labb3.Application.Database.DTO
{
    internal class PersonalModel
    {
        [Key]
        public int PersonalId { get; set; }

        [MaxLength(50)]
        public string PersonalName { get; set; }

        [Range(0, 255)]
        public Befattning PersonalBefattning { get; set; }
    }

}
