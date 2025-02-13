﻿using System.ComponentModel.DataAnnotations;
using System.Web;


namespace EmporioSystem.DATA;

public class Item
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public string? SerialNumber { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public string? Category { get; set; }
    public string? SubCategory { get; set; }
    public string? Color { get; set; }
    public string? Size { get; set; }
    public string? Material { get; set; }
    public DateTime? DateOfRecive { get; set; } = DateTime.Now;
    public DateTime? DateOfShipping { get; set; }
}
