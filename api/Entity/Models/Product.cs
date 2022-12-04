using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entity.Models;

[Keyless]
[Table("Product")]
public partial class Product
{
    public int? ProductID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ProductName { get; set; }
}
