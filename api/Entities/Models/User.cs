﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Entities.Models
{
    [Table("User")]
    public partial class User
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Last { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        public bool IsActive { get; set; }
        public Guid AddressId { get; set; }
    }
}
