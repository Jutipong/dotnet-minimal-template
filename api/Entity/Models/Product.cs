﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entity.Model;

[Keyless]
public partial class Product
{
    public int? ProductID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ProductName { get; set; }
}