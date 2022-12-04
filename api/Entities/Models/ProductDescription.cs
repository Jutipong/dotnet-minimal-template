using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Api.Entities.Models;

[Keyless]
[Table("ProductDescription")]
public partial class ProductDescription
{
    public int? ProductID { get; set; }

    [Column("ProductDescription")]
    [StringLength(800)]
    [Unicode(false)]
    public string? ProductDescription1 { get; set; }
}
