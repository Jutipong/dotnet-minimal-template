﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entity.Model;

[Table("Address")]
public partial class Address
{
    [Key]
    public Guid Id { get; set; }

    [Column("Address")]
    public string Address1 { get; set; } = null!;

    public bool IsActive { get; set; }

    public Guid UserId { get; set; }
}