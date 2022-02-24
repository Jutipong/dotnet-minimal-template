﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api.Entities.Models
{
    [Keyless]
    [Table("Todo")]
    public partial class Todo
    {
        public Guid Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [StringLength(100)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [StringLength(100)]
        public string? UpdateBy { get; set; }
        public bool? IsActive { get; set; }
    }
}