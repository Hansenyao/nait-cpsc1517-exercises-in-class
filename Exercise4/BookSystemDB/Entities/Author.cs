﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookSystemDB.Entities;

public partial class Author
{
    [Key]
    public int AuthorId { get; set; }

    [Required]
    [StringLength(50)]
    public string LastName { get; set; }

    [Required]
    [StringLength(25)]
    public string FirstName { get; set; }

    [NotMapped]
    public string FullName { get { return $"{FirstName} {LastName}"; } }

    [Required]
    [StringLength(50)]
    public string ContactUrl { get; set; }

    [StringLength(30)]
    public string ResidentCity { get; set; }

    [StringLength(30)]
    public string ResidentCountry { get; set; }

    [InverseProperty("Author")]
    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}