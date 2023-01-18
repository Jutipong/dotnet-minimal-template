using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Entities.Models
{
    [Table("Address")]
    public partial class Address
    {
        [Key]
        public Guid Id { get; set; }
        [Column("Address")]
        public string Address1 { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
