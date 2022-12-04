﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entity.Models;

[Table("Customer_Bun")]
public partial class Customer_Bun
{
    [Key]
    [StringLength(256)]
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Email { get; set; }

    public long? Age { get; set; }

    public DateTimeOffset? CreatedDate { get; set; }

    public bool? IsActive { get; set; }
}
