﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookSystemDB.Entities;

public partial class Genre
{
    [Key]
    public int GenreId { get; set; }

    [Required]
    [StringLength(20)]
    public string Description { get; set; }

    [InverseProperty("Genre")]
    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}